namespace GUI
{
    partial class FormUsuario
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
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.listViewUsuario = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.buttonVai = new System.Windows.Forms.Button();
            this.labelIdUser = new System.Windows.Forms.Label();
            this.groupBoxBloqueio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBloqueio
            // 
            this.groupBoxBloqueio.Controls.Add(this.radioButtonBloqueioNao);
            this.groupBoxBloqueio.Controls.Add(this.radioButtonBloqueioSim);
            this.groupBoxBloqueio.Enabled = false;
            this.groupBoxBloqueio.Location = new System.Drawing.Point(63, 377);
            this.groupBoxBloqueio.Name = "groupBoxBloqueio";
            this.groupBoxBloqueio.Size = new System.Drawing.Size(187, 43);
            this.groupBoxBloqueio.TabIndex = 19;
            this.groupBoxBloqueio.TabStop = false;
            this.groupBoxBloqueio.Text = "Bloqueio";
            // 
            // radioButtonBloqueioNao
            // 
            this.radioButtonBloqueioNao.AutoSize = true;
            this.radioButtonBloqueioNao.Location = new System.Drawing.Point(106, 18);
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
            this.radioButtonBloqueioSim.Location = new System.Drawing.Point(31, 18);
            this.radioButtonBloqueioSim.Name = "radioButtonBloqueioSim";
            this.radioButtonBloqueioSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonBloqueioSim.TabIndex = 6;
            this.radioButtonBloqueioSim.TabStop = true;
            this.radioButtonBloqueioSim.Text = "Sim";
            this.radioButtonBloqueioSim.UseVisualStyleBackColor = true;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Enabled = false;
            this.labelSenha.Location = new System.Drawing.Point(263, 348);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 18;
            this.labelSenha.Text = "Senha";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Enabled = false;
            this.labelLogin.Location = new System.Drawing.Point(24, 348);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 17;
            this.labelLogin.Text = "Login";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Enabled = false;
            this.labelNome.Location = new System.Drawing.Point(22, 284);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Usuário";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Enabled = false;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCpf.Location = new System.Drawing.Point(30, 316);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 14;
            this.labelCpf.Text = "CPF";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Location = new System.Drawing.Point(335, 438);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(416, 438);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Enabled = false;
            this.textBoxSenha.Location = new System.Drawing.Point(307, 345);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = 'ᴑ';
            this.textBoxSenha.Size = new System.Drawing.Size(184, 20);
            this.textBoxSenha.TabIndex = 5;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(63, 345);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(189, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // comboBoxPerfil
            // 
            this.comboBoxPerfil.Enabled = false;
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Location = new System.Drawing.Point(307, 312);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(184, 21);
            this.comboBoxPerfil.TabIndex = 3;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Location = new System.Drawing.Point(63, 281);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(428, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Enabled = false;
            this.labelPerfil.Location = new System.Drawing.Point(271, 316);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(30, 13);
            this.labelPerfil.TabIndex = 20;
            this.labelPerfil.Text = "Perfil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Buscar";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(63, 49);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(378, 20);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // listViewUsuario
            // 
            this.listViewUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader6});
            this.listViewUsuario.FullRowSelect = true;
            this.listViewUsuario.Location = new System.Drawing.Point(63, 94);
            this.listViewUsuario.Name = "listViewUsuario";
            this.listViewUsuario.Size = new System.Drawing.Size(428, 150);
            this.listViewUsuario.TabIndex = 30;
            this.listViewUsuario.UseCompatibleStateImageBehavior = false;
            this.listViewUsuario.View = System.Windows.Forms.View.Details;
            this.listViewUsuario.SelectedIndexChanged += new System.EventHandler(this.listViewUsuario_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Usuário";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Perfil";
            this.columnHeader6.Width = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Resultado";
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(175, 438);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 23);
            this.buttonCriar.TabIndex = 10;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Enabled = false;
            this.buttonDeletar.Location = new System.Drawing.Point(254, 438);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 11;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Enabled = false;
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(63, 312);
            this.maskedTextBoxCpf.Mask = "999,999,999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(189, 20);
            this.maskedTextBoxCpf.TabIndex = 2;
            // 
            // buttonVai
            // 
            this.buttonVai.Location = new System.Drawing.Point(447, 46);
            this.buttonVai.Name = "buttonVai";
            this.buttonVai.Size = new System.Drawing.Size(44, 23);
            this.buttonVai.TabIndex = 1;
            this.buttonVai.Text = "VAI";
            this.buttonVai.UseVisualStyleBackColor = true;
            this.buttonVai.Click += new System.EventHandler(this.buttonVai_Click);
            // 
            // labelIdUser
            // 
            this.labelIdUser.AutoSize = true;
            this.labelIdUser.Location = new System.Drawing.Point(76, 256);
            this.labelIdUser.Name = "labelIdUser";
            this.labelIdUser.Size = new System.Drawing.Size(60, 13);
            this.labelIdUser.TabIndex = 32;
            this.labelIdUser.Text = "labelIdUser";
            this.labelIdUser.Visible = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 477);
            this.Controls.Add(this.labelIdUser);
            this.Controls.Add(this.buttonVai);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewUsuario);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxBloqueio);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.comboBoxPerfil);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelPerfil);
            this.MaximizeBox = false;
            this.Name = "FormUsuario";
            this.Text = "Usuario";
            this.groupBoxBloqueio.ResumeLayout(false);
            this.groupBoxBloqueio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBloqueio;
        private System.Windows.Forms.RadioButton radioButtonBloqueioNao;
        private System.Windows.Forms.RadioButton radioButtonBloqueioSim;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ListView listViewUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Button buttonVai;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelIdUser;
    }
}