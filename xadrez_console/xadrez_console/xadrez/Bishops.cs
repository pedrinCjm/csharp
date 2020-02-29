using tabuleiro;

namespace xadrez
{
    class Bishops : Peca
    {
        public Bishops(Cor cor) : base(cor) { }

        public override string ToString()
        {
            return "B";
        }
    }
}
