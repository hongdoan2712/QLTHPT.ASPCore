#pragma checksum "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df783820c859883b44ec071197d9ea39180d80a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chuyennganhs_Edit), @"mvc.1.0.view", @"/Views/Chuyennganhs/Edit.cshtml")]
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
#line 1 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\_ViewImports.cshtml"
using qlthpt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\_ViewImports.cshtml"
using qlthpt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df783820c859883b44ec071197d9ea39180d80a", @"/Views/Chuyennganhs/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536edb61622c8e484fe7ae8ab22b45277c2d05e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Chuyennganhs_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<qlthpt.Models.Chuyennganh>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""data-table-area mg-b-15"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""sparkline13-list shadow-reset"">
                        <div class=""sparkline13-hd"">
                            <div class=""main-sparkline13-hd"">
                                <h4><strong>Chỉnh Sửa</strong></h4>
                            </div>
                        </div>
                        <div class=""sparkline13-graph"">
");
#nullable restore
#line 18 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                             using (Html.BeginForm())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"form-horizontal\">\r\n                                    ");
#nullable restore
#line 23 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 24 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                               Write(Html.HiddenFor(model => model.CnMa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div class=\"form-group-inner\">\r\n                                        ");
#nullable restore
#line 26 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                                   Write(Html.LabelFor(model => model.CnMa, "Mã", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div class=\"col-md-10\">\r\n                                            ");
#nullable restore
#line 28 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                                       Write(Html.EditorFor(model => model.CnMa, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <br />\r\n                                            ");
#nullable restore
#line 30 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.CnMa, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                    <div class=\"form-group-inner\">\r\n                                        ");
#nullable restore
#line 35 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                                   Write(Html.LabelFor(model => model.CnTen, "Lớp", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <div class=\"col-md-10\">\r\n                                            ");
#nullable restore
#line 37 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                                       Write(Html.EditorFor(model => model.CnTen, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <br />\r\n                                            ");
#nullable restore
#line 39 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.CnTen, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>


                                    <div class=""form-group"">
                                        <div class=""col-md-offset-2 col-md-10"">
                                            <input type=""submit"" value=""Lưu"" class=""btn btn-default"" /> |
                                            <a");
            BeginWriteAttribute("href", " href=\"", 2696, "\"", 2739, 1);
#nullable restore
#line 47 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
WriteAttributeValue("", 2703, Url.Action("Index", "CHUYENNGANHs"), 2703, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-custon-rounded-three btn-primary\"><i class=\"fa fa-undo\"></i></a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 51 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<qlthpt.Models.Chuyennganh> Html { get; private set; }
    }
}
#pragma warning restore 1591
