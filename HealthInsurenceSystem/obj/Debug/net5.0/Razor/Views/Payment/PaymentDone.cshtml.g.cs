#pragma checksum "D:\GitHub\HealthInsurenceSystem\HealthInsurenceSystem\Views\Payment\PaymentDone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7906205b0eb2d50965346ff1c020299fc1061787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_PaymentDone), @"mvc.1.0.view", @"/Views/Payment/PaymentDone.cshtml")]
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
#nullable restore
#line 1 "D:\GitHub\HealthInsurenceSystem\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\HealthInsurenceSystem\HealthInsurenceSystem\Views\_ViewImports.cshtml"
using HealthInsurenceSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7906205b0eb2d50965346ff1c020299fc1061787", @"/Views/Payment/PaymentDone.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e2e8eff2f278ec56cd155b82857607914793b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_PaymentDone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthInsurenceSystem.Models.Paymentlog>>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7906205b0eb2d50965346ff1c020299fc10617873181", async() => {
                WriteLiteral("\r\n\r\n    <title>\r\n        No Panding Payment Found\r\n    </title>\r\n");
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
            WriteLiteral("\r\n<div class=\"jumbotron text-center\">\r\n    <h1 class=\"display-3\">Thank You!</h1>\r\n\r\n    <p class=\"lead\"><h3> Our record shows that you have paid premium for this month.</b></h3></p>\r\n    <hr><br />\r\n    <p>Paid Amount: $ ");
#nullable restore
#line 14 "D:\GitHub\HealthInsurenceSystem\HealthInsurenceSystem\Views\Payment\PaymentDone.cshtml"
                 Write(TempData["data"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n    <p>Transaction Date: $ ");
#nullable restore
#line 15 "D:\GitHub\HealthInsurenceSystem\HealthInsurenceSystem\Views\Payment\PaymentDone.cshtml"
                      Write(TempData["Ldate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\r\n    <p> See You Next Month.</p>\r\n    <br />\r\n    <p>\r\n       Buy our new Policy.\r\n    </p>\r\n    <p class=\"lead\">\r\n        <a class=\"btn btn-primary btn-sm\" href=\"https://bootstrapcreative.com/\" role=\"button\">Check Now</a>\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthInsurenceSystem.Models.Paymentlog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
