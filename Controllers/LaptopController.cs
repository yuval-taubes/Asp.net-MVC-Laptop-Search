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
            List<Laptop> sortedByPrice = Database.Laptops.OrderByDescending(x => x.Price).Take(2).ToList();
            return View(sortedByPrice);
        }
        public IActionResult CheapestLaptop()
        {
            List<Laptop> sortedByPrice = Database.Laptops.OrderBy(x => x.Price).Take(3).ToList();
            return View(sortedByPrice);
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
            //it says it might be null, but it wont be as its a dropdown list, meaning only allowed values will be selected
            vm.Laptop1 = Database.Laptops.FirstOrDefault(x => x.Id == vm.Laptop1Id);
            vm.Laptop2 = Database.Laptops.FirstOrDefault(x => x.Id == vm.Laptop2Id);

            return View(vm);
        }

        public IActionResult CreateLaptop()
        {
            CreateLaptopViewModel vm = new CreateLaptopViewModel();
            vm.Brands = Database.Brands;
            return View(vm);
        }
        [HttpPost]
        public IActionResult CreateLaptop(CreateLaptopViewModel vm)
        {
            vm.Brands = Database.Brands;
            Database.CreateLaptop(vm.Model, vm.BrandChoice, vm.Price, vm.Year);
            vm.DisplaySuccess = true;
            return View(vm);
        }
    }
}
