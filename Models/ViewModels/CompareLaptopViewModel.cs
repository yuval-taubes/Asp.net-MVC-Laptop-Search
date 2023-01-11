namespace FinalProject.Models.ViewModels
{
    public class CompareLaptopViewModel
    {
        public int Laptop1Id { get; set; }
        public int Laptop2Id { get; set; }

        public Laptop Laptop1 { get; set; }

        public Laptop Laptop2 { get; set; }


        public List<Laptop> Laptops { get; set; } = new();

        public bool Display { get; set; } = false;
    }
}
