#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d28762ccac277023dda0fc9b1231f0087b8dfc85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Edit), @"mvc.1.0.view", @"/Views/Admins/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d28762ccac277023dda0fc9b1231f0087b8dfc85", @"/Views/Admins/Edit.cshtml")]
    public class Views_Admins_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Admins>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
  
    ViewData["Title"] = "Edit User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
#nullable restore
#line 11 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
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
                    <h3 class=""box-title"">Edit User Info</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/Admins/Edit"">
                    <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Full Name</label>
                            <input type=""text"" class=""form-control"" id=""FullName"" name=""FullName""");
            BeginWriteAttribute("value", " value=\"", 1036, "\"", 1059, 1);
#nullable restore
#line 30 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
WriteAttributeValue("", 1044, Model.FullName, 1044, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter Full Name"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Email</label>
                            <input type=""email"" class=""form-control"" id=""Email"" name=""Email""");
            BeginWriteAttribute("value", " value=\"", 1341, "\"", 1361, 1);
#nullable restore
#line 34 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
WriteAttributeValue("", 1349, Model.Email, 1349, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Enter Email\">\n                        </div>\n                        <div class=\"form-group\">\n                            <label asp-for=\"RolesId\" class=\"control-label\">Roles</label>\n                            ");
#nullable restore
#line 38 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
                       Write(Html.DropDownList("RolesId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 40 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
                         if (ViewBag.RoleLevel != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-group\">\n                            <label asp-for=\"Id\" class=\"control-label\">Quality Checker Roles</label>\n                            ");
#nullable restore
#line 43 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
                       Write(Html.DropDownList("Parentadminroleid", (IEnumerable<SelectListItem>)ViewBag.userrole,null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                         </div>                        ");
#nullable restore
#line 44 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
                                                       }
                        else
                        {
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-group\">\n                            <label for=\"Level\">Level</label>                           \n                            ");
#nullable restore
#line 51 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Edit.cshtml"
                       Write(Html.DropDownList("LevelId", null, htmlAttributes: new { @class = "form-control" }));

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
        </div>
    </div>
</section>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.Admins> Html { get; private set; }
    }
}
#pragma warning restore 1591
