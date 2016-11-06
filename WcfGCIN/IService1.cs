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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // TODO: Add your service operations here

        //USUARIO
        [OperationContract]
        void UsuarioCadastrar(Usuario usuario);
        
        [OperationContract]
        List<Usuario> UsuarioListar(Usuario usuario);

        [OperationContract]
        void UsuarioAlterar(Usuario usuario);

        [OperationContract]
        void UsuarioDeletar(Usuario usuario);

        /*-------------------------------  Perfil -------------------------------------------- */
        [OperationContract]
        List<Perfil> PerfilListar();

        [OperationContract]
        void PerfilCadastrarAlterar(Perfil perfil);

        [OperationContract]
        void PerfilDeletar(Perfil perfil);
        /*-------------------------------  Perfil -------------------------------------------- */
    }
}
