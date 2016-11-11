using GUI.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin : Form
    {
        public Usuario usuario = new Usuario();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Service1 service1 = new localhost.Service1();
     
            usuario.Login = textBoxLogin.Text;
            usuario.Senha = textBoxSenha.Text;

            service1.UsuarioListar(usuario);

            if (service1.UsuarioListar(usuario).Count() == 1)
            {
                this.DialogResult = DialogResult.OK;
                foreach(Usuario u in service1.UsuarioListar(usuario))
                {
                    usuario = u;
                }
                
                this.Dispose();

            } else
            {
                MessageBox.Show("Acesso Negado !");
            }
        }
    }
}
