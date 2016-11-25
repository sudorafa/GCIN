using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.negocio
{
    public class NProduto
    {
        public Produto NCadastrarAlterarProduto(Produto produto)
        {
            if (produto.IdProduto == 0)
            {
                if (produto.DescProduto.Length == 0 || produto.DescProduto.Equals("") || produto.DescProduto == null)
                {
                    throw new Exception("Por Favor, Informar Descrição do Produto !");
                }
                else
                {
                    return new DProduto().DCadastrarProduto(produto);
                }
            }
            else
            {
                if (produto.DescProduto.Length == 0 || produto.DescProduto.Equals("") || produto.DescProduto == null)
                {
                    throw new Exception("Por Favor, Informar Descrição do Produto !");
                }
                else
                {
                    new DProduto().DAlterarProduto(produto);
                }
            }
            return produto;
        }

        public void NDeletarProduto(Produto produto)
        {
            if (produto.IdProduto == 0)
            {
                throw new Exception("Por Favor, Escolha um Produto da Lista Para Deletar !");
            }
            else
            {
                new DProduto().DDeletarProduto(produto);
            }
        }

        public List<Produto> NListarProduto(Produto produto)
        {
            return new DProduto().DListarProduto(produto);
        }
    }
}
