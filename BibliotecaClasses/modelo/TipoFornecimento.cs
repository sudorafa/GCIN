using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
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
