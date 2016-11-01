using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    public class Fornecedor
    {
        private int idFornecedor;
        private string nomeFornecedor, bloqueio, telefone, endereco, bairro, cidade, uf, email, cep;
        private List<TipoFornecimento> tiposFornecimentos;

        public Fornecedor()
        {
            this.tiposFornecimentos = new List<TipoFornecimento>();
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Bloqueio
        {
            get
            {
                return bloqueio;
            }

            set
            {
                bloqueio = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public int IdFornecedor
        {
            get
            {
                return idFornecedor;
            }

            set
            {
                idFornecedor = value;
            }
        }

        public string NomeFornecedor
        {
            get
            {
                return nomeFornecedor;
            }

            set
            {
                nomeFornecedor = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public List<TipoFornecimento> TiposFornecimentos
        {
            get
            {
                return tiposFornecimentos;
            }

            set
            {
                tiposFornecimentos = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }
    }
}
