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

            localhost.Service1 service1 = new localhost.Service1();
            listPerfis = service1.PerfilListar().ToList();
            
            listViewPerfil.Items.Clear();
            foreach (var pf in listPerfis)
            {
                ListViewItem ItemLV = listViewPerfil.Items.Add("" + pf.IdPerfil);
                ItemLV.SubItems.Add(pf.DescPerfil);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            string descricao;

            if (textBoxId.Text.Length > 0)
            {
                id = Int32.Parse(textBoxId.Text);
            }
            
            descricao = textBoxDescricao.Text;

            Perfil perfil = new Perfil();

            perfil.IdPerfil = id;
            perfil.DescPerfil = descricao;

            localhost.Service1 service1 = new localhost.Service1();
            service1.PerfilCadastrar(perfil);
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
                textBoxId.Text = "";
                textBoxDescricao.Text = "";
                textBoxDescricao.Focus();
            }
        }
    }
}
