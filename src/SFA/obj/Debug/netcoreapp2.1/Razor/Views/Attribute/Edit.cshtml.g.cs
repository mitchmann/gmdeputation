#pragma checksum "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\Attribute\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f5cd82791e9863bee933436ae694c9b1d6ad58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attribute_Edit), @"mvc.1.0.view", @"/Views/Attribute/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attribute/Edit.cshtml", typeof(AspNetCore.Views_Attribute_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f5cd82791e9863bee933436ae694c9b1d6ad58", @"/Views/Attribute/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01978648e477dbbf1387b3b505fc4c96303d1348", @"/Views/_ViewImports.cshtml")]
    public class Views_Attribute_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/scripts/services/attributeService.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/scripts/controllers/attributeEditController.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\Attribute\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(40, 58, true);
            WriteLiteral("\r\n<div data-ng-controller=\"attributeEditController\">\r\n    ");
            EndContext();
            BeginContext(98, 3917, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f5cd82791e9863bee933436ae694c9b1d6ad584957", async() => {
                BeginContext(116, 316, true);
                WriteLiteral(@"
        <div class=""topbar"">
            <div class=""md-toolbar-tools"" layout=""row"">
                <div class=""topbar-title"" flex>
                    <h2>Edit Attribute</h2>
                    <i class=""vertical-seperator"" hide-xs>&nbsp;</i>
                    <span hide-xs><a href=""/home"">Home</a> / <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 432, "\"", 458, 2);
                WriteAttributeValue("", 439, "/nav/", 439, 5, true);
#line 12 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\Attribute\Edit.cshtml"
WriteAttributeValue("", 444, ViewBag.Group, 444, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(459, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(461, 13, false);
#line 12 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\Attribute\Edit.cshtml"
                                                                                      Write(ViewBag.Group);

#line default
#line hidden
                EndContext();
                BeginContext(474, 1188, true);
                WriteLiteral(@"</a> / <a href=""/attribute"">Attributes</a> / Edit</span>
                </div>
                <div flex=""none"">
                    <md-button class=""add-btn"" aria-label=""Back to List"" data-ng-click=""backToList()"">
                        <md-tooltip>Back to List</md-tooltip>
                        <i class=""ti-angle-double-left""></i> Back to List
                    </md-button>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div layout=""row"" layout-xs=""column"">
                <md-input-container class=""md-block"" flex>
                    <label>Attribute Type Name</label>
                    <input ng-model=""attribute.name"" required>
                </md-input-container>
            </div>
        </div>
        <md-table-container layout=""column"" layout-xs=""column"">
            <table md-table md-progress=""promise"">
                <thead md-head>
                    <tr md-row>
                        <th md-column class=""cent");
                WriteLiteral("er\" style=\"width:20%;\"><span>Attribute Name</span></th>\r\n                        <th md-column class=\"center\" style=\"width:80%;\"><span>Attribute Notes</span></th>\r\n");
                EndContext();
                BeginContext(1765, 766, true);
                WriteLiteral(@"                    </tr>
                </thead>
                <tbody md-body>
                    <tr md-row ng-repeat=""detail in attribute.attributes track by $index"">
                        <td md-cell class=""center"" style=""width:20%;"">
                            <md-input-container flex>
                                <input ng-model=""detail.attributeName"" required>
                            </md-input-container>
                        </td>
                        <td md-cell class=""center"" style=""width:80%;"">
                            <md-input-container flex>
                                <textarea ng-model=""detail.attributeNotes""></textarea>
                            </md-input-container>
                        </td>
");
                EndContext();
                BeginContext(2821, 1187, true);
                WriteLiteral(@"                    </tr>
                    <tr md-row>
                        <td md-cell style=""text-align:right;"" colspan=""4"">
                            <md-button class=""add-btn"" aria-label=""Add"" data-ng-click=""addNewState()"">
                                <md-tooltip>Add Attribute</md-tooltip>
                                <i class=""ti-plus""></i>Add Attribute
                            </md-button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </md-table-container>
        <div class=""container"">
            <div layout=""row"" layout-align=""center center"">
                <md-button class=""save-btn"" aria-label=""Save"" data-ng-click=""save()"" data-ng-disabled=""form.$invalid"">
                    <md-tooltip>Save</md-tooltip>
                    <i class=""far fa-save""></i> Save
                </md-button>
                <md-button class=""cancel-btn"" aria-label=""Cancel"" data-ng-click=""backToList()"">
                 ");
                WriteLiteral("   <md-tooltip>Cancel</md-tooltip>\r\n                    <i class=\"fas fa-reply\"></i> Cancel\r\n                </md-button>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4015, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4044, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4050, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f5cd82791e9863bee933436ae694c9b1d6ad5811477", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 82 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\Attribute\Edit.cshtml"
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
                BeginContext(4138, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4144, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f5cd82791e9863bee933436ae694c9b1d6ad5813564", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 83 "C:\Users\SEANR\OneDrive\Documents\GitHub\gmdeputation\src\SFA\Views\Attribute\Edit.cshtml"
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
                BeginContext(4242, 2, true);
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