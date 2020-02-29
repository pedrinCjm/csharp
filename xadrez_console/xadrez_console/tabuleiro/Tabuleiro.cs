using System;
using System.Collections.Generic;
using System.Text;
using xadrez;

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

        public Peca getPeca(Position posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }

        public Peca movePiece(Position posicaoInicial, Position posicaoFinal)
        {
            Peca pecaMovida = null;
            Peca pecaRemovida = null;

            if (getPeca(posicaoInicial) != null)
            {
                pecaMovida = getPeca(posicaoInicial);
            }
            if (getPeca(posicaoFinal) != null)
            {
                pecaRemovida = getPeca(posicaoFinal);
            }

            if (posicaoFinal.Linha<0 || posicaoFinal.Linha>linhas || posicaoFinal.Coluna<0 || posicaoFinal.Coluna>colunas)
            {
                // posição não existe no tabuleiro
                //return false;
                throw new ApplicationException("A posição não está nos limites do tabuleiro");
            }
            else if (pecaRemovida != null && pecaRemovida.cor == pecaMovida.cor)
            {
                // encontrou outra peça na posição
                //return false;
                throw new ApplicationException("A posição já está ocupada");
            }
            else if (pecaRemovida != null && pecaRemovida.cor != pecaMovida.cor)
            {
                // encontrou uma peça inimiga
                pecas[posicaoFinal.Linha, posicaoFinal.Coluna] = pecaMovida;
                pecaMovida.posicao = posicaoFinal;
                removePiace(posicaoInicial);
            }
            else
            {
                // posição vazia, pode gravar
                pecas[posicaoFinal.Linha, posicaoFinal.Coluna] = pecaMovida;
                pecaMovida.posicao = posicaoFinal;
                removePiace(posicaoInicial);
            }
            return pecaRemovida;
        }

        public Peca removePiace(Position posicao)
        {
            Peca peca;
            if (getPeca(posicao) == null)
            {
                return null;
            }
            else
            {
                peca = getPeca(posicao);
                peca.posicao = null;
                pecas[posicao.Linha, posicao.Coluna] = null;
            }
            return peca;
        }

        public void startTabChess()
        {
            Cor cor = Cor.Branca;
            Peca peca = new Pawns(cor);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 7 || i == 0)
                    {
                        if (j == 0 || j == 7)
                        {
                            peca = new Rooks(cor);
                        }
                        else if (j == 1 || j == 6)
                        {
                            peca = new Horse(cor);
                        }
                        else if (j == 2 || j == 5)
                        {
                            peca = new Bishops(cor);
                        }
                        else if (j == 3)
                        {
                            peca = new Queen(cor);
                        }
                        else
                        {
                            peca = new King(cor);
                        }
                    }
                    else
                    {
                        peca = new Pawns(cor);
                    }

                    pecas[i, j] = peca;
                    peca.posicao = new Position(i, j);

                    if (j==7)
                    {
                        if (i == 1)
                        {
                            cor = Cor.Preta;
                            i = 5;
                        }
                    }
                }
            }
        }
    }
}
