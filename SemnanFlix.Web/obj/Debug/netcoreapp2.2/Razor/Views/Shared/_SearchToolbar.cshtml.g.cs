#pragma checksum "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05ebad8b2e74adcc51fe8c08c6595cdfedd8512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SearchToolbar), @"mvc.1.0.view", @"/Views/Shared/_SearchToolbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SearchToolbar.cshtml", typeof(AspNetCore.Views_Shared__SearchToolbar))]
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
#line 1 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix;

#line default
#line hidden
#line 2 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels;

#line default
#line hidden
#line 3 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels.Account;

#line default
#line hidden
#line 4 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using SemnanFlix.ViewModels.Manage;

#line default
#line hidden
#line 5 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05ebad8b2e74adcc51fe8c08c6595cdfedd8512", @"/Views/Shared/_SearchToolbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa6f439dba39d5d7130eb680c45ba14b0891373", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SearchToolbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SemnanFlix.ViewModels.Shared.DataTableViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block form-control w-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(58, 1146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05ebad8b2e74adcc51fe8c08c6595cdfedd85125839", async() => {
                BeginContext(96, 43, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"SortOrder\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 139, "\"", 163, 1);
#line 4 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml"
WriteAttributeValue("", 147, Model.SortOrder, 147, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(164, 140, true);
                WriteLiteral(" />\r\n\r\n    <div class=\"d-flex mb-4\">\r\n        <div>\r\n            <p class=\"d-none d-sm-inline-block mr-2\">Items per page: </p>\r\n            ");
                EndContext();
                BeginContext(304, 141, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05ebad8b2e74adcc51fe8c08c6595cdfedd85126850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 9 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.PageSizeOptions;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(445, 164, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"ml-auto\">\r\n            <div class=\"input-group mb-3\">\r\n                <input type=\"text\" class=\"form-control\" name=\"Search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 609, "\"", 630, 1);
#line 14 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml"
WriteAttributeValue("", 617, Model.Search, 617, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(631, 292, true);
                WriteLiteral(@" placeholder=""Search"" />
                <div class=""input-group-append"">
                    <button type=""submit"" class=""btn btn-primary"">
                        <i class=""fas fa-search""></i>
                    </button>
                </div>
            </div>
        </div>

");
                EndContext();
#line 23 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml"
         if (!string.IsNullOrEmpty(Model.Search))
        {

#line default
#line hidden
                BeginContext(985, 53, true);
                WriteLiteral("            <div class=\"ml-3 mt-2\">\r\n                ");
                EndContext();
                BeginContext(1038, 114, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a05ebad8b2e74adcc51fe8c08c6595cdfedd851210086", async() => {
                    BeginContext(1136, 12, true);
                    WriteLiteral("Clear search");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 26 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml"
                                               WriteLiteral(Model.SortOrder);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 26 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml"
                                                                                     WriteLiteral(Model.PageSize);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1152, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 28 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_SearchToolbar.cshtml"
        }

#line default
#line hidden
                BeginContext(1185, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SemnanFlix.ViewModels.Shared.DataTableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
