using System.ComponentModel.DataAnnotations;

namespace TurboAzTask.Models
{
    public class AddCarViewModel
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        public string Vendor { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
    }
}
