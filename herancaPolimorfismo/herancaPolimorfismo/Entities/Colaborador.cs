using System;
using System.Collections.Generic;
using System.Text;

namespace herancaPolimorfismo.Entities
{
    abstract class Colaborador
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHora { get; set; }

        public Colaborador() { }
        public Colaborador(int id, string nome, int horas, double valorHora)
        {
            if (valorHora < 0) // verifica se o custo da hora é negativo e lança uma exceção
            {
                throw new ApplicationException("O valor da hora não pode ser negativo");
            }

            ID = id;
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public abstract double getPagamento();
    }
}
