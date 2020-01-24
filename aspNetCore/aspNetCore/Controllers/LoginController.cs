using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspNetCore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}