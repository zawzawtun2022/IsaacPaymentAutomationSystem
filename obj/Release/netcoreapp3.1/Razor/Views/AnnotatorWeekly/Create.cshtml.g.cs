#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1065948b69d84f1da61b51a53472ae5e6136d760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnnotatorWeekly_Create), @"mvc.1.0.view", @"/Views/AnnotatorWeekly/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1065948b69d84f1da61b51a53472ae5e6136d760", @"/Views/AnnotatorWeekly/Create.cshtml")]
    public class Views_AnnotatorWeekly_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.MonthlyReviews>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/popper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/select2/select2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
  
    ViewData["Title"] = "Create Annotator";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1065948b69d84f1da61b51a53472ae5e6136d7604995", async() => {
                WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
#nullable restore
#line 12 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
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
                    <h3 class=""box-title"">Add New Annotation</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
");
#nullable restore
#line 27 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
                     using (Html.BeginForm("WeeklyResult", "AnnotatorWeekly", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""box-body"">
                        <div class=""form-group"">
                            <label for=""Monthly"">Monthly</label>                           
                            <select asp-for=""Monthly"" name=""Monthly"" class=""form-control"">
                                <option value=""January"">January</option>
                                <option value=""February"">February</option>
                                <option value=""March"">March</option>
                                <option value=""April"">April</option>
                                <option value=""May"">May</option>
                                <option value=""June"">June</option>
                                <option value=""July"">July</option>
                                <option value=""August"">August</option>
                                <option value=""September"">September</option>
                                <option value=""October"">October</option>
                         ");
                WriteLiteral(@"       <option value=""November"">November</option>
                                <option value=""December"">December</option>
                            </select>
                        </div>
                        <div class=""form-group"">
                            <label for=""Numberofweek"">Number Of Week</label>
                            <input type=""text"" class=""form-control"" id=""Numberofweek"" name=""Numberofweek"" placeholder=""Enter NumberOfWeek"">
                        </div>
                        <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"" formaction=""Generate"" onclick=""AddTextBox()"">Add</button>
                        </div>
                        <div class=""form-group"">  
                            ");
#nullable restore
#line 55 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
                       Write(Html.ListBox("ddlAnnotators",  (IEnumerable<SelectListItem>) ViewData["ddlAnnotators"], new { size = 40, width = 1000 }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@")  
                        </div>  
                        
                         <br/>
                        <br/>
                        <div id=""TextBoxContainer"">
                            <!--Textboxes will be added here -->
                        </div>
                            
                        <div class=""form-group"">
                            <label for=""Startdate"">Start Date</label>
                            <input type=""text"" class=""form-control"" id=""Startdate"" name=""Startdate"" placeholder=""Enter Startdate"">
                        </div>
                        <div class=""form-group"">
                            <label for=""Enddate"">End Date</label>
                            <input type=""text"" class=""form-control"" id=""Enddate"" name=""Enddate"" placeholder=""Enter Enddate"">
                        </div>
");
                WriteLiteral("                    </div>\r\n                    <!-- /.box-body -->\r\n                    <div class=\"box-footer\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n                    </div>        \r\n");
#nullable restore
#line 81 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    \r\n                \r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral(@"
        <script type=""text/javascript"" src=""http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
    <script type=""text/javascript"">
        function GetDynamicTextBox(value) {
            var div = $(""<div />"");
 
            var textBox = $(""<input />"").attr(""type"", ""textbox"").attr(""name"", ""DynamicTextBox"");
            textBox.val(value);
            div.append(textBox);
 
            var button = $(""<input />"").attr(""type"", ""button"").attr(""value"", ""Remove"");
            button.attr(""onclick"", ""RemoveTextBox(this)"");
            div.append(button);
 
            return div;
        }
        function AddTextBox() {
            var div = GetDynamicTextBox("""");
            $(""#TextBoxContainer"").append(div);
        }
 
        function RemoveTextBox(button) {
            $(button).parent().remove();
        }
 
        $(function () {
            var values = eval('");
#nullable restore
#line 111 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
                          Write(Html.Raw(ViewBag.Values));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"');
            if (values != null) {
                $(""#TextBoxContainer"").html("""");
                $(values).each(function () {
                    $(""#TextBoxContainer"").append(GetDynamicTextBox(this));
                });
            }
        });
    </script>
");
#nullable restore
#line 120 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("        <script type=\"text/javascript\">\r\n            $(function () {\r\n                alert(\"");
#nullable restore
#line 124 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\")\r\n            });\r\n        </script>\r\n");
#nullable restore
#line 127 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorWeekly\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"    <!-- Bootstrap -->
    <link href=""https://code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css"" rel=""Stylesheet""
    type=""text/css"" />
    <script type=""text/javascript"" src=""https://code.jquery.com/jquery-1.7.2.min.js""></script>
    <script type=""text/javascript"" src=""https://code.jquery.com/ui/1.10.4/jquery-ui.js""></script>

    <script>
        function getYesterdayDate() {
			  return new Date(new Date().getTime() - 24*60*60*1000);
			}
	function getTomorrowDate() {
	var today = new Date();
	return new Date(new Date().getFullYear()+'-'+(today.getMonth()+1)+'-'+today.getDate());
	}
    $('#txtSelectedDate').datepicker({
                        minDate: getYesterdayDate(),
				        maxDate: getTomorrowDate()
                  });

            $(function () {
                $('#Startdate').datepicker();
                $('#Enddate').datepicker();
                
            });
    </script>
 ");
                }
                );
                WriteLiteral(@"            </div>
        </div>
    </div>
</section>
<!-- get dem fancy typefaces -->
<script type=""text/javascript"" src=""//use.typekit.net/psm0wvc.js""></script>
<script type=""text/javascript"">try{Typekit.load();}catch(e){}</script>

    <!--===============================================================================================-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1065948b69d84f1da61b51a53472ae5e6136d76014258", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1065948b69d84f1da61b51a53472ae5e6136d76015468", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1065948b69d84f1da61b51a53472ae5e6136d76016568", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1065948b69d84f1da61b51a53472ae5e6136d76017778", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1065948b69d84f1da61b51a53472ae5e6136d76018988", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n               \r\n    ");
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
            WriteLiteral("\r\n   </html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.MonthlyReviews> Html { get; private set; }
    }
}
#pragma warning restore 1591
