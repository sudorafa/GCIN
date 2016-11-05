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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            FormUsuarioCadastrar formUsuarioCadastrar = new FormUsuarioCadastrar();
            formUsuarioCadastrar.Show();
        }

        private void buttonVai_Click(object sender, EventArgs e)
        {
            string buscar = textBoxBuscar.Text;
            try
            {
                Usuario usuario = new Usuario();
                usuario.Perfil = new Perfil();

                usuario.Nome = buscar;

                localhost.Service1 service1 = new localhost.Service1();
                service1.UsuarioListar(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
