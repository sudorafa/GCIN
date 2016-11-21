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
    public partial class FormSolicitacao : Form
    {
        Service1 service1 = new Service1();
        List<Usuario> listUsuario = new List<Usuario>();
        List<Produto> listProdutos = new List<Produto>();
        List<TipoFornecimento> listTiposFornecimentos = new List<TipoFornecimento>();
        Usuario usuario = new Usuario();
        int idUsuarioTela;

        public FormSolicitacao(Usuario u, Solicitacao s)
        {
            InitializeComponent();
            usuario = u;

            if (s == null)
            {
                CarregarSolicitacaoNova();
            }
            else
            {
                SolicitacaoLista(s);
            }
        }

        private void CarregarUsuarioTela()
        {
            try
            {
                /*
                List<Usuario> listUsuarios = new List<Usuario>();
                Service1 service1 = new Service1();

                usuario.Perfil = new Perfil();

                listUsuarios = service1.UsuarioListar(usuario).ToList();

                foreach (Usuario user in listUsuarios)
                {
                    usuario = user;
                }
                */
                
                textBoxNome.Text = usuario.Nome;
                textBoxPerfil.Text = usuario.Perfil.DescPerfil;
                idUsuarioTela = usuario.IdUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do usuário na tela \n\n" + ex.Message);
            }
        }

        private void CarregarSolicitacaoNova()
        {
            CarregarComboBox();
            CarregarUsuarioTela();
            try
            {
                comboBoxTipoFornecimento.SelectedIndex = 0;
            }
            catch{}

            try
            {
                comboBoxProduto.SelectedIndex = 0;
            }
            catch{}

            try
            {
                comboBoxSeveridade.SelectedIndex = 0;
            }
            catch{}

            comboBoxHistorico.Enabled = false;
            comboBoxHistorico.Text = "";
            comboBoxAtualizarSolicitacao.Enabled = false;
            comboBoxAtualizarSolicitacao.Text = "";
            dateTimePickerDataAbertura.Enabled = false;
            dateTimePickerDataPrevistaCompra.Enabled = false;
            dateTimePickerDataDesejadaCompra.Value = DateTime.Now.Date;
            textBoxDetalhe.Text = "";
            textBoxId.Text = "";
            buttonSalvar.Text = "Salvar";
            buttonNovo.Visible = false;
            comboBoxTipoFornecimento.Enabled = true;
            comboBoxProduto.Enabled = true;
            comboBoxSeveridade.Enabled = true;
            comboBoxAtualizarSolicitacao.Enabled = false;
            textBoxDetalhe.Enabled = true;
            dateTimePickerDataDesejadaCompra.Enabled = true;
            textBoxDetalhe.Focus();
        }

        private void CarregarComboBox()
        {
            Produto produto = new Produto();
            listProdutos = service1.ProdutoListar(produto).ToList();
            listTiposFornecimentos = service1.TipoFornecimentoListar().ToList();

            comboBoxTipoFornecimento.Items.Clear();
            foreach (var tf in listTiposFornecimentos)
            {
                comboBoxTipoFornecimento.Items.Add(tf.DescTipoFornecimento.ToString());
            }

            //Fazer Pegar Tipo de fornecimento changeado da tela para passar para o produto dele

            comboBoxProduto.Items.Clear();
            foreach (var prod in listProdutos)
            {
                comboBoxProduto.Items.Add(prod.DescProduto.ToString());
            }
        }

        private void CarregarSolicitacao(Solicitacao s)
        {
            comboBoxHistorico.Items.Clear();

            textBoxId.Text = s.IdSolicitacao + "";
            textBoxStatus.Text = s.StatusSolicitacao;
            comboBoxHistorico.Enabled = true;
            comboBoxHistorico.Items.Add(usuario.Nome + " - " + s.StatusSolicitacao + " - " + s.DataSolicitacao);
            comboBoxHistorico.SelectedIndex = 0;
            comboBoxAtualizarSolicitacao.Enabled = true;
            comboBoxAtualizarSolicitacao.SelectedIndex = 0;
            comboBoxTipoFornecimento.Enabled = false;
            comboBoxProduto.Enabled = false;
            comboBoxSeveridade.Enabled = false;
            comboBoxAtualizarSolicitacao.Enabled = false;
            textBoxDetalhe.Enabled = false;
            dateTimePickerDataDesejadaCompra.Enabled = false;

            buttonSalvar.Text = "Atualizar";
            buttonNovo.Visible = true;
        }

        private void SolicitacaoLista(Solicitacao solicitacao)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxId.TextLength > 0)
            {
                if (buttonSalvar.Text.Equals("Atualizar"))
                {
                    buttonSalvar.Text = "Salvar";
                    dateTimePickerDataDesejadaCompra.Enabled = true;
                    dateTimePickerDataPrevistaCompra.Enabled = true;
                    comboBoxSeveridade.Enabled = true;
                    comboBoxAtualizarSolicitacao.Enabled = true;
                    textBoxDetalhe.Enabled = true;
                    textBoxDetalhe.Text = "";
                    textBoxDetalhe.Focus();
                }
                MessageBox.Show("oi");
            }
            else
            {
                string dataSolicitacao, dataPrecisa, dataPrevistaCompra, severidade, detalheSolicitacao, detalheStatus, dataStatus, statusSolicitacao;
                int idProduto, index;

                Produto produtoEscolhido;
                index = comboBoxProduto.SelectedIndex;
                produtoEscolhido = listProdutos.ElementAt(index);

                dataSolicitacao = dateTimePickerDataAbertura.Value.Date.ToString("yyyy-MM-dd");
                dataPrecisa = dateTimePickerDataDesejadaCompra.Value.Date.ToString("yyyy-MM-dd");
                dataPrevistaCompra = dateTimePickerDataPrevistaCompra.Value.Date.ToString("yyyy-MM-dd");
                severidade = comboBoxSeveridade.Text;
                detalheSolicitacao = textBoxDetalhe.Text;
                idProduto = produtoEscolhido.IdProduto;
                detalheStatus = textBoxDetalhe.Text;
                dataStatus = dateTimePickerDataAbertura.Value.Date.ToString("yyyy-MM-dd");
                statusSolicitacao = "Aberta";

                if (detalheStatus.Equals("") || detalheStatus.Length == 0 || detalheStatus == null)
                {
                    MessageBox.Show("Por Favor, Informe Detalhe Status ! ", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBoxDetalhe.Focus();
                }
                else
                {
                    Solicitacao solicitacao = new Solicitacao();
                    solicitacao.Produto = new Produto();
                    solicitacao.Status = new Status();
                    solicitacao.Status.Usuario = new Usuario();

                    solicitacao.DataSolicitacao = dataSolicitacao;
                    solicitacao.DataPrecisa = dataPrecisa;
                    solicitacao.DataPrevistaFim = dataPrevistaCompra;
                    solicitacao.Severidade = severidade;
                    solicitacao.Detalhe = detalheSolicitacao;
                    solicitacao.Produto.IdProduto = idProduto;
                    solicitacao.Status.DetalheStatus = detalheStatus;
                    solicitacao.Status.DataStatus = dataStatus;
                    solicitacao.StatusSolicitacao = statusSolicitacao;
                    solicitacao.Status.Usuario.IdUsuario = idUsuarioTela;

                    try
                    {
                        Solicitacao s = new Solicitacao();
                        s = new Service1().SolicitacaoCadastrar(solicitacao);
                        MessageBox.Show("Solicitação Realizada Com Sucesso !");
                        CarregarSolicitacao(s);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            CarregarSolicitacaoNova();
        }
    }
}