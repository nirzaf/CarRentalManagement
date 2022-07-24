using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Create 
    {
        [Inject] IHttpRepository<Make> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Make make = new Make();

        private async Task CreateMake()
        {
            await _client.Create(Endpoints.MakesEndpoint, make);
            _navManager.NavigateTo("/makes/");
        }
        
    }
}
