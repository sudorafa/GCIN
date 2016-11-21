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
    public partial class FormPrincipal : Form
    {
        public Usuario usuario = new Usuario();
        public FormPrincipal(Usuario u)
        {
            InitializeComponent();

            List<Usuario> listUsuarios = new List<Usuario>();

            Service1 service1 = new Service1();

            usuario.Perfil = new Perfil();

            listUsuarios = service1.UsuarioListar(u).ToList();

            foreach (Usuario user in listUsuarios)
            {
                usuario = user;
            }
        }

        private void abrirSolicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSolicitacao(usuario, null).Show();
        }

        private void solicitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSolicitacaoListar(usuario).Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUsuarioCadastrar().Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUsuario().Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto().Show();
        }

        private void perfilUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPerfil().Show();
        }

        private void tipoDeFornecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecimentoTipo().Show();
        }
    }
}
