using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using webComApsNetCore.Data;
using webComApsNetCore.Models;

namespace webComApsNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly webComApsNetCoreContext _context;

        public HomeController(webComApsNetCoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Carros(DateTime? minDate, DateTime? maxDate, string nome)
        {
            //List<CarroGenerico> listaGenerica = new List<CarroGenerico>();

            //HttpClient client = new HttpClient();

            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = await client.GetAsync("http://localhost:44381/api/Carros/lista/a");

            //if (response.IsSuccessStatusCode)
            //{
            //    listaGenerica = await response.Content.ReadAsAsync<List<CarroGenerico>>();
            //}

            ////var listaGenerica = await _context.Carro.ToListAsync();

            //ViewBag.MyList = listaGenerica;

            string ApiBaseUrl = "http://localhost:44381/"; // endereço da sua api
            string MetodoPath = "api/Carros/lista"; //caminho do método a ser chamado

            var model = new CarroGenerico();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + MetodoPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var retorno = JsonConvert.DeserializeObject<List<string>>(streamReader.ReadToEnd());

                    //if (retorno != null)
                    //    model.ListaProdutos = retorno;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View();
        }

        public struct CarroGenerico
        {
            public string Cor;
            public string Placa;
            public string Proprietario;
            public List<string> exProprietarios;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult RelatorioPacientes()
        {
            HttpClient Http = new HttpClient();

            string url = "https://localhost:44381/" + $"Carros/ListaCarros";

            var response = Http.GetStringAsync(url).Result.ToString();

            var relatorio = JsonConvert.DeserializeObject<List<Carro>>(response);

            //string customSwitches = string.Format("--footer-right \"Pag: [page] de [toPage]\" ");

            var demoViewLandscape = new ViewAsPdf(relatorio)
            {
                FileName = "Home_" + DateTime.Now + ".pdf",
                //PageMargins = { Left = 10, Bottom = 0, Right = 10, Top = 5 },
                //PageSize = Rotativa.AspNetCore.Options.Size.A4,
                //PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                //PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,
                //PageSize = Rotativa.AspNetCore.Options.Size.A6,
                CustomSwitches = $"--header-html \"{Url.Action("Header", "Home", new { area = "" }, "https")}\" " +
                                 $"--footer-html \"{Url.Action("Footer", "Home", new { area = "" }, "https")}\" " +
                                 $"--page-offset 0  --footer-font-size 8 --footer-center \"  Relatório: " + DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\" ",
                //CustomSwitches = $"--footer-html \"{Url.Action("Footer", "Home", new { area = "" }, "https")}\" --header-html \"{Url.Action("Footer", "Home", new { area = "" }, "https")}\"",
                //CustomSwitches = string.Format("--footer-html {0} --header-html {1}", 
                //                                Url.Action("Footer", "Home", new { area = "" }, "https"),
                //                                Url.Action("Header", "Home", new { area = "" }, "https")),
                //CustomSwitches = string.Format("--print-media-type --allow {0} --footer-html {0} --header-html {1}",
                //                                Url.Action("Footer", "Home", new { area = "" }, "https"),
                //                                Url.Action("Header", "Home", new { area = "" }, "https")),
                //CustomSwitches = customSwitches,
                //CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 12"
                //CustomSwitches = "--footer-center \"  Created Date: " + DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\"" +
                //                " --footer-line --footer-font-size \"12\" --footer-spacing 1 --footer-font-name \"Segoe UI\"",
            };

            return demoViewLandscape;
        }

        [AllowAnonymous]
        public ActionResult Footer()
        {
            return View();
        } 
        
        [AllowAnonymous]
        public ActionResult Header()
        {
            return View();
        }
    }
}