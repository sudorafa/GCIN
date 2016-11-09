namespace GUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.solicitaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirSolicitaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeFornecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitaçãoToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.fornecimentoToolStripMenuItem,
            this.cotaçãoToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // solicitaçãoToolStripMenuItem
            // 
            this.solicitaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirSolicitaçãoToolStripMenuItem,
            this.solicitaçõesToolStripMenuItem});
            this.solicitaçãoToolStripMenuItem.Name = "solicitaçãoToolStripMenuItem";
            this.solicitaçãoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitaçãoToolStripMenuItem.Text = "Solicitação";
            // 
            // abrirSolicitaçãoToolStripMenuItem
            // 
            this.abrirSolicitaçãoToolStripMenuItem.Name = "abrirSolicitaçãoToolStripMenuItem";
            this.abrirSolicitaçãoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.abrirSolicitaçãoToolStripMenuItem.Text = "Abrir Solicitação";
            this.abrirSolicitaçãoToolStripMenuItem.Click += new System.EventHandler(this.abrirSolicitaçãoToolStripMenuItem_Click);
            // 
            // solicitaçõesToolStripMenuItem
            // 
            this.solicitaçõesToolStripMenuItem.Name = "solicitaçõesToolStripMenuItem";
            this.solicitaçõesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.solicitaçõesToolStripMenuItem.Text = "Solicitações";
            this.solicitaçõesToolStripMenuItem.Click += new System.EventHandler(this.solicitaçõesToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // fornecimentoToolStripMenuItem
            // 
            this.fornecimentoToolStripMenuItem.Name = "fornecimentoToolStripMenuItem";
            this.fornecimentoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fornecimentoToolStripMenuItem.Text = "Forncedor";
            // 
            // cotaçãoToolStripMenuItem
            // 
            this.cotaçãoToolStripMenuItem.Name = "cotaçãoToolStripMenuItem";
            this.cotaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cotaçãoToolStripMenuItem.Text = "Cotação";
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilUsuárioToolStripMenuItem,
            this.tipoDeFornecimentoToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // perfilUsuárioToolStripMenuItem
            // 
            this.perfilUsuárioToolStripMenuItem.Name = "perfilUsuárioToolStripMenuItem";
            this.perfilUsuárioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.perfilUsuárioToolStripMenuItem.Text = "Perfil Usuário";
            this.perfilUsuárioToolStripMenuItem.Click += new System.EventHandler(this.perfilUsuárioToolStripMenuItem_Click);
            // 
            // tipoDeFornecimentoToolStripMenuItem
            // 
            this.tipoDeFornecimentoToolStripMenuItem.Name = "tipoDeFornecimentoToolStripMenuItem";
            this.tipoDeFornecimentoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tipoDeFornecimentoToolStripMenuItem.Text = "Tipo de Fornecimento";
            this.tipoDeFornecimentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeFornecimentoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 638);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solicitaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirSolicitaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeFornecimentoToolStripMenuItem;
    }
}