// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Carousel.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Carousel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using Carousel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\YudaSoft\Youtube\BlazorTutorial\BlazorTutorial\Carousel\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
