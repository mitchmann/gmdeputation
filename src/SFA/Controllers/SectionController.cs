﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFA.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFA.Models;
using SFA.Extensions;
using Microsoft.AspNetCore.Authorization;
using SFA.Filters;
using Microsoft.AspNetCore.Hosting;
using SFA.Entities;
using System.IO;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore;

namespace SFA.Controllers
{
    [Route("sections")]
    [Authorize]
    public class SectionController : Controller
    {
        private readonly ISectionService _sectionService = null;
        private readonly IWebHostEnvironment _environment = null;
        private readonly SFADBContext _context = null;

        public SectionController(ISectionService sectionService, IWebHostEnvironment environment, SFADBContext context)
        {
            _sectionService = sectionService;
            _environment = environment;
            _context = context;
        }
        [Route("")]
        [CheckAccess]
        public IActionResult Index()
        {
            return View();
        }

        [Route("add")]
        [CheckAccess]
        public IActionResult Add()
        {
            return View();
        }

        [Route("edit/{id}")]
        [CheckAccess]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [Route("export")]
        [CheckAccess]
        public ActionResult Export()
        {
            return View();
        }
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {
            var sections = await _sectionService.GetAll();
            return new JsonResult(sections);
        }

        [Route("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var section = await _sectionService.GetById(id);
            return new JsonResult(section);
        }

        [Route("GetSectionByDistrictId/{id}")]
        public async Task<IActionResult> GetSectionByDistrictId(int id)
        {
            var section = await _sectionService.GetSectionByDistrictId(id);
            return new JsonResult(section);
        }

        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var loggedinUser = HttpContext.Session.Get<User>("SESSIONSFAUSER");
            var result = await _sectionService.Delete(id, loggedinUser.Id);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("search")]
        public async Task<IActionResult> Search([FromBody]SectionQuery query)
        {
            var sections = await _sectionService.Search(query);
            return new JsonResult(sections);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody]Section section)
        {
            var loggedinUser = HttpContext.Session.Get<User>("SESSIONSFAUSER");
            section.CreatedBy = loggedinUser.Id;

            var result = await _sectionService.Add(section, loggedinUser);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody]Section section)
        {
            if (id != section.Id)
            {
                return BadRequest("Distric Id not matched");
            }
            var loggedinUser = HttpContext.Session.Get<User>("SESSIONSFAUSER");
            section.LastModifiedBy = loggedinUser.Id;

            var result = await _sectionService.Edit(section, loggedinUser);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("export-section")]
        public async Task<IActionResult> ExportSection([FromForm]Section section)
        {

            var files = Request.Form.Files;
            var file = files[0];
            var jsonString = "";
            var loggedinUser = HttpContext.Session.Get<User>("SESSIONSFAUSER");
            try
            {

                var extention = (file != null) ? Path.GetExtension(file.FileName) : null;
                if (file != null && (extention.Equals(".xls", StringComparison.OrdinalIgnoreCase) || extention.Equals(".xlsx", StringComparison.OrdinalIgnoreCase) || extention.Equals(".XLSX", StringComparison.OrdinalIgnoreCase) || extention.Equals(".XLS", StringComparison.OrdinalIgnoreCase)))
                {
                    var fileName = file.FileName;

                    var uploadPath = Path.Combine(_environment.WebRootPath, "resources", "sections");
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }
                    //if (file.Length > 0)
                    //{
                    var fileSequence = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") + "_" + loggedinUser.Id.ToString() + "_" + loggedinUser.Name;
                    var saveFileName = fileSequence + Path.GetExtension(file.FileName);
                    using (var fileStream = new FileStream(Path.Combine(uploadPath, saveFileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    //banner.FileName = fileName;
                    //banner.FileSequence = fileSequence;
                    //}
                    //var path = fileName1;
                    var model = new List<TblSectionNta>();
                    FileInfo File = new FileInfo(Path.Combine(uploadPath, saveFileName));
                    using (ExcelPackage package = new ExcelPackage(File))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                        int rowCount = worksheet.Dimension.Rows;
                        int ColCount = worksheet.Dimension.Columns;

                        var rawText = string.Empty;
                        var existingEntity = await _context.TblSectionNta.Include(m => m.District).ToListAsync();
                        //var maxNumber = existingEntity.Count() == 0 ? 1 : existingEntity.OrderByDescending(m => m.CodeVal).FirstOrDefault().CodeVal + 1;
                        var districtCodes = await _context.TblDistrictNta.ToListAsync();
                        for (int row = 2; row <= rowCount; row++)
                        {
                            if (worksheet.Cells[row, 1].Value != null)
                            {
                                if (!districtCodes.Select(m => m.Id.ToString()).Contains(worksheet.Cells[row, 2].Value.ToString()))
                                {
                                    jsonString = "District ID does not exists in district table  at" + row + " th row of excel sheet. Kindly check District ID";
                                    return Json(jsonString);
                                }
                                var districtID = worksheet.Cells[row, 2].Value;
                                //0 will cause the insert  to fail for the foreign key relationship will fail in the database
                                int districtIDAsInt = 0; ;

                                if (districtID != null)
                                    districtIDAsInt = Convert.ToInt32(districtID);

                                var formModel = new TblSectionNta
                                {
                                    InsertDatetime = DateTime.Now,
                                    InsertUser = loggedinUser.Id.ToString(),                                
                                    DistrictId = districtIDAsInt,                                 
                                    Name = worksheet.Cells[row, 1].Value.ToString()
                                };
                                //model = formModel;
                                var currentList = model.Where(m => m.Name == formModel.Name).ToList();
                                var existingList = existingEntity.Where(m => m.Name == formModel.Name).ToList();
                                if (currentList.Count > 0 || existingList.Count > 0)
                                {
                                    model.Remove(formModel);
                                }
                                else
                                {
                                    model.Add(formModel);
                                }
                            }
                            else
                            {
                                jsonString = "First Column is not filled in one of the columns. Please fix import file";
                                return Json(jsonString);
                            }

                        }
                        _context.TblSectionNta.AddRange(model);
                        await _context.SaveChangesAsync();
                        return Json(jsonString);
                    }

                }
                return Json("Extension is not match");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
