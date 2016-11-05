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
    public class DPerfil : IPerfil
    {
        ConexaoBanco conexao = new ConexaoBanco();

        public void DAlterarPerfil(Perfil perfil)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "update Perfil set descPerfil = @descPerfil where idPerfil = @idPerfil";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                
                comando.Parameters.Add("@descPerfil", SqlDbType.VarChar);
                comando.Parameters["@descPerfil"].Value = perfil.DescPerfil;

                comando.Parameters.Add("@idPerfil", SqlDbType.Int);
                comando.Parameters["@idPerfil"].Value = perfil.IdPerfil;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new Exception("Erro ao Atualizar Perfil " + E.Message);
            }
        }

        public void DCadastrarPerfil(Perfil perfil)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "insert into Perfil";
                sql += "(descPerfil) values";
                sql += "(@descPerfil)";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@descPerfil", SqlDbType.VarChar);
                comando.Parameters["@descPerfil"].Value = perfil.DescPerfil;
                
                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new Exception("Erro ao Cadastrar Perfil " + E.Message);
            }
        }

        public void DDeletarPerfil(Perfil perfil)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "delete Perfil where idPerfil = @idPerfil";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@idPerfil", SqlDbType.Int);
                comando.Parameters["@idPerfil"].Value = perfil.IdPerfil;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new Exception("Erro ao Deletar Perfil " + E.Message);
            }
        }

        public List<Perfil> DListarPerfil()
        {
            List<Perfil> perfis = new List<Perfil>();
            try
            {
                conexao.abrirConexao();
                string sql = "select idPerfil, descPerfil from Perfil";
                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                SqlDataReader DbReader = comando.ExecuteReader();
                try
                {
                    while (DbReader.Read())
                    {
                        Perfil perfil = new Perfil();
                        perfil.IdPerfil = DbReader.GetInt32(DbReader.GetOrdinal("idPerfil"));
                        perfil.DescPerfil = DbReader.GetString(DbReader.GetOrdinal("descPerfil"));
                        perfis.Add(perfil);
                    }
                    DbReader.Close();
                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    throw new Exception("Pesquisa ListarPerfil sem resultado" + ex.Message);
                }
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new Exception("Erro ao Listar Perfil " + E.Message);
            }
            return perfis;
        }
    }
}
