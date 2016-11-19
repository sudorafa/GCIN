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
