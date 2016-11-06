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
        List<Usuario> listUsuarios = new List<Usuario>();
        List<Perfil> listPerfis = new List<Perfil>();

        public FormUsuario()
        {
            InitializeComponent();
            ListarPerfil();
        }

        private void LimparTela()
        {
            textBoxBuscar.Text = "";
            textBoxNome.Text = "";
            maskedTextBoxCpf.Text = "";
            textBoxLogin.Text = "";
            textBoxSenha.Text = "";
            radioButtonBloqueioSim.Checked = false;
            radioButtonBloqueioNao.Checked = false;
            comboBoxPerfil.SelectedIndex = 0;
            listViewUsuario.Items.Clear();
            textBoxBuscar.Focus();

            labelIdUser.Visible = false;
            labelNome.Enabled = false;
            labelCpf.Enabled = false;
            labelPerfil.Enabled = false;
            labelLogin.Enabled = false;
            labelSenha.Enabled = false;
            groupBoxBloqueio.Enabled = false;

            textBoxNome.Enabled = false;
            maskedTextBoxCpf.Enabled = false;
            comboBoxPerfil.Enabled = false;
            textBoxLogin.Enabled = false;
            textBoxSenha.Enabled = false;
            radioButtonBloqueioSim.Enabled = false;
            radioButtonBloqueioNao.Enabled = false;

            buttonDeletar.Enabled = false;
            buttonSalvar.Enabled = false;
        }

        private void ListarPerfil()
        {
            localhost.Service1 service1 = new localhost.Service1();
            listPerfis = service1.PerfilListar().ToList();

            comboBoxPerfil.Items.Clear();
            foreach (Perfil pf in listPerfis)
            {
                comboBoxPerfil.Items.Add(pf.DescPerfil.ToString());
            }
            comboBoxPerfil.SelectedIndex = 0;
        }

        private void HabilitarTela()
        {
            labelIdUser.Visible = true;
            labelNome.Enabled = true;
            labelCpf.Enabled = true;
            labelPerfil.Enabled = true;
            labelLogin.Enabled = true;
            labelSenha.Enabled = true;
            groupBoxBloqueio.Enabled = true;

            textBoxNome.Enabled = true;
            maskedTextBoxCpf.Enabled = true;
            comboBoxPerfil.Enabled = true;
            textBoxLogin.Enabled = true;
            textBoxSenha.Enabled = true;
            radioButtonBloqueioSim.Enabled = true;
            radioButtonBloqueioNao.Enabled = true;

            buttonCriar.Enabled = true;
            buttonDeletar.Enabled = true;
            buttonSalvar.Enabled = true;
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
                listUsuarios = service1.UsuarioListar(usuario).ToList();

                listViewUsuario.Items.Clear();
                foreach (var user in listUsuarios)
                {
                    ListViewItem ItemLV = listViewUsuario.Items.Add("" + user.IdUsuario);
                    ItemLV.SubItems.Add(user.Nome);
                    ItemLV.SubItems.Add(user.Login);
                    ItemLV.SubItems.Add(user.Perfil.DescPerfil);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarTela();
            Usuario usuarioSelecionado;
            int index = listViewUsuario.FocusedItem.Index;
            usuarioSelecionado = listUsuarios.ElementAt(index);

            labelIdUser.Text = "Alterando Usuário ID: "+ usuarioSelecionado.IdUsuario + " - Nome: " + usuarioSelecionado.Nome;
            textBoxNome.Text = usuarioSelecionado.Nome;
            maskedTextBoxCpf.Text = usuarioSelecionado.Cpf;
            comboBoxPerfil.Text = usuarioSelecionado.Perfil.DescPerfil ;
            textBoxLogin.Text = usuarioSelecionado.Login;
            textBoxSenha.Text = usuarioSelecionado.Senha;
            if (usuarioSelecionado.Bloqueio.Equals("sim"))
            {
                radioButtonBloqueioSim.PerformClick();
            }
            else
            {
                radioButtonBloqueioNao.PerformClick();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            string buscar, nome, cpf, login, senha;
            buscar = textBoxBuscar.Text;
            nome = textBoxNome.Text;
            cpf = maskedTextBoxCpf.Text;
            login = textBoxLogin.Text;
            senha = textBoxSenha.Text;
            if (buscar.Equals("") && nome.Equals("") && cpf.Equals("   .   .   -") && login.Equals("") && senha.Equals(""))
            {
                MessageBox.Show("Feche");
            }
            else
            {
                LimparTela();
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            String nome, cpf, perfil, login, senha, bloqueio;
            int idUsuario, idPerfil, indexPerfil, indexUsuario;

            //get tela
            nome = textBoxNome.Text;
            cpf = maskedTextBoxCpf.Text;
            perfil = comboBoxPerfil.Text;
            login = textBoxLogin.Text;
            senha = textBoxSenha.Text;
            if (radioButtonBloqueioSim.Checked == true)
            {
                bloqueio = "sim";
            }
            else
            {
                bloqueio = "nao";
            }
            Perfil perfilEscolhido;
            indexPerfil = comboBoxPerfil.SelectedIndex;
            perfilEscolhido = listPerfis.ElementAt(indexPerfil);
            idPerfil = perfilEscolhido.IdPerfil;

            Usuario usuarioSelecionado;
            indexUsuario = listViewUsuario.FocusedItem.Index;
            usuarioSelecionado = listUsuarios.ElementAt(indexUsuario);
            idUsuario = usuarioSelecionado.IdUsuario;

            //validação campos
            if (nome.Equals("") || nome.Length == 0 || nome == null)
            {
                MessageBox.Show("Por Favor, Informe Nome ! ", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNome.Focus();
            }
            else if (cpf.Equals("   .   .   -"))
            {
                MessageBox.Show("Por Favor, Informe CPF ! ", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                maskedTextBoxCpf.Focus();
            }
            else if (login.Equals("") || login.Length == 0 || login == null)
            {
                MessageBox.Show("Por Favor, Informe Login ! ", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxLogin.Focus();
            }
            else if (senha.Equals("") || senha.Length == 0 || senha == null)
            {
                MessageBox.Show("Por Favor, Informe Senha ! ", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxSenha.Focus();
            }
            else if (radioButtonBloqueioSim.Checked == false && radioButtonBloqueioNao.Checked == false)
            {
                MessageBox.Show("Por Favor, Informe Bloqueio ! ", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBoxBloqueio.Focus();
            }
            else
            {
                //obj
                Usuario usuario = new Usuario();
                usuario.Perfil = new Perfil();

                //set obj
                usuario.IdUsuario = idUsuario;
                usuario.Nome = nome;
                usuario.Cpf = cpf;
                usuario.Login = login;
                usuario.Senha = senha;
                usuario.Bloqueio = bloqueio;
                usuario.Perfil.IdPerfil = idPerfil;

                try
                {
                    localhost.Service1 service1 = new localhost.Service1();
                    service1.UsuarioAlterar(usuario);
                    MessageBox.Show("Alteração Salva com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListarPerfil();
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            int indexUsuario, idUsuario;
            Usuario usuarioSelecionado;
            indexUsuario = listViewUsuario.FocusedItem.Index;
            usuarioSelecionado = listUsuarios.ElementAt(indexUsuario);
            idUsuario = usuarioSelecionado.IdUsuario;
            
            Usuario usuario = new Usuario();

            usuario.IdUsuario = idUsuario;
            
            try
            {
                localhost.Service1 service1 = new localhost.Service1();
                service1.UsuarioDeletar(usuario);

                MessageBox.Show("Usuário Deletado com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
