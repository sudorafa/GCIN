﻿using BibliotecaClasses.faixada;
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
                sql += "(dataSolicitacao, dataPrecisa, dataPrevistaFim, severidade, detalhe, statusSolicitacao, idProduto) output Inserted.idSolicitacao values";
                sql += "(@dataSolicitacao, @dataPrecisa, @dataPrevistaFim, @severidade, @detalhe, @statusSolicitacao, @idProduto)";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@dataSolicitacao", SqlDbType.Date);
                comando.Parameters["@dataSolicitacao"].Value = solicitacao.DataSolicitacao;

                comando.Parameters.Add("@dataPrecisa", SqlDbType.Date);
                comando.Parameters["@dataPrecisa"].Value = solicitacao.DataPrecisa;

                comando.Parameters.Add("@dataPrevistaFim", SqlDbType.Date);
                comando.Parameters["@dataPrevistaFim"].Value = solicitacao.DataPrevistaFim;

                comando.Parameters.Add("@severidade", SqlDbType.VarChar);
                comando.Parameters["@severidade"].Value = solicitacao.Severidade;

                comando.Parameters.Add("@statusSolicitacao", SqlDbType.VarChar);
                comando.Parameters["@statusSolicitacao"].Value = solicitacao.StatusSolicitacao;

                comando.Parameters.Add("@detalhe", SqlDbType.VarChar);
                comando.Parameters["@detalhe"].Value = solicitacao.Detalhe;

                comando.Parameters.Add("@idProduto", SqlDbType.Int);
                comando.Parameters["@idProduto"].Value = solicitacao.Produto.IdProduto;
                
                //idSolicitação cadastrado acima:
                solicitacao.IdSolicitacao = (int)comando.ExecuteScalar();
                
                //Status:
                string sql2 = "insert into Stat";
                sql2 += "(detalheStatus, dataStatus, idSolicitacao, idUsuario) values";
                sql2 += "(@detalheStatus, @dataStatus, @idSolicitacao, @idUsuario)";

                SqlCommand comando2 = new SqlCommand(sql2, conexao.sqlConn);

                comando2.Parameters.Add("@detalheStatus", SqlDbType.VarChar);
                comando2.Parameters["@detalheStatus"].Value = solicitacao.Status.DetalheStatus;

                comando2.Parameters.Add("@dataStatus", SqlDbType.Date);
                comando2.Parameters["@dataStatus"].Value = solicitacao.Status.DataStatus;
                
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

        public List<Solicitacao> ListarSolicitacao(Solicitacao solicitacao, string dataInicial, string dataFinal)
        {
            List<Solicitacao> solicitacaoes = new List<Solicitacao>();
            try
            {
                conexao.abrirConexao();
                string sql = "select s.idSolicitacao, s.dataSolicitacao, s.dataPrecisa, s.severidade, s.detalhe, s.statusSolicitacao, s.dataPrevistaFim, ";
                sql += "p.descProduto, st.detalheStatus, st.dataStatus, u.idUsuario, u.nome From Solicitacao as s ";
                sql += "inner join Produto as p on s.idProduto = p.idProduto ";
                sql += "inner join Stat as st on s.idSolicitacao = st.idSolicitacao ";
                sql += "inner join Usuario as u on st.idUsuario = u.idUsuario ";
                sql += "where s.idSolicitacao = s.idSolicitacao ";

                if (solicitacao.IdSolicitacao > 0)
                {
                    sql += "and s.idSolicitacao = " + solicitacao.IdSolicitacao;
                }
                if (solicitacao.Status.Usuario.IdUsuario > 0)
                {
                    sql += " and st.idUsuario = " + solicitacao.Status.Usuario.IdUsuario;
                }

                sql += " and s.dataSolicitacao between '" + dataInicial + "' and '" + dataFinal + "'";

                if (solicitacao.StatusSolicitacao != null && solicitacao.StatusSolicitacao.Trim().Equals("") == false)
                {
                    sql += " and s.statusSolicitacao = '" + solicitacao.StatusSolicitacao + "'";
                }

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);
                SqlDataReader DbReader = comando.ExecuteReader();

                while (DbReader.Read())
                {
                    Solicitacao s = new Solicitacao();
                    s.IdSolicitacao = DbReader.GetInt32(DbReader.GetOrdinal("idSolicitacao"));
                    s.DataSolicitacao = DbReader.GetDateTime(DbReader.GetOrdinal("dataSolicitacao")).ToString();
                    s.DataPrecisa = DbReader.GetDateTime(DbReader.GetOrdinal("dataPrecisa")).ToString();
                    s.Severidade = DbReader.GetString(DbReader.GetOrdinal("severidade"));
                    s.Detalhe = DbReader.GetString(DbReader.GetOrdinal("detalhe"));
                    s.StatusSolicitacao = DbReader.GetString(DbReader.GetOrdinal("statusSolicitacao"));
                    s.DataPrevistaFim = DbReader.GetDateTime(DbReader.GetOrdinal("dataPrevistaFim")).ToString();
                    s.Produto.DescProduto = DbReader.GetString(DbReader.GetOrdinal("descProduto"));
                    s.Status.DetalheStatus = DbReader.GetString(DbReader.GetOrdinal("detalheStatus"));
                    s.Status.DataStatus = DbReader.GetDateTime(DbReader.GetOrdinal("dataStatus")).ToString();
                    s.Status.Usuario.IdUsuario = DbReader.GetInt32(DbReader.GetOrdinal("idUsuario"));
                    s.Status.Usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    solicitacaoes.Add(s);
                }
                DbReader.Close();
                comando.Dispose();
                conexao.fecharConexao();
            }
            catch (Exception E)
            {
                throw new FaultException("Erro ao Listar Solicitações \n\n" + E.Message);
            }
            return solicitacaoes;
        }
    }
}
