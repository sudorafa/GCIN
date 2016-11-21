namespace GUI
{
    partial class FormSolicitacaoListar
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMostrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.listBoxSolicitacao = new System.Windows.Forms.ListBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonVai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // comboBoxMostrar
            // 
            this.comboBoxMostrar.FormattingEnabled = true;
            this.comboBoxMostrar.Items.AddRange(new object[] {
            "Minhas Solicitações",
            "Todas Solicitações"});
            this.comboBoxMostrar.Location = new System.Drawing.Point(139, 71);
            this.comboBoxMostrar.Name = "comboBoxMostrar";
            this.comboBoxMostrar.Size = new System.Drawing.Size(202, 21);
            this.comboBoxMostrar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mostrar";
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Finalizada"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(347, 71);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(202, 21);
            this.comboBoxBuscar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID (Opcional)";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(33, 71);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Final";
            // 
            // dateTimePickerDataInicial
            // 
            this.dateTimePickerDataInicial.Location = new System.Drawing.Point(33, 118);
            this.dateTimePickerDataInicial.Name = "dateTimePickerDataInicial";
            this.dateTimePickerDataInicial.Size = new System.Drawing.Size(230, 20);
            this.dateTimePickerDataInicial.TabIndex = 8;
            // 
            // dateTimePickerDataFinal
            // 
            this.dateTimePickerDataFinal.Location = new System.Drawing.Point(269, 118);
            this.dateTimePickerDataFinal.Name = "dateTimePickerDataFinal";
            this.dateTimePickerDataFinal.Size = new System.Drawing.Size(233, 20);
            this.dateTimePickerDataFinal.TabIndex = 9;
            // 
            // listBoxSolicitacao
            // 
            this.listBoxSolicitacao.FormattingEnabled = true;
            this.listBoxSolicitacao.Location = new System.Drawing.Point(33, 153);
            this.listBoxSolicitacao.Name = "listBoxSolicitacao";
            this.listBoxSolicitacao.Size = new System.Drawing.Size(516, 251);
            this.listBoxSolicitacao.TabIndex = 18;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(474, 410);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 19;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Solicitações";
            // 
            // buttonVai
            // 
            this.buttonVai.Location = new System.Drawing.Point(508, 115);
            this.buttonVai.Name = "buttonVai";
            this.buttonVai.Size = new System.Drawing.Size(41, 23);
            this.buttonVai.TabIndex = 17;
            this.buttonVai.Text = "VAI";
            this.buttonVai.UseVisualStyleBackColor = true;
            this.buttonVai.Click += new System.EventHandler(this.buttonVai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Selecione uma solicitação acima para atualização/visualização";
            // 
            // FormSolicitacaoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonVai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.listBoxSolicitacao);
            this.Controls.Add(this.dateTimePickerDataFinal);
            this.Controls.Add(this.dateTimePickerDataInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMostrar);
            this.Controls.Add(this.label1);
            this.Name = "FormSolicitacaoListar";
            this.Text = "Listar Solicitação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFinal;
        private System.Windows.Forms.ListBox listBoxSolicitacao;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonVai;
        private System.Windows.Forms.Label label7;
    }
}