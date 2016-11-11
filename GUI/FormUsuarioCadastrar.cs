using GUI.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormUsuarioCadastrar : Form
    {
        List<Perfil> listPerfis = new List<Perfil>();

        public FormUsuarioCadastrar()
        {
            InitializeComponent();
            ListarPerfil();
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

        private void LimparTela()
        {
            textBoxNome.Text = "";
            maskedTextBoxCpf.Text = "";
            comboBoxPerfil.SelectedIndex = 0;
            textBoxLogin.Text = "";
            textBoxSenha.Text = "";
            textBoxNome.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            String nome, cpf, perfil, login, senha, bloqueio;
            int idPerfil, index;

            //get tela
            nome = textBoxNome.Text;
            cpf = maskedTextBoxCpf.Text;
            perfil = comboBoxPerfil.Text;
            login = textBoxLogin.Text;
            senha = textBoxSenha.Text;
            bloqueio = "nao";
            Perfil perfilEscolhido;
            index = comboBoxPerfil.SelectedIndex;
            perfilEscolhido = listPerfis.ElementAt(index);
            idPerfil = perfilEscolhido.IdPerfil;

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
            else
            {
                //obj
                Usuario usuario = new Usuario();
                usuario.Perfil = new Perfil();

                //set obj
                usuario.Nome = nome;
                usuario.Cpf = cpf;
                usuario.Login = login;
                usuario.Senha = senha;
                usuario.Bloqueio = bloqueio;
                usuario.Perfil.IdPerfil = idPerfil;

                localhost.Service1 service1 = new localhost.Service1();
                
                try
                {
                    service1.UsuarioCadastrar(usuario);
                    MessageBox.Show("Usuario Salvo com Sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListarPerfil();
                    LimparTela();
                }catch (Exception ex)
                {
                    MessageBox.Show(new MenssagemValidaErro().MensagemValidaErro(ex.Message));
                }
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}