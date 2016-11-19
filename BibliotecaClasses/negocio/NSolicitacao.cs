using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.negocio
{
    public class NSolicitacao
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public void NCadastrarSolicitacao(Solicitacao solicitacao)
        {
            if (NSalvarSolicitacao(solicitacao) == true)
            {
                new DSolicitacao().CadastrarSolicitacao(solicitacao);
            }
        }
        
        public Solicitacao NSolicitacaoBuscar(Solicitacao solicitacao)
        {
            try
            {
                conexao.abrirConexao();

                string sql = "select top 1 s.idSolicitacao, s.dataSolicitacao, s.dataPrecisa, s.severidade, s.detalhe, st.detalheStatus, st.dataStatus, st.statusSolicitacao, u.idUsuario, u.nome, p.descProduto From Solicitacao s";
                sql += "inner join Stat as st";
                sql += "on s.idSolicitacao = st.idSolicitacao";
                sql += "inner join Usuario as u";
                sql += "on st.idUsuario = u.idUsuario";
                sql += "inner join Produto as p";
                sql += "on s.idProduto = p.idProduto";
                sql += "where u.idUsuario = " + solicitacao.Status.Usuario.IdUsuario + " and st.statusSolicitacao = 'Aberto' order by s.idSolicitacao desc";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                SqlDataReader DbReader = comando.ExecuteReader();

                while (DbReader.Read())
                {
                    solicitacao.IdSolicitacao= DbReader.GetInt32(DbReader.GetOrdinal("s.idSolicitacao"));
                    solicitacao.DataSolicitacao = DbReader.GetString(DbReader.GetOrdinal("s.dataSolicitacao"));
                    solicitacao.DataPrecisa = DbReader.GetString(DbReader.GetOrdinal("s.dataPrecisa"));
                }
                DbReader.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                throw new FaultException("Erro ao Listar Solicitação \n\n" + ex.Message);
            }
            conexao.fecharConexao();
            return solicitacao;
        }

        private static bool NSalvarSolicitacao(Solicitacao solicitacao)
        {
            if (solicitacao.Detalhe.Equals("") || solicitacao.Detalhe.Length == 0 || solicitacao.Detalhe == null)
            {
                throw new FaultException("Por Favor, Informe Detalhe ! ");
            }
            return true;
        }
        
    }
}
