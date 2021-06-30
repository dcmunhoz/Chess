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
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(1,2));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 6));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
