using System;
using System.IO;

namespace manipulacao_de_arquivos
{
    public static class FuncoesDoPath
    {
        public static void funcoesDoPath(string sourcePath)
        {
            Console.WriteLine("Principais funções da biblioteca Path:");
            Console.WriteLine();

            if (sourcePath.Equals(""))
            {
                sourcePath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste\soucePath.txt";
            }

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(sourcePath));
            Console.WriteLine("GetFileName: " + Path.GetFileName(sourcePath));
            Console.WriteLine("GetExtension: " + Path.GetExtension(sourcePath));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(sourcePath));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(sourcePath));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
