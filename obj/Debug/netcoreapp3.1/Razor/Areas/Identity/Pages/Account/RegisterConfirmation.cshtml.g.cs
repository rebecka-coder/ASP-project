#pragma checksum "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0671b4e63954d186955f412a412ab9ac7fd2cba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/_ViewImports.cshtml"
using ASPproject.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/_ViewImports.cshtml"
using ASPproject.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using ASPproject.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0671b4e63954d186955f412a412ab9ac7fd2cba6", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca429c2ae56ea309d2cdae77952e4284ae3416e5", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0feac97e50d1abc1657993e98f41f27515c33bc7", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    Denna app har just nu ingen e-post bekräftelse registrerad. Se <a href=\"https://aka.ms/aspaccountconf\">detta dokument</a> för konfigurera din epost.\r\n    Detta borde vanligen epostas genom: <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 402, "\"", 436, 1);
#nullable restore
#line 13 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
WriteAttributeValue("", 409, Model.EmailConfirmationUrl, 409, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Klicka här för att bekräfta ditt konto. </a>\r\n</p>\r\n");
#nullable restore
#line 15 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n        Kontrollera din e-post som bekräftelse för ditt konto.\r\n</p>\r\n");
#nullable restore
#line 21 "/Users/rebeckahogstrom/Projects/ASPproject/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
