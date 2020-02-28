using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {   
        public static string imprimeTabuleiro(Tabuleiro tabuleiro)
        {
            string impressao = "";

            for (int i=0; i<tabuleiro.linhas; i++)
            {
                for (int j=0; j<tabuleiro.colunas; j++)
                {
                    if(tabuleiro.getPeca(i,j) == null)
                    {
                        impressao = impressao + "- ";
                    }
                    else
                    {
                        impressao = impressao + $"{tabuleiro.getPeca(i, j)} ";
                    }
                }
                impressao = impressao + "\n";
            }

            return impressao;
        }
    }
}
