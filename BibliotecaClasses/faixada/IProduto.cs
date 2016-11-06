using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.faixada
{
    interface IProduto
    {
        List<Produto> DListarProduto(Produto produto);
        void DDeletarProduto(Produto produto);
        void DCadastrarProduto(Produto produto);
        void DAlterarProduto(Produto produto);
    }
}
