using game;
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
            int consistencia = 0;
            Game game = new Game(); 
            List<Peca> morto = new List<Peca>();

            game.startTabChess();

            Console.WriteLine("Master Chess");
            Console.WriteLine();
            Console.WriteLine(PrintTab.imprimeTabuleiro(game.tabuleiro));
            Console.WriteLine();
            Console.WriteLine();

            for (;;)
            {
                Console.Write("Digite a posição da peça: ");
                string posicaoInicial = Console.ReadLine();
                char linha = posicaoInicial[0];
                int coluna = int.Parse(posicaoInicial[1] + "");

                game.verificaMovimentos(new Position(linha, coluna));
                Console.Clear();
                Console.WriteLine(PrintTab.imprimeTabuleiro(game.tabuleiro));

                Console.Write("Digite o destino posição da peça: ");
                string posicaoFinal = Console.ReadLine();
                char linhaFinal = posicaoFinal[0];
                int colunaFinal = int.Parse(posicaoFinal[1] + "");

                try
                {
                    Peca peca = game.movePiece(new Position(linha, coluna), new Position(linhaFinal, colunaFinal));
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
                    consistencia = 1;
                    Console.WriteLine("Erro: " + e.Message);
                }

                if (consistencia == 0)
                {
                    Console.Clear();
                    Console.WriteLine(PrintTab.imprimeTabuleiro(game.tabuleiro));
                    Console.WriteLine(PrintTab.imprimeMorto(morto));
                }
            }
        }
    }
}
