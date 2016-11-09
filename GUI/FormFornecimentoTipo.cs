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
    public partial class FormFornecimentoTipo : Form
    {
        List<TipoFornecimento> listTipoFornecimento = new List<TipoFornecimento>();
        public FormFornecimentoTipo()
        {
            InitializeComponent();
            ListarTipoFornecimento();
        }
        private void ListarTipoFornecimento()
        {
            localhost.Service1 service1 = new localhost.Service1();
            listTipoFornecimento = service1.TipoFornecimentoListar().ToList();

            listViewTipoFornecimento.Items.Clear();
            foreach (var tf in listTipoFornecimento)
            {
                ListViewItem ItemLV = listViewTipoFornecimento.Items.Add("" + tf.IdTipoFornecimento);
                ItemLV.SubItems.Add(tf.DescTipoFornecimento);
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
                MessageBox.Show("Por Favor, Informar Descrição do Tipo de Fornecimento !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxDescricao.Focus();
            }
            else
            {
                TipoFornecimento tipoFornecimento = new TipoFornecimento();

                tipoFornecimento.IdTipoFornecimento = id;
                tipoFornecimento.DescTipoFornecimento = descricao;

                try
                {
                    localhost.Service1 service1 = new localhost.Service1();
                    service1.TipoFornecimentoCadastrarAlterar(tipoFornecimento);
                    MessageBox.Show("Tipo de Fornecimento Salvo com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListarTipoFornecimento();
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
            int id = 0;
            string descricao;
            descricao = textBoxDescricao.Text;

            if (textBoxId.Text.Length > 0)
            {
                id = Int32.Parse(textBoxId.Text);

                TipoFornecimento tipoFornecimento = new TipoFornecimento();

                tipoFornecimento.IdTipoFornecimento = id;
                tipoFornecimento.DescTipoFornecimento = descricao;

                try
                {
                    localhost.Service1 service1 = new localhost.Service1();
                    service1.TipoFornecimentoDeletar(tipoFornecimento);

                    MessageBox.Show("Tipo de Fornecimento Deletado com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListarTipoFornecimento();
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Escolha um Perfil da Lista Para Deletar !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            string id, descricao;
            id = textBoxId.Text;
            descricao = textBoxDescricao.Text;
            if (id.Equals("") && descricao.Equals(""))
            {
                MessageBox.Show("Feche");
            }
            else
            {
                LimparTela();
            }
        }

        private void listViewTipoFornecimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoFornecimento tipoFornecimentoSelecionado;
            int index = listViewTipoFornecimento.FocusedItem.Index;
            tipoFornecimentoSelecionado = listTipoFornecimento.ElementAt(index);
            textBoxId.Text = tipoFornecimentoSelecionado.IdTipoFornecimento + "";
            textBoxDescricao.Text = tipoFornecimentoSelecionado.DescTipoFornecimento;
        }
    }
}
