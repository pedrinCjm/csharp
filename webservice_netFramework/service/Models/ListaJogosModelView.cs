using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service.Models
{
    public class ListaJogosModelView
    {
        public string NoJogo { get; set; }
        public string DsJogo { get; set; }
        public int TipoJogoId { get; set; }
        public double JogadoresRegistrados { get; set; }
        public double JogadoresOnline { get; set; }
        public string CodigoPromocional { get; set; }

        public DateTime? DtInicial { get; set; }
        public DateTime? DtFinal { get; set; }

        public List<JogoModelView> JogoModelView;
    }
}