#pragma checksum "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30453ff8b0a6b332ebb17b4c9c3d17e9a5798383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
#line 1 "F:\project\OAuth2\AuthorizationServer\Views\_ViewImports.cshtml"
using AuthorizationServer;

#line default
#line hidden
#line 2 "F:\project\OAuth2\AuthorizationServer\Views\_ViewImports.cshtml"
using AuthorizationServer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30453ff8b0a6b332ebb17b4c9c3d17e9a5798383", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba51f240eca2359e4cd8981e9837e96a8c2cb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorizationServer.ViewModels.ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(83, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(108, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30453ff8b0a6b332ebb17b4c9c3d17e9a57983835658", async() => {
                BeginContext(114, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(210, 3636, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30453ff8b0a6b332ebb17b4c9c3d17e9a57983836934", async() => {
                BeginContext(216, 110, true);
                WriteLiteral("\r\n    <div class=\"page-consent\">\r\n        <div class=\"row page-header\">\r\n            <div class=\"col-sm-10\">\r\n");
                EndContext();
#line 15 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                 if (Model.ClientLogoUrl != null)
                {

#line default
#line hidden
                BeginContext(396, 49, true);
                WriteLiteral("                    <div class=\"client-logo\"><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 445, "\"", 471, 1);
#line 17 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
WriteAttributeValue("", 451, Model.ClientLogoUrl, 451, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(472, 9, true);
                WriteLiteral("></div>\r\n");
                EndContext();
#line 18 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(500, 42, true);
                WriteLiteral("                <h1>\r\n                    ");
                EndContext();
                BeginContext(543, 16, false);
#line 20 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
               Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(559, 181, true);
                WriteLiteral("\r\n                    <small>需要获取</small>\r\n                </h1>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                ");
                EndContext();
                BeginContext(740, 3049, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30453ff8b0a6b332ebb17b4c9c3d17e9a57983839013", async() => {
                    BeginContext(786, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(808, 43, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30453ff8b0a6b332ebb17b4c9c3d17e9a57983839435", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(851, 40, true);
                    WriteLiteral("\r\n                    <div>选择.</div>\r\n\r\n");
                    EndContext();
#line 31 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                     if (Model.IdentityScopes != null && Model.IdentityScopes.Any())
                    {

#line default
#line hidden
                    BeginContext(1000, 345, true);
                    WriteLiteral(@"                        <div class=""panel panel-default consent-buttons"">
                            <div class=""panel-heading"">
                                <span class=""glyphicon glyphicon-user""></span>
                                需要获取以下用户信息
                            </div>
                            <ul class=""list-group"">
");
                    EndContext();
#line 39 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                                 foreach (var scope in Model.IdentityScopes)
                                {
                                    

#line default
#line hidden
                    BeginContext(1585, 37, false);
#line 42 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                               Write(Html.Partial("_ScopeListItem", scope));

#line default
#line hidden
                    EndContext();
#line 42 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                                                                          ;
                                }

#line default
#line hidden
                    BeginContext(1660, 67, true);
                    WriteLiteral("                            </ul>\r\n                        </div>\r\n");
                    EndContext();
#line 46 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                    BeginContext(1750, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
#line 47 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                     if (Model.ResourceScopes != null && Model.ResourceScopes.Any())
                    {

#line default
#line hidden
                    BeginContext(1859, 330, true);
                    WriteLiteral(@"                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <span class=""glyphicon glyphicon-tasks""></span>
                                需要获取以下用户权限
                            </div>
                            <ul class=""list-group"">
");
                    EndContext();
#line 55 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                                 foreach (var scope in Model.ResourceScopes)
                                {

#line default
#line hidden
                    BeginContext(2302, 36, true);
                    WriteLiteral("                                    ");
                    EndContext();
                    BeginContext(2338, 48, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30453ff8b0a6b332ebb17b4c9c3d17e9a579838314349", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 57 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2386, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 58 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                                                                               
                                    //await Html.PartialAsync("_ScopeListItem", scope);
                                }

#line default
#line hidden
                    BeginContext(2593, 67, true);
                    WriteLiteral("                            </ul>\r\n                        </div>\r\n");
                    EndContext();
#line 63 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                    BeginContext(2683, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
#line 64 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                     if (Model.AllowRememberConsent)
                    {

#line default
#line hidden
                    BeginContext(2760, 125, true);
                    WriteLiteral("                        <div class=\"consent-remember\">\r\n                            <label>\r\n                                ");
                    EndContext();
                    BeginContext(2885, 62, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30453ff8b0a6b332ebb17b4c9c3d17e9a579838317391", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 68 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2947, 126, true);
                    WriteLiteral("\r\n                                <strong>记住我</strong>\r\n                            </label>\r\n                        </div>\r\n");
                    EndContext();
#line 72 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                    BeginContext(3096, 238, true);
                    WriteLiteral("                    <div class=\"consent-buttons\">\r\n                        <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>同意</button>\r\n                        <button name=\"button\" value=\"no\" class=\"btn\">取消</button>\r\n");
                    EndContext();
#line 76 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                         if (Model.ClientUrl != null)
                        {

#line default
#line hidden
                    BeginContext(3416, 81, true);
                    WriteLiteral("                            <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 3497, "\"", 3520, 1);
#line 78 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
WriteAttributeValue("", 3504, Model.ClientUrl, 3504, 16, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3521, 128, true);
                    WriteLiteral(">\r\n                                <span class=\"glyphicon glyphicon-info-sign\"></span>\r\n                                <strong>");
                    EndContext();
                    BeginContext(3650, 16, false);
#line 80 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                                   Write(Model.ClientName);

#line default
#line hidden
                    EndContext();
                    BeginContext(3666, 45, true);
                    WriteLiteral("</strong>\r\n                            </a>\r\n");
                    EndContext();
#line 82 "F:\project\OAuth2\AuthorizationServer\Views\Consent\Index.cshtml"
                        }

#line default
#line hidden
                    BeginContext(3738, 44, true);
                    WriteLiteral("                    </div>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3789, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3846, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorizationServer.ViewModels.ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
