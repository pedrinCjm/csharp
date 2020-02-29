using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using xadrez;

namespace game
{
    class Game
    {
        public void startTabChess(Tabuleiro tabuleiro)
        {
            Cor cor = Cor.Branca;
            Position position = new Position(0, 0);
            Peca peca = new Pawns(cor);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //pecas[i, j] = peca;
                    peca.posicao = new Position(i, j);
                }
                cor = Cor.Preta;
            }
        }
    }
}
