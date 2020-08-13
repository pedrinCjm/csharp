using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nancy.Json;
using Newtonsoft.Json;
using ProjetoComSenha.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;

namespace ProjetoComSenha.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            enviarEmail();

            return View();
        }
        public IActionResult Carregamento()
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

        public IActionResult Partidas()
        {
            var model = new List<Partida>();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ProjetoComSenha.Common.Api + "Partidas");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    model = JsonConvert.DeserializeObject<List<Partida>>(streamReader.ReadToEnd());

                    //if (retorno != null)
                    //    model.ListaProdutos = retorno;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View(model);
        }

        //public IActionResult CreatePartida()
        //{
        //    string ApiBaseUrl = "https://localhost:44307/"; // endereço da sua api
        //    string MetodoPath = "api/Regioes"; //caminho do método a ser chamado

        //    //Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

        //    try
        //    {
        //        var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + MetodoPath); // + System.Convert.ToInt64(CoSeqUsuario).ToString();
        //        httpWebRequest.ContentType = "application/json";
        //        httpWebRequest.Method = "GET";

        //        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //        {
        //            var model = JsonConvert.DeserializeObject<List<Regiao>>(streamReader.ReadToEnd());

        //            ViewBag.Regiao = new SelectList(model, dataValueField:"RegiaoId", dataTextField:"Descricao");
        //            //if (retorno != null)
        //            //    model.ListaProdutos = retorno;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //    return View();
        //}

        public IActionResult CreatePartida()
        {
            HttpClient Http = new HttpClient();
            //Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

            try
            {
                string url = ProjetoComSenha.Common.Api + "Regioes";

                var response = Http.GetStringAsync(url).Result.ToString();

                var model = JsonConvert.DeserializeObject<List<Regiao>>(response);

                ViewBag.Regiao = new SelectList(model, dataValueField: "RegiaoId", dataTextField: "Descricao");
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString().Trim() == "-2146233088")
                {
                    return null;
                }
                else
                {
                    throw ex;
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult CreatePartida([Bind("Nome,CoJog1,CoJog2,CoTpJogo")] Partida partida)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // prepara os dados para envio
                    var serializer = new JavaScriptSerializer();
                    var json = serializer.Serialize(partida);
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                    //HTTP POST
                    var postTask = client.PostAsync(ProjetoComSenha.Common.Api + "Partidas", stringContent);
                    postTask.Wait();

                    // pega o resultado
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Partidas");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            }
            catch (Exception e)
            {
                throw e;
            }

            return View();
        }

        public IActionResult CreateRegiao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRegiao(Regiao regiao)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // prepara os dados para envio
                    var serializer = new JavaScriptSerializer();
                    var json = serializer.Serialize(regiao);
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                    //HTTP POST
                    var postTask = client.PostAsync(ProjetoComSenha.Common.Api + "Regioes", stringContent);
                    postTask.Wait();

                    // pega o resultado
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            }
            catch (Exception e)
            {
                throw e;
            }

            return View();
        }

        public IActionResult Notificacoes()
        {
            return View();
        }

        public IActionResult Acoes()
        {
            TableFromPdf tableFromPdf = new TableFromPdf();

            var resultado = tableFromPdf.Read();

            return View(resultado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void enviarEmail()
        {
            var fromAddress = new MailAddress("minasmotospecanha@gmail.com", "Minas Motos");
            var toAddress = new MailAddress("pedrincjm@gmail.com", "Pedro Medeiros");
            string fromPassword = "2020minasmotos";
            const string subject = "Assunto do email";
            const string body = "Corpo do email";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
            {
                try
                {
                    smtp.Send(message);
                }
                catch (Exception e)
                {
                    var mensagem = e.Message.ToString();
                }
            }
        }
    }
}
