#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f0ebdcc3b2a86553d546dbf937dd06412041f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnnotatorChecker_Index), @"mvc.1.0.view", @"/Views/AnnotatorChecker/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f0ebdcc3b2a86553d546dbf937dd06412041f7", @"/Views/AnnotatorChecker/Index.cshtml")]
    public class Views_AnnotatorChecker_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleBasedAuthorization.Models.MonthlyReviews>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AnnotatorChecker/OnGetDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-danger mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/popper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/select2/select2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
  
    ViewData["Title"] = "Imports Function";
    Layout = "~/Views/Shared/_Layout.cshtml";




#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f76584", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width""/>
    <title>Annotator Checker Calculation</title>
    <style>
        input[name=SelectedDate] + img {
            position: relative;
            top: 5px;
            left: 2px;
        }
    </style>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f77823", async() => {
                WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Annotator Checker Calculation
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Annotator Checker Table</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                <h4>Annotator Checker Information</h4>
            <hr />

");
#nullable restore
#line 43 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
             using (Html.BeginForm("AnnotatorChecker", "AnnotatorChecker", FormMethod.Post))
            {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""form-horizontal"">
                    <br/>
                   
                    <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1. Choose Month : <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     </div>
                     <div class=""form-group"" style=""margin-left:30px;width:260px"">
                                
                     ");
#nullable restore
#line 56 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                Write(Html.DropDownList("ddlMonthly", (IEnumerable<SelectListItem>)ViewBag.MONTHLY, null, new { @class ="form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral("                      <input type=\"hidden\" id=\"hidden2\" name=\"hidden2\"");
                BeginWriteAttribute("value", " value=\"", 2118, "\"", 2126, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                             \r\n");
                WriteLiteral(@"                  </div>                
                    <div class=""form-group"">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Choose the Annotator : <font style=""color:red"">*</font><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>
                     <div class=""form-group"" style=""margin-left:30px;width:260px"">
                                
                     ");
#nullable restore
#line 69 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                Write(Html.DropDownList("ddlchildusertype", (IEnumerable<SelectListItem>)ViewBag.ITEM,null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral("                        <input type=\"hidden\" id=\"hidden3\" name=\"hidden3\"");
                BeginWriteAttribute("value", " value=\"", 3166, "\"", 3174, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                              \r\n                \r\n                        </div>                \r\n                     <div class=\"row\">\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n");
                WriteLiteral(@"                        <div class=""form-group"">
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""submit"" value=""Generate"" id=""btnSubmit"" class=""btn btn-primary"" />
                        
                    </div>
                    <br/>
       <!-- left column -->
       <div class=""box-body"">
                 <table id=""example2"" class=""table table-bordered table-hover"">
");
                WriteLiteral(@"                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Monthly</th>
                                <th>Number Of Week</th>
                                <th>Start Date</th>
                                <th>End Date</th>
                                <th>Rating</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 103 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 107 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.MonthlyreviewID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 110 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Monthly));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 113 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Numberofweek));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 116 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Startdate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 119 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Enddate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    \r\n                                    <td>\r\n                                        ");
#nullable restore
#line 123 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.AssignMonthlyReviews.Rating));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 5827, "\"", 5878, 2);
                WriteAttributeValue("", 5834, "/AnnotatorChecker/Edit/", 5834, 23, true);
#nullable restore
#line 126 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
WriteAttributeValue("", 5857, item.MonthlyreviewID, 5857, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a> \r\n                                    </td>\r\n                                </tr>\r\n                                <br/>\r\n");
#nullable restore
#line 130 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <br/>\r\n                    \r\n\r\n                    </div>\r\n                <br/>\r\n        <br/>\r\n");
#nullable restore
#line 140 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
            using (Html.BeginForm("RetrieveResult", "AnnotatorChecker", FormMethod.Post))
            {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <br/>\r\n                    <br/>\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f718459", async() => {
                    WriteLiteral("Refresh");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"                    
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type=""submit"" value=""Calculate"" id=""btnSubmit"" class=""btn btn-primary"" />
                        
                    </div>
                    <br/>
                    <div class=""form-group"">
                        <div class=""control-label col-md-2""></div>
                        <div class=""col-md-10"">
                        <!--Show Message if file is uploaded or not-->
                        <font color=""red"" style=""text-align:center"">");
#nullable restore
#line 167 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
                                                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</font>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 170 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorChecker\Index.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f723403", async() => {
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
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f724613", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f725713", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f726923", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!--===============================================================================================-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f0ebdcc3b2a86553d546dbf937dd06412041f728133", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleBasedAuthorization.Models.MonthlyReviews>> Html { get; private set; }
    }
}
#pragma warning restore 1591
