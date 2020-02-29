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
    }
}
