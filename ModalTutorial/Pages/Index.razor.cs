using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModalTutorial.Pages
{
    public partial class Index
    {
        [CascadingParameter] public IModalService Modal { get; set; }

        void ShowEditMovie(string title, string filter)
        {
            // passing parameter
            var parameters = new ModalParameters();
            parameters.Add(nameof(FetchData.Filter), filter);

            // customize modal
            var opt = new ModalOptions()
            {
                Animation = ModalAnimation.FadeInOut(1),
                ContentScrollable = true,
                FocusFirstElement = true
            };

            Modal.Show<FetchData>(title, parameters, opt);
        }
    }
}
