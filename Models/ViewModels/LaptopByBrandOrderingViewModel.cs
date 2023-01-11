namespace FinalProject.Models.ViewModels
{
    public class LaptopByBrandOrderingViewModel
    {
        public int BrandChoice { get; set; } = new();

        public List<Brand> Brands { get; set; }

        //public static List<string> OrderingChoices() { "Order by Year Ascending", "Order by Year Desending"};

        public string OrderChoice { get; set; }
    }
}
