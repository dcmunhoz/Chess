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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno   : " + partida.Turno);
                        Console.WriteLine("Jogador : " + partida.JogadorAtual.ToString());

                        Console.WriteLine();
                        Console.Write("Origem >: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino >: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch ( BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

            }
            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
