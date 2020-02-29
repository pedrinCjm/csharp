using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca getPeca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca getPeca(Posicao posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }

        public void setPeca(Peca peca, Posicao posicao)
        {
            if (posicao.Linha<0 || posicao.Linha>linhas || posicao.Coluna<0 || posicao.Coluna>colunas)
            {
                // posição não existe no tabuleiro
                //return false;
                throw new ApplicationException("A posição não está nos limites do tabuleiro");
            }
            else if (getPeca(posicao) != null)
            {
                // encontrou outra peça na posição
                //return false;
                throw new ApplicationException("A posição já está ocupada");
            }
            else
            {
                // tudo certo com a posição, pode gravar
                pecas[posicao.Linha, posicao.Coluna] = peca;
                peca.posicao = posicao;
            }
            //return true;
        }
    }
}
