using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
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
        public IActionResult Contato()
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
        public IActionResult ContatoII()
        {
            return View();
        }
        public IActionResult Viagensprogramadas()
        {
            return View();
        }
    }
}
