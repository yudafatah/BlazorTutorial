using Blazored.Modal;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ModalTutorial.Shared
{
    public partial class YesNoPrompt
    {
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        async Task Yes()
        {
            var confirmationModal = ModalService.Show<Confirm>("Second Modal");
            var result = await confirmationModal.Result;

            if (result.Cancelled)
                return;

            await BlazoredModal.CloseAsync();
        }

        async Task No() => await BlazoredModal.CancelAsync();
    }
}
