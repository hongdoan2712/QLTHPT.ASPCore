#pragma checksum "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\THUs1\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af5549b9e5b641e5fbda0f1d50882138946cf10e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_THUs1_Details), @"mvc.1.0.view", @"/Views/THUs1/Details.cshtml")]
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
#line 1 "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\_ViewImports.cshtml"
using QLTHPT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\_ViewImports.cshtml"
using QLTHPT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5549b9e5b641e5fbda0f1d50882138946cf10e", @"/Views/THUs1/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772303cc8cb73f667367781b9df5b6124072f5ca", @"/Views/_ViewImports.cshtml")]
    public class Views_THUs1_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLTHPT.Models.Thu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\THUs1\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

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
                            <h4>
                                <strong>
                                    Chi Tiết
                                </strong>
                            </h4>


                        </div>
                    </div>
                    <div class=""sparkline10-graph"">
                        <div class=""card-body"">
                            <table id=""bootstrap-data-table"" class=""table table-striped table-bordered"">
                                <thead>
                                    <tr>
                                        <th>
                                            Mã
                                        </th>
                  ");
            WriteLiteral(@"                      <th>
                                            Tên
                                        </th>

                                    </tr>
                                    <tr>
                                        <td>
                                            ");
#nullable restore
#line 39 "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\THUs1\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.ThuMa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 42 "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\THUs1\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.ThuTen));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>

                                    </tr>
                                </thead>

                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<p>
    <a");
            BeginWriteAttribute("href", " href=\"", 1982, "\"", 2041, 1);
#nullable restore
#line 57 "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\THUs1\Details.cshtml"
WriteAttributeValue("", 1989, Url.Action("Edit", "THUs", new { id = Model.ThuMa}), 1989, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-custon-rounded-three btn-warning\"><i class=\"fa fa-edit\"></i></a> |\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 2132, "\"", 2167, 1);
#nullable restore
#line 58 "D:\DoAn2\QLTHPT.ASPCore\QLTHPT\Views\THUs1\Details.cshtml"
WriteAttributeValue("", 2139, Url.Action("Index", "THUs"), 2139, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-custon-rounded-three btn-primary\"><i class=\"fa fa-undo\"></i></a>\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLTHPT.Models.Thu> Html { get; private set; }
    }
}
#pragma warning restore 1591
