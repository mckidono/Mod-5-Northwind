#pragma checksum "C:\Users\mats9\mckidono\Downloads\DotNetMod5-main\DotNetMod5-main\Mod 5 Northwind\Mod 5 Northwind\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f38c8f339172c4a9e06bf743003d7114f2ebd1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mod_5_Northwind.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace Mod_5_Northwind.Views.Home
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
#line 1 "C:\Users\mats9\mckidono\Downloads\DotNetMod5-main\DotNetMod5-main\Mod 5 Northwind\Mod 5 Northwind\Views\Home\Index.cshtml"
using Mod_5_Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f38c8f339172c4a9e06bf743003d7114f2ebd1d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfed2576e512ecbe5f689a901af965db50678b2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blogs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h4>Blog Listing</h4></div>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\mats9\mckidono\Downloads\DotNetMod5-main\DotNetMod5-main\Mod 5 Northwind\Mod 5 Northwind\Views\Home\Index.cshtml"
     foreach (Blog blog in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 8 "C:\Users\mats9\mckidono\Downloads\DotNetMod5-main\DotNetMod5-main\Mod 5 Northwind\Mod 5 Northwind\Views\Home\Index.cshtml"
       Write(blog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 9 "C:\Users\mats9\mckidono\Downloads\DotNetMod5-main\DotNetMod5-main\Mod 5 Northwind\Mod 5 Northwind\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blogs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
