#pragma checksum "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7f922313247e00f7cafd7849f30b6def3dd228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnnotatorApproval_Index), @"mvc.1.0.view", @"/Views/AnnotatorApproval/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7f922313247e00f7cafd7849f30b6def3dd228", @"/Views/AnnotatorApproval/Index.cshtml")]
    public class Views_AnnotatorApproval_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.PaginatedList<RoleBasedAuthorization.Models.Sglookup>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("approveBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-danger mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
  
    ViewData["Title"] = "Listing Function";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7f922313247e00f7cafd7849f30b6def3dd2284612", async() => {
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
            WriteLiteral("\r\n<form asp-action=\"Index\" method=\"get\">\r\n\r\n    <br/>\r\n\r\n    <br/>\r\n    <div class=\"form-actions no-color\">\r\n        <p>\r\n            Find by data: <input type=\"text\" name=\"SearchString\"");
            BeginWriteAttribute("value", " value=\"", 500, "\"", 534, 1);
#nullable restore
#line 25 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 508, ViewData["CurrentFilter"], 508, 26, false);

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
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 928, "\"", 975, 1);
#nullable restore
#line 37 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 950, ViewData["NameSortParm"], 950, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 976, "\"", 1028, 1);
#nullable restore
#line 37 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1002, ViewData["CurrentFilter"], 1002, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">ID</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 1112, "\"", 1159, 1);
#nullable restore
#line 40 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1134, ViewData["NameSortParm"], 1134, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 1160, "\"", 1212, 1);
#nullable restore
#line 40 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1186, ViewData["CurrentFilter"], 1186, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Contract</a>\r\n\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 1304, "\"", 1351, 1);
#nullable restore
#line 44 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1326, ViewData["NameSortParm"], 1326, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 1352, "\"", 1404, 1);
#nullable restore
#line 44 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1378, ViewData["CurrentFilter"], 1378, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Name</a>\r\n\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 1492, "\"", 1539, 1);
#nullable restore
#line 48 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1514, ViewData["NameSortParm"], 1514, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 1540, "\"", 1592, 1);
#nullable restore
#line 48 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1566, ViewData["CurrentFilter"], 1566, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">PacteraEdgeEmail</a>\r\n\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 1914, "\"", 1961, 1);
#nullable restore
#line 55 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1936, ViewData["NameSortParm"], 1936, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 1962, "\"", 2014, 1);
#nullable restore
#line 55 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 1988, ViewData["CurrentFilter"], 1988, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">OneFormaID</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2106, "\"", 2153, 1);
#nullable restore
#line 58 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2128, ViewData["NameSortParm"], 2128, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2154, "\"", 2206, 1);
#nullable restore
#line 58 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2180, ViewData["CurrentFilter"], 2180, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Active Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2298, "\"", 2345, 1);
#nullable restore
#line 61 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2320, ViewData["NameSortParm"], 2320, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2346, "\"", 2398, 1);
#nullable restore
#line 61 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2372, ViewData["CurrentFilter"], 2372, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">InActive Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2492, "\"", 2539, 1);
#nullable restore
#line 64 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2514, ViewData["NameSortParm"], 2514, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2540, "\"", 2592, 1);
#nullable restore
#line 64 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2566, ViewData["CurrentFilter"], 2566, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Billable InActive Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2695, "\"", 2742, 1);
#nullable restore
#line 67 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2717, ViewData["NameSortParm"], 2717, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2743, "\"", 2795, 1);
#nullable restore
#line 67 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2769, ViewData["CurrentFilter"], 2769, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Total Hrs</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 2886, "\"", 2933, 1);
#nullable restore
#line 70 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2908, ViewData["NameSortParm"], 2908, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 2934, "\"", 2986, 1);
#nullable restore
#line 70 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 2960, ViewData["CurrentFilter"], 2960, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Final Amount Payable</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 3088, "\"", 3135, 1);
#nullable restore
#line 73 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 3110, ViewData["NameSortParm"], 3110, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 3136, "\"", 3188, 1);
#nullable restore
#line 73 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 3162, ViewData["CurrentFilter"], 3162, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Additional Project Allowance</a>\r\n            </th>\r\n            <th>\r\n                <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", " asp-route-sortOrder=\"", 3298, "\"", 3345, 1);
#nullable restore
#line 76 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 3320, ViewData["NameSortParm"], 3320, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", " asp-route-currentFilter=\"", 3346, "\"", 3398, 1);
#nullable restore
#line 76 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 3372, ViewData["CurrentFilter"], 3372, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Status</a>\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n    \r\n");
#nullable restore
#line 84 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
         foreach (var item in Model) {
            var tm = "#myModal" + item.LookupID;
            var mid = "myModal" + item.LookupID;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                ");
#nullable restore
#line 89 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LookupID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contract));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                &nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 96 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 99 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PacteraEdgeEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 102 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.oneforma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                ");
#nullable restore
#line 105 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ActiveHrs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>    \r\n             <td>\r\n                ");
#nullable restore
#line 108 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InactiveHrs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>  \r\n            <td>\r\n                ");
#nullable restore
#line 111 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BillableInactiveHrs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalHrs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                ");
#nullable restore
#line 117 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.finalamountpayable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>    \r\n             <td>\r\n                ");
#nullable restore
#line 120 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.USDTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>    \r\n             <td>\r\n                ");
#nullable restore
#line 123 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.dashboardstatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>  \r\n            <td>\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d7f922313247e00f7cafd7849f30b6def3dd22823623", async() => {
                WriteLiteral("Approve");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5231, "~/AnnotatorApproval/OnPostDelete?id=", 5231, 36, true);
#nullable restore
#line 128 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
AddHtmlAttributeValue("", 5267, item.LookupID, 5267, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-route-Id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 128 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
AddHtmlAttributeValue("", 5323, item.LookupID, 5323, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                |  \r\n                <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"");
#nullable restore
#line 130 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
                                                                                          Write(tm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    Reject \r\n                </button>\r\n                            \r\n                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 5643, "\"", 5652, 1);
#nullable restore
#line 134 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 5648, mid, 5648, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                                <h4 class=""modal-title"" id=""myModalLabel"">Reject Confirmation</h4>
                            </div>
                            <div class=""modal-body"">
                                Are you sure want to reject this item?
                            </div>
");
#nullable restore
#line 144 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
                             using (Html.BeginForm("OnGetComment", "AnnotatorApproval", FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div style=""margin-left:15px;width:30px;"">                                
                                        <textarea cols=""50"" rows=""2"" id=""Comment"" name=""Comment"" placeholder=""Leave Comment ...""></textarea>
                                    </div>
");
            WriteLiteral("                                    <div class=\"modal-footer\">\r\n                                        <input type=\"hidden\" name=\"LookupID\"");
            BeginWriteAttribute("value", " value=\"", 6966, "\"", 6988, 1);
#nullable restore
#line 152 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 6974, item.LookupID, 6974, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral(@"                                          <input type=""submit"" value=""Reject"" id=""btnSubmit"" class=""btn btn-primary"" onclick=""verify()"" />
                                          <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                                    </div>
");
#nullable restore
#line 157 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    \r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                \r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 166 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
                 if(ViewBag.Message != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <script type=""text/javascript"">
                                    window.onload = function () {
                                        alert(""Please enter the Comment!"");
                                    };
                                </script>
");
#nullable restore
#line 172 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
                            }  

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 175 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>    \r\n");
#nullable restore
#line 178 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", "\r\n   asp-route-sortOrder=\"", 8341, "\"", 8391, 1);
#nullable restore
#line 184 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 8367, ViewData["CurrentSort"], 8367, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-pageNumber", "\r\n   asp-route-pageNumber=\"", 8392, "\"", 8441, 1);
#nullable restore
#line 185 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 8419, Model.PageIndex - 1, 8419, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", "\r\n   asp-route-currentFilter=\"", 8442, "\"", 8498, 1);
#nullable restore
#line 186 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 8472, ViewData["CurrentFilter"], 8472, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n   class=\"", 8499, "\"", 8540, 3);
            WriteAttributeValue("", 8511, "btn", 8511, 3, true);
            WriteAttributeValue(" ", 8514, "btn-default", 8515, 12, true);
#nullable restore
#line 187 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue(" ", 8526, prevDisabled, 8527, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    Previous\r\n</a>\r\n<a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-sortOrder", "\r\n   asp-route-sortOrder=\"", 8585, "\"", 8635, 1);
#nullable restore
#line 191 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 8611, ViewData["CurrentSort"], 8611, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-pageNumber", "\r\n   asp-route-pageNumber=\"", 8636, "\"", 8685, 1);
#nullable restore
#line 192 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 8663, Model.PageIndex + 1, 8663, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-currentFilter", "\r\n   asp-route-currentFilter=\"", 8686, "\"", 8742, 1);
#nullable restore
#line 193 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue("", 8716, ViewData["CurrentFilter"], 8716, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n   class=\"", 8743, "\"", 8784, 3);
            WriteAttributeValue("", 8755, "btn", 8755, 3, true);
            WriteAttributeValue(" ", 8758, "btn-default", 8759, 12, true);
#nullable restore
#line 194 "C:\Projects\PacteraEdge_PaymentAutomation\IsaacPaymentAuto\RoleBasedAuthorization\Views\AnnotatorApproval\Index.cshtml"
WriteAttributeValue(" ", 8770, nextDisabled, 8771, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    Next\r\n</a>\r\n</html>");
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
