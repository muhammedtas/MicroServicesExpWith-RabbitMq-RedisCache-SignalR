#pragma checksum "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2795dc732c19546c5f6dbd280a2cb7ba757c6ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
using Example_Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2795dc732c19546c5f6dbd280a2cb7ba757c6ec", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbeab2bceca91a649be5c684dbc8b4054d254b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 103, true);
            WriteLiteral("    <div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n        <h3>Choose product</h3>\r\n    </div>\r\n");
            EndContext();
#line 7 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
     using(Html.BeginForm("Detail","Home","FormMethod.Post"))
    {
        

#line default
#line hidden
#line 9 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
         foreach(var product in Model)
        {

#line default
#line hidden
            BeginContext(276, 150, true);
            WriteLiteral("            <div class=\"radio\">\r\n                <label for=\"female\" style=\"width : 125px\">\r\n                    <input type=\"radio\" name=\"Id\" id=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 426, "\"", 445, 1);
#line 13 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
WriteAttributeValue("", 434, product.Id, 434, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(446, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(448, 12, false);
#line 13 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
                                                                         Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(460, 106, true);
            WriteLiteral("                                        \r\n                </label>\r\n                <b>Fiyat</b> : <label>");
            EndContext();
            BeginContext(567, 13, false);
#line 15 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
                                 Write(product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(580, 44, true);
            WriteLiteral(" ₺</label>\r\n            </div>            \r\n");
            EndContext();
#line 17 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(635, 81, true);
            WriteLiteral("        <br>\r\n        <input type=\"submit\" value=\"Buy\" class=\"btn btn-success\">\r\n");
            EndContext();
#line 20 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Client\Views\Home\Index.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
