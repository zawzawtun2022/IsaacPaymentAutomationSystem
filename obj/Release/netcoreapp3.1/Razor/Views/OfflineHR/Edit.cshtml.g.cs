#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a09a1f725a8407b63de4548e971c69541e4f8d27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OfflineHR_Edit), @"mvc.1.0.view", @"/Views/OfflineHR/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a09a1f725a8407b63de4548e971c69541e4f8d27", @"/Views/OfflineHR/Edit.cshtml")]
    public class Views_OfflineHR_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Offlinehours>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
  
    ViewData["Title"] = "Listing Function";
    
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
#nullable restore
#line 11 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <!-- general form elements -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Edit CalculationGrid Info</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/OfflineHR/Edit"">
                    <input type=""hidden"" class=""form-control"" id=""OfflineHrsID"" name=""OfflineHrsID""");
            BeginWriteAttribute("value", " value=\"", 926, "\"", 953, 1);
#nullable restore
#line 27 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
WriteAttributeValue("", 934, Model.OfflineHrsID, 934, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >

                    <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""Jobname"">Job Name</label>
                            <input type=""text"" class=""form-control"" id=""JobID"" name=""JobID""");
            BeginWriteAttribute("value", " value=\"", 1212, "\"", 1232, 1);
#nullable restore
#line 32 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
WriteAttributeValue("", 1220, Model.JobID, 1220, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter Job Name"">
                        </div>
                        <div class=""form-group"">
                            <label for=""PacteraEdgeEmail"">PacteraEdgeEmail</label>
                            <input type=""text"" class=""form-control"" id=""PacteraEdgeEmail"" name=""PacteraEdgeEmail""");
            BeginWriteAttribute("value", " value=\"", 1544, "\"", 1575, 1);
#nullable restore
#line 36 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
WriteAttributeValue("", 1552, Model.PacteraEdgeEmail, 1552, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter PacteraEdgeEmail"">
                        </div>
                        <div class=""form-group"">
                            <label for=""WorkedHrs"">WorkedHrs</label>
                            <input type=""text"" class=""form-control"" id=""WorkedHrs"" name=""WorkedHrs""");
            BeginWriteAttribute("value", " value=\"", 1867, "\"", 1891, 1);
#nullable restore
#line 40 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
WriteAttributeValue("", 1875, Model.WorkedHrs, 1875, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Enter WorkedHrs\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"StarshotCrashIsError\">StarshotCrashIsError</label>\r\n                            ");
#nullable restore
#line 44 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
                       Write(Html.DropDownList("StarshotCrashIsError", (IEnumerable<SelectListItem>)ViewBag.starshot, null, new { @class ="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                           \r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                          <label for=\"TypeOfTaskID\">TypeOfTask </label>\r\n                          ");
#nullable restore
#line 49 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\OfflineHR\Edit.cshtml"
                     Write(Html.DropDownList("TypeOfTaskID", (IEnumerable<SelectListItem>)ViewBag.TypeOfTask, null, new { @class ="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                          </div>
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                </form>
            </div>
            <!-- /.box -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- Bootstrap -->
    <link href=""https://code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css"" rel=""Stylesheet""
    type=""text/css"" />
    <script type=""text/javascript"" src=""https://code.jquery.com/jquery-1.7.2.min.js""></script>
    <script type=""text/javascript"" src=""https://code.jquery.com/ui/1.10.4/jquery-ui.js""></script>
 <script>
    $(document).ready(function () {
       $(""#typeoftaskList"").change(function () {
            var ddtext = $(""#typeoftaskList option:selected"").text();
            $(""#hidden2"").val(ddtext);

        })

    })



</script>
");
            }
            );
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.Offlinehours> Html { get; private set; }
    }
}
#pragma warning restore 1591