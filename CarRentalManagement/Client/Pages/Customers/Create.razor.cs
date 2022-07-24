using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Contracts;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create
    {
        [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }
        Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            await _client.Create(Endpoints.CustomersEndpoint, customer);
            _navManager.NavigateTo("/customers/");
        }
       
    }
}
