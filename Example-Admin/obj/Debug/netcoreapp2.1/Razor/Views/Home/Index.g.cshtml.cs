#pragma checksum "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed9794a52f30ea1ad1d8a445b10e1995f7e5ec8d"
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
#line 1 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\_ViewImports.cshtml"
using Example_Admin;

#line default
#line hidden
#line 2 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\_ViewImports.cshtml"
using Example_Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed9794a52f30ea1ad1d8a445b10e1995f7e5ec8d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da1d7266beae2dbf1665eb9d37de40ae8c96226", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(24, 444, true);
            WriteLiteral(@"    <script>
        function setValue(selectedOption){
            var price=selectedOption.getAttribute('price');   
            document.getElementById(""Value"").value=price;    

            var productID=selectedOption.id;   
            document.getElementById(""ID"").value=productID;      
        }
    </script>
<div class=""container"">
    <div class=""jumbotron"">
        <h3> Update item's price </h3>
    </div>
    <hr>
");
            EndContext();
#line 17 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
     using(Html.BeginForm("Push","Home","FormMethod.Post"))
    {

#line default
#line hidden
            BeginContext(536, 134, true);
            WriteLiteral("        <label> Product Type: </label>\r\n        <select name=\"Name\" id=\"Name\" onchange=\"setValue(this.options[this.selectedIndex])\">\r\n");
            EndContext();
#line 21 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
             foreach(var product in Model)
            {

#line default
#line hidden
            BeginContext(729, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(745, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bf174cdc554424bb14aab56fc59de61", async() => {
                BeginContext(816, 12, false);
#line 23 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
                                                                                 Write(product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 23 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
                   WriteLiteral(product.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 779, product.ID, 779, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "price", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 799, product.Value, 799, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(837, 14, true);
            WriteLiteral("            \r\n");
            EndContext();
#line 24 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(866, 290, true);
            WriteLiteral(@"        </select>                                             
                <input type=""text"" name=""Value"" id=""Value"">
                <input type=""hidden"" name= ""ID"" id=""ID"">                                     
        <input type=""submit"" value=""Update"" class=""btn btn-success"">
");
            EndContext();
#line 29 "C:\CoreDeployment\RabbbitMq-RedisCache-SignalR-Example\Example-Admin\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1163, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591