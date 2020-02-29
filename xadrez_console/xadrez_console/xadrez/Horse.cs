using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class Horse : Peca
    {
        public Horse(Cor cor) : base(cor) { }

        public override string ToString()
        {
            return "H";
        }

        public override List<Position> movimentosPossiveis(Position position, Tabuleiro tabuleiro)
        {
            List<Position> positions = new List<Position>();

            if (tabuleiro.getPeca(position.Linha + 1, position.Coluna) == null)
            {
                positions.Add(new Position(position.Linha + 1, position.Coluna));

                if (qtdeMovimentos == 0)
                {
                    if (tabuleiro.getPeca(position.Linha + 2, position.Coluna) == null)
                    {
                        positions.Add(new Position(position.Linha + 1, position.Coluna));
                    }
                }
            }

            return positions;
        }
    }
}
