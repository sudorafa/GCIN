using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.negocio
{
    public class NPerfil
    {
        public void NCadastrarAlterarPerfil(Perfil perfil)
        {
            if (perfil.IdPerfil == 0)
            {
                if (perfil.DescPerfil.Length == 0 || perfil.DescPerfil.Equals("") || perfil.DescPerfil == null)
                {
                    throw new Exception("Por Favor, Informar Descrição do Perfil !");
                }else
                {
                    new DPerfil().DCadastrarPerfil(perfil);
                }
            }
            else
            {
                if (perfil.DescPerfil.Length == 0 || perfil.DescPerfil.Equals("") || perfil.DescPerfil == null)
                {
                    throw new Exception("Por Favor, Informar Descrição do Perfil !");
                }
                else
                {
                    new DPerfil().DAlterarPerfil(perfil);
                }
            }
        }

        public void NDeletarPerfil(Perfil perfil)
        {
            if (perfil.IdPerfil == 0 )
            {
                throw new Exception("Por Favor, Escolha um Perfil da Lista Para Deletar !");
            } else
            {
                new DPerfil().DDeletarPerfil(perfil);
            }
        }

        public List<Perfil> NListarPerfil()
        {
            return new DPerfil().DListarPerfil();
        }
    }
}
