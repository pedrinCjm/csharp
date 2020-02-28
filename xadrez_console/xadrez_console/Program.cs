using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8,8);

            tabuleiro.setPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0,0));
            tabuleiro.setPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(3, 4));
            tabuleiro.setPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(5, 7));

            Console.WriteLine(Tela.imprimeTabuleiro(tabuleiro));
        }
    }
}
