using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class Rooks : Peca
    {
        public Rooks(Cor cor) : base(cor) { }

        public override string ToString()
        {
            return "R";
        }

        public override List<Position> movimentosPossiveis(Position position, Tabuleiro tabuleiro)
        {
            List<Position> positions = new List<Position>();

            if (tabuleiro.getPeca(position.Linha - 1, position.Coluna) == null)
            {
                positions.Add(new Position(position.Linha - 1, position.Coluna));

                if (qtdeMovimentos == 0)
                {
                    if (tabuleiro.getPeca(position.Linha - 2, position.Coluna) == null)
                    {
                        positions.Add(new Position(position.Linha - 2, position.Coluna));
                    }
                }
            }

            return positions;
        }
    }
}

