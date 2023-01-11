using FinalProject.Models;
using FinalProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            return View(vm);
        }
        
        [HttpPost]
        public IActionResult LaptopByBrandOrdering(LaptopByBrandOrderingViewModel vm)
        {

            return View(vm);
        }
    }
}
