using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class King : Peca
    {
        public King(Cor cor) : base(cor) { }

        public override string ToString()
        {
            return "K";
        }

        public override List<Position> movimentosPossiveis(Position position, Tabuleiro tabuleiro)
        {
            return null;
        }
    }
}
