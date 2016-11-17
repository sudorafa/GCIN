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
    public class DTipoFornecimento : ITipoFornecimento
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public void DAlterarTipoFornecimento(TipoFornecimento tipoFornecimento)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "update TipoFornecimento set descTipoFornecimento = @descTipoFornecimento where idTipoFornecimento = @idTipoFornecimento";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                
                comando.Parameters.Add("@descTipoFornecimento", SqlDbType.VarChar);
                comando.Parameters["@descTipoFornecimento"].Value = tipoFornecimento.DescTipoFornecimento;

                comando.Parameters.Add("@idTipoFornecimento", SqlDbType.Int);
                comando.Parameters["@idTipoFornecimento"].Value = tipoFornecimento.IdTipoFornecimento;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Atualizar Tipo Fornecimento \n\n" + E.Message);
            }
        }

        public void DCadastrarTipoFornecimento(TipoFornecimento tipoFornecimento)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "insert into TipoFornecimento";
                sql += "(descTipoFornecimento) values";
                sql += "(@descTipoFornecimento)";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@descTipoFornecimento", SqlDbType.VarChar);
                comando.Parameters["@descTipoFornecimento"].Value = tipoFornecimento.DescTipoFornecimento;
                
                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Cadastrar Tipo Fornecimento \n\n" + E.Message);
            }
        }

        public void DDeletarTipoFornecimento(TipoFornecimento tipoFornecimento)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "delete TipoFornecimento where idTipoFornecimento = @idTipoFornecimento";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@idTipoFornecimento", SqlDbType.Int);
                comando.Parameters["@idTipoFornecimento"].Value = tipoFornecimento.IdTipoFornecimento;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Deletar Tipo Fornecimento \n\n" + E.Message);
            }
        }

        public List<TipoFornecimento> DListarTipoFornecimento()
        {
            List<TipoFornecimento> tiposFornecimentos = new List<TipoFornecimento>();
            try
            {
                conexao.abrirConexao();
                string sql = "select idTipoFornecimento, descTipoFornecimento from TipoFornecimento";
                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                SqlDataReader DbReader = comando.ExecuteReader();
                try
                {
                    while (DbReader.Read())
                    {
                        TipoFornecimento tipoFornecimento = new TipoFornecimento();
                        tipoFornecimento.IdTipoFornecimento = DbReader.GetInt32(DbReader.GetOrdinal("idTipoFornecimento"));
                        tipoFornecimento.DescTipoFornecimento = DbReader.GetString(DbReader.GetOrdinal("descTipoFornecimento"));
                        tiposFornecimentos.Add(tipoFornecimento);
                    }
                    DbReader.Close();
                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    throw new FaultException("Pesquisa Listar Tipo Fornecimento sem resultado" + ex.Message);
                }
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Listar Tipo Fornecimento \n\n" + E.Message);
            }
            return tiposFornecimentos;
        }
    }
}
