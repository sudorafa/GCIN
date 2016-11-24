using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using BibliotecaClasses.xml;
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
        public Solicitacao NCadastrarSolicitacao(Solicitacao solicitacao)
        {
            if (NSalvarSolicitacao(solicitacao) == true)
            {
                return new DSolicitacao().CadastrarSolicitacao(solicitacao);
            }else
            {
                return solicitacao;
            }
        }

        public List<Solicitacao> NListarSolicitacao(Solicitacao solicitacao, string dataInicial, string dataFinal)
        {
            return new DSolicitacao().ListarSolicitacao(solicitacao, dataInicial, dataFinal);
        }

        public Solicitacao NAlterarSolicitacao(Solicitacao solicitacao)
        {
            if (NAtualizarSolicitacao(solicitacao) == true)
            {
                return new DSolicitacao().AtualizarSolicitacao(solicitacao);
            }
            else
            {
                return solicitacao;
            }
        }

        public void NGerarXmlSolicitacao(Solicitacao solicitacao)
        {
            new XSolicitacao().GerarXmlSolicitacao(solicitacao);
        }

        private bool NSalvarSolicitacao(Solicitacao solicitacao)
        {
            if (solicitacao.Detalhe.Equals("") || solicitacao.Detalhe.Length == 0 || solicitacao.Detalhe == null)
            {
                throw new FaultException("Por Favor, Informe Detalhe ! ");
            }
            return true;
        }
        private bool NAtualizarSolicitacao(Solicitacao solicitacao)
        {
            string sql, statusSolicitacao = null;

            try { 
                conexao.abrirConexao();

                sql = "select top 1 statusSolicitacao from Stat where statusSolicitacao <> 'Atualizado' and idSolicitacao = " + solicitacao.IdSolicitacao;
                sql += "order by idStatus desc";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                SqlDataReader DbReader = comando.ExecuteReader();
                while (DbReader.Read())
                {
                    statusSolicitacao = DbReader.GetString(DbReader.GetOrdinal("statusSolicitacao"));
                }
                DbReader.Close();
                comando.Dispose();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Listar statusSolicitacao no NSolicitacao \n\n" + E.Message);
            }
            if (statusSolicitacao.Equals("Cancelado"))
            {
                throw new FaultException("Não Pode "+ solicitacao.Status.StatusSolicitacao + " ! Solicitação Está Cancelado");
            }
            else if (statusSolicitacao.Equals("Em Cotação"))
            {
                throw new FaultException("Não Pode " + solicitacao.Status.StatusSolicitacao + " ! Solicitação Está Cotação");
            }
            else if (statusSolicitacao.Equals("Reprovado"))
            {
                throw new FaultException("Não Pode " + solicitacao.Status.StatusSolicitacao + " ! Solicitação Está Reprovado");
            }

            return true;
        }
    }
}
