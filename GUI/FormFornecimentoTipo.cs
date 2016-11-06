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
            //listTipoFornecimento = service1.PerfilListar().ToList();

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
    }
}
