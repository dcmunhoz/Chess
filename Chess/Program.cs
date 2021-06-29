using System;
using Board;
using Board.Enums;
using Chess;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 1));

            Tela.ImprimirTabuleiro(tab);


        }
    }
}
