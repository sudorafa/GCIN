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
    public class TipoFornecimento
    {
        private int idTipoFornecimento;
        private string descTipoFornecimento;
        
        [DataMember(IsRequired = true)]
        public int IdTipoFornecimento
        {
            get
            {
                return idTipoFornecimento;
            }

            set
            {
                idTipoFornecimento = value;
            }
        }

        [DataMember(IsRequired = true)]
        public string DescTipoFornecimento
        {
            get
            {
                return descTipoFornecimento;
            }

            set
            {
                descTipoFornecimento = value;
            }
        }
    }
}
