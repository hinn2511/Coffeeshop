#pragma checksum "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd807fed5556931e3e94c723ce6ddcc7312f249d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredient_Delete), @"mvc.1.0.view", @"/Views/Ingredient/Delete.cshtml")]
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
#line 1 "C:\Git\Coffeeshop\Do_An\CFSM\Views\_ViewImports.cshtml"
using CFSM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\Coffeeshop\Do_An\CFSM\Views\_ViewImports.cshtml"
using Application.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Git\Coffeeshop\Do_An\CFSM\Views\_ViewImports.cshtml"
using CFSM.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd807fed5556931e3e94c723ce6ddcc7312f249d", @"/Views/Ingredient/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce70055b056afb5d7d185c187689215e97510d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredient_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IngredientDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Ingredient</h4>\r\n    <hr/>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 13 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 14 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                         Write(Html.DisplayFor(model => Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 15 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 16 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                         Write(Html.DisplayFor(model => Model.Supplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 17 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 18 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                         Write(Html.DisplayFor(model => Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 19 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 20 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                         Write(Html.DisplayFor(model => Model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 21 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 22 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                         Write(Html.DisplayFor(model => Model.Unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">");
#nullable restore
#line 23 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 24 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
                         Write(Html.DisplayFor(model => Model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd807fed5556931e3e94c723ce6ddcc7312f249d7873", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1189, "\"", 1213, 1);
#nullable restore
#line 28 "C:\Git\Coffeeshop\Do_An\CFSM\Views\Ingredient\Delete.cshtml"
WriteAttributeValue("", 1204, Model.Id, 1204, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\"/>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd807fed5556931e3e94c723ce6ddcc7312f249d8620", async() => {
                    WriteLiteral("Back to list");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IngredientDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
