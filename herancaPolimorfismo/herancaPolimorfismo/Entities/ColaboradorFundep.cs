using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace herancaPolimorfismo.Entities
{
    class ColaboradorFundep : Colaborador
    {
        public ColaboradorFundep(int id, string nome, int horas, double valorHora) : base (id, nome, horas, valorHora)
        {
            // usa o construtor da superclasse para atribuir os valores
        }

        public override double getPagamento()
        {
            return ValorHora * Horas;
        }

        public DataSet getDados()
        {
            DataSet dataset;

            try
            {
                int i = 0;
                if (i == 1)
                {
                    dataset = new DataSet();
                    return dataset;
                }
                
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }
    }
}
