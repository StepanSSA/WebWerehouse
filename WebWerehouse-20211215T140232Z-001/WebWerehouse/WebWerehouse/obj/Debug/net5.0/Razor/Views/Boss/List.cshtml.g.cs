#pragma checksum "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354140bef4183df929fac77907be41d4ffa8718e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boss_List), @"mvc.1.0.view", @"/Views/Boss/List.cshtml")]
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
#line 1 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\_ViewImports.cshtml"
using WebWerehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\_ViewImports.cshtml"
using WebWerehouse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354140bef4183df929fac77907be41d4ffa8718e", @"/Views/Boss/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03e65375c61e79caaf747022ddc90a41f04860b", @"/Views/_ViewImports.cshtml")]
    public class Views_Boss_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebWerehouse.Models.UsersViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Список сотрудников</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "354140bef4183df929fac77907be41d4ffa8718e4012", async() => {
                WriteLiteral("Добавить сотрудника");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Степан\Desktop\Учёба\Программирование\3Курс\C# projects\WebWerehouse\WebWerehouse-20211215T140232Z-001\WebWerehouse\WebWerehouse\Views\Boss\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebWerehouse.Models.UsersViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
