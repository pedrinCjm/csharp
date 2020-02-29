using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class Queen : Peca
    {
        public Queen(Cor cor) : base(cor) { }

        public override string ToString()
        {
            return "Q";
        }

        public override List<Position> movimentosPossiveis(Position position, Tabuleiro tabuleiro)
        {
            return null;
        }
    }
}
