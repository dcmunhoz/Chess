namespace Tabuleiro
{
    class Tabuleiro
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas { get; private set; }

        public Tabuleiro()
        {

        }

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[linhas, colunas];

        }


    }
}
