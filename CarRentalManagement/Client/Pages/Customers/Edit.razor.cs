using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Edit
    {
        [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            customer = await _client.Get(Endpoints.CustomersEndpoint, id);
        }

        async Task EditCustomer()
        {
            await _client.Update(Endpoints.CustomersEndpoint,customer,id);
            _navManager.NavigateTo("/customers/");
        }
        
    }
}
