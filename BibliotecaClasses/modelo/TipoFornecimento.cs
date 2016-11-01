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
    public class TipoFornecimento
    {
        private int idTipoFornecimento;
        private string descTipoFornecimento;
        private Fornecedor fornecedor;
        private Produto produto;

        public TipoFornecimento()
        {
            this.fornecedor = new Fornecedor();
            this.produto = new Produto();
        }

        [DataMember(IsRequired = true)]
        public int IdTipoFornecimento
        {
            get
            {
                return idTipoFornecimento;
            }

            set
            {
                idTipoFornecimento = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DescTipoFornecimento
        {
            get
            {
                return descTipoFornecimento;
            }

            set
            {
                descTipoFornecimento = value;
            }
        }

        [DataMember(IsRequired = true)]
        public Fornecedor Fornecedor
        {
            get
            {
                return fornecedor;
            }

            set
            {
                fornecedor = value;
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
    }
}
