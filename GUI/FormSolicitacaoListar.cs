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
        List<Solicitacao> listSolicitacao = new List<Solicitacao>();

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
                statusBuscar = "Fechado";
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
                solicitacao.Status.Usuario.Perfil = new Perfil();
                solicitacao.Produto = new Produto();
                
                solicitacao.IdSolicitacao = idSolicitacao;
                solicitacao.Status.Usuario.IdUsuario = idUsuario;
                solicitacao.Situacao = statusBuscar;

                listSolicitacao = new Service1().SolicitacaoListar(solicitacao, dataInicial, dataFinal).ToList();

                listViewSolicitacao.Items.Clear();
                foreach (var s in listSolicitacao)
                {
                    ListViewItem ItemLV = listViewSolicitacao.Items.Add("" + s.IdSolicitacao);
                    ItemLV.SubItems.Add(s.DataSolicitacao);
                    ItemLV.SubItems.Add(s.Status.Usuario.Nome);
                    ItemLV.SubItems.Add(s.Severidade);
                    ItemLV.SubItems.Add(s.Produto.DescProduto);
                    ItemLV.SubItems.Add(s.Situacao);
                }
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

        private void listViewSolicitacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Solicitacao solicitacaoSelecionado;
                int index = listViewSolicitacao.FocusedItem.Index;
                solicitacaoSelecionado = listSolicitacao.ElementAt(index);

                new FormSolicitacao(usuario, solicitacaoSelecionado).Show();
            }
            catch (Exception) { }
        }
    }
}
