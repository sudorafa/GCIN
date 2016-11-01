﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    public class Produto
    {
        private int idProduto;
        private string dataCadastro, descProduto;
        private List<CotacaoDoProduto> cotacoesProdutosSolicitacoes;

        public Produto()
        {
            this.cotacoesProdutosSolicitacoes = new List<CotacaoDoProduto>();
        }

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
    }
}
