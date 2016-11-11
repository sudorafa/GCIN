using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaClasses.dados
{
    public class ConexaoBanco
    {
        public SqlConnection sqlConn;
        //Meu Note
        /*
        private const string local = "LAPTOP-J74C8P11\\RAFAEL";
        private const string banco = "GCIN";
        private const string usuario = "rafa";
        private const string senha = "2016";
        */

        //Unibratec
        private const string local = "PC-058";
        private const string banco = "GCIN";
        private const string usuario = "aluno";
        private const string senha = "aluno";

        string connectionStringSqlServer = @"Data Source=" + local + ";Initial Catalog=" + banco + ";UId=" + usuario + ";Password=" + senha + ";";

        public void abrirConexao()
        {
            this.sqlConn = new SqlConnection(connectionStringSqlServer);
            this.sqlConn.Open();
        }

        public void fecharConexao()
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }
    }
}