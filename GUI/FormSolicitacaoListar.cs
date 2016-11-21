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
    public partial class FormSolicitacaoListar : Form
    {
        public FormSolicitacaoListar(Usuario u)
        {
            InitializeComponent();
            comboBoxBuscar.SelectedIndex = 0;
            comboBoxMostrar.SelectedIndex = 0;
        }

        private void buttonVai_Click(object sender, EventArgs e)
        {
            string dataInicial, dataFinal;
            dataInicial = dateTimePickerDataInicial.Value.Date.ToString("yyyy-MM-dd");
            dataFinal = dateTimePickerDataFinal.Value.Date.ToString("yyyy-MM-dd");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
