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
    public partial class FormUsuarioCadastrar : Form
    {
        List<Perfil> listPerfis = new List<Perfil>();

        public FormUsuarioCadastrar()
        {
            InitializeComponent();
            localhost.Service1 service1 = new localhost.Service1();
            listPerfis = service1.PerfilListar().ToList();
            
            comboBoxPerfil.Items.Clear();
            foreach (Perfil pf in listPerfis)
            {
                comboBoxPerfil.Items.Add(pf.DescPerfil.ToString());
            }
            comboBoxPerfil.SelectedIndex = 0;
        }
        
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            String nome, cpf, perfil, login, senha, bloqueio;
            int idPerfil, index;

            nome = textBoxNome.Text;
            cpf = textBoxCpf.Text;
            perfil = comboBoxPerfil.Text;
            login = textBoxLogin.Text;
            senha = textBoxSenha.Text;
            bloqueio = "sim";

            Perfil perfilEscolhido;
            index = comboBoxPerfil.SelectedIndex;
            perfilEscolhido = listPerfis.ElementAt(index);
            idPerfil = perfilEscolhido.IdPerfil;

            Usuario usuario = new Usuario();
            usuario.Perfil = new Perfil();

            usuario.IdUsuario = 32;
            usuario.Nome = nome;
            usuario.Cpf = cpf;
            usuario.Login = login;
            usuario.Senha = senha;
            usuario.Bloqueio = bloqueio;
            usuario.Perfil.IdPerfil = idPerfil;

            try
            {
                localhost.Service1 service1 = new localhost.Service1();
                service1.UsuarioCadastrar(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}