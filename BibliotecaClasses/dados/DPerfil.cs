using BibliotecaClasses.faixada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClasses.modelo;
using System.Data.SqlClient;

namespace BibliotecaClasses.dados
{
    public class DPerfil : IPerfil
    {
        ConexaoBanco conexao = new ConexaoBanco();

        public void DAlterarPerfil(Perfil perfil)
        {
            
        }

        public void DCadastrarPerfil(Perfil perfil)
        {
            
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
                    Perfil perfil = new Perfil();
                    while (DbReader.Read())
                    {
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
