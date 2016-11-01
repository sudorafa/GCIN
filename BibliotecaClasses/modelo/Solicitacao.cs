using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    public class Solicitacao
    {
        private int idSolicitacao;
        private string dataSolicitacao, dataPrecisa, severidade;
        private List<CotacaoDoProduto> cotacoesProdutosSolicitacoes;
        private List<Status> status;
        private List<Usuario> usuarios;

        public Solicitacao()
        {
            this.cotacoesProdutosSolicitacoes = new List<CotacaoDoProduto>();
            this.status = new List<modelo.Status>();
            this.Usuarios = new List<Usuario>();
        }

        public int IdSolicitacao
        {
            get
            {
                return idSolicitacao;
            }

            set
            {
                idSolicitacao = value;
            }
        }

        public string DataSolicitacao
        {
            get
            {
                return dataSolicitacao;
            }

            set
            {
                dataSolicitacao = value;
            }
        }

        public string DataPrecisa
        {
            get
            {
                return dataPrecisa;
            }

            set
            {
                dataPrecisa = value;
            }
        }

        public string Severidade
        {
            get
            {
                return severidade;
            }

            set
            {
                severidade = value;
            }
        }

        public List<CotacaoDoProduto> CotacoesProdutosSolicitacoes
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

        public List<Status> Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public List<Usuario> Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }
    }
}
