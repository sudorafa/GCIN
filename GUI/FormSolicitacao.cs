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

            }
        }

        private void CarregarUsuarioTela()
        {
            try
            {
                List<Usuario> listUsuarios = new List<Usuario>();
                localhost.Service1 service1 = new localhost.Service1();

                Usuario usuario = new Usuario();
                usuario.Perfil = new Perfil();

                listUsuarios = service1.UsuarioListar(usuario).ToList();

                foreach (Usuario user in listUsuarios)
                {
                    usuario = user;
                }
                
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
            comboBoxAtualizarSolicitacao.Enabled = false;
            dateTimePickerDataAbertura.Enabled = false;
            dateTimePickerDataPrevistaCompra.Enabled = false;
        }

        private void CarregarComboBox()
        {
            Produto produto = new Produto();
            listProdutos = service1.ProdutoListar(produto).ToList();
            listTiposFornecimentos = service1.TipoFornecimentoListar().ToList();

            foreach (var tf in listTiposFornecimentos)
            {
                comboBoxTipoFornecimento.Items.Add(tf.DescTipoFornecimento.ToString());
            }

            //Pegar Tipo de fornecimento changeado da tela para passar para o produto
            foreach (var prod in listProdutos)
            {
                comboBoxProduto.Items.Add(prod.DescProduto.ToString());
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string dataSolicitacao, severidade, detalheSolicitacao, detalheStatus, dataStatus, statusSolicitacao;
            int idProduto, index;

            Produto produtoEscolhido;
            index = comboBoxProduto.SelectedIndex;
            produtoEscolhido = listProdutos.ElementAt(index);

            Solicitacao solicitacao = new Solicitacao();
            Status status = new Status();
            solicitacao.Produto = new Produto();
            status.Usuario = new Usuario();

            dataSolicitacao = dateTimePickerDataAbertura.Value.Date.ToString("yyyy-MM-dd");
            severidade = comboBoxSeveridade.Text;
            detalheSolicitacao = textBoxDetalhe.Text;
            idProduto = produtoEscolhido.IdProduto;
            detalheStatus = textBoxDetalhe.Text;
            dataStatus = dateTimePickerDataAbertura.Value.Date.ToString("yyyy-MM-dd");
            statusSolicitacao = "Aberto";
           
            solicitacao.DataSolicitacao = dataSolicitacao;
            solicitacao.Severidade = severidade;
            solicitacao.DataSolicitacao = dataSolicitacao;
            solicitacao.Produto.IdProduto = idProduto;
            status.DetalheStatus = detalheStatus;
            status.DetalheStatus = dataStatus;
            status.StatusSolicitacao = statusSolicitacao;
            status.Usuario.IdUsuario = idUsuarioTela;

            /*
             * No D/N irá insert esta solicitação,
             * Em seguida inset Stat..
             * Para pegar id desta solicitação: where detalhe e data da solicitação = solicitacao.Data..Status...
             */

            //Negocio CadastrarSolicitação

            //Negocio CadastrarStatus
        }
    }
}