namespace GUI
{
    partial class FormFornecedorCadastrar
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
            this.groupBoxBloqueio = new System.Windows.Forms.GroupBox();
            this.radioButtonBloqueioNao = new System.Windows.Forms.RadioButton();
            this.radioButtonBloqueioSim = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxBloqueio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBloqueio
            // 
            this.groupBoxBloqueio.Controls.Add(this.radioButtonBloqueioNao);
            this.groupBoxBloqueio.Controls.Add(this.radioButtonBloqueioSim);
            this.groupBoxBloqueio.Location = new System.Drawing.Point(238, 116);
            this.groupBoxBloqueio.Name = "groupBoxBloqueio";
            this.groupBoxBloqueio.Size = new System.Drawing.Size(164, 32);
            this.groupBoxBloqueio.TabIndex = 82;
            this.groupBoxBloqueio.TabStop = false;
            this.groupBoxBloqueio.Text = "Bloqueio";
            // 
            // radioButtonBloqueioNao
            // 
            this.radioButtonBloqueioNao.AutoSize = true;
            this.radioButtonBloqueioNao.Location = new System.Drawing.Point(113, 9);
            this.radioButtonBloqueioNao.Name = "radioButtonBloqueioNao";
            this.radioButtonBloqueioNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonBloqueioNao.TabIndex = 7;
            this.radioButtonBloqueioNao.TabStop = true;
            this.radioButtonBloqueioNao.Text = "Não";
            this.radioButtonBloqueioNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonBloqueioSim
            // 
            this.radioButtonBloqueioSim.AutoSize = true;
            this.radioButtonBloqueioSim.Location = new System.Drawing.Point(65, 10);
            this.radioButtonBloqueioSim.Name = "radioButtonBloqueioSim";
            this.radioButtonBloqueioSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonBloqueioSim.TabIndex = 6;
            this.radioButtonBloqueioSim.TabStop = true;
            this.radioButtonBloqueioSim.Text = "Sim";
            this.radioButtonBloqueioSim.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 20);
            this.textBox3.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Especialidades";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 78;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 77;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 20);
            this.textBox2.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 83;
            this.label2.Text = "Cadastro de Fornecedor";
            // 
            // FormFornecedorCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxBloqueio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Name = "FormFornecedorCadastrar";
            this.Text = "FormFornecedorCadastrar";
            this.groupBoxBloqueio.ResumeLayout(false);
            this.groupBoxBloqueio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBloqueio;
        private System.Windows.Forms.RadioButton radioButtonBloqueioNao;
        private System.Windows.Forms.RadioButton radioButtonBloqueioSim;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}