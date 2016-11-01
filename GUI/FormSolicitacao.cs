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
    public partial class FormSolicitacao : Form
    {
        public FormSolicitacao()
        {
            InitializeComponent();

            try
            {
                localhost.Service1 service1 = new localhost.Service1();
                Usuario usuario = new Usuario();
                usuario.IdUsuario = 1000;
                service1.UsuarioBuscar(usuario);
                
                textBoxNome.Text = usuario.Nome;
                textBoxPerfil.Text = usuario.Perfil.DescPerfil;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário na tela \n\n" + ex.Message);
            }
        }
        
    }
}
