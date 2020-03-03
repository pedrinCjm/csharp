using System;
using System.IO;



namespace manipulacao_de_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manipulação de arquivos em C#!");
            Console.WriteLine();
            Controller controller = null;

            while (1 == 1)
            {
                int option = -1;
                string sourcePath = "";

                Console.WriteLine($"Digite: \n" +
                                   "1 - Para copiar o arquivo do exemplo.\n" +
                                   "2 - Para informar o caminho do arquivo a ser copiado.\n" +
                                   "3 - Para ler o arquivo de origem.\n" +
                                   "4 - Para informar o caminho do arquivo a ser lido.\n" + 
                                   "5 - Para ler o arquivo com ReadAllLines\n" + 
                                   "0 - Para sair");
                option = int.Parse(Console.ReadLine());

                if (option == 2 || option == 4)
                {
                    Console.Write("Informe o caminho completo do arquivo:");
                    sourcePath = Console.ReadLine();
                }

                if (option > 0 && option < 6)
                {
                    Console.Clear();
                    controller = new Controller(option, sourcePath);
                    Console.WriteLine();
                }

                else if (option == 0) 
                { 
                    Console.Clear(); 
                    Console.WriteLine("Fim\n\n"); 
                    Console.WriteLine("02/03/2020 - Pedro Medeiros - Graduado em engenharia da computação - Ufop\n\n"); 
                    break; 
                }
                
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine();
                }
            }
        }
    }
}
