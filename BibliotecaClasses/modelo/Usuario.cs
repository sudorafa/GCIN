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
    public class Usuario
    {
        private int idUsuario;
        private string cpf, login, senha, nome, bloqueio;
        private Perfil perfil;

        public Usuario()
        {
            this.perfil = new Perfil();
        }

        [DataMember(IsRequired = true)]
        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        [DataMember()]
        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }


        [DataMember()]
        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        [DataMember()]
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        [DataMember()]
        public string Bloqueio
        {
            get
            {
                return bloqueio;
            }
            
            set
            {
                bloqueio = value;
            }
        }
        
        [DataMember()]
        public Perfil Perfil
        {
            get
            {
                return perfil;
            }

            set
            {
                perfil = value;
            }
        }

        [DataMember()]
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }
    }
}
