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

            int n = 0;

            try
            {
                Console.Write("Informe o número de colaboradores no projeto: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("O valor deve ser um inteiro!");
                Console.Write("Informe o número de colaboradores no projeto: ");
                n = int.Parse(Console.ReadLine());
            }
            finally // executa esse bloco mesmo se encontrar uma exceção. Pode ser usado pra fechar um BD por exemplo
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
            }

            try
            {
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
                        list.Add(new ColaboradorFundep(i, nome, horas, valorHora));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
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
