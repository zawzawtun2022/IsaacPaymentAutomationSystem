#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9976f471a6197cc60332761fa4ab82c61cbb9de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sglookup_Index), @"mvc.1.0.view", @"/Views/Sglookup/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9976f471a6197cc60332761fa4ab82c61cbb9de", @"/Views/Sglookup/Index.cshtml")]
    public class Views_Sglookup_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.PaginatedList<RoleBasedAuthorization.Models.Sglookup>>
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
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
  
    ViewData["Title"] = "Listing Function";
    
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9976f471a6197cc60332761fa4ab82c61cbb9de3130", async() => {
                WriteLiteral("\r\n<style>\r\ntable {\r\n    display: block;\r\n    overflow-x: auto;\r\n    white-space: nowrap;  \r\n}\r\n</style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9976f471a6197cc60332761fa4ab82c61cbb9de4213", async() => {
                WriteLiteral("\r\n    <br/><br/><br/>\r\n    <div class=\"row\" style=\"margin-left:30px\">\r\n            <div class=\"panel-primary\">\r\n");
#nullable restore
#line 22 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
                 using (Html.BeginForm("ExportToCSV", "Sglookup", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-success\">\r\n                        <i class=\"glyphicon glyphicon glyphicon-download\"></i> Download CSV\r\n                    </button>\r\n");
#nullable restore
#line 27 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    <form asp-action=\"Index\" method=\"get\">\r\n        \r\n        <br/>\r\n        \r\n        <br/>\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Find by data: <input type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 1001, "\"", 1035, 1);
#nullable restore
#line 37 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 1009, ViewData["CurrentFilter"], 1009, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <input type=""submit"" value=""Search"" class=""btn btn-default"" /> |
            <a asp-action=""Index"">Back to Full List</a>
        </p>
    </div>
    </form>
    <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">    
        <br/>
        <thead>
        <tr>
              <th>
                <a asp-action=""Index""");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 1441, "\"", 1488, 1);
#nullable restore
#line 48 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 1463, ViewData["NameSortParm"], 1463, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 1489, "\"", 1541, 1);
#nullable restore
#line 48 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 1515, ViewData["CurrentFilter"], 1515, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">ID</a>\r\n            </th>               \r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 1640, "\"", 1687, 1);
#nullable restore
#line 51 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 1662, ViewData["NameSortParm"], 1662, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 1688, "\"", 1740, 1);
#nullable restore
#line 51 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 1714, ViewData["CurrentFilter"], 1714, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">BillingMonth</a>\r\n\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 1836, "\"", 1883, 1);
#nullable restore
#line 55 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 1858, ViewData["NameSortParm"], 1858, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 1884, "\"", 1936, 1);
#nullable restore
#line 55 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 1910, ViewData["CurrentFilter"], 1910, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Joined Date</a>\r\n                \r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2047, "\"", 2094, 1);
#nullable restore
#line 59 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2069, ViewData["NameSortParm"], 2069, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2095, "\"", 2147, 1);
#nullable restore
#line 59 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2121, ViewData["CurrentFilter"], 2121, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Contract</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2237, "\"", 2284, 1);
#nullable restore
#line 62 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2259, ViewData["NameSortParm"], 2259, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2285, "\"", 2337, 1);
#nullable restore
#line 62 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2311, ViewData["CurrentFilter"], 2311, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Full Name</a>\r\n            </th>\r\n              <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2430, "\"", 2477, 1);
#nullable restore
#line 65 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2452, ViewData["NameSortParm"], 2452, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2478, "\"", 2530, 1);
#nullable restore
#line 65 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2504, ViewData["CurrentFilter"], 2504, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">PacteraEdgeEmail</a>\r\n            </th>      \r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2634, "\"", 2681, 1);
#nullable restore
#line 68 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2656, ViewData["NameSortParm"], 2656, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2682, "\"", 2734, 1);
#nullable restore
#line 68 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2708, ViewData["CurrentFilter"], 2708, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">PayRateUS</a>\r\n            </th>           \r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2836, "\"", 2883, 1);
#nullable restore
#line 71 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2858, ViewData["NameSortParm"], 2858, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2884, "\"", 2936, 1);
#nullable restore
#line 71 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 2910, ViewData["CurrentFilter"], 2910, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Active Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 3028, "\"", 3075, 1);
#nullable restore
#line 74 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3050, ViewData["NameSortParm"], 3050, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 3076, "\"", 3128, 1);
#nullable restore
#line 74 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3102, ViewData["CurrentFilter"], 3102, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">InActive Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 3222, "\"", 3269, 1);
#nullable restore
#line 77 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3244, ViewData["NameSortParm"], 3244, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 3270, "\"", 3322, 1);
#nullable restore
#line 77 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3296, ViewData["CurrentFilter"], 3296, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">BillableInActive Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 3424, "\"", 3471, 1);
#nullable restore
#line 80 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3446, ViewData["NameSortParm"], 3446, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 3472, "\"", 3524, 1);
#nullable restore
#line 80 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3498, ViewData["CurrentFilter"], 3498, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Total Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 3615, "\"", 3662, 1);
#nullable restore
#line 83 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3637, ViewData["NameSortParm"], 3637, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 3663, "\"", 3715, 1);
#nullable restore
#line 83 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3689, ViewData["CurrentFilter"], 3689, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Productivity</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 3809, "\"", 3856, 1);
#nullable restore
#line 86 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3831, ViewData["NameSortParm"], 3831, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 3857, "\"", 3909, 1);
#nullable restore
#line 86 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 3883, ViewData["CurrentFilter"], 3883, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Productivity %</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 4005, "\"", 4052, 1);
#nullable restore
#line 89 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4027, ViewData["NameSortParm"], 4027, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 4053, "\"", 4105, 1);
#nullable restore
#line 89 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4079, ViewData["CurrentFilter"], 4079, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Quality</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 4194, "\"", 4241, 1);
#nullable restore
#line 92 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4216, ViewData["NameSortParm"], 4216, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 4242, "\"", 4294, 1);
#nullable restore
#line 92 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4268, ViewData["CurrentFilter"], 4268, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Quality %</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 4385, "\"", 4432, 1);
#nullable restore
#line 95 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4407, ViewData["NameSortParm"], 4407, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 4433, "\"", 4485, 1);
#nullable restore
#line 95 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4459, ViewData["CurrentFilter"], 4459, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Average Score</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 4580, "\"", 4627, 1);
#nullable restore
#line 98 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4602, ViewData["NameSortParm"], 4602, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 4628, "\"", 4680, 1);
#nullable restore
#line 98 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4654, ViewData["CurrentFilter"], 4654, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Final Amount Payable</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 4782, "\"", 4829, 1);
#nullable restore
#line 101 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4804, ViewData["NameSortParm"], 4804, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 4830, "\"", 4882, 1);
#nullable restore
#line 101 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 4856, ViewData["CurrentFilter"], 4856, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Additional Project Allowance</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 4992, "\"", 5039, 1);
#nullable restore
#line 104 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 5014, ViewData["NameSortParm"], 5014, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 5040, "\"", 5092, 1);
#nullable restore
#line 104 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 5066, ViewData["CurrentFilter"], 5066, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Status</a>\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n    \r\n");
#nullable restore
#line 111 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LookupID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 117 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BillingMonth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 120 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JoinedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 123 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contract));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 126 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                &nbsp;&nbsp;&nbsp;\r\n                ");
#nullable restore
#line 128 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 131 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PacteraEdgeEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                ");
#nullable restore
#line 134 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PayRateUS));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 137 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ActiveHrs));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 140 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InactiveHrs));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 143 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BillableInactiveHrs));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 146 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalHrs));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 149 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Productivity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 152 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductivityPercentage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 155 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.quality));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 158 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.qualitypercentage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 161 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.averagescore));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 164 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.finalamountpayable));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 167 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.USDTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n            <td>\r\n                ");
#nullable restore
#line 170 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td> \r\n");
#nullable restore
#line 172 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
                     if (ViewBag.RoleLevel != null) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n                    <a class=\"btn btn-info\"");
                BeginWriteAttribute("href", " href=\"", 7443, "\"", 7479, 2);
                WriteAttributeValue("", 7450, "/Sglookup/Edit/", 7450, 15, true);
#nullable restore
#line 174 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 7465, item.LookupID, 7465, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a> |\r\n                    <a class=\"btn btn-info\"");
                BeginWriteAttribute("href", " href=\"", 7536, "\"", 7574, 2);
                WriteAttributeValue("", 7543, "/Sglookup/Delete/", 7543, 17, true);
#nullable restore
#line 175 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 7560, item.LookupID, 7560, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                    </td>\r\n");
#nullable restore
#line 177 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
                    }
                        else
                        {
                            
                        }  

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tr>\r\n");
#nullable restore
#line 183 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>    \r\n");
#nullable restore
#line 186 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n<a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", "\r\n   asp-route-sortOrder=\"", 7958, "\"", 8008, 1);
#nullable restore
#line 192 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 7984, ViewData["CurrentSort"], 7984, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-pageNumber", "\r\n   asp-route-pageNumber=\"", 8009, "\"", 8058, 1);
#nullable restore
#line 193 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 8036, Model.PageIndex - 1, 8036, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", "\r\n   asp-route-currentFilter=\"", 8059, "\"", 8115, 1);
#nullable restore
#line 194 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 8089, ViewData["CurrentFilter"], 8089, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", "\r\n   class=\"", 8116, "\"", 8157, 3);
                WriteAttributeValue("", 8128, "btn", 8128, 3, true);
                WriteAttributeValue(" ", 8131, "btn-default", 8132, 12, true);
#nullable restore
#line 195 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue(" ", 8143, prevDisabled, 8144, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    Previous\r\n</a>\r\n<a asp-action=\"Index\"");
                BeginWriteAttribute("asp-route-sortOrder", "\r\n   asp-route-sortOrder=\"", 8202, "\"", 8252, 1);
#nullable restore
#line 199 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 8228, ViewData["CurrentSort"], 8228, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-pageNumber", "\r\n   asp-route-pageNumber=\"", 8253, "\"", 8302, 1);
#nullable restore
#line 200 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 8280, Model.PageIndex + 1, 8280, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("asp-route-currentFilter", "\r\n   asp-route-currentFilter=\"", 8303, "\"", 8359, 1);
#nullable restore
#line 201 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue("", 8333, ViewData["CurrentFilter"], 8333, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", "\r\n   class=\"", 8360, "\"", 8401, 3);
                WriteAttributeValue("", 8372, "btn", 8372, 3, true);
                WriteAttributeValue(" ", 8375, "btn-default", 8376, 12, true);
#nullable restore
#line 202 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\Sglookup\Index.cshtml"
WriteAttributeValue(" ", 8387, nextDisabled, 8388, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    Next\r\n</a>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.PaginatedList<RoleBasedAuthorization.Models.Sglookup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
