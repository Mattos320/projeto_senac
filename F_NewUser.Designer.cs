namespace ProjetoEscola2
{
    partial class F_NewUser
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.num_nivel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 51);
            this.tb_nome.Multiline = true;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(416, 24);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 115);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(416, 24);
            this.tb_username.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(12, 183);
            this.tb_senha.Multiline = true;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(416, 24);
            this.tb_senha.TabIndex = 2;
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(15, 323);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(98, 34);
            this.bt_novo.TabIndex = 5;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(175, 323);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(98, 34);
            this.bt_salvar.TabIndex = 6;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(330, 323);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(98, 34);
            this.bt_fechar.TabIndex = 7;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nível:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "A: Ativo B: Bloqueado";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cb_status.Location = new System.Drawing.Point(51, 253);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(108, 21);
            this.cb_status.TabIndex = 14;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // num_nivel
            // 
            this.num_nivel.Location = new System.Drawing.Point(272, 254);
            this.num_nivel.Name = "num_nivel";
            this.num_nivel.Size = new System.Drawing.Size(100, 20);
            this.num_nivel.TabIndex = 15;
            // 
            // F_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 378);
            this.Controls.Add(this.num_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_NewUser";
            ((System.ComponentModel.ISupportInitialize)(this.num_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.NumericUpDown num_nivel;
    }
}