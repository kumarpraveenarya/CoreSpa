#pragma checksum "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10d1933d6e67679484f6cb1deeab4efaf5f6aad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ShowRecoveryCodes.cshtml", typeof(AspNetCore.Views_Manage_ShowRecoveryCodes))]
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
#line 1 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml"
using AspNetCoreSpa.STS.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d1933d6e67679484f6cb1deeab4efaf5f6aad1", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70243347a4331c6ceb8bad4e9ed708ba952e5bef", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b930c79357c22944b45d92e69afcc4bf92f3b3a", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(226, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(233, 17, false);
#line 9 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(250, 377, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
            EndContext();
#line 21 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
            BeginContext(710, 18, true);
            WriteLiteral("            <code>");
            EndContext();
            BeginContext(729, 24, false);
#line 23 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(753, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(766, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(779, 6, true);
            WriteLiteral("<code>");
            EndContext();
            BeginContext(786, 28, false);
#line 23 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(814, 15, true);
            WriteLiteral("</code><br />\r\n");
            EndContext();
#line 24 "C:\aspcore\AspNetCoreSpa\src\AspNetCoreSpa.STS\Views\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
            BeginContext(840, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591