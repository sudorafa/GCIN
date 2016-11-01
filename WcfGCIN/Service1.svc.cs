using BibliotecaClasses.dados;
using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfGCIN
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Usuario

        public void UsuarioCadastrar(Usuario usuario)
        {
            try
            {
                new DUsuario().CadastrarUsuario(usuario);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Cadastrar Usuário " + e.Message);
            }
        }

        public Usuario UsuarioBuscar(Usuario usuario)
        {
            try
            {
                DUsuario du = new DUsuario();
                usuario = du.BuscarUsuario(usuario);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Buscar Usuário " + e.Message);
            }
            return usuario;
        }

        //Perfil

        public List<Perfil> PerfilListar()
        {
            DPerfil dp = new DPerfil();
            List<Perfil> perfis = dp.ListarPerfil();
                        
            return perfis;
        }
        
    }
}
