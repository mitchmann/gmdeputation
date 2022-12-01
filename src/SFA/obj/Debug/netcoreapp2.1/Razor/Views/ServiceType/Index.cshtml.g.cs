#pragma checksum "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e3b9cf63efe73a10ed285174639a3879fd21b26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceType_Index), @"mvc.1.0.view", @"/Views/ServiceType/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ServiceType/Index.cshtml", typeof(AspNetCore.Views_ServiceType_Index))]
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
#line 1 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\_ViewImports.cshtml"
using SFA;

#line default
#line hidden
#line 2 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\_ViewImports.cshtml"
using SFA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e3b9cf63efe73a10ed285174639a3879fd21b26", @"/Views/ServiceType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01978648e477dbbf1387b3b505fc4c96303d1348", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/scripts/services/serviceTypeService.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/scripts/controllers/serviceTypesController.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
  
    ViewData["Title"] = "List of Service Types";

#line default
#line hidden
            BeginContext(57, 348, true);
            WriteLiteral(@"<div data-ng-controller=""serviceTypesController"">
    <div class=""topbar"">
        <div class=""md-toolbar-tools"" layout=""row"">
            <div class=""topbar-title"" flex>
                <h2>List of Service Types</h2>
                <i class=""vertical-seperator"" hide-xs>&nbsp;</i>
                <span hide-xs><a href=""/home"">Home</a> / <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 405, "\"", 431, 2);
            WriteAttributeValue("", 412, "/nav/", 412, 5, true);
#line 10 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
WriteAttributeValue("", 417, ViewBag.Group, 417, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(432, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(434, 13, false);
#line 10 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
                                                                                  Write(ViewBag.Group);

#line default
#line hidden
            EndContext();
            BeginContext(447, 338, true);
            WriteLiteral(@"</a> / Service Types</span>
            </div>
            <div flex=""none"">
                <md-button class=""filter-btn"" ng-click=""filter()"" ng-disabled=""selected.length>0"">
                    <md-tooltip>Filter</md-tooltip>
                    <i class=""ti-filter""></i> <span hide-xs>Filter</span>
                </md-button>
");
            EndContext();
#line 17 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
                 if (ViewBag.Access == 7 || ViewBag.Access == 3)
                {

#line default
#line hidden
            BeginContext(870, 250, true);
            WriteLiteral("                    <md-button class=\"add-btn\" ng-click=\"detail()\" ng-disabled=\"selected.length>0\">\r\n                        <md-tooltip>Add New</md-tooltip>\r\n                        <i class=\"ti-plus\"></i> Add New\r\n                    </md-button>\r\n");
            EndContext();
#line 26 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
                                  
                }

#line default
#line hidden
            BeginContext(1414, 1894, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""filter-grid"" data-ng-show=""showFilter"">
        <div layout=""row"" layout-xs=""column"">
            <div class=""filter-title"" flex=""none"">
                <i class=""ti-filter""></i> <span>Filter By</span>
            </div>
            <div flex>
                <md-input-container class=""md-block"">
                    <label>Name</label>
                    <input data-ng-model=""query.filter"" data-ng-model-options=""filter.options"">
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
    <md-table-container>
        <table md-table md-progress=""promise"">
            <thead md-head md-order=""query.order"" md-on-reorder=""search"">");
            WriteLiteral(@"
                <tr md-row>
                    <th md-column class=""center"">Sl No</th>
                    <th md-column md-order-by=""name""><span class=""pad-l-8"">Name</span></th>
                    <th md-column class=""center"" style=""width:160px;""><span class=""pad-l-8"">Actions</span></th>
                </tr>
            </thead>
            <tbody md-body>
                <tr class=""md-row md-row-empty"" ng-show=""serviceTypes.length === 0"">
                    <td class=""md-cell"" colspan=""2"">No Data Found</td>
                </tr>
                <tr md-row data-ng-repeat=""serviceType in serviceTypes track by $index"">
                    <td md-cell class=""center"">{{((query.page - 1) * query.limit) + ($index+1)}}</td>
                    <td md-cell class=""pad-l-8"">{{serviceType.name}}</td>
                    <td md-cell class=""center"">
");
            EndContext();
#line 67 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
                         if (ViewBag.Access == 7 || ViewBag.Access == 3)
                        {

#line default
#line hidden
            BeginContext(3409, 517, true);
            WriteLiteral(@"                        <md-button class=""md-icon-button edit-btn"" ng-click=""detail(serviceType.id)"">
                            <md-tooltip>Edit</md-tooltip>
                            <i class=""ti-marker-alt""></i>
                        </md-button>
                        <md-button class=""md-icon-button delete-btn"" ng-click=""delete(serviceType.id)"">
                            <md-tooltip>Delete</md-tooltip>
                            <i class=""ti-trash""></i>
                        </md-button>
");
            EndContext();
#line 77 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3953, 311, true);
            WriteLiteral(@"                    </td>
                </tr>
            </tbody>
        </table>
    </md-table-container>
    <md-table-pagination md-limit=""query.limit"" md-limit-options=""[20, 50, 100]"" md-page=""query.page"" md-total=""{{count}}"" md-on-paginate=""search"" md-page-select></md-table-pagination>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4281, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4287, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e3b9cf63efe73a10ed285174639a3879fd21b2610414", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 86 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4377, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4383, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e3b9cf63efe73a10ed285174639a3879fd21b2612504", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 87 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\ServiceType\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4480, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
