using BibliotecaClasses.faixada;
using BibliotecaClasses.modelo;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ServiceModel;

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
                throw new FaultException("Erro ao Cadastrar Usuário \n\n" + E.Message);
            }
        }

        public List<Usuario> ListarUsuario(Usuario usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conexao.abrirConexao();
                string sql = "select u.idUsuario, u.nome, u.cpf, u.usuario, u.senha, u.bloqueio, p.descPerfil ";
                sql += "from Usuario as u ";
                sql += "inner join Perfil as p on ";
                sql += "u.idPerfil = p.idPerfil ";
                sql += "where u.idPerfil = p.idPerfil ";

                if (usuario.IdUsuario > 0)
                {
                    sql += "and u.idUsuario = @idUsuario" ;
                }
                if (usuario.Nome != null && usuario.Nome.Trim().Equals("") == false)
                {
                    sql += "and u.nome like %@nome% ";
                }
                if (usuario.Login != null && usuario.Login.Trim().Equals("") == false)
                {
                    sql += "and u.usuario = @usuario ";
                }
                if (usuario.Senha != null && usuario.Senha.Trim().Equals("") == false)
                {
                    sql += "and u.senha = @senha ";
                }

                try
                {
                    SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                    if (usuario.IdUsuario > 0)
                    {
                        comando.Parameters.Add("@idUsuario", SqlDbType.Int);
                        comando.Parameters["@idUsuario"].Value = usuario.IdUsuario;
                    }
                    if (usuario.Nome != null && usuario.Nome.Trim().Equals("") == false)
                    {
                        comando.Parameters.Add("@nome", SqlDbType.VarChar);
                        comando.Parameters["@nome"].Value = usuario.Nome;
                    }
                    if (usuario.Login != null && usuario.Login.Trim().Equals("") == false)
                    {
                        comando.Parameters.Add("@usuario", SqlDbType.VarChar);
                        comando.Parameters["@usuario"].Value = usuario.Login;
                    }
                    if (usuario.Senha != null && usuario.Senha.Trim().Equals("") == false)
                    {
                        comando.Parameters.Add("@senha", SqlDbType.VarChar);
                        comando.Parameters["@senha"].Value = usuario.Senha;
                    }

                    SqlDataReader DbReader = comando.ExecuteReader();

                    while (DbReader.Read())
                    {
                        Usuario user = new Usuario();
                        user.IdUsuario = DbReader.GetInt32(DbReader.GetOrdinal("idUsuario"));
                        user.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                        user.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                        user.Login = DbReader.GetString(DbReader.GetOrdinal("usuario"));
                        user.Senha = DbReader.GetString(DbReader.GetOrdinal("senha"));
                        user.Bloqueio = DbReader.GetString(DbReader.GetOrdinal("bloqueio"));
                        user.Perfil.DescPerfil = DbReader.GetString(DbReader.GetOrdinal("descPerfil"));
                        usuarios.Add(user);
                    }
                    conexao.fecharConexao();
                }
                catch (Exception ex)
                {
                    throw new FaultException("Pesquisa BuscaUsuario sem resultado \n\n" + ex.Message);
                }
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Buscar Usuário \n\n" + E.Message);
            }

            return usuarios;
        }

        public void AlterarUsuario(Usuario usuario)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "update Usuario set nome = @nome, cpf = @cpf, usuario = @usuario, senha = @senha, bloqueio = @bloqueio, idPerfil = @idPerfil where idUsuario = @idUsuario";

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

                comando.Parameters.Add("@idUsuario", SqlDbType.Int);
                comando.Parameters["@idUsuario"].Value = usuario.IdUsuario;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Atualizar Usuário \n\n" + E.Message);
            }
        }

        public void DeletarUsuario(Usuario usuario)
        {
            try
            {
                conexao.abrirConexao();
                string sql = "delete Usuario where idUsuario = @idUsuario";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@idUsuario", SqlDbType.Int);
                comando.Parameters["@idUsuario"].Value = usuario.IdUsuario;

                comando.ExecuteNonQuery();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Deletar Usu´rio \n\n" + E.Message);
            }
        }
    }
}
