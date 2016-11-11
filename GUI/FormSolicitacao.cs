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
        List<Usuario> listUsuario = new List<Usuario>();
        Usuario usuario = new Usuario();

        public FormSolicitacao(Usuario u)
        {
            InitializeComponent();
            
            usuario = u;
            CarregarUsuarioTela();
        }

        private void CarregarUsuarioTela()
        {
            try
            {
                textBoxNome.Text = usuario.Nome;
                textBoxPerfil.Text = usuario.Perfil.DescPerfil;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário na tela \n\n" + ex.Message);
            }
        }
        
    }
}