using System;

namespace extensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int option = -1;

            DateTime data = new DateTime();
            string strObj = "Criando um método adicional para a classe String!";

            while(option != 0)
            {
                Console.WriteLine("Métodos criados para extender algumas classes da biblioteca System");
                Console.WriteLine();
                Console.WriteLine("Digite:");
                Console.WriteLine("1 - Para cortar um texto indicando o tamanho máximo");
                Console.WriteLine("2 - Para calcular a quantidade de dias que passou a partir de uma data");
                Console.WriteLine("0 - Para sair");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o texto:");
                        strObj = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Digite uma quantidade de caracteres para cortar a frase anterior: ");
                        count = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado:");
                        Console.WriteLine(strObj.cut(count));
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Digite a data para calcular o tempo decorrido (DD/MM/AAAA): ");
                        data = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Resultado:");
                        Console.WriteLine(data.tempoDecorrido(data));
                        Console.WriteLine();
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
