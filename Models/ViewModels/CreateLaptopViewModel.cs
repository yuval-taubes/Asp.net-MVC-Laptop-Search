using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.ViewModels
{
    public class CreateLaptopViewModel
    {
        [Required]
        public string Model { get; set; }

        public List<Brand> Brands { get; set; } = new();

        [Required]
        public int BrandChoice { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Year { get; set; }

        public bool DisplaySuccess { get; set; } = false;
    }
}
