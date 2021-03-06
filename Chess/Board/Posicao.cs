using System;
using System.Collections.Generic;
using System.Text;

namespace Board
{
    class Posicao
    {

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao()
        {

        }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public void DefinirPosicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return $"{Linha}, {Coluna}";
        }
    }
}
