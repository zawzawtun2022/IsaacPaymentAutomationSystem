#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045c6007ce01456bfb3708f8d115a0498f9ac3c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Edit), @"mvc.1.0.view", @"/Views/Roles/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045c6007ce01456bfb3708f8d115a0498f9ac3c9", @"/Views/Roles/Edit.cshtml")]
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Roles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml"
  
    ViewData["Title"] = "Edit Role & Permissions";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
#nullable restore
#line 11 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml"
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
                    <h3 class=""box-title"">Edit Admin Info</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form method=""post"" asp-action=""/Roles/Edit"">
                    <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Title</label>
                            <input type=""text"" class=""form-control"" id=""Title"" name=""Title""");
            BeginWriteAttribute("value", " value=\"", 1039, "\"", 1059, 1);
#nullable restore
#line 30 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1047, Model.Title, 1047, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter Title"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Description</label>
                            <input type=""text"" class=""form-control"" id=""Description"" name=""Description""");
            BeginWriteAttribute("value", " value=\"", 1354, "\"", 1380, 1);
#nullable restore
#line 34 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 1362, Model.Description, 1362, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter Description"">
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

    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""white-box"">
                <h3 class=""box-title m-b-30"">Assign Roles</h3>
                <div class=""row"">
                    <div class=""col-lg-12 col-sm-12"">

                        <div style=""margin-left:28px; margin-top:20px;"">
                            <button type=""button"" class=""btn"">Collepsed</button>
                            <button type=""button"" class=""btn"">Expanded</button>
                            <button type=""button"" class=""btn"">Checked All</button>
                            <button type=""button"" class=""btn"">Unchek All</butt");
            WriteLiteral("on>\n                        </div>\n\n                        <ul class=\"mytree\">\n                            ");
#nullable restore
#line 62 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml"
                       Write(Html.Raw(ViewBag.menu));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                        <div style=""margin-left:28px"">
                            <button onclick=""Done()"" class=""btn btn-primary"">Update</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<script>

    $(document).on('click', '.mytree label', function (e) {
        $(this).next('ul').fadeToggle();
        e.stopPropagation();
    });

    $(document).on('change', '.mytree input[type=checkbox]', function (e) {
        $(this).siblings('ul').find(""input[type='checkbox']"").prop('checked', this.checked);
        $(this).parentsUntil('.mytree').children(""input[type='checkbox']"").prop('checked', this.checked);
        e.stopPropagation();
    });

    $(document).on('click', 'button', function (e) {
        switch ($(this).text()) {
            case 'Collepsed':
                $('.mytree ul').fadeOut();
                break;
            case 'Expanded':
                $('.mytree ul').f");
            WriteLiteral(@"adeIn();
                break;
            case 'Checked All':
                $("".mytree input[type='checkbox']"").prop('checked', true);
                break;
            case 'Unchek All':
                $("".mytree input[type='checkbox']"").prop('checked', false);
                break;
            default:
        }
    });


    function Done() {

        var checkedValues = $('input:checkbox:checked').map(function () {
            return this.id;
        }).get();

        $body = $(""body"");
        $(document).on({
            ajaxStart: function () { $body.addClass(""loading""); },
            ajaxStop: function () { }
        });

        $.ajax({
            type: ""POST"",
            url: '");
#nullable restore
#line 120 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml"
             Write(Url.Action("Update", "Roles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            data: {\n                id: ");
#nullable restore
#line 122 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Roles\Edit.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                roles: checkedValues
            },
            error: function (result) {
                alert(""error"");
            },
            success: function (result) {
                $body.removeClass(""loading"");
                if (result.status == true) {

                    alert(""Successfully Updated Role!"")
                    var baseUrl = ""/Roles"";
                    window.location.href = baseUrl;
                }
                else {
                    alert(""Failed:""+result);
                }
            }
        });
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.Roles> Html { get; private set; }
    }
}
#pragma warning restore 1591
