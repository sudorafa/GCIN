using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.modelo
{
    public class Status
    {
        private string detalheStatus, statusSolicitacao, dataStatus;
        private Solicitacao solicitacao;

        public Status()
        {
            this.Solicitacao = new Solicitacao();
        }

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
