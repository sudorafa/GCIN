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
        public void NCadastrarPerfil(Perfil perfil)
        {
            DPerfil dp = new DPerfil();
            if (perfil.IdPerfil == 0)
            {
                if (perfil.DescPerfil.Length == 0)
                {
                    throw new Exception("Por favor, Informar Perfil !");
                }else
                {
                    dp.DCadastrarPerfil(perfil);
                }
                
            }
            else
            {
                if (perfil.DescPerfil.Length == 0)
                {
                    throw new Exception("Por favor, Informar Perfil !");
                }
                else
                {
                    dp.DAlterarPerfil(perfil);
                }
            }
        }
    }
}
