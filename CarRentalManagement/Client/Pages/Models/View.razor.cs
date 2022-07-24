using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using CarRentalManagement.Client.Contracts;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class View 
    {
       [Inject] IHttpRepository<Model> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Model model = new Model();

        protected async override Task OnParametersSetAsync()
        {
            model = await _client.Get(Endpoints.ModelsEndpoint, id);
        }
       
    }
}
