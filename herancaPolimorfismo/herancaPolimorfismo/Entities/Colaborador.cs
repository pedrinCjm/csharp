using System;
using System.Collections.Generic;
using System.Text;

namespace herancaPolimorfismo.Entities
{
    class Colaborador
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora { get; set; }

        public Colaborador() { }
        public Colaborador(int id, string nome, int horas, double valorHora)
        {
            ID = id;
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public virtual double getPagamento()
        {
            return ValorHora * Horas;
        }
    }
}
