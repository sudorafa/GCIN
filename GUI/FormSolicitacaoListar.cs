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
        Usuario usuario = new Usuario();
        public FormSolicitacaoListar(Usuario u)
        {
            InitializeComponent();
            comboBoxMostrar.SelectedIndex = 0;
            comboBoxBuscar.SelectedIndex = 0;

            usuario = u;
        }

        private void buttonVai_Click(object sender, EventArgs e)
        {
            int idSolicitacao = 0, idUsuario = 0;
            string dataInicial, dataFinal, statusBuscar;

            try
            {
                idSolicitacao = int.Parse(textBoxId.Text);
            }
            catch (Exception) { }
            

            if (comboBoxMostrar.SelectedIndex == 0)
            {
                idUsuario = usuario.IdUsuario;
            }
            if (comboBoxBuscar.SelectedIndex == 1)
            {
                statusBuscar = "Aberta";
            }
            else if (comboBoxBuscar.SelectedIndex == 2)
            {
                statusBuscar = "Finalizada";
            }
            else
            {
                statusBuscar = "";
            }

            dataInicial = dateTimePickerDataInicial.Value.Date.ToString("yyyy-MM-dd");
            dataFinal = dateTimePickerDataFinal.Value.Date.ToString("yyyy-MM-dd");

            try
            {
                Solicitacao solicitacao = new Solicitacao();
                solicitacao.Status = new Status();
                solicitacao.Status.Usuario = new Usuario();
                
                solicitacao.IdSolicitacao = idSolicitacao;
                solicitacao.Status.Usuario.IdUsuario = idUsuario;
                solicitacao.StatusSolicitacao = statusBuscar;
                //new Service1().

                //carregar listview
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
