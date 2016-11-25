using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BibliotecaClasses.xml
{
    public class XSolicitacao
    {
        //Meu Note
        //string caminho = "C:\\Users\\o Rafa\\Source\\Repos\\GCIN\\xml gerados\\solicitacao";

        //Unibratec
        string caminho = "C:\\Users\\aluno\\Source\\Repos\\GCIN\\xml gerados\\solicitacao";

        //Meu PC
        //string caminho = "C:\\Users\\ORAFA-PC\\Source\\Repos\\GCIN\\xml gerados\\solicitacao";

        public void GerarXmlSolicitacao(Solicitacao solicitacao)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlNode raiz = doc.CreateElement("GCIN");
                doc.AppendChild(raiz);
                doc.Save(caminho + "_" + solicitacao.IdSolicitacao + ".xml");
                //MessageBox.Show("Não existe, criei");
            }
            catch (Exception ex)
            {
                throw new FaultException("Erro Ao Criar Arquivo Xml De Solicitação\n\n" + ex.Message);
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(caminho + "_" + solicitacao.IdSolicitacao + ".xml");

                XmlNode linha, id, usuario, nome, perfil, data, dataAbertura, dataDesejada, dataPrevista, /*fornecimento,*/ produto, severidade, status;

                linha = doc.CreateElement("solicitacao");
                id = doc.CreateElement("id");
                usuario = doc.CreateElement("usuario");
                nome = doc.CreateElement("nome");
                perfil = doc.CreateElement("perfil");
                data = doc.CreateElement("data");
                dataAbertura = doc.CreateElement("dataAbertura");
                dataDesejada = doc.CreateElement("dataDesejada");
                dataPrevista = doc.CreateElement("dataPrevista");
                //Fornecedor
                produto = doc.CreateElement("produto");
                severidade = doc.CreateElement("severidade");
                status = doc.CreateElement("status");

                id.InnerText = solicitacao.IdSolicitacao+"";
                nome.InnerText = solicitacao.Status.Usuario.Nome;
                perfil.InnerText = solicitacao.Status.Usuario.Perfil.DescPerfil;
                dataAbertura.InnerText = solicitacao.DataSolicitacao;
                dataDesejada.InnerText = solicitacao.DataPrecisa;
                dataPrevista.InnerText = solicitacao.DataPrevistaFim;
                //Fornecedor
                produto.InnerText = solicitacao.Produto.DescProduto;
                severidade.InnerText = solicitacao.Severidade;
                status.InnerText = solicitacao.Situacao;

                usuario.AppendChild(nome);
                usuario.AppendChild(perfil);
                data.AppendChild(dataAbertura);
                data.AppendChild(dataDesejada);
                data.AppendChild(dataPrevista);
                linha.AppendChild(id);
                linha.AppendChild(usuario);
                linha.AppendChild(data);
                //Linha.AppendChild(fornecimento);
                linha.AppendChild(produto);
                linha.AppendChild(severidade);
                linha.AppendChild(status);

                doc.SelectSingleNode("/GCIN").AppendChild(linha);
                doc.Save(caminho + "_" + solicitacao.IdSolicitacao + ".xml");
            }
            catch (Exception ex)
            {
                throw new FaultException("Erro Ao Gerar Dados no Xml De Solicitação\n\n" + ex.Message);
            }
        }
    }
}
