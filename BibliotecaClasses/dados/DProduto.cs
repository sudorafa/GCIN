using BibliotecaClasses.faixada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClasses.modelo;
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel;

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
                throw new FaultException("Erro ao Atualizar Produto \n\n" + E.Message);
            }
        }

        public Produto DCadastrarProduto(Produto produto)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "insert into Produto";
                sql += "(descProduto) output Inserted.IdProduto values";
                sql += "(@descProduto)";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@descProduto", SqlDbType.VarChar);
                comando.Parameters["@descProduto"].Value = produto.DescProduto;

                //comando.ExecuteNonQuery();

                produto.IdProduto = (int)comando.ExecuteScalar();

                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Cadastrar Produto \n\n" + E.Message);
            }
            return produto;
        }

        public void DDeletarProduto(Produto produto)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "delete Produto where idProduto = @idProduto";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@idProduto", SqlDbType.Int);
                comando.Parameters["@idProduto"].Value = produto.IdProduto;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Deletar Produto \n\n" + E.Message);
            }
        }

        public List<Produto> DListarProduto(Produto produto)
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                conexao.abrirConexao();
                string sql = "select idProduto, descProduto from Produto where idProduto = idProduto ";
                if (produto.IdProduto > 0)
                {
                    sql += "and idProduto = " + produto.IdProduto;
                }
                if (produto.DescProduto != null && produto.DescProduto.Trim().Equals("") == false)
                {
                    sql += "and descProduto like '%" + produto.DescProduto+ "%'";
                }
                try
                {
                    SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                    SqlDataReader DbReader = comando.ExecuteReader();

                    while (DbReader.Read())
                    {
                        Produto prod = new Produto();
                        prod.IdProduto= DbReader.GetInt32(DbReader.GetOrdinal("idProduto"));
                        prod.DescProduto = DbReader.GetString(DbReader.GetOrdinal("descProduto"));
                        produtos.Add(prod);
                    }
                    DbReader.Close();
                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    throw new FaultException("Pesquisa Listar Produtos sem resultado" + ex.Message);
                }
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Listar Produtos \n\n" + E.Message);
            }
            return produtos;
        }
    }
}
