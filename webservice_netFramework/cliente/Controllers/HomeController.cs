using System.Web.Mvc;

namespace cliente.Controllers
{
    using service;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ws = new service();
            var listaJogosModelView = new ListaJogosModelView();

            listaJogosModelView = ws.AcessaJogos();

            return View(listaJogosModelView);
        }

        public ActionResult ListaPedidos()
        {
            var ws = new service();
            var listaJogosModelView = new ListaJogosModelView();

            listaJogosModelView = ws.AcessaJogos();

            return View(listaJogosModelView);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}