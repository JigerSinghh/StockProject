#pragma checksum "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2811ec5fddfbc63af766b5eef0dd8cafe4d07704fa74fc02dafae25dec58b679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trade__TradeViewModalPartial), @"mvc.1.0.view", @"/Views/Trade/_TradeViewModalPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2811ec5fddfbc63af766b5eef0dd8cafe4d07704fa74fc02dafae25dec58b679", @"/Views/Trade/_TradeViewModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"23e78e053b9acd85e625e36b8dc7cb6223daa1deaf9fbc97cc2e7c6ba825642f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Trade__TradeViewModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataProjectCsharp.Models.Portfolio>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Trademodals.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""modal-placeholder-trades""></div>
<div class=""modal fade"" id=""viewTrades"" >
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class="" = modal-header"">
                <h5 class=""modal-title"" id=""viewTradeLabel"">Trades for ");
#nullable restore
#line 8 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\n                    <span aria-hidden=\"true\">&times;</span>\n                </button>\n            </div>\n            <div class=\"modal-body\">\n\n");
#nullable restore
#line 15 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                 if (@Model.Trades.FirstOrDefault() != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col\">\n                        <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"ajax-modal-trade\" data-target=\"#addTrade\" data-url=\"");
#nullable restore
#line 18 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                                                                                                                  Write(Url.Action("AddTrade", "Trade", new { id=Model.PortfolioId}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Add a new Trade</button>
                    </div>
                    <div class=""col-12"">
                        <table class=""table table-striped table-bordered"" style=""width:100%"" id=""TradesView"">
                            <thead>
                                <tr>
                                    <th>Ticker</th>
                                    <th>Quantity</th>
                                    <th>Price</th>
                                    <th>Trade Date</th>
                                    <th>Comments</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 33 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                 if (@Model.Trades.FirstOrDefault() != null)
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                     foreach (Trade trade in @Model.Trades)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 39 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                           Write(trade.Ticker);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 40 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                           Write(trade.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 41 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                           Write(trade.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 42 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                           Write(trade.TradeDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 43 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                           Write(trade.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n                                                <button type=\"button\" class=\"btn btn-outline-primary\" data-toggle=\"ajax-modal-trade\" data-target=\"#editTrade\" data-url=\"");
#nullable restore
#line 45 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                                                                                                                                                   Write(Url.Action("EditTrade", "Trade", new { id=trade.TradeId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</button>\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2811ec5fddfbc63af766b5eef0dd8cafe4d07704fa74fc02dafae25dec58b67910637", async() => {
                WriteLiteral("\n                                                    <input class=\"btn btn-outline-danger\" type=\"submit\" value=\"Delete\" onclick=\"return confirm(\'Are you sure you want to delete this trade?\')\" />\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                                                                                                      WriteLiteral(trade.TradeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 51 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n");
#nullable restore
#line 56 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>This Portfolio is currently empty.</p>\n                    <div class=\"col\">\n                        <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"ajax-modal-trade\" data-target=\"#addTrade\" data-url=\"");
#nullable restore
#line 61 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                                                                                                                                  Write(Url.Action("AddTrade", "Trade", new { id=Model.PortfolioId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Add a new Trade</button>\n                    </div>\n");
#nullable restore
#line 63 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <div class=\"modal-footer\">\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\n            </div>\n        </div>\n    </div>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2811ec5fddfbc63af766b5eef0dd8cafe4d07704fa74fc02dafae25dec58b67915986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 71 "/Users/jigersingh/Downloads/DataProjectCsharp-master/DataProjectCsharp/Views/Trade/_TradeViewModalPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script>\n    $(document).ready(function () {\n        $(\'#TradesView\').DataTable({\n            \"lengthChange\": false,\n            \"pageLength\": 4,\n        });\n    });\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataProjectCsharp.Models.Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
