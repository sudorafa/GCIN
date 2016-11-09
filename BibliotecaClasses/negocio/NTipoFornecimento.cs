using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.negocio
{
    public class NTipoFornecimento
    {
        public void NCadastrarAlterarTipoFornecimento(TipoFornecimento tipoFornecimento)
        {
            if (tipoFornecimento.IdTipoFornecimento == 0)
            {
                if (tipoFornecimento.DescTipoFornecimento.Length == 0 || tipoFornecimento.DescTipoFornecimento.Equals("") || tipoFornecimento.DescTipoFornecimento == null)
                {
                    throw new Exception("Por Favor, Informar Descrição do Tipo de Fornecimento !");
                }else
                {
                    new DTipoFornecimento().DCadastrarTipoFornecimento(tipoFornecimento);
                }
            }
            else
            {
                if (tipoFornecimento.DescTipoFornecimento.Length == 0 || tipoFornecimento.DescTipoFornecimento.Equals("") || tipoFornecimento.DescTipoFornecimento == null)
                {
                    throw new Exception("Por Favor, Informar Descrição do Tipo de Fornecimento !");
                }
                else
                {
                    new DTipoFornecimento().DAlterarTipoFornecimento(tipoFornecimento);
                }
            }
        }

        public void NDeletarTipoFornecimento(TipoFornecimento tipoFornecimento)
        {
            if (tipoFornecimento.IdTipoFornecimento == 0 )
            {
                throw new Exception("Por Favor, Escolha um Tipo de Fornecimento da Lista Para Deletar !");
            } else
            {
                new DTipoFornecimento().DDeletarTipoFornecimento(tipoFornecimento);
            }
        }

        public List<TipoFornecimento> NListarTipoFornecimento()
        {
            return new DTipoFornecimento().DListarTipoFornecimento();
        }
    }
}
