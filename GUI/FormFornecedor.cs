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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            FormFornecedorCadastrar formFornecedorCadastrar = new FormFornecedorCadastrar();
            formFornecedorCadastrar.Show();
        }
    }
}
