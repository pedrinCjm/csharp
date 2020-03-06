using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webComApsNetCore.Models;

namespace webComApsNetCore.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departaments> departaments = new List<Departaments>();

            departaments.Add(new Departaments { pubint_id = 20, pubint_nomeDepartament = "Informática" });
            departaments.Add(new Departaments { pubint_id = 21, pubint_nomeDepartament = "Administração" });
            departaments.Add(new Departaments { pubint_id = 22, pubint_nomeDepartament = "Recursos humanos" });

            return View(departaments);
        }
    }
}