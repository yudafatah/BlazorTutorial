#pragma checksum "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf971bfcfbebc740fee1e7196aea5bb30fb32b56"
// <auto-generated/>
#pragma warning disable 1591
namespace ModalTutorial.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using ModalTutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using ModalTutorial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-reraygplrb");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-reraygplrb");
            __builder.OpenComponent<ModalTutorial.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-reraygplrb");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-reraygplrb><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-reraygplrb>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-reraygplrb");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591