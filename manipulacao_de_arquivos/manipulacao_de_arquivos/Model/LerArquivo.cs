using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace manipulacao_de_arquivos
{
    public static class LerArquivo
    {
        public static void lerSemFileStream(string sourcePath)
        {
            if (sourcePath.Equals(""))
            {
                sourcePath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste\sourcePath.txt";
            }
            
            List<string> lines = new List<string>();
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(sourcePath);

                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        public static void lerArquivoComReadAllLines(string sourcePath)
        {
            if (sourcePath.Equals(""))
            {
                sourcePath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste\sourcePath.txt";
            }

            string[] lines = File.ReadAllLines(sourcePath);
            
            try
            {
                foreach (string line in lines)
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
