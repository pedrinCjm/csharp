using Newtonsoft.Json;
using service.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Services;

namespace service
{
    /// <summary>
    /// Summary description for service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class service : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
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
