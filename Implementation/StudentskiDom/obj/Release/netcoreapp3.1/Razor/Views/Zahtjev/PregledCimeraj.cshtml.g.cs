#pragma checksum "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5689f7b520f71979fe10d0391d5773a4985096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zahtjev_PregledCimeraj), @"mvc.1.0.view", @"/Views/Zahtjev/PregledCimeraj.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5689f7b520f71979fe10d0391d5773a4985096", @"/Views/Zahtjev/PregledCimeraj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc0e2512298311bcce8892fa996745ef0eb41af", @"/Views/_ViewImports.cshtml")]
    public class Views_Zahtjev_PregledCimeraj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e5689f7b520f71979fe10d0391d5773a49850963562", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>pregledCimeraj</title>
    <link rel=""stylesheet"" href=""../../wwwroot/lib/bootstrap/dist/css/bootstrapCimeraj.min.css>
    <link rel=""stylesheet"" href=""../../wwwroot/css/stylesPregledCimeraj.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e5689f7b520f71979fe10d0391d5773a49850964877", async() => {
                WriteLiteral(@"
    <h1 class=""text-center text-primary"" style=""font-style: normal;"">Pregled cimeraja</h1>
    <div>
        <div class=""container text-left"" style=""width: 1000px;margin: 70px;height: 500px;"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr style=""height: 80px;"">
                                    <td>Paviljon</td>
                                    <td><label>");
#nullable restore
#line 23 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                          Write(ViewBag.ZahtjevZaCimeraj.Paviljon.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                </tr>\r\n                                <tr style=\"height: 80px;\">\r\n                                    <td>Soba</td>\r\n                                    <td><label>");
#nullable restore
#line 27 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                          Write(ViewBag.ZahtjevZaCimeraj.Soba.BrojSobe);

#line default
#line hidden
#nullable disable
                WriteLiteral("<label></td>\r\n                                </tr>\r\n                                <tr style=\"height: 80px;\">\r\n                                    <td>Prvi cimer</td>\r\n                                    <td><label>");
#nullable restore
#line 31 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                          Write(ViewBag.ZahtjevZaCimeraj.Cimer1.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                                                                               Write(ViewBag.ZahtjevZaCimeraj.Cimer1.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                </tr>\r\n                                <tr style=\"height: 80px;\">\r\n                                    <td>Drugi cimer</td>\r\n                                    <td><label>");
#nullable restore
#line 35 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                          Write(ViewBag.ZahtjevZaCimeraj.Cimer2.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                                                                               Write(ViewBag.ZahtjevZaCimeraj.Cimer2.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td style=""height: 80px;"">Dodatne napomene</td>
                                </tr>
                                <tr>
                                    <td style=""width: 469.6px;height: 239.4px;""><label>");
#nullable restore
#line 49 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                                                                  Write(ViewBag.ZahtjevZaCimeraj.DodatneNapomene);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""table-responsive"" style=""width: 980px;"">
                <table class=""table"">
                    <tbody>
                        <tr>
                            <td style=""width: 483px;"">
                                <div class=""table-responsive"" style=""margin: 30px;width: 400px;"">
                                    <table class=""table"">
                                        <tbody>
                                            <tr>
                                                <td style=""width: 200px;""><button");
                BeginWriteAttribute("onclick", " onclick=\"", 3319, "\"", 3432, 5);
                WriteAttributeValue("", 3329, "window.location.href=\'", 3329, 22, true);
#nullable restore
#line 65 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
WriteAttributeValue("", 3351, Url.Action("OdobriCimeraj","Zahtjev"), 3351, 38, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3389, "?id=\'", 3389, 5, true);
                WriteAttributeValue(" ", 3394, "+", 3395, 2, true);
#nullable restore
#line 65 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
WriteAttributeValue(" ", 3396, ViewBag.ZahtjevZaCimeraj.ZahtjevId, 3397, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" type=\"button\" style=\"margin: 0px;width: 150px;margin-left: 0px;\">Odobri zahtjev</button></td>\r\n                                                <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 3612, "\"", 3724, 5);
                WriteAttributeValue("", 3622, "window.location.href=\'", 3622, 22, true);
#nullable restore
#line 66 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
WriteAttributeValue("", 3644, Url.Action("OdbijCimeraj","Zahtjev"), 3644, 37, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3681, "?id=\'", 3681, 5, true);
                WriteAttributeValue(" ", 3686, "+", 3687, 2, true);
#nullable restore
#line 66 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
WriteAttributeValue(" ", 3688, ViewBag.ZahtjevZaCimeraj.ZahtjevId, 3689, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-secondary"" type=""button"" style=""margin: 0px;width: 150px;margin-left: 0px;"">Odbij zahtjev</button></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </td>
                            <td>
                                <div class=""table-responsive"" style=""margin: 30px;width: 410px;"">
                                    <table class=""table"">
                                        <tbody>
                                            <tr style=""width: 427px;"">
                                                <td style=""width: 240px;"">Podnosilac zahtjeva:</td>
                                                <td style=""width: 240px;"">");
#nullable restore
#line 78 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                                                     Write(ViewBag.ZahtjevZaCimeraj.Student.LicniPodaci.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 78 "C:\Users\korisnik\Desktop\Grupa3-Domari\Implementation\StudentskiDom\Views\Zahtjev\PregledCimeraj.cshtml"
                                                                                                                           Write(ViewBag.ZahtjevZaCimeraj.Student.LicniPodaci.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/bootstrap/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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