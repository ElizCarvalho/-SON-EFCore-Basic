#pragma checksum "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79b42224a71b31f2d68ac6b0aa140620a469204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Index), @"mvc.1.0.view", @"/Views/Funcionario/Index.cshtml")]
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
#line 1 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\_ViewImports.cshtml"
using EFCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\_ViewImports.cshtml"
using EFCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79b42224a71b31f2d68ac6b0aa140620a469204", @"/Views/Funcionario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f33d983cd61420160d2da836c4b6e737e72e1b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EFCore.Models.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Todos os funcionários</h2>\r\n\r\n<a href=\"/Funcionario/Cadastrar\" class=\"btn btn-success\">Novo Funcionário</a>\r\n<hr>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>CPF: ");
#nullable restore
#line 10 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml"
       Write(item.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Nome: ");
#nullable restore
#line 11 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml"
        Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Salário: ");
#nullable restore
#line 12 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml"
           Write(item.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 300, "\"", 335, 2);
            WriteAttributeValue("", 307, "/Funcionario/Editar/", 307, 20, true);
#nullable restore
#line 13 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml"
WriteAttributeValue("", 327, item.Id, 327, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 379, "\"", 415, 2);
            WriteAttributeValue("", 386, "/Funcionario/Deletar/", 386, 21, true);
#nullable restore
#line 14 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml"
WriteAttributeValue("", 407, item.Id, 407, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n    <hr>\r\n");
#nullable restore
#line 16 "C:\Users\elizabeth.carvalho\Desktop\EFCore\Views\Funcionario\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EFCore.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
