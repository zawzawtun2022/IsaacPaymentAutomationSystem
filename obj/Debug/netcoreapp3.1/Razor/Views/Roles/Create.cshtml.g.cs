#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1823cb155cee4ae18a7a289a36f76fd146ff016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Create), @"mvc.1.0.view", @"/Views/Roles/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1823cb155cee4ae18a7a289a36f76fd146ff016", @"/Views/Roles/Create.cshtml")]
    public class Views_Roles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Roles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Create.cshtml"
  
    ViewData["Title"] = "Create Role";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
#nullable restore
#line 11 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Create.cshtml"
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
                    <h3 class=""box-title"">Add New Role</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/Roles/Create"">
                    <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Title</label>
                            <input type=""text"" class=""form-control"" id=""Title"" name=""Title"" placeholder=""Enter Title"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Description</label>
                            <input type=""text"" c");
            WriteLiteral(@"lass=""form-control"" id=""Description"" name=""Description"" placeholder=""Enter Description"">
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Submit</button>
                    </div>
                </form>
            </div>
            <!-- /.box -->
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.Roles> Html { get; private set; }
    }
}
#pragma warning restore 1591
