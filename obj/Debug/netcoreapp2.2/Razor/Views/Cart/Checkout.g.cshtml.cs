#pragma checksum "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45faadcd01dcc06e3eb8277483ae95ea36eaa6e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Checkout), @"mvc.1.0.view", @"/Views/Cart/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Checkout.cshtml", typeof(AspNetCore.Views_Cart_Checkout))]
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
#line 1 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\_ViewImports.cshtml"
using OsoloWebShop;

#line default
#line hidden
#line 2 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\_ViewImports.cshtml"
using OsoloWebShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45faadcd01dcc06e3eb8277483ae95ea36eaa6e3", @"/Views/Cart/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ac6866307e2c200f201c21e3e528f9215b08d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/page-info-art.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-info-art"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
            BeginContext(46, 333, true);
            WriteLiteral(@"
<!-- Page Info -->
<div class=""page-info-section page-info"">
    <div class=""container"">
        <div class=""site-breadcrumb"">
            <a href="""">Home</a> /
            <a href="""">Sales</a> /
            <a href="""">Bags</a> /
            <a href="""">Cart</a> /
            <span>Checkout</span>
        </div>
        ");
            EndContext();
            BeginContext(379, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45faadcd01dcc06e3eb8277483ae95ea36eaa6e34881", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(443, 758, true);
            WriteLiteral(@"
    </div>
</div>
<!-- Page Info end -->
<!-- Page -->
<div class=""page-area cart-page spad"">
    <div class=""container"">
        <div class=""checkout-form"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""order-card"">
                        <div class=""order-details"">
                            <div class=""od-warp"">
                                <h4 class=""checkout-title"">Your order has been stored!</h4>
                                <table class=""order-table"">
                                    <thead>
                                        <tr>
                                            <th>Order Reference Number</th>
                                            <th>");
            EndContext();
            BeginContext(1202, 15, false);
#line 34 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
                                           Write(ViewBag.orderID);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 302, true);
            WriteLiteral(@"</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>SubTotal</td>
                                            <td>");
            EndContext();
            BeginContext(1520, 13, false);
#line 40 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
                                           Write(ViewBag.total);

#line default
#line hidden
            EndContext();
            BeginContext(1533, 556, true);
            WriteLiteral(@"</td>
                                        </tr>
                                        <tr class=""cart-subtotal"">
                                            <td>Shipping</td>
                                            <td>Free</td>
                                        </tr>
                                    </tbody>
                                    <tfoot>
                                        <tr class=""order-total"">
                                            <th>Total</th>
                                            <th>");
            EndContext();
            BeginContext(2090, 13, false);
#line 50 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
                                           Write(ViewBag.total);

#line default
#line hidden
            EndContext();
            BeginContext(2103, 944, true);
            WriteLiteral(@"</th>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""order-card"">
                        <div class=""order-details"">
                            <div class=""od-warp"">
                                <h4 class=""checkout-title"">Your order:</h4>
                                <table class=""order-table"">
                                    <thead>
                                        <tr>
                                            <th>Product</th>
                                            <th>Quantity</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 71 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
                                         foreach (var item in ViewBag.cart)
                                        {

#line default
#line hidden
            BeginContext(3167, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(3270, 16, false);
#line 74 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
                                               Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3286, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3346, 13, false);
#line 75 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
                                               Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3359, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 77 "C:\Users\gusta\source\repos\OsoloWebShop\OsoloWebShop\Views\Cart\Checkout.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3460, 233, true);
            WriteLiteral("                                </table>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Page -->\r\n");
            EndContext();
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
