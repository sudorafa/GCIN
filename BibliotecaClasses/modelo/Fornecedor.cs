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
    public class Fornecedor
    {
        private int idFornecedor;
        private string nomeFornecedor, bloqueio, telefone, endereco, bairro, cidade, uf, email, cep;
        private List<TipoFornecimento> tiposFornecimentos;

        public Fornecedor()
        {
            this.tiposFornecimentos = new List<TipoFornecimento>();
        }

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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

        [DataMember(IsRequired = true)]
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
