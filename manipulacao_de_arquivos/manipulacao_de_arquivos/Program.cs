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
                string content = "";

                Console.WriteLine($"Digite: \n" +
                                   "1 - Para copiar o arquivo do exemplo.\n" +
                                   "2 - Para informar o caminho do arquivo a ser copiado.\n" +
                                   "3 - Para ler o arquivo de origem.\n" +
                                   "4 - Para ler o arquivo com: ReadAllLines\n" +
                                   "5 - Para ler o arquivo com: FileStream e StreamReader - Fechamento automático\n" +
                                   "6 - Para informar o caminho do arquivo a ser lido.\n" +
                                   "7 - Para escrita de arquivo.\n" +
                                   "8 - Diretórios - Manipulação.\n" +
                                   "9 - Principais funções do Path.\n" +
                                   "0 - Para sair");
                option = int.Parse(Console.ReadLine());

                if (option == 2 || option == 6)
                {
                    Console.Clear();
                    Console.Write("Informe o caminho completo do arquivo: ");
                    sourcePath = Console.ReadLine();
                }

                if (option == 7)
                {
                    Console.Clear();
                    Console.Write("Digite um conteúdo para o arquivo: ");
                    content = Console.ReadLine();
                    Console.Write("Digite o caminho completo para salvar o arquivo (ou precione enter para gerar automáticamente): ");
                    sourcePath = Console.ReadLine();
                }

                if (option > 0 && option < 10)
                {
                    Console.Clear();
                    controller = new Controller(option, sourcePath, content);
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
