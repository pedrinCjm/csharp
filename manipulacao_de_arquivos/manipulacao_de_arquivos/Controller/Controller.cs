using System;
using System.Collections.Generic;
using System.Text;

namespace manipulacao_de_arquivos
{
    class Controller
    {
        public Controller(int option, string sourcePath)
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
                    LerArquivo.lerSemFileStream(sourcePath);
                    break;
                case 5:
                    LerArquivo.lerArquivoComReadAllLines(sourcePath);
                    break;
            }
        }
    }
}
