using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using CarRentalManagement.Client.Contracts;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class View 
    {
       [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            customer = await _client.Get(Endpoints.CustomersEndpoint, id);
        }
        
    }
}
