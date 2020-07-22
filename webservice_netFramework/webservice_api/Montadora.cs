using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webservice_api
{
    public class Montadora
    {
        private List<string> ListaStrings;

        public Montadora()
        {
            ListaStrings = new List<string>();
            ListaStrings.Add("João");
            ListaStrings.Add("Maria");
            ListaStrings.Add("Lucas");
            ListaStrings.Add("Carlos");
            ListaStrings.Add("Rodrigo");
        }

        public List<string> getAll()
        {
            return ListaStrings;
        }
    }
}