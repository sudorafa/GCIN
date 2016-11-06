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
    public partial class FormProduto : Form
    {
        List<Produto> listprodutos = new List<Produto>();

        public FormProduto()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            textBoxBuscar.Text = "";
            textBoxId.Text = "";
            textBoxDescricao.Text = "";
            textBoxEspecialidades.Text = "";
            listViewProduto.Items.Clear();
            textBoxBuscar.Focus();
        }

        private void buttonVai_Click(object sender, EventArgs e)
        {
            string buscar = textBoxBuscar.Text;
            try
            {
                Produto produto = new Produto();

                produto.DescProduto = buscar;

                localhost.Service1 service1 = new localhost.Service1();
                listprodutos = service1.ProdutoListar(produto).ToList();

                listViewProduto.Items.Clear();
                foreach (var prod in listprodutos)
                {
                    ListViewItem ItemLV = listViewProduto.Items.Add("" + prod.IdProduto);
                    ItemLV.SubItems.Add(prod.DescProduto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelProduto.Visible = true;
            Produto produtoSelecionado;
            int index = listViewProduto.FocusedItem.Index;
            produtoSelecionado = listprodutos.ElementAt(index);

            labelProduto.Text = "Alterando Produto " + produtoSelecionado.IdProduto + " - " + produtoSelecionado.DescProduto;
            textBoxId.Text = produtoSelecionado.IdProduto+""; 
            textBoxDescricao.Text = produtoSelecionado.DescProduto;
            //data
            //especialidade
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            string buscar, id, descricao, especialidades;
            buscar = textBoxBuscar.Text;
            id = textBoxId.Text;
            descricao = textBoxDescricao.Text;
            especialidades = textBoxEspecialidades.Text;
            if (buscar.Equals("") && id.Equals("") && descricao.Equals("") && especialidades.Equals(""))
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
            int id = 0;
            string descricao;
            descricao = textBoxDescricao.Text;

            if (textBoxId.Text.Length > 0)
            {
                id = Int32.Parse(textBoxId.Text);
            }
            if (descricao.Equals("") || descricao.Length == 0 || descricao == null)
            {
                MessageBox.Show("Por Favor, Informar Descrição do Produto !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxDescricao.Focus();
            }
            else
            {
                Produto produto = new Produto();

                produto.IdProduto = id;
                produto.DescProduto = descricao;

                try
                {
                    localhost.Service1 service1 = new localhost.Service1();
                    service1.ProdutoCadastrarAlterar(produto);
                    MessageBox.Show("Produto Salvo com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                Produto produto = new Produto();

                produto.IdProduto = id;
                produto.DescProduto = descricao;

                try
                {
                    localhost.Service1 service1 = new localhost.Service1();
                    service1.ProdutoDeletar(produto);

                    MessageBox.Show("Produto Deletado com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Escolha um Produto da Lista Para Deletar !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
