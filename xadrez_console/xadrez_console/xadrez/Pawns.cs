using tabuleiro;

namespace xadrez
{
    class Pawns : Peca
    {
        public Pawns(Cor cor) : base(cor) { }

        public override string ToString()
        {
            return "P";
        }
    }
}

