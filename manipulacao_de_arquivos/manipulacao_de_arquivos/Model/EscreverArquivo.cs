using System;
using System.IO;

namespace manipulacao_de_arquivos
{
    public static class EscreverArquivo
    {
        public static void escreverComWriteLine(string targetPath, string content)
        {
            Console.WriteLine("Tipo de escrita: StreamWriter - método: WriteLine - Fechamento automático");
            Console.WriteLine();

            if (targetPath.Equals(""))
            {
                targetPath = @"C:\WINDOWS\Temp\writeLine.txt";
                Console.WriteLine();
                Console.WriteLine("Caminho automático: C:\\WINDOWS\\Temp\\writeLine.txt\n");
            }
            if (content.Equals(""))
            {
                content = "O arquivo foi gravado com essa mensagem automática, pois, não foi digitado nenhum texto!";
            }

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(targetPath))
                {
                    streamWriter.WriteLine(content);
                }
                Console.WriteLine();
                Console.WriteLine("Conteúdo gravado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
