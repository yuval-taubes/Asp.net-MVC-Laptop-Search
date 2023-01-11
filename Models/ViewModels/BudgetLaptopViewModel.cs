namespace FinalProject.Models.ViewModels
{
    public class BudgetLaptopViewModel
    {
        public List<Laptop> Result { get; set; } = new();

        public int Budget { get; set; }

        public bool Display { get; set; } = false;

    }
}
