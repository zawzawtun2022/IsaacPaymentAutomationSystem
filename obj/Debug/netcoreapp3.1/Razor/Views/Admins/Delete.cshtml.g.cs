#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "106a2675907ecbee5b495cfbc027656c2c86a31d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Delete), @"mvc.1.0.view", @"/Views/Admins/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"106a2675907ecbee5b495cfbc027656c2c86a31d", @"/Views/Admins/Delete.cshtml")]
    public class Views_Admins_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Admins>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
  
    ViewData["Title"] = "Delete User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
#nullable restore
#line 11 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
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
            <h3>Are you sure you want to delete this?</h3>
            <div>
                <dl class=""dl-horizontal"">
                    <dt>
                        ");
#nullable restore
#line 23 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd>\n                        ");
#nullable restore
#line 26 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt>\n                        ");
#nullable restore
#line 29 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd>\n                        ");
#nullable restore
#line 32 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                    <dt>\n                        ");
#nullable restore
#line 35 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dt>\n                    <dd>\n                        ");
#nullable restore
#line 38 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Roles.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </dd>\n                </dl>\n\n                <form method=\"post\" action=\"/Admins/DeleteConfirmed\">\n                    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1382, "\"", 1399, 1);
#nullable restore
#line 43 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Admins\Delete.cshtml"
WriteAttributeValue("", 1390, Model.Id, 1390, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" />\n                </form>\n            </div>\n        </div>\n    </div>\n</section>");
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