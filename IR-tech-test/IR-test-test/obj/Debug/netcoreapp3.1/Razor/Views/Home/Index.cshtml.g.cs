#pragma checksum "C:\Users\JAckoff\Documents\IR-tech-test\IR-tech-test\IR-test-test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1999aac5fa787384d5b99a5259288f1d4628587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\JAckoff\Documents\IR-tech-test\IR-tech-test\IR-test-test\Views\_ViewImports.cshtml"
using IR_tech_test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JAckoff\Documents\IR-tech-test\IR-tech-test\IR-test-test\Views\_ViewImports.cshtml"
using IR_tech_test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1999aac5fa787384d5b99a5259288f1d4628587", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a25718352ac4bc771805ff8ad5b4aa957fde3e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JAckoff\Documents\IR-tech-test\IR-tech-test\IR-test-test\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JAckoff\Documents\IR-tech-test\IR-tech-test\IR-test-test\Views\Home\Index.cshtml"
Write(Html.TextBoxFor(x => x.Depth));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" />\r\n");
#nullable restore
#line 7 "C:\Users\JAckoff\Documents\IR-tech-test\IR-tech-test\IR-test-test\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexView> Html { get; private set; }
    }
}
#pragma warning restore 1591
