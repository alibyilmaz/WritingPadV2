#pragma checksum "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "833a0e70f7a7ea617d54d20e69bf184b980f0100"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notepad_Index), @"mvc.1.0.view", @"/Views/Notepad/Index.cshtml")]
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
#line 1 "D:\Github\WritingPadV2\WritingPadV2\Views\_ViewImports.cshtml"
using WritingPadV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\WritingPadV2\WritingPadV2\Views\_ViewImports.cshtml"
using WritingPadV2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833a0e70f7a7ea617d54d20e69bf184b980f0100", @"/Views/Notepad/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7513401afa45ab88bc0a233cb0a87c36b2178d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Notepad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotepadViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
  
    ViewData["Title"] = "Not Defteri";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Not Defteri</h1>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 120, "\"", 158, 1);
#nullable restore
#line 9 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
WriteAttributeValue("", 127, Url.Action("Insert","NotePad"), 127, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success""> Yeni Kayıt Oluştur</a>
<table class=""table table-bordered"">
    <tbody>
        <tr>
            <td>Başlık</td>
            <td>Açıklama</td>
            <td>Tarih</td>
            <td>Link</td>
            <td>Resim</td>
            <td>Düzenle</td>
            <td>Sil</td>
        </tr>
");
#nullable restore
#line 21 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
         foreach (var notePad in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
               Write(notePad.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
               Write(notePad.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
               Write(notePad.DueAt.Humanize());

#line default
#line hidden
#nullable disable
            WriteLiteral(" eklendi</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 734, "\"", 757, 1);
#nullable restore
#line 27 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
WriteAttributeValue("", 741, notePad.NoteUrl, 741, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
                                          Write(notePad.NoteUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "833a0e70f7a7ea617d54d20e69bf184b980f01006821", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 817, "~/Uploads/", 817, 10, true);
#nullable restore
#line 28 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
AddHtmlAttributeValue("", 827, notePad.FilePath, 827, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 923, "\"", 991, 1);
#nullable restore
#line 29 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
WriteAttributeValue("", 930, Url.Action("Update","NotePad",new {id = notePad.NotePadId }), 930, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\">Düzenle</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1124, 1);
#nullable restore
#line 30 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
WriteAttributeValue("", 1064, Url.Action("Delete","NotePad",new {id = notePad.NotePadId}), 1064, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "D:\Github\WritingPadV2\WritingPadV2\Views\Notepad\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotepadViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
