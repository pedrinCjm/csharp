using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Position
    {
        public int Linha;
        public int Coluna;

        public Position(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Position(char l, int coluna)
        {
            Linha = 8 - coluna;
            Coluna = l - 'a';
        }
    }
}
