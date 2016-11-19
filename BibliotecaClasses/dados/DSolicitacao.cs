using BibliotecaClasses.faixada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClasses.modelo;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaClasses.dados
{
    public class DSolicitacao : ISolicitacao
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public Solicitacao CadastrarSolicitacao(Solicitacao solicitacao)
        {
            try
            {
                conexao.abrirConexao();
                //Solicitação
                string sql = "insert into Solicitacao";
                sql += "(dataSolicitacao, dataPrecisa, severidade, detalhe, idProduto) output Inserted.idSolicitacao values";
                sql += "(@dataSolicitacao, @dataPrecisa, @severidade, @detalhe, @idProduto)";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@dataSolicitacao", SqlDbType.Date);
                comando.Parameters["@dataSolicitacao"].Value = solicitacao.DataSolicitacao;

                comando.Parameters.Add("@dataPrecisa", SqlDbType.Date);
                comando.Parameters["@dataPrecisa"].Value = solicitacao.DataPrecisa;

                comando.Parameters.Add("@severidade", SqlDbType.VarChar);
                comando.Parameters["@severidade"].Value = solicitacao.Severidade;

                comando.Parameters.Add("@detalhe", SqlDbType.VarChar);
                comando.Parameters["@detalhe"].Value = solicitacao.Detalhe;

                comando.Parameters.Add("@idProduto", SqlDbType.Int);
                comando.Parameters["@idProduto"].Value = solicitacao.Produto.IdProduto;
                
                //idSolicitação cadastrado acima:
                solicitacao.IdSolicitacao = (int)comando.ExecuteScalar();
                
                //Status:
                string sql2 = "insert into Stat";
                sql2 += "(detalheStatus, dataStatus, statusSolicitacao, idSolicitacao, idUsuario) values";
                sql2 += "(@detalheStatus, @dataStatus, @statusSolicitacao, @idSolicitacao, @idUsuario)";

                SqlCommand comando2 = new SqlCommand(sql2, conexao.sqlConn);

                comando2.Parameters.Add("@detalheStatus", SqlDbType.VarChar);
                comando2.Parameters["@detalheStatus"].Value = solicitacao.Status.DetalheStatus;

                comando2.Parameters.Add("@dataStatus", SqlDbType.Date);
                comando2.Parameters["@dataStatus"].Value = solicitacao.Status.DataStatus;

                comando2.Parameters.Add("@statusSolicitacao", SqlDbType.VarChar);
                comando2.Parameters["@statusSolicitacao"].Value = solicitacao.Status.StatusSolicitacao;

                comando2.Parameters.Add("@idSolicitacao", SqlDbType.Int);
                comando2.Parameters["@idSolicitacao"].Value = solicitacao.IdSolicitacao;

                comando2.Parameters.Add("@idUsuario", SqlDbType.Int);
                comando2.Parameters["@idUsuario"].Value = solicitacao.Status.Usuario.IdUsuario;

                comando2.ExecuteNonQuery();

                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Cadastrar Solicitação \n\n" + E.Message);
            }
            return solicitacao;
        }
    }
}
