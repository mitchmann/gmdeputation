#pragma checksum "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfdbbd15892876cf17df8ca09e69755da400b6b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\_ViewImports.cshtml"
using SFA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\_ViewImports.cshtml"
using SFA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfdbbd15892876cf17df8ca09e69755da400b6b5", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01978648e477dbbf1387b3b505fc4c96303d1348", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/scripts/services/roleService.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/scripts/services/userService.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/scripts/controllers/usersController.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div data-ng-controller=""usersController"">
    <!--Topbar section-->
    <div class=""topbar"">
        <div class=""md-toolbar-tools"" layout=""row"">
            <div class=""topbar-title"" flex>
                <h2>List of User</h2>
                <i class=""vertical-seperator"" hide-sm hide-xs>&nbsp;</i>
                <span hide-sm hide-xs><a href=""/home"">Home</a> / <a");
            BeginWriteAttribute("href", " href=\"", 416, "\"", 442, 2);
            WriteAttributeValue("", 423, "/nav/", 423, 5, true);
#nullable restore
#line 11 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
WriteAttributeValue("", 428, ViewBag.Group, 428, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
                                                                                          Write(ViewBag.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> / Users</span>
            </div>
            <!--  checkbox -->
            <div class=""form-check"">
              <input
                mdbCheckbox
                ng-model=""checkboxModel""
                ng-init=""checkboxModel ='NO'""
                class=""form-check-input""
                type=""checkbox""
                id=""flexCheckChecked""
                ng-true-value=""'YES'"" 
                ng-false-value=""'NO'""            
               
   
              />
              <label class=""form-check-label"" for=""flexCheckChecked"">
                Show Inactive Users 
              </label>
            </div>
            <div flex=""none"">
                <md-button class=""filter-btn"" ng-click=""filter()"">
                    <md-tooltip>Search</md-tooltip>
                    <i class=""ti-filter""></i> <span hide-xs>Search</span>
                </md-button>
");
#nullable restore
#line 36 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
                 if (ViewBag.Access == 7 || ViewBag.Access == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <md-button class=""add-btn"" ng-click=""detail()""> <md-tooltip>Add New</md-tooltip> <i class=""ti-plus""></i> <span hide-xs>Add New</span> </md-button>
                <md-button class=""add-btn"" ng-click=""export()"" ng-disabled=""selected.length>0""> <md-tooltip>Export</md-tooltip> <i class=""ti-export""></i> <span hide-xs>Export</span> </md-button>
                <md-button class=""add-btn"" ng-click=""import()"" ng-disabled=""selected.length>0""> <md-tooltip>Import</md-tooltip> <i class=""ti-import""></i> <span hide-xs>Import</span> </md-button>
                <md-button class=""add-btn"" ng-click=""changeDistrict()"" ng-disabled=""selected.length>0""> <md-tooltip>Change District</md-tooltip> <i class=""ti-back-left""></i> <span hide-xs>C hange District</span> </md-button>
");
#nullable restore
#line 42 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <!--//End Topbar section-->
    <!--Filter Section-->
    <div class=""filter-grid"" data-ng-show=""showFilter"">
        <div layout=""row"" layout-xs=""column"">
            <div class=""filter-title"" flex=""none"">
                <i class=""ti-filter""></i> <span>Search By</span>
            </div>
            <div flex>
                <md-input-container class=""md-block"">
                    <label>Search</label>
                    <input data-ng-model=""query.name"" placeholder=""Search By User Name , Role, Email, Phone No, District or Section"" data-ng-model-options=""filter.options"">
                </md-input-container>
            </div>
            <div flex=""none"">
                <md-button class=""close-btn"" ng-click=""close()"" ng-disabled=""selected.length>0"">
                    <md-tooltip>Close</md-tooltip>
                    <i class=""ti-close""></i> Close
                </md-button>
            </div>
        </div>
    </div>
    <!--");
            WriteLiteral(@"//End Filter Section-->
    <md-table-container>
        <table md-table md-progress=""promise"">
            <thead md-head  md-order=""query.order"" md-on-reorder=""search"">
                <tr md-row>
                    <th md-column class=""center"">Sl No</th>
                    <th md-column md-order-by=""name""><span class=""pad-l-8"">Name</span></th>
                    <th md-column md-order-by=""role""><span class=""pad-l-8"">Role Name</span></th>
                    <th md-column md-order-by=""email""><span class=""pad-l-8"">Email</span></th>
                    <th md-column md-order-by=""phone""><span class=""pad-l-8"">Phone No</span></th>
                    <th md-column md-order-by=""district""><span class=""pad-l-8"">District Name</span></th>
                    <th md-column md-order-by=""section""><span class=""pad-l-8"">Section Name</span></th>
                    <th md-column class=""center"" style=""width:160px;""><span class=""pad-l-8"">Actions</span></th>
                </tr>
            </thead>
       ");
            WriteLiteral(@"     <tbody md-body>
                <tr class=""md-row md-row-empty"" ng-show=""users.length === 0"">
                    <td class=""md-cell"" colspan=""8"">No Data Found</td>
                </tr>
                <tr md-row data-ng-repeat=""user in users track by $index"" ng-show=""((user.isActive==true || user.isActive!=true)  && checkboxModel == 'YES' )|| (user.isActive==true && checkboxModel == 'NO') "">
                    <td md-cell class=""center"">{{((query.page - 1) * query.limit) + ($index+1)}}</td>
                    <td md-cell class=""pad-l-8"">{{user.name}}</td>
                    <td md-cell class=""pad-l-8"">{{user.roleName}}</td>
                    <td md-cell class=""pad-l-8"">{{user.email}}</td>
                    <td md-cell class=""pad-l-8"">{{user.phone}}</td>
                    <td md-cell class=""pad-l-8"">{{user.districtName}}</td>
                    <td md-cell class=""pad-l-8"">{{user.sectionName}}</td>
                    <td md-cell class=""center"">
");
#nullable restore
#line 95 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
                         if (ViewBag.Access == 7 || ViewBag.Access == 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <md-button class=""md-icon-button edit-btn"" ng-click=""detail(user.id)"">
                                <md-tooltip>Edit</md-tooltip>
                                <i class=""ti-marker-alt""></i>
                            </md-button>
");
#nullable restore
#line 101 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </td>
                </tr>
            </tbody>
        </table>
    </md-table-container>
    <md-table-pagination md-limit=""query.limit"" md-limit-options=""[20, 50, 100]"" md-page=""query.page"" md-total=""{{count}}"" md-on-paginate=""search"" md-page-select></md-table-pagination>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfdbbd15892876cf17df8ca09e69755da400b6b512303", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 111 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfdbbd15892876cf17df8ca09e69755da400b6b514274", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 112 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfdbbd15892876cf17df8ca09e69755da400b6b516245", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 113 "C:\Users\nghia\Documents\source\gmdeputation2\gmdeputation\src\SFA\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
