using herancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace herancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Colaborador> list = new List<Colaborador>();

            Console.Write("Informe o número de colaboradores no projeto: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Colaborador {i}: ");
                Console.Write("Terceirizado (s/n)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor da hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 's')
                {
                    Console.Write("Custo adicional: ");
                    double custoAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ColaboradorTerceirizado(i, nome, horas, valorHora, custoAdicional));
                }
                else
                {
                    list.Add(new Colaborador(i, nome, horas, valorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Custo do projeto: ");
            foreach (Colaborador colaborador in list)
            {
                Console.WriteLine(colaborador.Nome + " - $ " + colaborador.getPagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
