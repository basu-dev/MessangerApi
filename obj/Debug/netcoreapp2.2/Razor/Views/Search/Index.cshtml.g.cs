#pragma checksum "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e374d303dd2516e255415d4afd2ac7d614a729a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Index.cshtml", typeof(AspNetCore.Views_Search_Index))]
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
#line 2 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\_ViewImports.cshtml"
using Messege.Models;

#line default
#line hidden
#line 1 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
using Messege.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e374d303dd2516e255415d4afd2ac7d614a729a0", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c64ae2d1cd4f2d04742915b75c64e31bf59d044", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SearchView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/search.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 71, true);
            WriteLiteral("   \r\n       \r\n            <div class=\"card mb-1\">SearchResults </div>\r\n");
            EndContext();
#line 6 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
             foreach (var result in Model)
            {

#line default
#line hidden
            BeginContext(183, 82, true);
            WriteLiteral("                <div class=\"container text-center mb-2\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 265, "\"", 295, 2);
            WriteAttributeValue("", 271, "/", 271, 1, true);
#line 9 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 272, result.Profile_Picture, 272, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 76, true);
            WriteLiteral(" height=\"55\" width=\"55\" class=\"rounded-circle\" />\r\n                    <div>");
            EndContext();
            BeginContext(373, 17, false);
#line 10 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
                    Write(result.First_Name);

#line default
#line hidden
            EndContext();
            BeginContext(390, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(392, 16, false);
#line 10 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
                                       Write(result.Last_Name);

#line default
#line hidden
            EndContext();
            BeginContext(408, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 11 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
                     if (result.Status == 1)
                    {

#line default
#line hidden
            BeginContext(485, 78, true);
            WriteLiteral("                        <button class=\"btn  btn-primary btn-sm button_request\"");
            EndContext();
            BeginWriteAttribute("name", " name=", 563, "", 579, 1);
#line 13 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 569, result.Id, 569, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 579, "", 607, 2);
            WriteAttributeValue("", 586, "disconnect_", 586, 11, true);
#line 13 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 597, result.Id, 597, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(607, 22, true);
            WriteLiteral(">Disconnect</button>\r\n");
            EndContext();
#line 14 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
                    }
                    else if (result.Status == 2)
                    {

#line default
#line hidden
            BeginContext(725, 132, true);
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <button class=\"btn  btn-primary btn-sm button_request\"");
            EndContext();
            BeginWriteAttribute("name", " name=", 857, "", 873, 1);
#line 18 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 863, result.Id, 863, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 873, "", 897, 2);
            WriteAttributeValue("", 880, "accept_", 880, 7, true);
#line 18 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 887, result.Id, 887, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 100, true);
            WriteLiteral(">Accept</button>\r\n                            <button class=\"btn  btn-primary btn-sm button_request\"");
            EndContext();
            BeginWriteAttribute("name", " name=", 997, "", 1013, 1);
#line 19 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 1003, result.Id, 1003, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 1013, "", 1038, 2);
            WriteAttributeValue("", 1020, "decline_", 1020, 8, true);
#line 19 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 1028, result.Id, 1028, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1038, 53, true);
            WriteLiteral(">Decline</button>\r\n\r\n                        </div>\r\n");
            EndContext();
#line 22 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"

                    }
                    else if (result.Status == 3)
                    {

#line default
#line hidden
            BeginContext(1189, 132, true);
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <button class=\"btn  btn-primary btn-sm button_request\"");
            EndContext();
            BeginWriteAttribute("name", " name=", 1321, "", 1337, 1);
#line 27 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 1327, result.Id, 1327, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 1337, "", 1369, 2);
            WriteAttributeValue("", 1344, "cancel_request_", 1344, 15, true);
#line 27 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 1359, result.Id, 1359, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1369, 58, true);
            WriteLiteral(">Cancel Request</button>\r\n                        </div>\r\n");
            EndContext();
#line 29 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
                    }
                    else if (result.Status == 4)
                    {

#line default
#line hidden
            BeginContext(1523, 37, true);
            WriteLiteral("                        <div></div>\r\n");
            EndContext();
#line 33 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
                    }
                    else if (result.Status == 5)
                    {


#line default
#line hidden
            BeginContext(1658, 78, true);
            WriteLiteral("                        <button class=\"btn  btn-primary btn-sm button_request\"");
            EndContext();
            BeginWriteAttribute("name", " name=", 1736, "", 1752, 1);
#line 37 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 1742, result.Id, 1742, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 1752, "", 1777, 2);
            WriteAttributeValue("", 1759, "connect_", 1759, 8, true);
#line 37 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
WriteAttributeValue("", 1767, result.Id, 1767, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1777, 20, true);
            WriteLiteral(" >Connect</button>\r\n");
            EndContext();
#line 38 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1820, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 41 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Search\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1861, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1873, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e374d303dd2516e255415d4afd2ac7d614a729a012522", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1909, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1923, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e374d303dd2516e255415d4afd2ac7d614a729a013715", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1958, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1972, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e374d303dd2516e255415d4afd2ac7d614a729a014908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2023, 29, true);
            WriteLiteral("\r\n        \r\n       \r\n      \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SearchView>> Html { get; private set; }
    }
}
#pragma warning restore 1591