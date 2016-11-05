using BibliotecaClasses.faixada;
using BibliotecaClasses.modelo;
using System;
using System.Data;
using System.Data.SqlClient;
            
namespace BibliotecaClasses.dados
{
    public class DUsuario : IUsuario
    {

        ConexaoBanco conexao = new ConexaoBanco();

        public void CadastrarUsuario(Usuario usuario)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "insert into Usuario";
                sql += "(nome, cpf, usuario, senha, bloqueio, idPerfil) values";
                sql += "(@nome, @cpf, @usuario, @senha, @bloqueio, @idPerfil)";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@nome", SqlDbType.VarChar);
                comando.Parameters["@nome"].Value = usuario.Nome;

                comando.Parameters.Add("@cpf", SqlDbType.VarChar);
                comando.Parameters["@cpf"].Value = usuario.Cpf;

                comando.Parameters.Add("@usuario", SqlDbType.VarChar);
                comando.Parameters["@usuario"].Value = usuario.Login;

                comando.Parameters.Add("@senha", SqlDbType.VarChar);
                comando.Parameters["@senha"].Value = usuario.Senha;

                comando.Parameters.Add("@bloqueio", SqlDbType.VarChar);
                comando.Parameters["@bloqueio"].Value = usuario.Bloqueio;

                comando.Parameters.Add("@idPerfil", SqlDbType.Int);
                comando.Parameters["@idPerfil"].Value = usuario.Perfil.IdPerfil;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new Exception("Erro ao Cadastrar Usuário " + E.Message);
            }
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "select u.idUsuario, u.nome, u.cpf, u.usuario, u.senha, u.bloqueio, p.descPerfil ";
                sql += "from Usuario as u ";
                sql += "inner join Perfil as p on ";
                sql += "u.idPerfil = p.idPerfil ";
                
                //temp
                sql += "where u.idUsuario = 1006";
                
                if (usuario.IdUsuario > 0)
                {
                    //sql += "where u.idUsuario = " + usuario.IdUsuario;
                }
                
                try
                {
                    SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                    SqlDataReader DbReader = comando.ExecuteReader();

                    while (DbReader.Read())
                    {
                        usuario.IdUsuario = DbReader.GetInt32(DbReader.GetOrdinal("idUsuario"));
                        usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                        usuario.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                        usuario.Login = DbReader.GetString(DbReader.GetOrdinal("usuario"));
                        usuario.Senha = DbReader.GetString(DbReader.GetOrdinal("senha"));
                        usuario.Bloqueio = DbReader.GetString(DbReader.GetOrdinal("bloqueio"));
                        usuario.Perfil.DescPerfil = DbReader.GetString(DbReader.GetOrdinal("descPerfil"));
                    }
                    conexao.fecharConexao();
                }
                catch (Exception ex)
                {
                    throw new Exception("Pesquisa BuscaUsuario sem resultado" + ex.Message);
                }
            }
            catch (Exception E)
            {
                throw new Exception("Erro ao Buscar Usuário " + E.Message);
            }

            return usuario;
        }
    }
}
