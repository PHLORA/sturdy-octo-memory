#pragma checksum "E:\диплом asp.net core\BookStore\BookStore\Views\Manager\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b206f53cfe7d156492a60f6c2534c3939002b0c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Create), @"mvc.1.0.view", @"/Views/Manager/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b206f53cfe7d156492a60f6c2534c3939002b0c2", @"/Views/Manager/Create.cshtml")]
    public class Views_Manager_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\диплом asp.net core\BookStore\BookStore\Views\Manager\Create.cshtml"
  
    ViewBag.Title = "Добавление пользователя";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<form asp-action=""create"" asp-controller=""manager"">
    <div class=""form-group"">
        <label asp-for=""Name"" class=""control-label"">Имя</label>
        <input type=""text"" asp-for=""Name"" class=""form-control"" name=""Name""/>
    </div>
    <div class=""form-group"">
        <label asp-for=""Price"" class=""control-label"">Цена</label>
        <input type=""number"" asp-for=""Price"" class=""form-control"" name=""Price""/>
    </div>
    <div class=""form-group"">
        <input type=""submit"" value=""Отправить"" class=""btn btn-default"" />
    </div>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
