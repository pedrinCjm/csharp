using System;
using System.IO;

namespace manipulacao_de_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manipulação de arquivos em C#!");
            Console.WriteLine("02/03/2020 - Pedro Medeiros - Graduado em engenharia da computação - Ufop");
            Console.WriteLine();

            string sourcePath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste\sourcePath.txt";
            string targetPath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste\targetPath.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // cria uma instância do arquivo
                fileInfo.CopyTo(targetPath); // faz uma cópia do arquivo para esse outro

                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
