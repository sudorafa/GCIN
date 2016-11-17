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

            try
            {
                service1.UsuarioLogin(usuario);
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
