using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class MenssagemValidaErro
    {
        public string MensagemValidaErro(string erro)
        {
            string erroValido = erro;
            string[] vetor = erro.Split(':');

            int index = vetor[2].IndexOf("\n");
            erroValido = vetor[2].Substring(0, index);

            return erroValido;
        }
    }
}
