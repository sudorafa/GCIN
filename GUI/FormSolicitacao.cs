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
                MessageBox.Show("Erro ao carregar dados do usuário na tela \n\n" + ex.Message, "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            buttonXml.Visible = false;
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

            try
            {
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
            catch (Exception) { }
        }

        private void CarregarSolicitacao(Solicitacao solicitacao)
        {
            List<Status> listSolicitacaoStatus = new List<Status>();
            List<Solicitacao> listSolicitacao = new List<Solicitacao>();

            Solicitacao s = new Solicitacao();
            s.Status = new Status();
            s.Status.Usuario = new Usuario();
            s.IdSolicitacao = solicitacao.IdSolicitacao;

            listSolicitacao = service1.SolicitacaoListar(s, "", "").ToList();
            
            solicitacao.Status.Usuario = new Usuario();
            foreach (Solicitacao solicitacaoStatus in listSolicitacao)
            {
                listSolicitacaoStatus = solicitacaoStatus.ListStatus.ToList();
                s = solicitacaoStatus;
            }
            comboBoxHistorico.Items.Clear();
            foreach (Status st in listSolicitacaoStatus)
            {
                comboBoxHistorico.Items.Add(st.StatusSolicitacao + " - " + st.Usuario.Nome + " - " + st.DataStatus);
            }
            comboBoxHistorico.SelectedIndex = 0;

            textBoxId.Text = solicitacao.IdSolicitacao + "";
            textBoxStatus.Text = s.Situacao;

            comboBoxTipoFornecimento.Enabled = false;
            comboBoxProduto.Enabled = false;
            comboBoxSeveridade.Enabled = false;
            comboBoxAtualizarSolicitacao.SelectedIndex = 0;
            comboBoxAtualizarSolicitacao.Enabled = false;
            textBoxDetalhe.Enabled = false;
            dateTimePickerDataDesejadaCompra.Enabled = false;
            comboBoxHistorico.Enabled = true;
            dateTimePickerDataPrevistaCompra.Enabled = false;
            buttonSalvar.Text = "Atualizar";
            buttonNovo.Visible = true;
            buttonXml.Visible = true;
        }

        private void SolicitacaoLista(Solicitacao solicitacao)
        {
            List<Status> listSolicitacaoStatus = new List<Status>();

            textBoxId.Text = solicitacao.IdSolicitacao+"";
            textBoxNome.Text = solicitacao.Status.Usuario.Nome;
            textBoxPerfil.Text = solicitacao.Status.Usuario.Perfil.DescPerfil;
            dateTimePickerDataAbertura.Value = DateTime.Parse(solicitacao.DataSolicitacao);
            dateTimePickerDataDesejadaCompra.Value = DateTime.Parse(solicitacao.DataPrecisa);
            dateTimePickerDataPrevistaCompra.Value = DateTime.Parse(solicitacao.DataPrevistaFim);
            comboBoxProduto.Text = solicitacao.Produto.DescProduto;
            comboBoxProduto.Enabled = false;
            comboBoxSeveridade.Text = solicitacao.Severidade;
            comboBoxSeveridade.Enabled = false;
            textBoxStatus.Text = solicitacao.Situacao;
            
            comboBoxHistorico.Enabled = true;
            comboBoxHistorico.Items.Clear();
            solicitacao.Status.Usuario = new Usuario();
            foreach (Solicitacao s in service1.SolicitacaoListar(solicitacao, "", "").ToList())
            {
                listSolicitacaoStatus = s.ListStatus.ToList();
            }
            foreach (Status st in listSolicitacaoStatus)
            {
                comboBoxHistorico.Items.Add(st.StatusSolicitacao + " - " + st.Usuario.Nome + " - " + st.DataStatus);
            }
            comboBoxHistorico.SelectedIndex = 0;

            comboBoxAtualizarSolicitacao.Enabled = false;
            comboBoxAtualizarSolicitacao.SelectedIndex = 0;
            comboBoxTipoFornecimento.Enabled = false;
            textBoxDetalhe.Enabled = false;
            dateTimePickerDataDesejadaCompra.Enabled = false;
            dateTimePickerDataAbertura.Enabled = false;
            dateTimePickerDataPrevistaCompra.Enabled = false;
            buttonSalvar.Text = "Atualizar";
            buttonNovo.Visible = true;
            buttonXml.Visible = true;
        }

        private void SalvarAlterarSolicitacao(string status)
        {
            string dataSolicitacao, dataPrecisa, dataPrevistaCompra, severidade, detalheSolicitacao, detalheStatus, dataStatus, statusSolicitacao, situacao;
            int idProduto = 0, index, idSolicitacao = 0;
            Produto produtoEscolhido;

            if (status.Equals("Abertura"))
            {
                detalheStatus = textBoxDetalhe.Text;
                statusSolicitacao = status;
                detalheSolicitacao = textBoxDetalhe.Text;
                index = comboBoxProduto.SelectedIndex;
                produtoEscolhido = listProdutos.ElementAt(index);
                idProduto = produtoEscolhido.IdProduto;
            }
            else
            {
                detalheStatus = textBoxDetalhe.Text;
                statusSolicitacao = status;
                detalheSolicitacao = null;
                idSolicitacao = Int32.Parse(textBoxId.Text);
                idUsuarioTela = usuario.IdUsuario;
            }

            dataSolicitacao = dateTimePickerDataAbertura.Value.Date.ToString("yyyy-MM-dd");
            dataPrecisa = dateTimePickerDataDesejadaCompra.Value.Date.ToString("yyyy-MM-dd");
            dataPrevistaCompra = dateTimePickerDataPrevistaCompra.Value.Date.ToString("yyyy-MM-dd");
            severidade = comboBoxSeveridade.Text;
            dataStatus = DateTime.Today.ToString("yyyy-MM-dd");

            if (textBoxDetalhe.Text.Equals("") || textBoxDetalhe.Text.Length == 0 || textBoxDetalhe.Text == null)
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
                solicitacao.Status.StatusSolicitacao = statusSolicitacao;
                solicitacao.Status.Usuario.IdUsuario = idUsuarioTela;
                solicitacao.IdSolicitacao = idSolicitacao;

                try
                {
                    Solicitacao s = new Solicitacao();
                    if (status.Equals("Abertura"))
                    {
                        s = new Service1().SolicitacaoCadastrar(solicitacao);
                        MessageBox.Show("Solicitação Realizada Com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        s = new Service1().SolicitacaoAlterar(solicitacao);
                        MessageBox.Show("Solicitação Atualizada Com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                    CarregarSolicitacao(s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
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
                    comboBoxHistorico.Enabled = false;
                    comboBoxAtualizarSolicitacao.Enabled = true;
                    textBoxDetalhe.Enabled = true;
                    textBoxDetalhe.Text = "";
                    textBoxDetalhe.Focus();
                }
                else
                {
                    SalvarAlterarSolicitacao(comboBoxAtualizarSolicitacao.Text);
                }
            }
            else
            {
                SalvarAlterarSolicitacao("Abertura");
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            CarregarSolicitacaoNova();
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            int id;
            String nome, perfil, dataAbertura, dataDesejada, dataPrevista, /*fornecimento,*/ produto, severidade, status;
            
            id =  Int32.Parse(textBoxId.Text);
            nome = textBoxNome.Text;
            perfil = textBoxPerfil.Text;
            dataAbertura = dateTimePickerDataAbertura.Value.Date.ToString("yyyy-MM-dd");
            dataDesejada = dateTimePickerDataDesejadaCompra.Value.Date.ToString("yyyy-MM-dd");
            dataPrevista = dateTimePickerDataPrevistaCompra.Value.Date.ToString("yyyy-MM-dd");
            //fornecimento = comboBoxTipoFornecimento.Text;
            produto = comboBoxProduto.Text;
            severidade = comboBoxSeveridade.Text;
            status = textBoxStatus.Text;

            Solicitacao solicitacao = new Solicitacao();
            solicitacao.Produto = new Produto();
            solicitacao.Status = new Status();
            solicitacao.Status.Usuario = new Usuario();
            solicitacao.Status.Usuario.Perfil = new Perfil();

            solicitacao.IdSolicitacao = id;
            solicitacao.Status.Usuario.Nome = nome;
            solicitacao.Status.Usuario.Perfil.DescPerfil = perfil;
            solicitacao.DataSolicitacao = dataAbertura;
            solicitacao.DataPrecisa = dataPrevista;
            solicitacao.DataPrevistaFim = dataPrevista;
            //fornecimento
            solicitacao.Produto.DescProduto = produto;
            solicitacao.Severidade = severidade;
            solicitacao.Situacao = status;

            try
            {
                new Service1().SolicitacaoGerarXml(solicitacao);
                MessageBox.Show("Xml Gerado Com Sucesso !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}