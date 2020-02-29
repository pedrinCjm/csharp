using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Position posicao { get; set; }
        public Cor cor { get; set; }
        public int qtdeMovimentos { get; set; }
        private Tabuleiro tab;

        public Peca(Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdeMovimentos = 0;
        }
    }
}
