using BibliotecaClasses.faixada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClasses.modelo;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaClasses.dados
{
    public class DProduto : IProduto
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public void DAlterarProduto(Produto produto)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "update Produto set descProduto = @descProduto where idProduto = @idProduto";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@descProduto", SqlDbType.VarChar);
                comando.Parameters["@descProduto"].Value = produto.DescProduto;

                comando.Parameters.Add("@idProduto", SqlDbType.Int);
                comando.Parameters["@idProduto"].Value = produto.IdProduto;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new Exception("Erro ao Atualizar Produto \n\n" + E.Message);
            }
        }

        public void DCadastrarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void DDeletarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> DListarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
