#pragma checksum "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4e3c5be247f5d6c0a3dbbb941d6997f20ea3779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_TwoFactorAuthentication), @"mvc.1.0.view", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/TwoFactorAuthentication.cshtml", typeof(AspNetCore.Views_Manage_TwoFactorAuthentication))]
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
#line 1 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\_ViewImports.cshtml"
using AspNetCoreSpa.STS;

#line default
#line hidden
#line 3 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\_ViewImports.cshtml"
using AspNetCoreSpa.STS.Models;

#line default
#line hidden
#line 2 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\_ViewImports.cshtml"
using AspNetCoreSpa.STS.Views.Manage;

#line default
#line hidden
#line 1 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
using AspNetCoreSpa.STS.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e3c5be247f5d6c0a3dbbb941d6997f20ea3779", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70243347a4331c6ceb8bad4e9ed708ba952e5bef", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b930c79357c22944b45d92e69afcc4bf92f3b3a", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_TwoFactorAuthentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwoFactorAuthenticationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Disable2faWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodesWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("enable-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnableAuthenticator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reset-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetAuthenticatorWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
  
    ViewData["Title"] = @SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_TITLE");
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(283, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(290, 17, false);
#line 9 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(307, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 10 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
 if (Model.Is2faEnabled)
{
    if (Model.RecoveryCodesLeft == 0)
    {

#line default
#line hidden
            BeginContext(389, 62, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>");
            EndContext();
            BeginContext(452, 59, false);
#line 15 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("2FA_NO_CODES_LEFT"));

#line default
#line hidden
            EndContext();
            BeginContext(511, 35, true);
            WriteLiteral("</strong>\r\n            <p>You must ");
            EndContext();
            BeginContext(546, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea37798082", async() => {
                BeginContext(584, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(624, 65, true);
            WriteLiteral(" before you can log in with a recovery code.</p>\r\n            <p>");
            EndContext();
            BeginContext(690, 64, false);
#line 17 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_NO_CODES_LEFT_TEXT"));

#line default
#line hidden
            EndContext();
            BeginContext(754, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(755, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea37799934", async() => {
                BeginContext(794, 50, false);
#line 17 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("GENERATE"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(848, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft == 1)
    {

#line default
#line hidden
            BeginContext(928, 62, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>");
            EndContext();
            BeginContext(991, 60, false);
#line 23 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("2FA_ONE_CODES_LEFT"));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 26, true);
            WriteLiteral("</strong>\r\n            <p>");
            EndContext();
            BeginContext(1078, 65, false);
#line 24 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_ONE_CODES_LEFT_TEXT"));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 48, true);
            WriteLiteral("  You can generate a new set of recovery codes. ");
            EndContext();
            BeginContext(1191, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea377912811", async() => {
                BeginContext(1230, 50, false);
#line 24 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("GENERATE"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1284, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 26 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft <= 3)
    {

#line default
#line hidden
            BeginContext(1364, 63, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>");
            EndContext();
            BeginContext(1428, 95, false);
#line 30 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("2FA_N_CODES_LEFT", @Model.RecoveryCodesLeft.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 26, true);
            WriteLiteral("</strong>\r\n            <p>");
            EndContext();
            BeginContext(1550, 63, false);
#line 31 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_N_CODES_LEFT_TEXT"));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1614, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea377915727", async() => {
                BeginContext(1653, 50, false);
#line 31 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("GENERATE"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1707, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 33 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
    }


#line default
#line hidden
            BeginContext(1738, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1742, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea377917639", async() => {
                BeginContext(1801, 60, false);
#line 35 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                         Write(SharedLocalizer.GetLocalizedHtmlString("DISABLE_2FA_BUTTON"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1865, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1871, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea377919322", async() => {
                BeginContext(1941, 62, false);
#line 36 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                    Write(SharedLocalizer.GetLocalizedHtmlString("RESET_RECOVERY_CODES"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2007, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(2012, 6, true);
            WriteLiteral("\r\n<h5>");
            EndContext();
            BeginContext(2019, 59, false);
#line 39 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AUTHENTICATOR_APP"));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 40 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
 if (!Model.HasAuthenticator)
{

#line default
#line hidden
            BeginContext(2119, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2123, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea377921914", async() => {
                BeginContext(2211, 82, false);
#line 42 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                      Write(SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_ADD_AUTHENTICATOR_APP"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2311, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2315, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea377923977", async() => {
                BeginContext(2402, 74, false);
#line 46 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                     Write(SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_ADD_SETUP_APP"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2480, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2486, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e3c5be247f5d6c0a3dbbb941d6997f20ea377925785", async() => {
                BeginContext(2578, 74, false);
#line 47 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_ADD_RESET_APP"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2656, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(2661, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2681, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2688, 52, false);
#line 51 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\TwoFactorAuthentication.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(2740, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwoFactorAuthenticationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591