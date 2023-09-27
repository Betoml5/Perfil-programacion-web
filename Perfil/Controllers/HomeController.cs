using Microsoft.AspNetCore.Mvc;
using Perfil.Models.ViewModels;

namespace Perfil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            IndexViewModel vm = new()
            {
                Id = 1,
                Name = "Alberto",
                LastName = "Martinez",
                ControlNumber = "221GC057",
                Phone = "8611262242",
                Career = "Ing. Sistemas Computacionales"
            };



            return View(vm);
        }
    }
}
