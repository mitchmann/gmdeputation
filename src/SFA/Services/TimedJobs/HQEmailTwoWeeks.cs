﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using SFA.Entities;
using SFA.Models;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SFA.Services.TimedJobs
{
    //This job will run daily and return all the appointments that are to happen exactly in two weeks. 
    public class HQEmailTwoWeeks : IHostedService, IDisposable
    {
        private Timer timer;
        private readonly ILogger<HQEmailTwoWeeks> _logger;
        private int executionCount = 0;
        private readonly IServiceScopeFactory scopeFactory; 
		private readonly IWebHostEnvironment _environment;

		public HQEmailTwoWeeks(ILogger<HQEmailTwoWeeks> logger, IServiceScopeFactory scopeFactory, IWebHostEnvironment environment)
        {
            _logger = logger;
            this.scopeFactory = scopeFactory;
			_environment = environment;

		}
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            //timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromDays(1));
            Console.WriteLine("Timer was called");
            return Task.CompletedTask;
            throw new System.NotImplementedException();
        }
        private async Task<string> DoWork(object state)
        {

            var count = Interlocked.Increment(ref executionCount);

            _logger.LogInformation(
                "Timed Hosted Service is working. Count: {Count}", count);

            DateTime currentTim = DateTime.Now;
            if (count == 1)
            {
                using (var scope = scopeFactory.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<SFADBContext>();

                    //Linq Query Right now looking at everything greater than two weeks. When we go liev >= need to just be == Wre are just doing this for testing. 
                    var appointmentQuery = dbContext.TblAppointmentNta.Where(s => s.EventDate == currentTim.AddDays(-21)).Include(m => m.Church).ThenInclude(m => m.District).ThenInclude(m => m.TblUserNta)
                               .Include(m => m.AcceptByPastorByNavigation).Include(m => m.MacroScheduleDetail).ThenInclude(m => m.MacroSchedule)
                               .Include(m => m.MacroScheduleDetail).ThenInclude(m => m.District).Include(m => m.AcceptMissionaryByNavigation).Include(m => m.MacroScheduleDetail)
                              .ThenInclude(m => m.User).AsNoTracking().ToList();

                    _logger.LogInformation("Count of return is" + appointmentQuery.Count());



					string path = "HQ_Email_Appintment_2_Week_Report_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";
					string text = Path.Combine(_environment.WebRootPath, "resources", "reports", path);
					FileInfo fileInfo = new FileInfo(Path.Combine(text));
					if (fileInfo.Exists)
					{
						fileInfo.Delete();
						fileInfo = new FileInfo(Path.Combine(text));
					}
					new MemoryStream();
					ExcelPackage val = new ExcelPackage(fileInfo);
					try
					{
						ExcelWorksheet val2 = val.Workbook.Worksheets.Add("Appointments Report");
						val2.Cells[1, 1, 1, 8].Merge = true;
						val2.Cells[1, 1, 1, 8].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[1, 1, 1, 8].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[2, 1, 2, 8].Merge = (true);
						val2.Cells[2, 1, 2, 8].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[2, 1, 2, 8].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[1, 1].Style.Font.Size = (15f);
						val2.Cells[1, 1].Style.Font.Bold = (true);
						val2.Cells[1, 1].Style.Font.UnderLine = (true);
						val2.Cells[2, 1].Style.Font.UnderLine = (true);
						val2.Cells[2, 1].Style.Font.Bold = (true);
						val2.Cells[2, 1].Style.Font.Size = (12f);
						val2.Cells[1, 1].Value = ((object)"UPCI GLOBAL MISSIONS DEPUTATION MANAGEMENT SYSTEM.");
						val2.Cells[2, 1].Value = ((object)"Appointments Report");
						val2.Row(3).Style.Font
							.Bold = (true);
						val2.Row(4).Style.Font
							.Bold = (true);
						int num = 3;
						val2.Cells[num, 3].Value = ((object)"Report Generation Date & Time :");
						val2.Cells[num, 4].Value = ((object)DateTime.Now.ToString("dd-MM-yyyy"));
						val2.Cells[num, 5].Value = ((object)"Report Generated By :");
						val2.Cells[num, 6].Value = ((object)"Automated From Website");
						num = 4;
						int num2 = 0;
						val2.Cells[num, 1, num, 1].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 1, num, 1].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 2, num, 2].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 2, num, 2].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 3, num, 3].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 3, num, 3].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 4, num, 4].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 4, num, 4].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 5, num, 5].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 5, num, 5].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 6, num, 6].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 6, num, 6].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 7, num, 7].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 7, num, 7].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 8, num, 8].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
						val2.Cells[num, 8, num, 8].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
						val2.Cells[num, 1].Value = ((object)"SL NO");
						val2.Cells[num, 2].Value = ((object)"EVENT DATE");
						val2.Cells[num, 3].Value = ((object)"EVENT TIME");
						val2.Cells[num, 4].Value = ((object)"EMAIL");
						val2.Cells[num, 5].Value = ((object)"PAGE");
						val2.Cells[num, 6].Value = ((object)"DESCRIPTION");
						val2.Cells[num, 7].Value = ((object)"ACTION");
		
						if (appointmentQuery != null)
						{
							if (appointmentQuery.Count > 0)
							{
								foreach (TblAppointmentNta userActivity in appointmentQuery)
								{
									var churchEntity = await dbContext.TblChurchNta.Where(m => m.Id == userActivity.ChurchId).FirstAsync();
									var districtEntity = await dbContext.TblDistrictNta.Where(m => m.Id == churchEntity.DistrictId).FirstAsync();
									var macroScheudleDetailEntity = await dbContext.TblMacroScheduleDetailsNta.Where(m => m.Id == userActivity.MacroScheduleDetailId).FirstAsync();
									var missionaryEntity = await dbContext.TblUserNta.Where(m => m.Id == macroScheudleDetailEntity.UserId).FirstAsync();
									//Gets the link to see who the pastor is in a church: Could be mutiple? 
									var linkToPastorAndChurchEntity = await dbContext.TblUserChurchNta.Where(m => m.ChurchId == userActivity.ChurchId).FirstAsync();
									var pastorEntity = await dbContext.TblUserNta.Where(m => m.Id == linkToPastorAndChurchEntity.UserId).FirstAsync();
									var dgmd = await dbContext.TblUserNta.Where(m => m.DistrictId == districtEntity.Id && m.RoleId == 7).FirstAsync();
									var serviceTimeEntity = await dbContext.TblChurchServiceTimeNta.Where(m => m.Id == userActivity.ServiceTypeId).FirstAsync();
									var serviceTypeEntity = await dbContext.TblServiceTypeNta.Where(m => m.Id == serviceTimeEntity.ServiceTypeId).FirstAsync();


									num++;
									num2++;
									val2.Cells[num, 1, num, 1].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 1, num, 1].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 2, num, 2].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 2, num, 2].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 3, num, 3].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 3, num, 3].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 4, num, 4].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 4, num, 4].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 5, num, 5].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 5, num, 5].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 6, num, 6].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 6, num, 6].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 7, num, 7].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 7, num, 7].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 8, num, 8].Style.HorizontalAlignment = ((ExcelHorizontalAlignment)2);
									val2.Cells[num, 8, num, 8].Style.VerticalAlignment = ((ExcelVerticalAlignment)1);
									val2.Cells[num, 1].Value = ((object)num2);
									val2.Cells[num, 2].Value = ((object)userActivity.EventDate);
									val2.Cells[num, 3].Value = ((object)userActivity.EventTime);
									val2.Cells[num, 4].Value = ((object)missionaryEntity.Email);
									val2.Cells[num, 5].Value = ((object)userActivity.ToString());
									val2.Cells[num, 6].Value = ((object)userActivity.ToString());
									val2.Cells[num, 7].Value = ((object)userActivity.ToString());									
								}
							}
							else
							{
								val2.Cells[5, 4].Value = ((object)"No Data Found");
							}
						}
						else
						{
							val2.Cells[5, 4].Value = ((object)"No Data Found");
						}
						val.Save();
						//We now need to send the email to HQ Staff
						string districtWebsite = "https://gmdeputation.com/";
						//{ { district} }
						//{ { MissionaryFirstName} }
						//{ { MissionaryLastName} }
						//{ { District} }
						//{ { UserSalutation} }
						//{ { LastName} }
						//{ { DGMDFirstName} }
						//{ { DGMDLastName} }
						//{ { DGMDPrimaryPhone} }
						//{ { DGMDEmail} }
						//{ { DistrictWebsite} }

						string jsonString = "";
						string apiTemplateKey = "";
						string missionaryEmail = "troytreynolds@gmail.com";
						string district = "tmp";
						string missionaryFirstName = "Testing Name1<br>TestingName2<br>TestingName3";
						string missionaryLastName = "";
						string baseEncoded = Convert.ToBase64String(val.GetAsByteArray(), Base64FormattingOptions.None);
						//for template 11
						apiTemplateKey = "2d6f.32b15e784a472135.k1.af0d2570-9c04-11ed-9725-525400e3c1b1.185e49fa147";
						 jsonString = "{'template_key':'" + apiTemplateKey + "','bounce_address':'bounceback@bounce.gmdeputation.com','from': { 'address': 'noreply@gmdeputation.com','name':'Troy'},'to': [{'email_address': {'address': '" + missionaryEmail + "','name': 'Missionary'}}],'attachments':[{'content': '"+baseEncoded + "','mime_type':'application/vnd','name':'Schedule.xls'}],'merge_info':{'district':'" + appointmentQuery[0].MacroScheduleDetail.District.Name + "','MissionaryFirstName':'" + missionaryFirstName + "','MissionaryLastName':'" + missionaryLastName + "'}}";


						System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
						var baseAddress = "https://api.zeptomail.com/v1.1/email/template";

						var http = (HttpWebRequest)WebRequest.Create(new Uri(baseAddress));
						http.Accept = "application/json";
						http.ContentType = "application/json";
						http.Method = "POST";
						http.PreAuthenticate = true;
						http.Headers.Add("Authorization", "Zoho-enczapikey wSsVR60irB74DaZ+zzL/Lu5umg5RA1ugE0R6jVWiuXH6HvvD98c9wkKcUVOlFPAaEzNqEjdGo7krzUxR2jVa24t+ng5WCyiF9mqRe1U4J3x17qnvhDzKWW9alxONJY4MzgtukmdpEMgn+g==");

                        JObject parsedContent = null;
						try
						{
							parsedContent = JObject.Parse(jsonString);
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.Message);
						}

						Console.WriteLine(parsedContent.ToString());
						ASCIIEncoding encoding = new ASCIIEncoding();
						Byte[] bytes = encoding.GetBytes(parsedContent.ToString());

						Stream newStream = http.GetRequestStream();
						newStream.Write(bytes, 0, bytes.Length);
						newStream.Close();
						try
						{
							var response = http.GetResponse();
							var stream = response.GetResponseStream();
							var sr = new StreamReader(stream);
							var content = sr.ReadToEnd();
							Console.WriteLine(content);
						}
						catch (Exception ex)
						{
							return ("Failed");
							Console.WriteLine(ex.Message);
						}
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
					//Need to get the excel file that was saved and pass it into the email funtion as base 64.

				}
            }
			return ("Passed");
		}
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");
            Console.WriteLine("Task was stopped");
            timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
            throw new System.NotImplementedException();
        }
        public void Dispose()
        {
            timer?.Dispose();
        }
    }
}