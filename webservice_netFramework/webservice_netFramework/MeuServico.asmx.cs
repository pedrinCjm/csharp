﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using webservice_netFramework.Controllers;
using webservice_netFramework.Models;

namespace webservice_netFramework
{
    /// <summary>
    /// Summary description for MeuServico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MeuServico : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<string> AcessaHome()
        {
            return new Montadora().getAll();
        }

        [WebMethod]
        public ListaJogosModelView AcessaJogos()
        {
            var model = new ListaJogosModelView();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44307/api/" + "Jogos/consultaQuery");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    model.JogoModelView = JsonConvert.DeserializeObject<List<JogoModelView>>(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return model;
        }
    }
}
