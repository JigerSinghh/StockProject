#pragma checksum "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "879143404731206c90e491efd0ea6687ca4c8daca2c7a9b0ad5fee9021604cc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_PortfolioBreakdown), @"mvc.1.0.view", @"/Views/Portfolio/PortfolioBreakdown.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/_ViewImports.cshtml"
using DataProjectCsharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/_ViewImports.cshtml"
using DataProjectCsharp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"879143404731206c90e491efd0ea6687ca4c8daca2c7a9b0ad5fee9021604cc6", @"/Views/Portfolio/PortfolioBreakdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"23e78e053b9acd85e625e36b8dc7cb6223daa1deaf9fbc97cc2e7c6ba825642f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_PortfolioBreakdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataProjectCsharp.Models.DataViewModels.PortfolioDataVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Portfolios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PositionBreakdown", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
  
    ViewData["Title"] = "PortfolioBreakdown";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879143404731206c90e491efd0ea6687ca4c8daca2c7a9b0ad5fee9021604cc65537", async() => {
                WriteLiteral("Go Back to Your Portfolios");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h1 style=\"color:#002699\">Portfolio: ");
#nullable restore
#line 7 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                Write(Model.PortfolioObject.PortfolioName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<h3 class=\"mb-2 text-muted\">You have <span style=\"color:#389afc\">");
#nullable restore
#line 9 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                                            Write(Model.PortfolioObject.GetPositions().Where(p => p.NetQuantity != 0).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> open positions </h3>\n\n");
#nullable restore
#line 11 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
 if (@Model.PortfolioObject.GetPositions().Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-3"">
                <table class=""table table-hover"" style=""width:100%"" id=""PositionTable"">
                    <thead style=""background-color:cornflowerblue"">
                        <tr>
                            <th>All Positions</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 23 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                         foreach (var position in @Model.PortfolioObject.GetPositions())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>\n                                    <span style=\"white-space:nowrap\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879143404731206c90e491efd0ea6687ca4c8daca2c7a9b0ad5fee9021604cc69222", async() => {
                WriteLiteral("Breakdown for ");
#nullable restore
#line 28 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                                                                                                                                                                                     Write(position.symbol);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PortfolioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                                                                                              WriteLiteral(Model.PortfolioId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PortfolioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PortfolioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PortfolioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                                                                                                                                            WriteLiteral(position.symbol);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["positionSymbol"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-positionSymbol", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["positionSymbol"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("\\", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </span>\n                                    <span style=\"white-space:nowrap;color:#389afc\"><span style=\"font-weight:600\">Quantity: </span>");
#nullable restore
#line 30 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                                                                                                             Write(position.NetQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                    <span style=\"white-space:nowrap;color:#389afc\"><span style=\"font-weight:600\">Average Cost: </span>");
#nullable restore
#line 31 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                                                                                                                 Write(position.AverageCost.ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 34 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""col-9"">
                <canvas id=""myChart""></canvas>
            </div>
        </div>
    </div>
    <div class=""col-12"">
        <table class=""table table-striped table-bordered"" style=""width:100%"" id=""PortfolioHPR"">
            <thead style=""background-color:cornflowerblue"">
                <tr>
                    <th>Date</th>
                    <th>Performance</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 52 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                 foreach (var row in Model.HoldingPeriodReturn.Rows)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 55 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                       Write(row[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 56 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                       Write(row[@Model.HoldingPeriodReturn.Columns.Count-2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\n                    </tr>\n");
#nullable restore
#line 58 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n");
#nullable restore
#line 62 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#PositionTable').DataTable({
                ""pagingType"": ""simple"",
                ""Info"": false,
                ""lengthChange"": false,
                ""pageLength"": 3,
                ""order"": [0, 'desc'],
                ""searching"": true,
                ""columnDefs"": [{ 'type': 'date-eu', 'targets': 0 }],
            });
        });
    </script>
    <script>
        $(document).ready(function () {


            $('#PortfolioHPR').DataTable({
                ""order"": [0, 'desc'],
                ""searching"": false,
                ""columnDefs"": [{ 'type': 'date-eu', 'targets': 0 }],
            });
        });
    </script>

    <script>
        var dates = [];
        var performance = [];
");
#nullable restore
#line 92 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
         if (Model.HoldingPeriodReturn != null)
        {
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
           foreach(var row in Model.HoldingPeriodReturn.Rows)
            {
                if(@row[@Model.HoldingPeriodReturn.Columns.Count - 1] != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                WriteLiteral("dates.push(\"");
#nullable restore
#line 98 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                             Write(row[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n                    ");
                WriteLiteral("performance.push(\"");
#nullable restore
#line 99 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                   Write(row[@Model.HoldingPeriodReturn.Columns.Count - 1]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n");
#nullable restore
#line 100 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        var ctx = document.getElementById('myChart');
    var myChart = new Chart(ctx, {
        type: 'line',
        tooltipCaretSize: 10,
        maintainAspectRatio: false,
        data: {
            labels: dates,
            datasets: [{
                label: '%',
                data: performance,
                backgroundColor: [
                    'rgba(69, 159, 255, 0.2)'
                ],
                borderColor: [""rgba(5, 38, 14, 1)""],
                borderWidth: 2,
                pointBorderWidth: 1,
                pointBorderColor: 'rgba(40, 106, 176, 1)'
            }]
        },
        options: {
          responsive:true,
          tooltips: {
            mode: ""index"",
            intersect:false,
          },
          hover:{
            mode: ""nearest"",
            intersect: true,
          },
          legend: {
            display: false,
            labels: {
              fontColor: ""#0e61f0""
            }
          },
          title: {
            display: true,
     ");
                WriteLiteral("       text: \"Holding Period Return for ");
#nullable restore
#line 141 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Portfolio/PortfolioBreakdown.cshtml"
                                        Write(Model.PortfolioObject.PortfolioName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
            fontColor: ""#0e61f0""
          },
          layout: {
            padding:{
              left: 20,
              right: 20,
              top: 0,
              bottom: 0
            }
          },
            scales: {
                xAxes: [{

                  scaleLabel:{
                    display: true,
                    labelString: ""Date"",
                    fontColor: ""#0e61f0""
                  },
                    ticks: {
                        fontColor: ""#003a9c"",
                        autoSkip: true,
                        maxTicksLimit: 6,
                        maxRotation: 15,
                        minRotation:15
                    }
                }],
                yAxes: [{
                  display:true,
                  scaleLabel:{
                    fontColor: ""#0e61f0"",
                    display: true,
                    labelString:""Performance Indexed""
                  },
                  ticks:{
                      fontColor: ""#003a9c"",
   ");
                WriteLiteral("               }\n                }]\n            }\n        }\n    });\n    </script>\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataProjectCsharp.Models.DataViewModels.PortfolioDataVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
