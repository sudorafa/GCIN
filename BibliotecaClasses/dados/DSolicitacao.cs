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
                sql += "(dataSolicitacao, dataPrecisa, dataPrevistaFim, severidade, situacao, detalhe, idProduto) output Inserted.idSolicitacao values";
                sql += "(@dataSolicitacao, @dataPrecisa, @dataPrevistaFim, @severidade, @situacao, @detalhe, @idProduto)";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@dataSolicitacao", SqlDbType.Date);
                comando.Parameters["@dataSolicitacao"].Value = solicitacao.DataSolicitacao;

                comando.Parameters.Add("@dataPrecisa", SqlDbType.Date);
                comando.Parameters["@dataPrecisa"].Value = solicitacao.DataPrecisa;

                comando.Parameters.Add("@dataPrevistaFim", SqlDbType.Date);
                comando.Parameters["@dataPrevistaFim"].Value = solicitacao.DataPrevistaFim;

                comando.Parameters.Add("@severidade", SqlDbType.VarChar);
                comando.Parameters["@severidade"].Value = solicitacao.Severidade;

                comando.Parameters.Add("@situacao", SqlDbType.VarChar);
                comando.Parameters["@situacao"].Value = "Aberta";

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

        public List<Solicitacao> ListarSolicitacao(Solicitacao solicitacao, string dataInicial, string dataFinal)
        {
            List<Solicitacao> solicitacaoes = new List<Solicitacao>();
            string sql, sql2 = "";
            SqlCommand comando;
            try
            {
                conexao.abrirConexao();
                sql = "select distinct s.idSolicitacao, s.dataSolicitacao, s.dataPrecisa, s.severidade, s.detalhe, s.dataPrevistaFim, s.situacao, ";
                sql += "p.descProduto, u.idUsuario, u.nome, pf.descPerfil From Solicitacao as s ";
                sql += "inner join Produto as p on s.idProduto = p.idProduto ";
                sql += "inner join Stat as st on s.idSolicitacao = st.idSolicitacao ";
                sql += "inner join Usuario as u on st.idUsuario = u.idUsuario ";
                sql += "inner join Perfil as pf on u.idPerfil = pf.idPerfil ";
                sql += "where s.idSolicitacao = s.idSolicitacao and st.statusSolicitacao = 'Abertura' ";

                if (solicitacao.IdSolicitacao > 0)
                {
                    sql += "and s.idSolicitacao = @idSolicitacao ";
                    sql2 = "select st.detalheStatus, st.statusSolicitacao, st.dataStatus, u.idUsuario, u.nome from Stat as st ";
                    sql2 += "inner join Usuario as u on st.idUsuario = u.idUsuario ";
                    sql2 += "where idSolicitacao = @idSolicitacao2 ";
                }
                
                if (solicitacao.Status.Usuario.IdUsuario > 0)
                {
                    sql += " and st.idUsuario = @idUsuario ";
                }

                if (dataInicial != null && dataInicial.Trim().Equals("") == false)
                {
                    sql += " and s.dataSolicitacao between @dataInicial and @dataFinal ";
                }   

                if (solicitacao.Situacao != null && solicitacao.Situacao.Trim().Equals("") == false)
                {
                    sql += " and s.situacao = @situacao ";
                }

                if (solicitacao.IdSolicitacao > 0)
                {
                    comando = new SqlCommand(sql + sql2, conexao.sqlConn);
                }
                else
                {
                    comando = new SqlCommand(sql, conexao.sqlConn);
                }

                if (solicitacao.IdSolicitacao > 0)
                {
                    comando.Parameters.Add("@idSolicitacao", SqlDbType.Int);
                    comando.Parameters["@idSolicitacao"].Value = solicitacao.IdSolicitacao;

                    comando.Parameters.Add("@idSolicitacao2", SqlDbType.Int);
                    comando.Parameters["@idSolicitacao2"].Value = solicitacao.IdSolicitacao;
                }

                if (solicitacao.Status.Usuario.IdUsuario > 0)
                {
                    comando.Parameters.Add("@idUsuario", SqlDbType.Int);
                    comando.Parameters["@idUsuario"].Value = solicitacao.Status.Usuario.IdUsuario;
                }

                if (dataInicial != null && dataInicial.Trim().Equals("") == false)
                {
                    comando.Parameters.Add("@dataInicial", SqlDbType.Date);
                    comando.Parameters["@dataInicial"].Value = dataInicial;

                    comando.Parameters.Add("@dataFinal", SqlDbType.Date);
                    comando.Parameters["@dataFinal"].Value = dataFinal;
                }

                if (solicitacao.Situacao != null && solicitacao.Situacao.Trim().Equals("") == false)
                {
                    comando.Parameters.Add("@situacao", SqlDbType.VarChar);
                    comando.Parameters["@situacao"].Value = solicitacao.Situacao;
                }

                SqlDataReader DbReader = comando.ExecuteReader();

                while (DbReader.Read())
                {
                    Solicitacao s = new Solicitacao();
                    s.IdSolicitacao = DbReader.GetInt32(DbReader.GetOrdinal("idSolicitacao"));
                    s.DataSolicitacao = DbReader.GetDateTime(DbReader.GetOrdinal("dataSolicitacao")).ToString();
                    s.DataPrecisa = DbReader.GetDateTime(DbReader.GetOrdinal("dataPrecisa")).ToString();
                    s.Severidade = DbReader.GetString(DbReader.GetOrdinal("severidade"));
                    s.Detalhe = DbReader.GetString(DbReader.GetOrdinal("detalhe"));
                    s.DataPrevistaFim = DbReader.GetDateTime(DbReader.GetOrdinal("dataPrevistaFim")).ToString();
                    s.Produto.DescProduto = DbReader.GetString(DbReader.GetOrdinal("descProduto"));
                    s.Situacao = DbReader.GetString(DbReader.GetOrdinal("situacao"));
                    s.Status.Usuario.IdUsuario = DbReader.GetInt32(DbReader.GetOrdinal("idUsuario"));
                    s.Status.Usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    s.Status.Usuario.Perfil.DescPerfil = DbReader.GetString(DbReader.GetOrdinal("descPerfil"));

                    if (solicitacao.IdSolicitacao > 0)
                    {
                        DbReader.NextResult();

                        while (DbReader.Read())
                        {
                            Status stat = new Status();
                            stat.DetalheStatus = DbReader.GetString(DbReader.GetOrdinal("detalheStatus"));
                            stat.DataStatus = DbReader.GetDateTime(DbReader.GetOrdinal("dataStatus")).ToString();
                            stat.StatusSolicitacao = DbReader.GetString(DbReader.GetOrdinal("statusSolicitacao"));
                            stat.Usuario.IdUsuario = DbReader.GetInt32(DbReader.GetOrdinal("idUsuario"));
                            stat.Usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                            s.ListStatus.Add(stat);
                        }
                    }
                        
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

        public Solicitacao AtualizarSolicitacao(Solicitacao solicitacao)
        {
            try
            {
                if (solicitacao.Status.StatusSolicitacao.Equals("Atualizar"))
                {
                    solicitacao.Situacao = "Aberta";
                    solicitacao.Status.StatusSolicitacao = "Atualizado";
                }
                else if (solicitacao.Status.StatusSolicitacao.Equals("Cancelar"))
                {
                    solicitacao.Situacao = "Finalizada";
                    solicitacao.Status.StatusSolicitacao = "Cancelado";
                }
                else if (solicitacao.Status.StatusSolicitacao.Equals("Reprovar Solicitação"))
                {
                    solicitacao.Situacao = "Finalizada";
                    solicitacao.Status.StatusSolicitacao = "Reprovado";
                }
                else if (solicitacao.Status.StatusSolicitacao.Equals("Aprovar para Cotação"))
                {
                    solicitacao.Situacao = "Aberta";
                    solicitacao.Status.StatusSolicitacao = "Em Cotação";
                }

                conexao.abrirConexao();
                //Solicitação
                string sql = "update Solicitacao set dataPrecisa = @dataPrecisa, dataPrevistaFim = @dataPrevistaFim, severidade = @severidade, situacao = @situacao where idSolicitacao = @idSolicitacao";

                SqlCommand comando = new SqlCommand(sql, conexao.sqlConn);

                comando.Parameters.Add("@dataPrecisa", SqlDbType.Date);
                comando.Parameters["@dataPrecisa"].Value = solicitacao.DataPrecisa;

                comando.Parameters.Add("@dataPrevistaFim", SqlDbType.Date);
                comando.Parameters["@dataPrevistaFim"].Value = solicitacao.DataPrevistaFim;

                comando.Parameters.Add("@severidade", SqlDbType.VarChar);
                comando.Parameters["@severidade"].Value = solicitacao.Severidade;

                comando.Parameters.Add("@situacao", SqlDbType.VarChar);
                comando.Parameters["@situacao"].Value = solicitacao.Situacao;

                comando.Parameters.Add("@idSolicitacao", SqlDbType.Int);
                comando.Parameters["@idSolicitacao"].Value = solicitacao.IdSolicitacao;

                comando.ExecuteNonQuery();
                
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
                throw new FaultException("Erro ao Salvar Alteração da Solicitação \n\n" + E.Message);
            }
            return solicitacao;
        }
    }
}
