using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        public int Linha;
        public int Coluna;

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Posicao(char l, int coluna)
        {
            Linha = 8 - coluna;
            Coluna = l - 'a';
        }
    }
}
