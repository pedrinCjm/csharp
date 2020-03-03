using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace manipulacao_de_arquivos
{
    public static class CopiarArquivo
    {
        public static void copiaArquivo(string sourcePath)
        {
            string targetPath = @"C:\WINDOWS\Temp\targetPath.txt";

            if (sourcePath.Equals(""))
            {
                sourcePath = @"D:\csharp\manipulacao_de_arquivos\manipulacao_de_arquivos\arquivos_de_teste\sourcePath.txt";
            }

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // cria uma instância do arquivo
                fileInfo.CopyTo(targetPath); // faz uma cópia do arquivo para esse outro

                Console.WriteLine("Caminho de destino: " 
                                  + "C:\\WINDOWS\\Temp\\targetPath.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
