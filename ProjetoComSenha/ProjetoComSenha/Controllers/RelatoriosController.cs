using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjetoComSenha.Models;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ProjetoComSenha.Controllers
{
    public class RelatoriosController : Controller
    {

        public IActionResult ListaJogos()
        {
            var model = new List<JogoModelView>();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ProjetoComSenha.Common.Api + "Jogos");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    model = JsonConvert.DeserializeObject<List<JogoModelView>>(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View(model);
        }

        public IActionResult ListaJogosRelatorio()
        {
            var model = new List<JogoModelView>();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ProjetoComSenha.Common.Api + "Jogos");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    model = JsonConvert.DeserializeObject<List<JogoModelView>>(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            var demoViewLandscape = new ViewAsPdf(model)
            {
                FileName = "Home_" + DateTime.Now + ".pdf",
                CustomSwitches = $"--header-html \"{Url.Action("Header", "Relatorios", new { area = "" }, "https")}\" " +
                                 $"--footer-html \"{Url.Action("Footer", "Relatorios", new { area = "" }, "https")}\" " +
                                 $"--page-offset 0  --footer-font-size 8 --footer-center \"  Relatório: " + DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\" ",
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