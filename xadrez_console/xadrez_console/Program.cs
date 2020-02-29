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
            tabuleiro.setPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(3, 4));
            tabuleiro.setPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(5, 7));

            Console.WriteLine(PrintTab.imprimeTabuleiro(tabuleiro));

            for (;;)
            {
                Console.Write("Digite a linha: ");
                char linha = char.Parse(Console.ReadLine());
                Console.Write("Digite a coluna: ");
                int coluna = int.Parse(Console.ReadLine());
                try
                {
                    tabuleiro.setPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(linha, coluna));
                    break;
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
            }

            Console.Clear();
            Console.WriteLine(PrintTab.imprimeTabuleiro(tabuleiro));
        }
    }
}
