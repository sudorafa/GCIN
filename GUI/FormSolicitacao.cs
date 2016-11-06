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

        public FormSolicitacao()
        {
            InitializeComponent();
            CarregarUsuarioTela();
        }

        private void CarregarUsuarioTela()
        {
            try
            {
                localhost.Service1 service1 = new localhost.Service1();
                Usuario usuario = new Usuario();
                usuario.IdUsuario = 1010;
                listUsuario = service1.UsuarioListar(usuario).ToList();

                foreach (var user in listUsuario)
                {
                    textBoxNome.Text = user.Nome;
                    textBoxPerfil.Text = user.Perfil.DescPerfil;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário na tela \n\n" + ex.Message);
            }
        }
    }
}
