#pragma checksum "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf3b4dfa5ce1f438d95027476e55d6e07ec2cc88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chuyennganhs_Index), @"mvc.1.0.view", @"/Views/Chuyennganhs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3b4dfa5ce1f438d95027476e55d6e07ec2cc88", @"/Views/Chuyennganhs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536edb61622c8e484fe7ae8ab22b45277c2d05e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Chuyennganhs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<qlthpt.Models.Chuyennganh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
  
    ViewBag.Title = "Index";

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
                            <h4><strong>CHUYÊN NGÀNH</strong></h4>
                        </div>
                    </div>
                    <div class=""sparkline13-graph"">
                        <div class=""datatable-dashv1-list custom-datatable-overright"">
                            <div id=""toolbar"">
                                <strong>");
#nullable restore
#line 20 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
                                   Write(Html.ActionLink("Tạo Mới", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                            </div>
                            <table id=""table"" data-toggle=""table"" data-search=""true"" data-key-events=""true"" data-resizable=""true"" data-cookie=""true"" data-cookie-id-table=""saveId"" data-click-to-select=""true"" data-toolbar=""#toolbar"">
                                <thead>
                                    <tr>
                                        <th>
                                            Mã
                                        </th>
                                        <th>
                                            Tên
                                        </th>

                                        <th>

                                        </th>
                                    </tr>
                                </thead>
                                <tbody>

");
#nullable restore
#line 39 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 43 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.CnMa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 46 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.CnTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2295, "\"", 2364, 1);
#nullable restore
#line 49 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
WriteAttributeValue("", 2302, Url.Action("Details", "Chuyennganhs", new { id = item.CnMa }), 2302, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-custon-rounded-three btn-success\"><i class=\"fa fa-info-circle\"></i></a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2504, "\"", 2570, 1);
#nullable restore
#line 50 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
WriteAttributeValue("", 2511, Url.Action("Edit", "Chuyennganhs", new { id = item.CnMa }), 2511, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-custon-rounded-three btn-warning\"><i class=\"fa fa-edit\"></i></a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2703, "\"", 2771, 1);
#nullable restore
#line 51 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
WriteAttributeValue("", 2710, Url.Action("Delete", "Chuyennganhs", new { id = item.CnMa }), 2710, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-custon-rounded-three btn-danger\"><i class=\"fa fa-trash\"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\pc\source\repos\qlthpt\qlthpt\Views\Chuyennganhs\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<qlthpt.Models.Chuyennganh>> Html { get; private set; }
    }
}
#pragma warning restore 1591