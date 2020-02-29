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
    }
}

