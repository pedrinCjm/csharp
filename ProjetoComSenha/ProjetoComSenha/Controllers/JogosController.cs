﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nancy.Json;
using Newtonsoft.Json;
using ProjetoComSenha.Models;

namespace ProjetoComSenha.Controllers
{
    public class JogosController : Controller
    {
        public IActionResult OnGetPartial() => new PartialViewResult
        {
            ViewName = "_ListaJogos",
            ViewData = ViewData,
        };

        public void CarregaModal()
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
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Teste(JogoModelView jogoModelView)
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

            var serializer = JsonConvert.SerializeObject(model);
            TempData["ModelTemporario"] = serializer;

            return RedirectToAction("ListaJogos");
        }

        public IActionResult ListaJogos()
        {
            var model = new List<JogoModelView>();

            if (TempData["ModelTemporario"] != null)
            {
                model = JsonConvert.DeserializeObject<List<JogoModelView>>(TempData["ModelTemporario"].ToString());
            }

            TempData["ModelTemporario"] = null;

            return View(model);
        }

        public IActionResult ListaTiposJogos()
        {
            HttpClient Http = new HttpClient();
            //Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

            try
            {
                string url = ProjetoComSenha.Common.Api + "TipoJogos";

                var response = Http.GetStringAsync(url).Result.ToString();

                var model = JsonConvert.DeserializeObject<List<TipoJogo>>(response);

                return View(model);
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
        }

        public IActionResult ListaJogadores()
        {
            var model = new List<Jogador>();
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ProjetoComSenha.Common.Api + "Jogadores");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    model = JsonConvert.DeserializeObject<List<Jogador>>(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return View(model);
        }

        public IActionResult CreateJogo()
        {
            HttpClient Http = new HttpClient();
            //Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);

            var modelView = new JogoViewModel();
            try
            {
                string url = ProjetoComSenha.Common.Api + "TipoJogos";

                var response = Http.GetStringAsync(url).Result.ToString();

                var model = JsonConvert.DeserializeObject<List<TipoJogo>>(response);

                modelView.TipoJogo = model;
                //ViewBag.TiposJogos = new SelectList(model, dataValueField: "TipoJogoId", dataTextField: "NoTipoJogo");
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

            return View(modelView);
        }

        [HttpPost]
        public IActionResult CreateJogo(Jogo jogo)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // prepara os dados para envio
                    var serializer = JsonConvert.SerializeObject(jogo);
                    var stringContent = new StringContent(serializer, Encoding.UTF8, "application/json");

                    //HTTP POST
                    var postTask = client.PostAsync(ProjetoComSenha.Common.Api + "Jogos", stringContent);
                    postTask.Wait();

                    // pega o resultado
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("ListaJogos");
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

        public IActionResult CreateTipoJogo()
        {
            return View();
        }

        public IActionResult CreateJogador()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTipoJogo(TipoJogo tipoJogo)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoJogo);
            }

            try
            {
                using (var client = new HttpClient())
                {
                    // prepara os dados para envio
                    var serializer = new JavaScriptSerializer();
                    var json = serializer.Serialize(tipoJogo);
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                    //HTTP POST
                    var postTask = client.PostAsync(ProjetoComSenha.Common.Api + "TipoJogos", stringContent);
                    postTask.Wait();

                    // pega o resultado
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("ListaTiposJogos");
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

        [HttpPost]
        public IActionResult CreateJogador(Jogador jogador)
        {
            if (!ModelState.IsValid)
            {
                return View(jogador);
            }

            try
            {
                using (var client = new HttpClient())
                {
                    // prepara os dados para envio
                    var serializer = new JavaScriptSerializer();
                    var json = serializer.Serialize(jogador);
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                    //HTTP POST
                    var postTask = client.PostAsync(ProjetoComSenha.Common.Api + "Jogadores", stringContent);
                    postTask.Wait();

                    // pega o resultado
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("ListaJogadores");
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
    }
}