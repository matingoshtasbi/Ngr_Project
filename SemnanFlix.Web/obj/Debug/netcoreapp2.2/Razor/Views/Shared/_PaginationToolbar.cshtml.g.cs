#pragma checksum "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96fc29ba4408c128c3a125370c9adddc0fa0ae5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PaginationToolbar), @"mvc.1.0.view", @"/Views/Shared/_PaginationToolbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PaginationToolbar.cshtml", typeof(AspNetCore.Views_Shared__PaginationToolbar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96fc29ba4408c128c3a125370c9adddc0fa0ae5", @"/Views/Shared/_PaginationToolbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa6f439dba39d5d7130eb680c45ba14b0891373", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PaginationToolbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SemnanFlix.ViewModels.Shared.DataTableViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
            BeginContext(193, 68, true);
            WriteLiteral("\r\n<div class=\"d-flex justify-content-end mt-4 pagination-toolbar\">\r\n");
            EndContext();
#line 9 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
     if (Model.FilteredCount == Model.TotalCount)
    {

#line default
#line hidden
            BeginContext(319, 35, true);
            WriteLiteral("        <p class=\"my-auto mr-auto\">");
            EndContext();
            BeginContext(355, 20, false);
#line 11 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                              Write(Model.FirstItemIndex);

#line default
#line hidden
            EndContext();
            BeginContext(375, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(379, 19, false);
#line 11 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                                                      Write(Model.LastItemIndex);

#line default
#line hidden
            EndContext();
            BeginContext(398, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(403, 19, false);
#line 11 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                                                                              Write(Model.FilteredCount);

#line default
#line hidden
            EndContext();
            BeginContext(422, 12, true);
            WriteLiteral(" items</p>\r\n");
            EndContext();
#line 12 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(458, 35, true);
            WriteLiteral("        <p class=\"my-auto mr-auto\">");
            EndContext();
            BeginContext(494, 20, false);
#line 15 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                              Write(Model.FirstItemIndex);

#line default
#line hidden
            EndContext();
            BeginContext(514, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(518, 19, false);
#line 15 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                                                      Write(Model.LastItemIndex);

#line default
#line hidden
            EndContext();
            BeginContext(537, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(542, 19, false);
#line 15 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                                                                              Write(Model.FilteredCount);

#line default
#line hidden
            EndContext();
            BeginContext(561, 22, true);
            WriteLiteral(" items (filtered from ");
            EndContext();
            BeginContext(584, 16, false);
#line 15 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                                                                                                                        Write(Model.TotalCount);

#line default
#line hidden
            EndContext();
            BeginContext(600, 19, true);
            WriteLiteral(" total items)</p>\r\n");
            EndContext();
#line 16 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
    }

#line default
#line hidden
            BeginContext(626, 112, true);
            WriteLiteral("\r\n    <div class=\"btn-group btn-group-toggle my-auto\">\r\n        <!-- Display link to previous page -->\r\n        ");
            EndContext();
            BeginContext(738, 361, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b96fc29ba4408c128c3a125370c9adddc0fa0ae58468", async() => {
                BeginContext(1020, 75, true);
                WriteLiteral("\r\n            <i class=\"fas fa-chevron-left my-auto ml-auto\"></i>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                    WriteLiteral(Model.SortOrder);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 22 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                 WriteLiteral(Model.Search);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 23 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                     WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                   WriteLiteral(Model.PageSize);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 981, "btn", 981, 3, true);
            AddHtmlAttributeValue(" ", 984, "btn-outline-primary", 985, 20, true);
#line 25 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
AddHtmlAttributeValue(" ", 1004, prevDisabled, 1005, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1099, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 29 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
         for (var i = 1; i <= Model.PageCount; i++)
        {
            //Display page links for the current page, the pages on both sides of the current page, the first page and last page
            if (Math.Abs(Model.PageIndex - i) < 2 || i == 1 || i == Model.PageCount)
            {

#line default
#line hidden
            BeginContext(1398, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1414, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b96fc29ba4408c128c3a125370c9adddc0fa0ae514104", async() => {
                BeginContext(1761, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1784, 1, false);
#line 40 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
               Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(1785, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                            WriteLiteral(Model.SortOrder);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                         WriteLiteral(Model.Search);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 37 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                            WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 38 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                           WriteLiteral(Model.PageSize);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1677, "btn", 1677, 3, true);
            AddHtmlAttributeValue(" ", 1680, "btn-outline-primary", 1681, 20, true);
            AddHtmlAttributeValue(" ", 1700, "d-none", 1701, 7, true);
            AddHtmlAttributeValue(" ", 1707, "d-md-inline", 1708, 12, true);
#line 39 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
AddHtmlAttributeValue(" ", 1719, i == Model.PageIndex ? "active" : "", 1720, 39, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1807, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
            }
            //Display "..." spacers to represent page number skips between the middle 3 pages and the first and last pages
            else if (Math.Abs(Model.PageIndex - i) < 3)
            {

#line default
#line hidden
            BeginContext(2020, 88, true);
            WriteLiteral("                <a class=\"btn btn-outline-primary d-none d-md-inline disabled\">...</a>\r\n");
            EndContext();
#line 47 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2134, 54, true);
            WriteLiteral("\r\n        <!-- Display link to next page -->\r\n        ");
            EndContext();
            BeginContext(2188, 362, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b96fc29ba4408c128c3a125370c9adddc0fa0ae520567", async() => {
                BeginContext(2470, 76, true);
                WriteLiteral("\r\n            <i class=\"fas fa-chevron-right my-auto ml-auto\"></i>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                    WriteLiteral(Model.SortOrder);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                 WriteLiteral(Model.Search);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 54 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                     WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 55 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
                   WriteLiteral(Model.PageSize);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2431, "btn", 2431, 3, true);
            AddHtmlAttributeValue(" ", 2434, "btn-outline-primary", 2435, 20, true);
#line 56 "D:\Movie Asp.Net Core\SemnanFlix\SemnanFlix\SemnanFlix.Web\Views\Shared\_PaginationToolbar.cshtml"
AddHtmlAttributeValue(" ", 2454, nextDisabled, 2455, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2550, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
