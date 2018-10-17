#pragma checksum "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0b1cad29285a0d8dba69fe5c02cbc023dc4afc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\_ViewImports.cshtml"
using RabbitMq_Client;

#line default
#line hidden
#line 2 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\_ViewImports.cshtml"
using RabbitMq_Client.Models;

#line default
#line hidden
#line 1 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Detail.cshtml"
using Example_Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b1cad29285a0d8dba69fe5c02cbc023dc4afc1", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbeab2bceca91a649be5c684dbc8b4054d254b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/signalr-client-1.0.0-alpha2-final.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9ab48694b94ae69e3d27e0016a3053", async() => {
                BeginContext(52, 7, true);
                WriteLiteral("\r\n     ");
                EndContext();
                BeginContext(59, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd528f824870479a825e4f16cabb334f", async() => {
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
                BeginContext(133, 264, true);
                WriteLiteral(@"
     <script>
        let connection = new signalR.HubConnection('/producthub');
         
         connection.on('SetConnectionId', data => {
                console.log(""ConnectionID : ""+data);
                var result=connection.invoke('ConnectGroup','");
                EndContext();
                BeginContext(398, 10, false);
#line 10 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Detail.cshtml"
                                                        Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(408, 368, true);
                WriteLiteral(@"',data);
                console.log(result);

        });   

        connection.on('ChangeProductValue', data => {
            console.log(JSON.stringify(data));
               alert(""New Price : ""+data.value +"" ₺"");
               document.getElementById(""productValue"").innerHTML=data.value;
        });

        connection.start()
     </script>    
");
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
            BeginContext(783, 78, true);
            WriteLiteral("\r\n <div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n        <h3>Alınan = ");
            EndContext();
            BeginContext(862, 10, false);
#line 26 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Detail.cshtml"
                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(872, 27, true);
            WriteLiteral(" : <span id=\"productValue\">");
            EndContext();
            BeginContext(900, 11, false);
#line 26 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Detail.cshtml"
                                                      Write(Model.Value);

#line default
#line hidden
            EndContext();
            BeginContext(911, 35, true);
            WriteLiteral("</span> ₺</h3>\r\n    </div>\r\n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591