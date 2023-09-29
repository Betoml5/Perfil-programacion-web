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
                NombreMateria = "Programación web",
                Nombre = "Alberto Martinez",
                Periodo = "Agosto - Diciembtre 2023",
                Semestre = "Sexto",
            };



            return View(vm);
        }

        public IActionResult Perfil()
        {


            PerfilViewModel vm = new()
            {
                    Nombre = "Alberto",
                    Apellido = "Martinez",
                    NumeroControl = "221GC057",
                    Semestre = "Septimo",
                    Carrera = "Ing. Sistemas Computacionales",
                    Telefono = "861-126-2242"
            };
                
            return View(vm);
        }
        
    }
}
