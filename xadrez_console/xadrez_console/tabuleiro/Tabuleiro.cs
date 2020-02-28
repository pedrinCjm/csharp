﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca getPeca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void setPeca(Peca peca, Posicao posicao)
        {
            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.posicao = posicao;
        }
    }
}