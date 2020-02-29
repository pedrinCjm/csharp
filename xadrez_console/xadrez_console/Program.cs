using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8,8);
            List<Peca> morto = new List<Peca>();

            tabuleiro.startTabChess();

            Console.WriteLine("Master Chess");
            Console.WriteLine();
            Console.WriteLine(PrintTab.imprimeTabuleiro(tabuleiro));
            Console.WriteLine();
            Console.WriteLine();
            for (;;)
            {
                Console.Write("Digite a posição da peça: ");
                string[] posicaoInicial = Console.ReadLine().Split(',');
                char linha = char.Parse(posicaoInicial[0]);
                int coluna = int.Parse(posicaoInicial[1]);

                Console.Write("Digite a nova posição da peça: ");
                string[] posicaoFinal = Console.ReadLine().Split(',');
                char linhaFinal = char.Parse(posicaoFinal[0]);
                int colunaFinal = int.Parse(posicaoFinal[1]);

                try
                {
                    Peca peca = tabuleiro.movePiece(new Position(linha, coluna), new Position(linhaFinal, colunaFinal));
                    if (peca != null)
                    {
                        morto.Add(peca);
                    }
                    if (peca is King)
                    {
                        break;
                    }
                    
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine("Erro: " + e.Message);
                }
                Console.Clear();
                Console.WriteLine(PrintTab.imprimeTabuleiro(tabuleiro));
                Console.WriteLine(PrintTab.imprimeMorto(morto));
            }
        }
    }
}
