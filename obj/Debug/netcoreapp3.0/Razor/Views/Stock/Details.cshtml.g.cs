#pragma checksum "/Users/saajanpaudel/VS_Projects/SuperMarket/SuperMarket/Views/Stock/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfc1f6a3adbb58486ba1cdbb164053d8a236eabe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stock_Details), @"mvc.1.0.view", @"/Views/Stock/Details.cshtml")]
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
#line 1 "/Users/saajanpaudel/VS_Projects/SuperMarket/SuperMarket/Views/_ViewImports.cshtml"
using SuperMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/saajanpaudel/VS_Projects/SuperMarket/SuperMarket/Views/_ViewImports.cshtml"
using SuperMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc1f6a3adbb58486ba1cdbb164053d8a236eabe", @"/Views/Stock/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa7be06d7a591ead91bbd6a5f9e215d8514106c", @"/Views/_ViewImports.cshtml")]
    public class Views_Stock_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SuperMarket.Models.stockModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\nCost price: <b>");
#nullable restore
#line 3 "/Users/saajanpaudel/VS_Projects/SuperMarket/SuperMarket/Views/Stock/Details.cshtml"
          Write(Model.cost_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <br />\nAddress: <b>");
#nullable restore
#line 4 "/Users/saajanpaudel/VS_Projects/SuperMarket/SuperMarket/Views/Stock/Details.cshtml"
       Write(Model.marked_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SuperMarket.Models.stockModel> Html { get; private set; }
    }
}
#pragma warning restore 1591