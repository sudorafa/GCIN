using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    [Serializable]
    [DataContract()]
    public class Perfil
    {
        private int idPerfil;
        private string descPerfil;
        private List<Usuario> usuarios;

        public Perfil()
        {
            this.usuarios = new List<Usuario>();
        }

        [DataMember(IsRequired = true)]
        public int IdPerfil
        {
            get
            {
                return idPerfil;
            }

            set
            {
                idPerfil = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DescPerfil
        {
            get
            {
                return descPerfil;
            }

            set
            {
                descPerfil = value;
            }
        }

        [DataMember(IsRequired = true)]
        public List<Usuario> Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }
    }
}
