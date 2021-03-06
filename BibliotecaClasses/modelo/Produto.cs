﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    [Serializable]
    [DataContract()]
    public class Produto
    {
        private int idProduto;
        private string dataCadastro, descProduto;
        private List<TipoFornecimento> listaTipoFornecimento;

        public Produto()
        {
            this.ListaTipoFornecimento = new List<TipoFornecimento>();
        }

        [DataMember(IsRequired = true)]
        public int IdProduto
        {
            get
            {
                return idProduto;
            }

            set
            {
                idProduto = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DataCadastro
        {
            get
            {
                return dataCadastro;
            }

            set
            {
                dataCadastro = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DescProduto
        {
            get
            {
                return descProduto;
            }

            set
            {
                descProduto = value;
            }
        }

        [DataMember(IsRequired = true)]
        public List<TipoFornecimento> ListaTipoFornecimento
        {
            get
            {
                return listaTipoFornecimento;
            }

            set
            {
                listaTipoFornecimento = value;
            }
        }
    }
}
