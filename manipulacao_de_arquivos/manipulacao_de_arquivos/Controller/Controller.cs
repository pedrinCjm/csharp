namespace manipulacao_de_arquivos
{
    class Controller
    {
        public Controller(int option, string sourcePath, string content)
        {
            switch (option)
            {
                case 1:
                    CopiarArquivo.copiaArquivo(sourcePath);
                    break;
                case 2:
                    CopiarArquivo.copiaArquivo(sourcePath);
                    break;
                case 3:
                    LerArquivo.lerSemFileStream(sourcePath);
                    break;
                case 4:
                    LerArquivo.lerArquivoComReadAllLines(sourcePath);
                    break;
                case 5:
                    LerArquivo.lerComFileStreamComFechamentoAutomatico(sourcePath); 
                    break;
                case 6:
                    LerArquivo.lerSemFileStream(sourcePath); 
                    break;
                case 7:
                    EscreverArquivo.escreverComWriteLine(sourcePath,content);
                    break;
                case 8:
                    Diretorios.diretorios();
                    break;
                case 9:
                    FuncoesDoPath.funcoesDoPath(sourcePath);
                    break;
            }
        }
    }
}
