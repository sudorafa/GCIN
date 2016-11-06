using BibliotecaClasses.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.faixada
{
    interface IPerfil
    {
        List<Perfil> DListarPerfil();
        void DDeletarPerfil(Perfil perfil);
        void DCadastrarPerfil(Perfil perfil);
        void DAlterarPerfil(Perfil perfil);
    }
}
