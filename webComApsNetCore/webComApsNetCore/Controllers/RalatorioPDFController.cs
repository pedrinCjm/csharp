using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rotativa;
using System;
using webComApsNetCore.Models;

namespace webComApsNetCore.Controllers
{
    public class RalatorioPDFController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ViewAsPdf RelatorioPacientes()
        {
            Carro carro = new Carro();

            carro.placa = 123;
            carro.cor = "Azul";
            carro.id = 10;

            //string header = Microsoft.AspNetCore.Server.MapPath("~/Static/NewFolder/PrintHeader.html");
            //string footer = Server.MapPath("~/Static/NewFolder/PrintFooter.html");

            string customSwitches = string.Format("--header-html  \"{0}\" " +
                                   "--header-spacing \"0\" " +
                                   "--footer-html \"{1}\" " +
                                   "--footer-spacing \"10\" " +
                                   "--footer-font-size \"10\" " +
                                   "--header-font-size \"10\" " +
                                   "--footer-right \"Pag: [page] de [toPage]\" " );

            var demoViewLandscape = new ViewAsPdf(carro)
            {
                FileName = "Arquivo_" + DateTime.Now + ".pdf",
                //PageMargins = { Left = 10, Bottom = 0, Right = 10, Top = 5 },
                //PageSize = Rotativa.AspNetCore.Options.Size.A4,
                //PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                //PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,
                //CustomSwitches = $"--footer-html \"{Url.Action("Footer", "RelatorioPDF", new { area = "" }, "http")}\" --header-html \"{Url.Action("Footer", "RelatorioPDF", new { area = "" }, "http")}\"",
                CustomSwitches = customSwitches,
            };

            return demoViewLandscape;
        }

        public ActionResult Footer()
        {
            return View();
        }

    }
}