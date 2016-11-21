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
    public class Status
    {
        private string detalheStatus, dataStatus;
        private Usuario usuario;

        public Status()
        {
            this.usuario = new Usuario();
        }

        [DataMember(IsRequired = true)]
        public string DataStatus
        {
            get
            {
                return dataStatus;
            }

            set
            {
                dataStatus = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DetalheStatus
        {
            get
            {
                return detalheStatus;
            }

            set
            {
                detalheStatus = value;
            }
        }
        
        [DataMember(IsRequired = true)]
        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }
    }
}
