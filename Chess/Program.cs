using System;
using Board;
using Board.Enums;
using Board.Exceptions;
using Chess;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 1));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 9));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
