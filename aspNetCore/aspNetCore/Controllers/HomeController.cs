using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspNetCore.Models;

namespace aspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Privacy(Usuario usuario)
        {
            //if (string.IsNullOrEmpty(usuario.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo nome é obrigatório!");
            //}

            //if (usuario.Senha != usuario.ConfirmacaoSenha)
            //{
            //    ModelState.AddModelError("", "As senhas não podem ser diferentes!");
            //}

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        public IActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
