#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "605d5db4933f52585024e050392da2523d18a37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605d5db4933f52585024e050392da2523d18a37a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n<!-- Morris chart -->\r\n<link rel=\"stylesheet\" href=\"//cdnjs.cloudflare.com/ajax/libs/morris.js/0.5.1/morris.css\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "605d5db4933f52585024e050392da2523d18a37a3111", async() => {
                WriteLiteral(@"
   <script type=""text/javascript"">

    function yesnoCheck() {
    
        no1 = document.getElementById('txtoneformaid')
    
        if (document.getElementById('yesCheck').checked) {
            no1.type = 'hidden';
        } else {
            no1.type = 'text';
        }
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "605d5db4933f52585024e050392da2523d18a37a4392", async() => {
                WriteLiteral("\r\n<!-- Content Header (Page header) \r\n<section class=\"content-header\">\r\n    <h1>\r\n         Welcome to the IssacPaymentAutomation System !\r\n    </h1>\r\n</section>-->\r\n<!-- Main content -->\r\n");
                WriteLiteral(@"    <section class=""content-header"">
    <h1>
    Dashboard
    <small>Control panel</small>
    </h1>
    <ol class=""breadcrumb"">
    <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
    <li class=""active"">Dashboard</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <!-- Small boxes (Stat box) -->
");
                WriteLiteral(@"    <!-- /.row -->
    <!-- Main row -->
    <div class=""row"">
    <!-- Left col -->
    <section class=""col-lg-7 connectedSortable"">
        
        <!-- Custom tabs (Charts with tabs)-->
        <!-- Users CHART -->
        <div class=""box box-danger"" style=""width:1100px;"">
            <div class=""col-lg-3 col-xs-6"">
        <!-- small box -->
        <div class=""small-box bg-red"" style=""width:250px;"">
        <div class=""inner"">
                <p> Month</p>
                <h3>");
#nullable restore
#line 150 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.month_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>             \r\n                <p> Annotator</p>\r\n                ");
#nullable restore
#line 152 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
           Write(Model.annotate_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n                <p> SumOfTimeActive</p>\r\n                ");
#nullable restore
#line 154 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
           Write(Model.sumoftimeactive_count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                
        </div>
        <div class=""icon"">
            <i class=""ion ion-pie-graph""></i>
        </div>
        </div>
        </div>
        <div class=""col-lg-3 col-xs-6"">
        <!-- small box -->
        <div class=""small-box bg-aqua"">
        <div class=""inner"">
                <p> SumOfTimeInActive</p>  
                <h3>");
#nullable restore
#line 167 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.sumoftimeinactive_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>                \r\n                <p> Total Time</p>  \r\n                <h3>");
#nullable restore
#line 169 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.totaltime_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> Active Hrs</p>  \r\n                <h3>");
#nullable restore
#line 171 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.activehours_count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                
        </div>
        <div class=""icon"">
            <i class=""ion ion-pie-graph""></i>
        </div>
        </div>
        </div>
        <div class=""col-lg-3 col-xs-6"">
        <!-- small box -->
        <div class=""small-box"" style=""background-color:#3C8DBC"">
        <div class=""inner"">
                <p> Inactive Hrs</p>  
                <h3>");
#nullable restore
#line 184 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.inactivehours_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> BillableInActive Hrs</p>  \r\n                <h3>");
#nullable restore
#line 186 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.billableinactivehours_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> Total Hrs</p>  \r\n                <h3>");
#nullable restore
#line 188 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.totalhours_count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                
        </div>
        <div class=""icon"">
            <i class=""ion ion-pie-graph""></i>
        </div>
        </div>
        </div>
        <div class=""col-lg-3 col-xs-6"">
        <!-- small box -->
        <div class=""small-box"" style=""background-color:#819830"">
        <div class=""inner"">
                <p> Productivity</p>  
                <h3>");
#nullable restore
#line 201 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.productivity_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> Productivity %</p>  \r\n                <h3>");
#nullable restore
#line 203 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.productivitypercentage_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> Average Rating</p>  \r\n                <h3>");
#nullable restore
#line 205 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.averagerating_count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                
        </div>
         <div class=""icon"">
            <i class=""ion ion-pie-graph""></i>
        </div>
        </div>
        </div>
        <div class=""col-lg-3 col-xs-6"">
        <!-- small box -->
        <div class=""small-box"" style=""background-color:#819830"">
        <div class=""inner"">
                <p> Quality</p>  
                <h3>");
#nullable restore
#line 218 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.quality_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> Quality %</p>  \r\n                <h3>");
#nullable restore
#line 220 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.qualitypercentage_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> Average Score</p>  \r\n                <h3>");
#nullable restore
#line 222 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.averagescore_count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                
        </div>
        <div class=""icon"">
            <i class=""ion ion-pie-graph""></i>
        </div>
        </div>
        </div>
        <div class=""col-lg-3 col-xs-6"">
        <!-- small box -->
        <div class=""small-box"" style=""background-color:#819830"">
        <div class=""inner"" style=""height:460px;"">
                <p> Additional Project Allowance</p>  
                <h3>");
#nullable restore
#line 235 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.USDTotal_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p> Final Amount Payable</p>  \r\n                <h3>");
#nullable restore
#line 237 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.finalamountpayable_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 238 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                 using (Html.BeginForm("OnApproval", "Home", FormMethod.Post, new { enctype = "multipart/form-data"}))
                 {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p> OneFormaID</p>  \r\n                <h3>");
#nullable restore
#line 241 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.oneformaid_count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                <input type=""radio"" id=""yesCheck"" name=""yesno"" value=""Yes"" checked=""checked"" onclick=""yesnoCheck();"">
                <label for=""html"">Yes</label><input type=""radio"" id=""noCheck"" name=""yesno"" value=""No"" onclick=""yesnoCheck();"">
                <label for=""html"">No</label><br>
                <input type=""hidden"" id=""txtoneformaid"" name=""txtoneformaid"" style=""background-color:gray;""><br/>
");
                WriteLiteral("                <p> Status</p>  \r\n                <h3>");
#nullable restore
#line 248 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
               Write(Model.dashboardstatus_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 249 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                var total = Model.finalamountpayable_count;
                var isUserConnected = Model.dashboardstatus_count;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 251 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                     if( isUserConnected == "Processing" && total > 0) 
                    {
                        
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"modal-footer\">\r\n                                <input type=\"submit\" value=\"Confirmed\" id=\"btnSubmit\" class=\"btn btn-primary\" />\r\n                            </div>\r\n");
#nullable restore
#line 258 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                        
                    }
                    else
                    {
                            
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 263 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                     
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("                 </div>    \r\n                  \r\n        <div class=\"icon\">\r\n            <i class=\"ion ion-pie-graph\"></i>\r\n        </div>\r\n        </div>\r\n        </div>\r\n");
                WriteLiteral(@"            <!-- /.box-body -->
        </div>
        <!-- /.nav-tabs-custom -->
    </section>
        </div>
        <!-- /.box -->
    </section>
    <!-- right col -->
    </div>
    <!-- /.row (main row) -->
</section>
  
<!-- Morris.js charts -->
<script src=""bower_components/raphael/raphael.min.js""></script>
<script src=""bower_components/morris.js/morris.min.js""></script>
<script>
  $(function () {
    ""use strict"";
    //DONUT CHART
    var donut = new Morris.Donut({
      element: 'sales-chart',
      resize: true,
      colors: [""#3c8dbc"", ""#00A65A"", ""#F39C12""],
      data: [
        {label: ""Registered Admin"", value: ");
#nullable restore
#line 308 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                                      Write(Model.admin_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("},\r\n        {label: \"Registered Manager\", value: ");
#nullable restore
#line 309 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                                        Write(Model.manager_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("},\r\n        {label: \"Registered Annotator\", value: ");
#nullable restore
#line 310 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Home\Index.cshtml"
                                          Write(Model.annotator_count);

#line default
#line hidden
#nullable disable
                WriteLiteral("}\r\n      ],\r\n      hideHover: \'auto\'\r\n    });\r\n  });\r\n</script>\r\n");
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
            WriteLiteral("\r\n</html>\r\n    \r\n<!-- /.content -->\r\n");
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
