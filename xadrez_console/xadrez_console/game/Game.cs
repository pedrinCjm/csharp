using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using xadrez;

namespace game
{
    class Game
    {
        public Tabuleiro tabuleiro = new Tabuleiro(8,8);
        public void verificaMovimentos(Position posicaoInicial)
        {
            Peca pecaMovida = null;
            List<Position> positions = new List<Position>();
            if (tabuleiro.getPeca(posicaoInicial) != null)
            {
                pecaMovida = tabuleiro.getPeca(posicaoInicial);
                positions = pecaMovida.movimentosPossiveis(posicaoInicial, tabuleiro);
                if (positions.Count > 0)
                {
                    foreach (Position position in positions)
                    {
                        tabuleiro.pecas[position.Linha, position.Coluna] = new MarcaMovimento(Cor.Amarelo);
                    }
                }
            }
        }

        public Peca movePiece(Position posicaoInicial, Position posicaoFinal)
        {
            Peca pecaMovida = null;
            Peca pecaRemovida = null;

            if (tabuleiro.getPeca(posicaoInicial) != null)
            {
                pecaMovida = tabuleiro.getPeca(posicaoInicial);

                if (tabuleiro.getPeca(posicaoFinal) != null)
                {
                    pecaRemovida = tabuleiro.getPeca(posicaoFinal);
                }
                else
                {
                    throw new ApplicationException("Movimento inválido!");
                }
            }
            else
            {
                throw new ApplicationException("Não há peça na posição");
            }

            if (posicaoFinal.Linha < 0 || posicaoFinal.Linha > tabuleiro.linhas || posicaoFinal.Coluna < 0 || posicaoFinal.Coluna > tabuleiro.colunas)
            {
                // posição não existe no tabuleiro
                throw new ApplicationException("A posição não está nos limites do tabuleiro!");
            }
            else if (pecaRemovida != null && pecaRemovida.cor == pecaMovida.cor)
            {
                // encontrou outra peça na posição
                throw new ApplicationException("A posição já está ocupada!");
            }
            else if (pecaRemovida != null && pecaRemovida.cor != pecaMovida.cor)
            {
                // encontrou uma peça inimiga
                tabuleiro.pecas[posicaoFinal.Linha, posicaoFinal.Coluna] = pecaMovida;
                pecaMovida.posicao = posicaoFinal;
                tabuleiro.removePiace(posicaoInicial);
            }

            if (pecaRemovida.cor == Cor.Amarelo)
            {
                pecaRemovida = null;
            }

            limpaMovimentos();

            return pecaRemovida;
        }

        public void limpaMovimentos()
        {
            for (int i=0; i<8; i++)
            {
                for (int j=0; j<8; j++)
                {
                    if (tabuleiro.getPeca(i, j) != null)
                    {
                        if (tabuleiro.getPeca(i, j).cor == Cor.Amarelo)
                        {
                            tabuleiro.pecas[i, j] = null;
                        }
                    }
                }
            }
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

                    tabuleiro.pecas[i, j] = peca;
                    peca.posicao = new Position(i, j);

                    if (j == 7)
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
