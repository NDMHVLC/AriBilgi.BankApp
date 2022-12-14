#pragma checksum "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa22c9843504dead82107d81a104f35094834e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
using AriBilgi.BankApp.Web.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
using AriBilgi.BankApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa22c9843504dead82107d81a104f35094834e2", @"/Views/Account/Index.cshtml")]
    #nullable restore
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUserDTO>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col-md-6\">\r\n            <h3>Hesap Eklenecek Kişinin Bilgileri</h3>\r\n            <p>Adı Soyadı: ");
#nullable restore
#line 12 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
                                  Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Mevcut Hesap No: ");
#nullable restore
#line 13 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
                           Write(Model.AccountCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h3>Yeni Hesap Ekle</h3>\r\n            <form action=\"/Account/Create\" method=\"post\">\r\n                <input class=\"d-none\" name=\"ApplicationUserId\"");
            BeginWriteAttribute("value", " value=\"", 628, "\"", 645, 1);
#nullable restore
#line 19 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 636, Model.Id, 636, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                <div class=""form-group"">
                    <label>Hesap No:</label>
                    <input class=""form-control"" name=""AccountNo"" />
                </div>
                <div class=""form-group"">
                    <input type=""submit"" class=""btn btn-success"" />
                </div>
            </form>
        </div>

    </div>
    <hr />
    <div class=""row mt-3"">
        <h3>Mevcut Hesapların Listesi</h3>
        <table class=""mt-1 table table-hover table-bordered"">
            <thead>
                <tr>
                    <td>Hesap No</td>
                    <td>Mevcut Bakiye</td>
                    <td></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 43 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
                 foreach (Account item in Model.AccountList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 46 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
                       Write(item.AccountNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
                       Write(item.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                    </tr>\n");
#nullable restore
#line 50 "C:\Users\havla\OneDrive\Desktop\AriBilgi\AriBilgi.BankApp\AriBilgi.BankApp.Web\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUserDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
