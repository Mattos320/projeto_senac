namespace ProjetoEscola2
{
    partial class F_GerenciamentodeUsuarios
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
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.num_nivel = new System.Windows.Forms.NumericUpDown();
            this.lb_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 75);
            this.tb_nome.Multiline = true;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(409, 29);
            this.tb_nome.TabIndex = 1;
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.AllowUserToAddRows = false;
            this.dgv_usuario.AllowUserToDeleteRows = false;
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_usuario.EnableHeadersVisualStyles = false;
            this.dgv_usuario.Location = new System.Drawing.Point(443, 75);
            this.dgv_usuario.MultiSelect = false;
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.ReadOnly = true;
            this.dgv_usuario.RowHeadersVisible = false;
            this.dgv_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuario.Size = new System.Drawing.Size(320, 346);
            this.dgv_usuario.TabIndex = 7;
            this.dgv_usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuario_CellContentClick);
            this.dgv_usuario.SelectionChanged += new System.EventHandler(this.dgv_usuario_SelectionChanged);
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(12, 252);
            this.tb_senha.Multiline = true;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(409, 29);
            this.tb_senha.TabIndex = 3;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 161);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(409, 29);
            this.tb_username.TabIndex = 2;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(12, 59);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 4;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(12, 145);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(58, 13);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "Username:";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(12, 236);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(41, 13);
            this.lb_senha.TabIndex = 6;
            this.lb_senha.Text = "Senha:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cb_status.Location = new System.Drawing.Point(12, 320);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(182, 21);
            this.cb_status.TabIndex = 4;
            // 
            // num_nivel
            // 
            this.num_nivel.Location = new System.Drawing.Point(233, 320);
            this.num_nivel.Name = "num_nivel";
            this.num_nivel.Size = new System.Drawing.Size(188, 20);
            this.num_nivel.TabIndex = 5;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(12, 304);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(40, 13);
            this.lb_status.TabIndex = 17;
            this.lb_status.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nível:";
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(165, 445);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(90, 34);
            this.bt_atualizar.TabIndex = 9;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(660, 445);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(98, 34);
            this.bt_fechar.TabIndex = 12;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(492, 445);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(98, 34);
            this.bt_excluir.TabIndex = 11;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(323, 445);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(98, 34);
            this.bt_limpar.TabIndex = 10;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click_1);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(15, 445);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(90, 34);
            this.bt_novo.TabIndex = 8;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "A: Ativo B: Bloqueado";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(13, 402);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(58, 20);
            this.tb_id.TabIndex = 6;
            this.tb_id.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(13, 386);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 13);
            this.lb_id.TabIndex = 26;
            this.lb_id.Text = "ID:";
            // 
            // F_GerenciamentodeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 491);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.num_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.dgv_usuario);
            this.Controls.Add(this.tb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GerenciamentodeUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GerenciamentodeUsuarios";
            this.Load += new System.EventHandler(this.F_GerenciamentodeUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.NumericUpDown num_nivel;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
    }
}