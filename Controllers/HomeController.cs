using AgenciaExplorer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgenciaExplorer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrocliente()
        {
            return View();
        }

        public IActionResult Cadastrodestino()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult Contatolista()
        {
            return View();
        }
        public IActionResult Destinos()
        {
            return View();
        }
        public IActionResult Promocao()
        {
            return View();
        }
        public IActionResult Programadas()
        {
            return View();
        }


    }
}