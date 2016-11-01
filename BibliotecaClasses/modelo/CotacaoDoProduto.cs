using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    public class CotacaoDoProduto
    {
        private double valorCotado;
        private string venceu;
        private Cotacao cotacao;
        private Produto produto;
        private Solicitacao solicitacao;

        public CotacaoDoProduto()
        {
            this.cotacao = new Cotacao();
            this.produto = new Produto();
            this.Solicitacao = new Solicitacao();
        }

        

        public Cotacao Cotacao
        {
            get
            {
                return cotacao;
            }

            set
            {
                cotacao = value;
            }
        }

        public Produto Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        public Solicitacao Solicitacao
        {
            get
            {
                return solicitacao;
            }

            set
            {
                solicitacao = value;
            }
        }

        public double ValorCotado
        {
            get
            {
                return valorCotado;
            }

            set
            {
                valorCotado = value;
            }
        }

        public string Venceu
        {
            get
            {
                return venceu;
            }

            set
            {
                venceu = value;
            }
        }
    }
}
