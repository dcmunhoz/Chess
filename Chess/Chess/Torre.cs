using System;
using System.Collections.Generic;
using System.Text;
using Board;
using Board.Enums;

namespace Chess
{
    class Torre : Peca
    {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            // Acima
            pos.DefinirPosicao(this.Posicao.Linha - 1, this.Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && this.PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor !=  this.Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }


            // Abaixo
            pos.DefinirPosicao(this.Posicao.Linha + 1, this.Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && this.PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            // Direita
            pos.DefinirPosicao(this.Posicao.Linha, this.Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && this.PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            // Esquerda
            pos.DefinirPosicao(this.Posicao.Linha, this.Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && this.PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }


            return mat;

        }

    }
}
