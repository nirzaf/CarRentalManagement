using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using CarRentalManagement.Client.Contracts;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class View 
    {
       [Inject] IHttpRepository<Make> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Make make = new Make();

        protected async override Task OnParametersSetAsync()
        {
            make = await _client.Get(Endpoints.MakesEndpoint, id);
        }
      
    }
}
