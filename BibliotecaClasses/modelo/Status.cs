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
        private string detalheStatus, statusSolicitacao, dataStatus;
        private Solicitacao solicitacao;

        public Status()
        {
            this.Solicitacao = new Solicitacao();
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
        public Solicitacao Solicitacao
        {
            get
            {
                return solicitacao;
            }

            set
            {
                solicitacao = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string StatusSolicitacao
        {
            get
            {
                return statusSolicitacao;
            }

            set
            {
                statusSolicitacao = value;
            }
        }
    }
}
