using FinalProject.Models;
using FinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace FinalProject.Controllers
{
    public class BrandController : Controller
    {
        Database Database = Database.GetInstance();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LaptopByBrandOrdering()
        {
            LaptopByBrandOrderingViewModel vm = new LaptopByBrandOrderingViewModel();
            vm.Brands = Database.Brands;
            return View(vm);
        }

        [HttpPost]
        public IActionResult LaptopByBrandOrdering(LaptopByBrandOrderingViewModel vm)
        {
            vm.Brands = Database.Brands;
            List<Laptop> result = new List<Laptop>();
            result = Database.Laptops.Where(x => x.Brand.Id == vm.BrandChoice).ToList();
            /*
             *             
            "Order By Price Ascending",
            "Order By Price Descending",
            "Order By Year Ascending",
            "Order By Year Descending"
             */
            if (vm.OrderChoice == "Order By Price Ascending")
            {
                result = result.OrderBy(x => x.Price).ToList();
            }
            else if (vm.OrderChoice == "Order By Price Descending")
            {
                result = result.OrderByDescending(x => x.Price).ToList();
            }
            else if (vm.OrderChoice == "Order By Year Ascending")
            {
                result = result.OrderBy(x => x.Year).ToList();
            }
            else if (vm.OrderChoice == "Order By Year Descending")
            {
                result = result.OrderByDescending(x => x.Year).ToList();
            }
            else
            {
                result = result;
            }
            vm.ResultLaptops = result;
            return View(vm);
        }
        public IActionResult LaptopByFilter()
        {
            LaptopByFilterViewModel vm = new LaptopByFilterViewModel();
            vm.Brands = Database.Brands;
            return View(vm);
        }

        [HttpPost]
        public IActionResult LaptopByFilter(LaptopByFilterViewModel vm)
        {
            vm.Brands = Database.Brands;
            List<Laptop> result = Database.Laptops.Where(x => x.Brand.Id == vm.BrandChoice).ToList();

            bool IsMinBudgetEnteredNull = vm.MinBudget == 0;
            bool IsMaxBudgetEnteredNull = vm.MaxBudget == 0;
            bool IsMinYearEnteredNull = vm.MinYear == 0;
            bool IsMaxYearEnteredNull = vm.MaxYear == 0;

            if (!IsMinBudgetEnteredNull || !IsMaxBudgetEnteredNull || !IsMinYearEnteredNull || !IsMaxYearEnteredNull || vm.BrandChoice != 0)
            {
                vm.Display = true;
            }
            else
            {
                vm.Display = false;
            }

            if (!IsMinBudgetEnteredNull)
            {
                result = result.Where(x => x.Price >= vm.MinBudget).ToList();
            }
            if (!IsMaxBudgetEnteredNull)
            {
                result = result.Where(x => x.Price <= vm.MaxBudget).ToList();
            }
            if (!IsMinYearEnteredNull)
            {
                result = result.Where(x => x.Year >= vm.MinYear).ToList();
            }
            if (!IsMaxYearEnteredNull)
            {
                result = result.Where(x => x.Year <= vm.MaxYear).ToList();
            }
            vm.ResultLaptops = result;
            return View(vm);
        }
        public IActionResult LaptopsByBrand()
        {
            IEnumerable<IGrouping<Brand, Laptop>> result = Database.Laptops.GroupBy(x => x.Brand, x => x);
            return View(result);
        }

    }
}
