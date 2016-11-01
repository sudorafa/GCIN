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
    public class Cotacao
    {
        private int idCotacao;
        private string dataCotacao, statusCotacao, dataValidadeCotacao;
        private List<CotacaoDoProduto> cotacoesProdutosSolicitacoes;

        public Cotacao()
        {
            this.cotacoesProdutosSolicitacoes = new List<CotacaoDoProduto>();
        }

        [DataMember(IsRequired = true)]
        public int IdCotacao
        {
            get
            {
                return idCotacao;
            }

            set
            {
                idCotacao = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DataCotacao
        {
            get
            {
                return dataCotacao;
            }

            set
            {
                dataCotacao = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string StatusCotacao
        {
            get
            {
                return statusCotacao;
            }

            set
            {
                statusCotacao = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DataValidadeCotacao
        {
            get
            {
                return dataValidadeCotacao;
            }

            set
            {
                dataValidadeCotacao = value;
            }
        }

        [DataMember(IsRequired = true)]
        public List<CotacaoDoProduto> CotacaoProdutoSolicitacao
        {
            get
            {
                return cotacoesProdutosSolicitacoes;
            }

            set
            {
                cotacoesProdutosSolicitacoes = value;
            }
        }
    }
}