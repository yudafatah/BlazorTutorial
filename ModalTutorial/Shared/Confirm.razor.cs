using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ModalTutorial.Shared
{
    public partial class Confirm
    {
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        async Task Close() => await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        async Task Cancel() => await BlazoredModal.CancelAsync();
    }
}
