#pragma checksum "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a4a58ffc18242212f7854a80e6a2cdcf722c6e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restoran_Restoran), @"mvc.1.0.view", @"/Views/Restoran/Restoran.cshtml")]
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
#line 1 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using StudentskiDom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4a58ffc18242212f7854a80e6a2cdcf722c6e6", @"/Views/Restoran/Restoran.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Restoran_Restoran : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 240px;height: 140px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4a58ffc18242212f7854a80e6a2cdcf722c6e64415", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>restoranview</title>
    <link rel=""stylesheet"" href=""assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""assets/css/styles.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4a58ffc18242212f7854a80e6a2cdcf722c6e65686", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
     using (Html.BeginForm("ProvjeriID", "Restoran", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div style=""width: 300px;height: 50px;margin: 50px 0px 0px 100px;"">
        <h1 style=""font-family: cooper;font-size: 50px;"">RESTORAN</h1>
    </div>
    <div class=""border rounded border-primary d-xl-flex align-items-xl-start"" style=""width: 750px;height: 350px;margin: 30px 0px 0px 20px;"">
        <div class=""container"" style=""width: 400px;margin: 50px 0px 0px 10px;"">
            <div class=""row"">
                <div class=""col""><label class=""col-form-label"">Ime</label></div>
            </div>
            <div class=""row"">
                <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""width: 300px;"">");
#nullable restore
#line 24 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
                                                                                                                            Write(ViewBag.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></div>
            </div>
            <div class=""row"">
                <div class=""col""><label class=""col-form-label"">Prezime</label></div>
            </div>
            <div class=""row"">
                <div class=""col""><label class=""col-form-label text-center border rounded border-secondary"" style=""width: 300px;"">");
#nullable restore
#line 30 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
                                                                                                                            Write(ViewBag.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></div>\r\n            </div>\r\n        </div>\r\n        <div class=\"container\" style=\"width: 300px;margin: 30px 0px 0px 10px;\">\r\n            <div class=\"row\">\r\n                <div class=\"col\" style=\"height: 140px;\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1a4a58ffc18242212f7854a80e6a2cdcf722c6e68253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1707, "~/images/", 1707, 9, true);
#nullable restore
#line 35 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
AddHtmlAttributeValue("", 1716, ViewBag.Slika, 1716, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\" style=\"height: 80px;margin: 30px 0px 0px 0px;\"><button class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1938, "\"", 2008, 3);
                WriteAttributeValue("", 1948, "window.location.href=\'", 1948, 22, true);
#nullable restore
#line 38 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
WriteAttributeValue("", 1970, Url.Action("SkiniRucak", "Restoran"), 1970, 37, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2007, "\'", 2007, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" style=\"padding: 8px;margin: 10px;width: 220px;\">Skini ručak</button></div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\" style=\"height: 50px;\"><button class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2237, "\"", 2308, 3);
                WriteAttributeValue("", 2247, "window.location.href=\'", 2247, 22, true);
#nullable restore
#line 41 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
WriteAttributeValue("", 2269, Url.Action("SkiniVeceru", "Restoran"), 2269, 38, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2307, "\'", 2307, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" type=""button"" style=""height: 42px;width: 220px;margin: 10px;"">Skini večeru</button></div>
            </div>
        </div>
    </div>
    <div class=""container"" style=""width: 400px;margin: -130px 0px 0px 30px;"">
        <div class=""row"">
            <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 65px;"">Ručak</label></div>
            <div class=""col""><label class=""col-form-label"" style=""margin: 0px 0px 0px 60px;"">Večera</label></div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <h1 class=""text-center border rounded-circle"">");
#nullable restore
#line 52 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
                                                         Write(ViewBag.BrojRucaka);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h1 class=\"text-center border rounded-circle\">");
#nullable restore
#line 55 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
                                                         Write(ViewBag.BrojVecera);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
            </div>
        </div>
    </div>
    <div class=""row"" style=""width: 750px;margin: 50px 0px 0px 20px;"">
        <div class=""col"" style=""width: 300px;""><label class=""col-form-label text-center"" style=""font-size: 24px;margin: 11px 0px 0px 40px;"">Unesite ID studenta:</label></div>
        <div class=""col"" style=""width: 350px;""><input type=""text"" name=""fldStudentId"" style=""margin: 15px 0px 0px 40px;font-size: 24px;width: 300px;""></div>
    </div>
    <div class=""container float-right"" style=""width:350px;margin:-400px -10px 0px 15px;"">
        <div class=""row"" style=""width: 350px;"">
            <div class=""col"" style=""margin: 0px;""><button class=""btn btn-primary""");
                BeginWriteAttribute("onclick", " onclick=\"", 3771, "\"", 3856, 3);
                WriteAttributeValue("", 3781, "window.location.href=\'", 3781, 22, true);
#nullable restore
#line 65 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
WriteAttributeValue("", 3803, Url.Action("ZahtjevZaNabavkuNamirnica", "Restoran"), 3803, 52, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3855, "\'", 3855, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" style=\"width: 300px;margin: 10px;\">Zahtjev za nabavku namirnica</button></div>\r\n        </div>\r\n        <div class=\"row\" style=\"width: 350px;\">\r\n            <div class=\"col\"><button class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4077, "\"", 4147, 3);
                WriteAttributeValue("", 4087, "window.location.href=\'", 4087, 22, true);
#nullable restore
#line 68 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
WriteAttributeValue("", 4109, Url.Action("DnevniMeni", "Restoran"), 4109, 37, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4146, "\'", 4146, 1, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" style=\"width: 300px;margin: 10px;\">Ažuriranje menija</button></div>\r\n        </div>\r\n        <div class=\"row\" style=\"width: 350px;\">\r\n            <div class=\"col\"><button class=\"btn btn-primary\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4357, "\"", 4434, 3);
                WriteAttributeValue("", 4367, "window.location.href=\'", 4367, 22, true);
#nullable restore
#line 71 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
WriteAttributeValue("", 4389, Url.Action("PregledDnevniMeni", "Restoran"), 4389, 44, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4433, "\'", 4433, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" type=""button"" style=""width: 300px;margin: 10px;"">Pregled menija</button></div>
        </div>
        <div class=""row"" style=""width: 350px; height: 172px;"">
            <div class=""col""></div>
        </div>
        <div class=""row"" style=""width: 350px;"">
            <div class=""col""><button class=""btn btn-primary"" type=""submit"" style=""width: 300px;margin: 10px;"">Provjeri ID</button></div>
        </div>
        </div>
");
#nullable restore
#line 80 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Restoran\Restoran.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <script src=\"assets/js/jquery.min.js\"></script>\r\n    <script src=\"assets/bootstrap/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
