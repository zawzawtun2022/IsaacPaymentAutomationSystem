#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e29ab04ba6253da200f9e2897980f6e849c0a3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LossHR_Index), @"mvc.1.0.view", @"/Views/LossHR/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e29ab04ba6253da200f9e2897980f6e849c0a3b", @"/Views/LossHR/Index.cshtml")]
    public class Views_LossHR_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Dropdownlist>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
  
    ViewData["Title"] = "Imports Function";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e29ab04ba6253da200f9e2897980f6e849c0a3b5073", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width""/>
    <title>Loss HR Information</title>
    <style>
        input[name=SelectedDate] + img {
            position: relative;
            top: 5px;
            left: 2px;
        }
    </style>
    <script type=""text/javascript"">
    function validateNumber(e) {
            const pattern = /^[0-9]$/;

            return pattern.test(e.key )
        }    
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e29ab04ba6253da200f9e2897980f6e849c0a3b6486", async() => {
                WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        LossHR Information
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">LossHR Table</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                <h4>Loss Idling Hours Information</h4>
            <hr />

");
#nullable restore
#line 46 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
             using (Html.BeginForm("LossHR", "LossHR", FormMethod.Post))
            {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""form-horizontal"">
                    <div class=""form-group"">
                        <div>
                        <h1>&nbsp;&nbsp;&nbsp;&nbsp;Isaac Japan - Error Task Tracker </h1> <br/>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Hi Team, kindly input the Job/Task/Work ID of those work which you encounter errors like SUBMIT TASK ERROR / Video Error / Annotation tool auto refresh etc.
                        <br>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Thank you!!
                        </div>
                    </div><br/>
                   
                    <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Job ID/Task ID/Work ID <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 ");
                WriteLiteral("       <textarea id=\"txtJobID\" name=\"txtJobID\" rows=\"5\" cols=\"40\">\r\n                        ");
#nullable restore
#line 64 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
                   Write(ViewBag.jobid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </textarea>\r\n");
                WriteLiteral(@"                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""submit"" value=""Generate"" id=""btnGenerate"" formaction=""Generate"" class=""btn btn-primary"" style=""margin-top:-5px;""/>
                    </div>                
                    <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Job Name <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input type=""text"" id=""txtJobName"" name=""txtJobName""");
                BeginWriteAttribute("value", " value=\"", 3231, "\"", 3254, 1);
#nullable restore
#line 72 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
WriteAttributeValue("", 3239, ViewBag.Result, 3239, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""width:270px;""/>
                         
                    </div>                
                    <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;3. Locale <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input type=""text"" id=""txtLocale"" name=""txtLocale""");
                BeginWriteAttribute("value", " value=\"", 3714, "\"", 3737, 1);
#nullable restore
#line 78 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
WriteAttributeValue("", 3722, ViewBag.locale, 3722, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:270px;\"/>\r\n                        </div>                \r\n");
                WriteLiteral(@"                    <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;4. Time Taken to do the task? In Hours <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input type=""text"" id=""txttimetaken"" name=""txttimetaken"" style=""width:270px;"" onkeypress=""return validateNumber(event)""/>
                        </div>
                    <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;5. Starshot Crash/Error? <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <input type=""radio"" id=""yes"" name=""fav_starshot"" value=""Yes"" checked=""checked"">
??                         Yes<br>
??                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nb");
                WriteLiteral(@"sp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <input type=""radio"" id=""no"" name=""fav_starshot"" value=""No"">
??                         No<br>
??                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <input type=""radio"" id=""videoannotation"" name=""fav_starshot"" value=""Video Annotation"">
??                         Done Button Problem (Video Annotation)<br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          <input type=""radio"" id=""incidentaltext"" name=""fav_starshot"" value=""Incidental Text"">
??                         Incidental Text<br>
                     </div>
                     <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;6. Type Of Task <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp");
                WriteLiteral(";&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                        ");
#nullable restore
#line 110 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
                   Write(Html.DropDownListFor(model => model.typeoftaskList, new SelectList(Model.typeoftaskList, "TypeOfTaskID", "TypeOfTask"), "Please Select Type Of Task"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <input type=\"hidden\" id=\"hidden2\" name=\"hidden2\"");
                BeginWriteAttribute("value", " value=\"", 6732, "\"", 6740, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                     <div class=""form-group"">
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""submit"" value=""Submit"" id=""btnSubmit"" class=""btn btn-primary"" />
                        
                    </div>
                    <br/>
                    <div class=""form-group"">
                        <div class=""control-label col-md-2""></div>
                        <div class=""col-md-10"">
                        <!--Show Message if file is uploaded or not-->
                        <font color=""red"" style=""text-align:center"">");
#nullable restore
#line 122 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
                                                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</font>\r\n                        </div>\r\n                    </div>\r\n                </div>    \r\n                <br/>\r\n        <br/>\r\n");
#nullable restore
#line 128 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\LossHR\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
                DefineSection("Scripts", async() => {
                    WriteLiteral(@"
    <!-- Bootstrap -->
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
                $('#txtStartDate1').datepicker();
                $('#txtEndDate1').datepicker();
                $('#txtStartDate2').datepicker();
                $('#txtEndDate2').datepicker();
                $");
                    WriteLiteral(@"('#txtStartDate3').datepicker();
                $('#txtEndDate3').datepicker();
                $('#txtStartDate4').datepicker();
                $('#txtEndDate4').datepicker();
            });
    </script>
    <script>
    $(document).ready(function () {
        $(""#lookupList"").change(function () {
            var ddtext = $(""#lookupList option:selected"").text();
            $(""#hidden1"").val(ddtext);

        })

        $(""#typeoftaskList"").change(function () {
            var ddtext = $(""#typeoftaskList option:selected"").text();
            $(""#hidden2"").val(ddtext);

        })

    })



</script>
");
                }
                );
                WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<!-- get dem fancy typefaces -->
<script type=""text/javascript"" src=""//use.typekit.net/psm0wvc.js""></script>
<script type=""text/javascript"">try{Typekit.load();}catch(e){}</script>

    <!--===============================================================================================-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e29ab04ba6253da200f9e2897980f6e849c0a3b17944", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e29ab04ba6253da200f9e2897980f6e849c0a3b19154", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e29ab04ba6253da200f9e2897980f6e849c0a3b20254", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e29ab04ba6253da200f9e2897980f6e849c0a3b21464", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e29ab04ba6253da200f9e2897980f6e849c0a3b22674", async() => {
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
                WriteLiteral("\r\n");
                WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.Dropdownlist> Html { get; private set; }
    }
}
#pragma warning restore 1591
