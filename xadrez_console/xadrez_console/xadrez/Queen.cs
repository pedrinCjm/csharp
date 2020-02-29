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
    }
}
