using Conversion.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Conversion.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index(IndexViewModel vm)
        {
    
           if (vm == null)
                return NotFound();
           if (vm.Moneda == "USD")
            {
                vm.Resultado = vm.Valor / 18m;
            }

            if (vm.Moneda == "MXN")
            {
                vm.Resultado = vm.Valor * 18m;
            }

            return View(vm);
        }

     
    }
}
