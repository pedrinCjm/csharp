﻿using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez_console
{
    class PrintTab
    {   
        public static string imprimeMorto(List<Peca> morto)
        {
            string impressao = "Morto: ";

            foreach (Peca peca in morto)
            {
                if (peca.cor == Cor.Branca)
                {
                    impressao = impressao + "\u001B[44m \u001B[30m";
                    impressao = impressao + peca.ToString();
                }
                else
                {
                    impressao = impressao + "\u001B[47m \u001B[31m";
                    impressao = impressao + peca.ToString();
                }
                impressao = impressao + "\u001B[40m \u001B[37m";
            }

            return impressao;
        }
        public static string imprimeTabuleiro(Tabuleiro tabuleiro)
        {
            string impressao = "";

            for (int i=0; i<tabuleiro.linhas; i++)
            {
                impressao = impressao + $"{8-i}     ";
                for (int j=0; j<tabuleiro.colunas; j++)
                {
                    if(tabuleiro.getPeca(i,j) == null)
                    {
                        impressao = impressao + " -     ";
                        impressao = impressao + " \u001B[40m";
                    }
                    else
                    {
                        if (tabuleiro.getPeca(i, j).cor == Cor.Preta)
                        {
                            impressao = impressao + "\u001B[47m \u001B[31m";

                        }
                        else if (tabuleiro.getPeca(i, j).cor == Cor.Branca)
                        {
                            impressao = impressao + "\u001B[44m \u001B[30m";
                        }
                        else if (tabuleiro.getPeca(i, j).cor == Cor.Amarelo)
                        {
                            impressao = impressao + "\u001B[43m \u001B[33m";
                            
                        }
                        impressao = impressao + $"{tabuleiro.getPeca(i, j)}";
                        impressao = impressao + "\u001B[40m \u001B[37m";
                        impressao = impressao + "     ";
                    }
                }
                impressao = impressao + "\n\n\n";
            }
            impressao = impressao + "       a       b       c       d       e       f       g       h";
            impressao = impressao + " \u001B[40m";
            return impressao;
        }
    }
}
