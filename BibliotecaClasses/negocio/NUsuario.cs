﻿using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.negocio
{
    public class NUsuario
    {

        public void NCadastrarUsuario(Usuario usuario)
        {
            if (NSalvarUsuario(usuario) == true && NCpfBanco(usuario) == true && NLoginBanco(usuario) == true)
            {
                new DUsuario().CadastrarUsuario(usuario);
            }
        }

        public List<Usuario> NListarUsuario(Usuario usuario)
        {
            return new DUsuario().ListarUsuario(usuario);
        }

        public void NAlterarUsuario(Usuario usuario)
        {
            if (NSalvarUsuario(usuario) == true && NCpfBanco(usuario) == true && NLoginBanco(usuario) == true)
            {
                new DUsuario().AlterarUsuario(usuario);
            }
        }

        public void NDeletarUsuario(Usuario usuario)
        {
            new DUsuario().DeletarUsuario(usuario);
        }
        
        private static bool NSalvarUsuario(Usuario usuario)
        {
            if (usuario.Nome.Equals("") || usuario.Nome.Length == 0 || usuario.Nome == null)
            {
                throw new Exception("Por Favor, Informe Nome ! ");
            }
            else if (ValidaCPF(usuario.Cpf) == false)
            {
                throw new Exception("Por Favor, Informe Cpf Válido ! ");
            }
            else if (usuario.Login.Equals("") || usuario.Login.Length == 0 || usuario.Login == null)
            {
                throw new Exception("Por Favor, Informe Login ! ");
            }
            else if (usuario.Senha.Equals("") || usuario.Senha.Length == 0 || usuario.Senha == null)
            {
                throw new Exception("Por Favor, Informe Senha ! ");
            }
            return true;
        }
        
        private static bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;
            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;
            if (igual || valor == "12345678909")
                return false;
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
            valor[i].ToString());
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];
            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];
            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                    return false;
            return true;
        }

        private static bool NCpfBanco(Usuario usuario)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            conexao.abrirConexao();
            string cpfAqui = "";
            string sql = "select cpf from Usuario where cpf = cpf ";

            if (usuario.IdUsuario > 0)
            {
                sql += "and idUsuario <> " + usuario.IdUsuario + " and cpf = '" + usuario.Cpf + "'";
            }
            else
            {
                sql += "and cpf = '" + usuario.Cpf + "'";
            }
            
            SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
            SqlDataReader DbReader = comando.ExecuteReader();

            while (DbReader.Read())
            {
                cpfAqui = DbReader.GetString(DbReader.GetOrdinal("cpf"));
            }

            
            if(usuario.Cpf == cpfAqui)
            {
                throw new Exception("Cpf Já Cadastrado ! ");
            }
               
            conexao.fecharConexao();
            return true;
        }

        private static bool NLoginBanco(Usuario usuario)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            conexao.abrirConexao();
            string usuarioAqui = "";
            string sql = "select usuario from Usuario where usuario = usuario ";
            if (usuario.IdUsuario > 0)
            {
                sql += "and idUsuario <> " + usuario.IdUsuario + " and usuario = '" + usuario.Login + "'";
            }
            else
            {
                sql += "and usuario = '" + usuario.Login + "'";
            }

            SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
            SqlDataReader DbReader = comando.ExecuteReader();

            while (DbReader.Read())
            {
                usuarioAqui = DbReader.GetString(DbReader.GetOrdinal("usuario"));
            }
            
            if (usuario.Login == usuarioAqui)
            {
                throw new Exception("Usuario(Login) Já Existe ! ");
            }

            conexao.fecharConexao();
            return true;
        }

        public bool NLogin(Usuario usuario)
        {
            NListarUsuario(usuario);

            if (NListarUsuario(usuario).Count() == 1)
            {
                //colocar objeto trazido aqui

                if (usuario.Bloqueio.Equals("sim"))
                {
                    throw new Exception("Usuário Bloqueado ! ");
                }
            }
            else
            {
                throw new Exception("Usuário Não Existe ! ");
            }
            return true;
        }

    }
}