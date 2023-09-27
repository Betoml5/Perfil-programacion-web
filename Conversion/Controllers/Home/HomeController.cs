using Conversion.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Conversion.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Convert(decimal mxn, decimal usd)
        {
            IndexViewModel vm = new IndexViewModel();    


            return View();
        }
    }
}
