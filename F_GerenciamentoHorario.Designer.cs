namespace ProjetoEscola2
{
    partial class F_GerenciamentoHorario
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
            this.dgv_horario = new System.Windows.Forms.DataGridView();
            this.tb_horario = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_horario
            // 
            this.dgv_horario.AllowUserToAddRows = false;
            this.dgv_horario.AllowUserToDeleteRows = false;
            this.dgv_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_horario.EnableHeadersVisualStyles = false;
            this.dgv_horario.Location = new System.Drawing.Point(468, 62);
            this.dgv_horario.MultiSelect = false;
            this.dgv_horario.Name = "dgv_horario";
            this.dgv_horario.ReadOnly = true;
            this.dgv_horario.RowHeadersVisible = false;
            this.dgv_horario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horario.Size = new System.Drawing.Size(320, 204);
            this.dgv_horario.TabIndex = 8;
            this.dgv_horario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horario_CellContentClick);
            this.dgv_horario.SelectionChanged += new System.EventHandler(this.dgv_horario_SelectionChanged);
            // 
            // tb_horario
            // 
            this.tb_horario.Location = new System.Drawing.Point(12, 78);
            this.tb_horario.Multiline = true;
            this.tb_horario.Name = "tb_horario";
            this.tb_horario.Size = new System.Drawing.Size(409, 29);
            this.tb_horario.TabIndex = 9;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 190);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(58, 20);
            this.tb_id.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Horários:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(35, 304);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(90, 34);
            this.bt_novo.TabIndex = 13;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(187, 304);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(90, 34);
            this.bt_atualizar.TabIndex = 14;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(344, 304);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(98, 34);
            this.bt_limpar.TabIndex = 15;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(497, 304);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(98, 34);
            this.bt_excluir.TabIndex = 16;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(653, 304);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(98, 34);
            this.bt_fechar.TabIndex = 17;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // F_GerenciamentoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_horario);
            this.Controls.Add(this.dgv_horario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GerenciamentoHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GerenciamentoHorario";
            this.Load += new System.EventHandler(this.F_GerenciamentoHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_horario;
        private System.Windows.Forms.TextBox tb_horario;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_fechar;
    }
}