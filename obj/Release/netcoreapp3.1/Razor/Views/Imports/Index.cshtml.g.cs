#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Imports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fded00e60ccaf293dcd90b998da0ccc54580dd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imports_Index), @"mvc.1.0.view", @"/Views/Imports/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fded00e60ccaf293dcd90b998da0ccc54580dd2", @"/Views/Imports/Index.cshtml")]
    public class Views_Imports_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Imports\Index.cshtml"
  
    ViewData["Title"] = "Imports Function";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Users Information
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Users Table</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                <h4>Upload User Information from Apple Connect</h4>
            <hr />
");
#nullable restore
#line 25 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Imports\Index.cshtml"
             using (Html.BeginForm("Import", "Imports", FormMethod.Post, new { enctype = "multipart/form-data"}))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-horizontal\">\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n                        <div class=\"control-label col-md-2\">Excel:</div>\r\n                        <div class=\"col-md-10\">\r\n                            <input type=\"file\" id=\"FormFile\" name=\"FormFile\"");
            BeginWriteAttribute("class", " class=\"", 1516, "\"", 1524, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Upload"" id=""btnSubmit"" class=""btn btn-primary"" />
                        </div>
                    </div>
                    <br/>
                    <div class=""form-group"">
                        <div class=""control-label col-md-2""></div>
                        <div class=""col-md-10"">
                        <!--Show Message if file is uploaded or not-->
                        <font color=""red"" style=""text-align:center"">");
#nullable restore
#line 50 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Imports\Index.cshtml"
                                                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</font>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 54 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Imports\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>

<script>
$(function () {
    $('#example2').DataTable({
      'paging'      : true,
      'lengthChange': false,
      'searching'   : false,
      'ordering'    : true,
      'info'        : true,
      'autoWidth'   : false
    })
  })
</script>
");
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