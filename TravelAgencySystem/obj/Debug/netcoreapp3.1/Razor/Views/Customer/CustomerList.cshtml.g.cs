#pragma checksum "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e263f7f45539e68732c361caa3b245d7929863a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerList), @"mvc.1.0.view", @"/Views/Customer/CustomerList.cshtml")]
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
#line 1 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\_ViewImports.cshtml"
using TravelAgencySystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\_ViewImports.cshtml"
using TravelAgencySystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e263f7f45539e68732c361caa3b245d7929863a", @"/Views/Customer/CustomerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc9f700d07878f4d43fe645e3ddff69c16046a5c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_CustomerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelAgencySystem.Models.CustomerEntity>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
  
    ViewData["Title"] = "CustomerList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CustomerList</h1>\r\n\r\n<hr />\r\n\r\n<p class=\"float-left\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e263f7f45539e68732c361caa3b245d7929863a4490", async() => {
                WriteLiteral("Add Customer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<p class=\"float-right\">\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
           Write(Html.DisplayNameFor(model => model.CustName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
           Write(Html.DisplayNameFor(model => model.CustPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 33 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
           Write(Html.DisplayNameFor(model => model.CustEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
           Write(Html.DisplayNameFor(model => model.CustAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n           \r\n\r\n\r\n\r\n            <th>Actions</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n              \r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
               Write(Html.ActionLink("Update", "AddCustomer", new {  item.CustId, item.CustName, item.CustPhoneNumber, item.CustEmail, item.CustAddress } , new { @class="btn btn-outline-success rounded-pill"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 69 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
               Write(Html.ActionLink("Delete", "DeleteCustomer", new {  item.CustId  }, new { @class = "btn btn-outline-danger rounded-pill",onclick="return confirm('Do you really want this record?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 73 "D:\Asp.NetCoreProjects\TravelAgencySystem\Views\Customer\CustomerList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelAgencySystem.Models.CustomerEntity>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
