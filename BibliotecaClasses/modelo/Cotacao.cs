using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    public class Cotacao
    {
        private int idCotacao;
        private string dataCotacao, statusCotacao, dataValidadeCotacao;
        private List<CotacaoDoProduto> cotacoesProdutosSolicitacoes;

        public Cotacao()
        {
            this.cotacoesProdutosSolicitacoes = new List<CotacaoDoProduto>();
        }

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
