using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
