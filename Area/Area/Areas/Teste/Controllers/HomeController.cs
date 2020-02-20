using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.Teste.Controllers
{
    public class HomeController : Controller
    {
        // GET: Teste/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}