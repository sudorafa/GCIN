using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    [Serializable]
    [DataContract()]
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
        
        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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
