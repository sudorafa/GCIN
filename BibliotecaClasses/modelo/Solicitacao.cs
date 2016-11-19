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
    public class Solicitacao
    {
        private int idSolicitacao;
        private string dataSolicitacao, dataPrecisa, severidade, detalhe;
        private Produto produto;
        private Status status;
        private List<CotacaoDoProduto> cotacoesProdutosSolicitacoes;
        //private List<Status> status;
        private List<Usuario> usuarios;

        public Solicitacao()
        {
            this.produto = new Produto();
            this.Status = new Status();
            this.cotacoesProdutosSolicitacoes = new List<CotacaoDoProduto>();
            //this.status = new List<modelo.Status>();
            this.Usuarios = new List<Usuario>();
        }

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        /*
        [DataMember(IsRequired = true)]
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
        */

        [DataMember(IsRequired = true)]
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
        public string Detalhe
        {
            get
            {
                return detalhe;
            }

            set
            {
                detalhe = value;
            }
        }

        [DataMember(IsRequired = true)]
        public Status Status
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
    }
}
