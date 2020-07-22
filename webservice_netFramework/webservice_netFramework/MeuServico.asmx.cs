using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using webservice_netFramework.Controllers;

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
    }
}
