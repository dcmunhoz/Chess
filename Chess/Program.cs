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
                PatidaDeXadrez partida = new PatidaDeXadrez();
                
                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);


                    Console.WriteLine();
                    Console.Write("Origem >: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino >: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

            }
            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
