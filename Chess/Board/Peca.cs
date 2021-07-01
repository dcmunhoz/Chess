using Board.Enums;

namespace Board
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QtdeMovimentos = 0;
        }

        public void IncrementarQtdeMovimentos()
        {
            QtdeMovimentos++;
        }

        protected bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);

            return p == null || p.Cor != this.Cor;

        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
