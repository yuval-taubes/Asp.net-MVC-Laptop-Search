using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models.ViewModels;
namespace FinalProject.Controllers
{
    public class LaptopController : Controller
    {
        Database Database = Database.GetInstance();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExpensiveLaptop()
        {
            List<Laptop> sortedByPrice = Database.Laptops.OrderByDescending(x => x.Price).ToList();
            List<Laptop> result = new List<Laptop>()
            {
                sortedByPrice[0],
                sortedByPrice[1]
            };
            return View(result);
        }
        public IActionResult CheapestLaptop()
        {
            List<Laptop> sortedByPrice = Database.Laptops.OrderByDescending(x => x.Price).ToList();
            List<Laptop> result = new List<Laptop>()
            {
                sortedByPrice[0],
                sortedByPrice[1],
                sortedByPrice[2]
            };
            return View(result);
        }
        public IActionResult LaptopInBudget()
        {
            BudgetLaptopViewModel vm = new BudgetLaptopViewModel();
            return View(vm);
        }
        [HttpPost]
        public IActionResult LaptopInBudget(BudgetLaptopViewModel vm)
        {
            vm.Display = true;
            List<Laptop> result = Database.Laptops.Where(x => x.Price <= vm.Budget).ToList();
            vm.Result = result;
            return View(vm);
        }


        public IActionResult CompareLaptops()
        {   
            CompareLaptopViewModel vm = new CompareLaptopViewModel();
            vm.Laptops = Database.Laptops;
            return View(vm);
        }

        [HttpPost]
        public IActionResult CompareLaptops(CompareLaptopViewModel vm)
        {
            vm.Laptops = Database.Laptops;
            vm.Laptop1 = Database.Laptops.FirstOrDefault(x => x.Id == vm.Laptop1Id);
            vm.Laptop2 = Database.Laptops.FirstOrDefault(x => x.Id == vm.Laptop2Id);

            return View(vm);
        }
    }
}
