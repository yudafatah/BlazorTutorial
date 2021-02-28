using Blazored.Modal;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Linq;
using Blazored.Modal.Services;
using ModalTutorial.Shared;

namespace ModalTutorial.Pages
{
    public partial class FetchData
    {
        [Parameter] public string Filter { get; set; }

        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            forecasts = forecasts.Where(x => x.Summary.Equals(Filter)).ToArray();
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }

        // Modal
        [CascadingParameter] public IModalService Modal { get; set; }

        void ShowModal() => Modal.Show<YesNoPrompt>("First Modal");
    }
}
