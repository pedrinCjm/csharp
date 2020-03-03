using System;
using System.Collections.Generic;
using System.IO;

namespace manipulacao_de_arquivos
{
    public static class LerArquivo
    {
        public static void lerSemFileStream(string sourcePath)
        {
            Console.WriteLine("Tipo de leitura: StreamReader - Fechamento manual");
            Console.WriteLine();

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
            Console.WriteLine("Tipo de leitura: File.ReadAllLines");
            Console.WriteLine();

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

        public static void lerComFileStreamComFechamentoAutomatico(string sourcePath)
        {
            Console.WriteLine("Tipo de leitura: FileStream e StreamReader - Fechamento automático");
            Console.WriteLine();

            if (sourcePath.Equals(""))
            {
                sourcePath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste\sourcePath.txt";
            }

            try
            {
                using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
