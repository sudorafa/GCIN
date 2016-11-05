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
            DPerfil dp = new DPerfil();
            if (perfil.IdPerfil == 0)
            {
                if (perfil.DescPerfil.Length == 0 || perfil.DescPerfil.Equals("") || perfil.DescPerfil == null)
                {
                    throw new Exception("Por Favor, Informar Descrição do Perfil !");
                }else
                {
                    dp.DCadastrarPerfil(perfil);
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
                    dp.DAlterarPerfil(perfil);
                }
            }
        }

        public void NDeletarPerfil(Perfil perfil)
        {
            DPerfil dp = new DPerfil();
            if (perfil.IdPerfil == 0 )
            {
                throw new Exception("Por Favor, Escolha um Perfil da Lista Para Deletar !");
            } else
            {
                dp.DDeletarPerfil(perfil);
            }
        }

        
    }
}
