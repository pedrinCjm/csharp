using System;
using System.IO;

namespace manipulacao_de_arquivos
{
    public static class Diretorios
    {
        public static void diretorios()
        {
            string sourcePath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste";
            try
            {
                var folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(sourcePath + @"\novaPasta");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
