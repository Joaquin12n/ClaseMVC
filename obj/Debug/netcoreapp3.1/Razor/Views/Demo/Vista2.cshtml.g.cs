#pragma checksum "C:\Users\Joaquin\Desktop\MVC_Clase\Views\Demo\Vista2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b16468700d74497d22a17f46c4d6e8cde8874c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Vista2), @"mvc.1.0.view", @"/Views/Demo/Vista2.cshtml")]
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
#line 1 "C:\Users\Joaquin\Desktop\MVC_Clase\Views\_ViewImports.cshtml"
using MVC_Clase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joaquin\Desktop\MVC_Clase\Views\_ViewImports.cshtml"
using MVC_Clase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b16468700d74497d22a17f46c4d6e8cde8874c", @"/Views/Demo/Vista2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f808f63bb9a9dc3d3c63bf6e2effec216b5841c", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Vista2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Clase.Curso>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Clases De Comunidad IT</h1>\r\n<i>\r\n");
#nullable restore
#line 5 "C:\Users\Joaquin\Desktop\MVC_Clase\Views\Demo\Vista2.cshtml"
 foreach (string diaitem in Model.Dias)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"color:green;\"> ");
#nullable restore
#line 7 "C:\Users\Joaquin\Desktop\MVC_Clase\Views\Demo\Vista2.cshtml"
                         Write(diaitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 8 "C:\Users\Joaquin\Desktop\MVC_Clase\Views\Demo\Vista2.cshtml"
Write(Model.Horas);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 10 "C:\Users\Joaquin\Desktop\MVC_Clase\Views\Demo\Vista2.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Clase.Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591