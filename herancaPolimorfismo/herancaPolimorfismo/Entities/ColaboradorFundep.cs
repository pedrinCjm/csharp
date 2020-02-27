using System;
using System.Collections.Generic;
using System.Text;

namespace herancaPolimorfismo.Entities
{
    class ColaboradorFundep : Colaborador
    {
        public ColaboradorFundep(int id, string nome, int horas, double valorHora) : base (id, nome, horas, valorHora)
        {
            // usa o construtor da superclasse para atribuir os valores
        }
    }
}
