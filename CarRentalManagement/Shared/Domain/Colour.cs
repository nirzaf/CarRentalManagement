using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Colour : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
