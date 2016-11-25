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
    public partial class FormFornecimentosNoProduto : Form
    {
        List<TipoFornecimento> listTipoFornecimento = new List<TipoFornecimento>();
        Produto novoProduto;
        Produto p;
        
        public FormFornecimentosNoProduto(Produto produto)
        {
            InitializeComponent();
            p = produto;
            this.novoProduto = new Produto();
            novoProduto.ListaTipoFornecimento = new List<TipoFornecimento>().ToArray() ;
            ListarTipoFornecimento();
        }

        private void ListarTipoFornecimento()
        {
            labelProduto.Text = "Produto: " + p.IdProduto + " - " + p.DescProduto;

            Service1 service1 = new Service1();
            listTipoFornecimento = service1.TipoFornecimentoListar().ToList();

            listViewTipoFornecimento.Items.Clear();
            foreach (var tf in listTipoFornecimento)
            {
                ListViewItem ItemLV = listViewTipoFornecimento.Items.Add("" + tf.IdTipoFornecimento);
                ItemLV.SubItems.Add(tf.DescTipoFornecimento);
            }
        }

        private void CarregarTipoFornecimentoEscolhidos()
        {
            try
            {
                listViewTipoFornecimentoEscolha.Items.Clear();
                foreach (TipoFornecimento tf in this.novoProduto.ListaTipoFornecimento)
                {
                    ListViewItem iltv = listViewTipoFornecimentoEscolha.Items.Add(tf.IdTipoFornecimento.ToString());
                    iltv.SubItems.Add(tf.DescTipoFornecimento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVai_Click(object sender, EventArgs e)
        {
            if (listViewTipoFornecimento.FocusedItem != null)
            {
                int posicao = listViewTipoFornecimento.FocusedItem.Index;
                TipoFornecimento tipoFornecimentoEscolhido = listTipoFornecimento.ElementAt(posicao);

                novoProduto.ListaTipoFornecimento.ToList().Add(tipoFornecimentoEscolhido);
                CarregarTipoFornecimentoEscolhidos();
            }
        }
    }
}
