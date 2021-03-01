using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Carousel.Pages
{
    public partial class Index
    {
        // Image Slider
        List<ImageSliderVM> items = new List<ImageSliderVM>();

        protected override async Task OnInitializedAsync()
        {
            // fetch list data Images
            var res1 = await Http.GetFromJsonAsync<ImageSliderVM[]>("sample-data/carouselImg.json");
            items.AddRange(res1.ToList());

            //StateHasChanged();
        }
    }

    public class ImageSliderVM
    {
        public string Source { get; set; } = "";
        public string Alt { get; set; } = "";
        public string Caption { get; set; } = "";
        public string Header { get; set; } = "";
        public string AppName { get; set; } = "";
    }
}