#pragma checksum "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88981e507db34ca849d88fd0a517501c7fc4b392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Details), @"mvc.1.0.view", @"/Views/Service/Details.cshtml")]
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
#line 1 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88981e507db34ca849d88fd0a517501c7fc4b392", @"/Views/Service/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Helperland.Models.UserAddress>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <label class=\"row address\">\r\n        <span class=\"col-lg-1\">\r\n            <input type=\"radio\" name=\"Address_radio\" checked");
            BeginWriteAttribute("value", " value=\"", 241, "\"", 264, 1);
#nullable restore
#line 11 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
WriteAttributeValue("", 249, item.AddressId, 249, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        </span>\r\n        <span class=\"col-lg-11\">\r\n            <span class=\"row\"> <b>Address</b>: ");
#nullable restore
#line 15 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
                                          Write(item.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
                                                             Write(item.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
                                                                                Write(item.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"row\"> <b>Phone number</b>:");
#nullable restore
#line 16 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
                                              Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </span>\r\n    </label>\r\n");
#nullable restore
#line 19 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Service\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""address"">

</div>



<button type=""button"" id=""addAdd"" class=""add-Add-btn mt-3"" onclick=""displayAddForm()"">+ Add New Address</button>




<hr>
<button type=""submit"" formmethod=""post"" class=""check-zip-btn "" name=""action"" value=""addSerAdd"" style=""float: right;"" onclick=""alert('Your details Submitted Successfully Please move to Make Payment tab to further booking')"">Continue</button>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Helperland.Models.UserAddress>> Html { get; private set; }
    }
}
#pragma warning restore 1591
