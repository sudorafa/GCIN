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
    public partial class FormPerfil : Form
    {
        List<Perfil> listPerfis = new List<Perfil>();

        public FormPerfil()
        {
            InitializeComponent();
            ListarPerfil();
        }

        private void ListarPerfil()
        {
            localhost.Service1 service1 = new localhost.Service1();
            listPerfis = service1.PerfilListar().ToList();

            listViewPerfil.Items.Clear();
            foreach (var pf in listPerfis)
            {
                ListViewItem ItemLV = listViewPerfil.Items.Add("" + pf.IdPerfil);
                ItemLV.SubItems.Add(pf.DescPerfil);
            }
        }

        private void LimparTela()
        {
            textBoxId.Text = "";
            textBoxDescricao.Text = "";
            textBoxDescricao.Focus();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string descricao;
            descricao = textBoxDescricao.Text;

            if (textBoxId.Text.Length > 0)
            {
                id = Int32.Parse(textBoxId.Text);
            }
            if (descricao.Equals("") || descricao.Length == 0 || descricao == null)
            {
                MessageBox.Show("Por Favor, Informar Descrição do Perfil !");
                textBoxDescricao.Focus();
            } else
            {
                Perfil perfil = new Perfil();

                perfil.IdPerfil = id;
                perfil.DescPerfil = descricao;

                try
                {
                    localhost.Service1 service1 = new localhost.Service1();
                    service1.PerfilCadastrarAlterar(perfil);
                    MessageBox.Show("Perfil Salvo com Sucesso !");
                    ListarPerfil();
                    LimparTela();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        
        private void listViewPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Perfil perfilSelecionado;
            int index = listViewPerfil.FocusedItem.Index;
            perfilSelecionado = listPerfis.ElementAt(index);
            textBoxId.Text = perfilSelecionado.IdPerfil + "";
            textBoxDescricao.Text = perfilSelecionado.DescPerfil;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            string id, descricao;
            id = textBoxId.Text;
            descricao = textBoxDescricao.Text;
            if (id.Equals("") && descricao.Equals(""))
            {
                MessageBox.Show("Feche");
            } else
            {
                LimparTela();
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string descricao;
            descricao = textBoxDescricao.Text;

            if (textBoxId.Text.Length > 0)
            {
                id = Int32.Parse(textBoxId.Text);

                Perfil perfil = new Perfil();

                perfil.IdPerfil = id;
                perfil.DescPerfil = descricao;

                try
                {
                    localhost.Service1 service1 = new localhost.Service1();
                    service1.PerfilDeletar(perfil);

                    MessageBox.Show("Perfil Deletado com Sucesso !");
                    ListarPerfil();
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Escolha um Perfil da Lista Para Deletar !");
            }
        }
    }
}
