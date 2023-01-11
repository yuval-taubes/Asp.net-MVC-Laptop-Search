namespace FinalProject.Models.ViewModels
{
    public class LaptopByFilterViewModel
    {
        public int BrandChoice { get; set; }

        public List<Brand> Brands { get; set; } = new();

        public int MinBudget { get; set; }

        public int MaxBudget { get; set; }

        public int MaxYear { get; set; }

        public int MinYear {get; set;}

        public bool Display { get; set; } = false;

        public List<Laptop> ResultLaptops { get; set; } = new();

    }
}
