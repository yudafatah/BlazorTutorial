#pragma checksum "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\Shared\Confirm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7502b1688c0b88846962515fdc060785d16e0a"
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
    public partial class Confirm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<p>Please click one of the buttons below to close or cancel the modal.</p>\r\n\r\n    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\Shared\Confirm.razor"
                      Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddContent(5, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\ModalTutorial\Shared\Confirm.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "btn btn-secondary");
            __builder.AddContent(10, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
