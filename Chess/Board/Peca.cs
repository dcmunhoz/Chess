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

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
