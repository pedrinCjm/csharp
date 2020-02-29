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
    }
}
