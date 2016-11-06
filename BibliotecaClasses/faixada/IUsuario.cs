using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.faixada
{
    interface IUsuario
    {
        void CadastrarUsuario(Usuario usuario);
        List<Usuario> ListarUsuario(Usuario usuario);
        void AlterarUsuario(Usuario usuario);
        void DeletarUsuario(Usuario usuario);
    }
}