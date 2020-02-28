using System;
using System.Collections.Generic;
using System.Text;

namespace herancaPolimorfismo.Entities
{
    class ColaboradorTerceirizado : Colaborador
    {
        public double CustoAdicional { get; set; }

        public ColaboradorTerceirizado() { }
        public ColaboradorTerceirizado(int id, string nome, int horas, double valorHora, double valorAdicional)
            : base(id, nome, horas, valorHora)
        {
            CustoAdicional = valorAdicional;
        }

        public override double getPagamento()
        {
            return (ValorHora * Horas) + 1.1 * CustoAdicional;
        }
    }
}
