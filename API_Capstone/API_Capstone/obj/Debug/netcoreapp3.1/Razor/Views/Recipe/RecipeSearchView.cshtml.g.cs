#pragma checksum "C:\Users\dylan\OneDrive\Documents\GrandCircus\API Capstone\API_Capstone\API_Capstone\Views\Recipe\RecipeSearchView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df919f9dbc13a84289cee6168cfc820132d5f207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_RecipeSearchView), @"mvc.1.0.view", @"/Views/Recipe/RecipeSearchView.cshtml")]
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
#line 1 "C:\Users\dylan\OneDrive\Documents\GrandCircus\API Capstone\API_Capstone\API_Capstone\Views\_ViewImports.cshtml"
using API_Capstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dylan\OneDrive\Documents\GrandCircus\API Capstone\API_Capstone\API_Capstone\Views\_ViewImports.cshtml"
using API_Capstone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df919f9dbc13a84289cee6168cfc820132d5f207", @"/Views/Recipe/RecipeSearchView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e07b9f7c8764a6d58e94f1a3aa0911346cb13f", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_RecipeSearchView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API_Capstone.Models.ViewModels.RecipeSearchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dylan\OneDrive\Documents\GrandCircus\API Capstone\API_Capstone\API_Capstone\Views\Recipe\RecipeSearchView.cshtml"
  
    ViewData["Title"] = "RecipeSearchView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <ul>\r\n");
#nullable restore
#line 9 "C:\Users\dylan\OneDrive\Documents\GrandCircus\API Capstone\API_Capstone\API_Capstone\Views\Recipe\RecipeSearchView.cshtml"
         foreach (var recipe in Model.Recipes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 11 "C:\Users\dylan\OneDrive\Documents\GrandCircus\API Capstone\API_Capstone\API_Capstone\Views\Recipe\RecipeSearchView.cshtml"
           Write(recipe.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>                \r\n");
#nullable restore
#line 12 "C:\Users\dylan\OneDrive\Documents\GrandCircus\API Capstone\API_Capstone\API_Capstone\Views\Recipe\RecipeSearchView.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API_Capstone.Models.ViewModels.RecipeSearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591