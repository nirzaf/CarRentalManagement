using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Edit
    {
        [Inject] IHttpRepository<Colour> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Colour colour = new Colour();

        protected async override Task OnParametersSetAsync()
        {
            colour = await _client.Get(Endpoints.ColoursEndpoint, id);
        }

        async Task EditColour()
        {
            await _client.Update(Endpoints.ColoursEndpoint, colour, id);
            _navManager.NavigateTo("/colours/");
        }

    }
}
