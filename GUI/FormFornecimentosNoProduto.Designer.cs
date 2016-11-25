namespace GUI
{
    partial class FormFornecimentosNoProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTipoFornecimento = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTipoFornecimentoEscolha = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonVai = new System.Windows.Forms.Button();
            this.buttonVem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo de Fornecimento";
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.Location = new System.Drawing.Point(8, 58);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(258, 20);
            this.labelProduto.TabIndex = 40;
            this.labelProduto.Text = "Aqui será exibido dados do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tipos de Fornecimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Para Atribuição";
            // 
            // listViewTipoFornecimento
            // 
            this.listViewTipoFornecimento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewTipoFornecimento.FullRowSelect = true;
            this.listViewTipoFornecimento.Location = new System.Drawing.Point(12, 120);
            this.listViewTipoFornecimento.Name = "listViewTipoFornecimento";
            this.listViewTipoFornecimento.Size = new System.Drawing.Size(186, 147);
            this.listViewTipoFornecimento.TabIndex = 43;
            this.listViewTipoFornecimento.UseCompatibleStateImageBehavior = false;
            this.listViewTipoFornecimento.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Produto";
            this.columnHeader2.Width = 102;
            // 
            // listViewTipoFornecimentoEscolha
            // 
            this.listViewTipoFornecimentoEscolha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewTipoFornecimentoEscolha.FullRowSelect = true;
            this.listViewTipoFornecimentoEscolha.Location = new System.Drawing.Point(253, 120);
            this.listViewTipoFornecimentoEscolha.Name = "listViewTipoFornecimentoEscolha";
            this.listViewTipoFornecimentoEscolha.Size = new System.Drawing.Size(200, 147);
            this.listViewTipoFornecimentoEscolha.TabIndex = 44;
            this.listViewTipoFornecimentoEscolha.UseCompatibleStateImageBehavior = false;
            this.listViewTipoFornecimentoEscolha.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Produto";
            this.columnHeader5.Width = 119;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(378, 279);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 45;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(297, 279);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 46;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonVai
            // 
            this.buttonVai.Location = new System.Drawing.Point(210, 166);
            this.buttonVai.Name = "buttonVai";
            this.buttonVai.Size = new System.Drawing.Size(32, 23);
            this.buttonVai.TabIndex = 47;
            this.buttonVai.Text = ">>";
            this.buttonVai.UseVisualStyleBackColor = true;
            this.buttonVai.Click += new System.EventHandler(this.buttonVai_Click);
            // 
            // buttonVem
            // 
            this.buttonVem.Location = new System.Drawing.Point(210, 196);
            this.buttonVem.Name = "buttonVem";
            this.buttonVem.Size = new System.Drawing.Size(32, 23);
            this.buttonVem.TabIndex = 48;
            this.buttonVem.Text = "<<";
            this.buttonVem.UseVisualStyleBackColor = true;
            // 
            // FormFornecimentosNoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 318);
            this.Controls.Add(this.buttonVem);
            this.Controls.Add(this.buttonVai);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.listViewTipoFornecimentoEscolha);
            this.Controls.Add(this.listViewTipoFornecimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.label2);
            this.Name = "FormFornecimentosNoProduto";
            this.Text = "Tipo de Fornecimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTipoFornecimento;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewTipoFornecimentoEscolha;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonVai;
        private System.Windows.Forms.Button buttonVem;
    }
}