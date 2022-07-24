using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Model : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
