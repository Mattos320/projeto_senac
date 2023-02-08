namespace ProjetoEscola2
{
    partial class F_GerenciamentoTurma
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
            this.dgv_turma = new System.Windows.Forms.DataGridView();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.num_qtdaluno = new System.Windows.Forms.NumericUpDown();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.cb_idprofessor = new System.Windows.Forms.ComboBox();
            this.cb_idhorario = new System.Windows.Forms.ComboBox();
            this.cb_idcurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qtdaluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_turma
            // 
            this.dgv_turma.AllowUserToAddRows = false;
            this.dgv_turma.AllowUserToDeleteRows = false;
            this.dgv_turma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_turma.EnableHeadersVisualStyles = false;
            this.dgv_turma.Location = new System.Drawing.Point(391, 68);
            this.dgv_turma.MultiSelect = false;
            this.dgv_turma.Name = "dgv_turma";
            this.dgv_turma.ReadOnly = true;
            this.dgv_turma.RowHeadersVisible = false;
            this.dgv_turma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turma.Size = new System.Drawing.Size(518, 329);
            this.dgv_turma.TabIndex = 8;
            this.dgv_turma.SelectionChanged += new System.EventHandler(this.dgv_turma_SelectionChanged);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cb_status.Location = new System.Drawing.Point(12, 295);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(108, 21);
            this.cb_status.TabIndex = 21;
            // 
            // num_qtdaluno
            // 
            this.num_qtdaluno.Location = new System.Drawing.Point(12, 234);
            this.num_qtdaluno.Name = "num_qtdaluno";
            this.num_qtdaluno.Size = new System.Drawing.Size(322, 20);
            this.num_qtdaluno.TabIndex = 24;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 422);
            this.tb_id.Multiline = true;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(58, 20);
            this.tb_id.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Professor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Qtd Alunos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID Curso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID:";
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(15, 459);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(90, 34);
            this.bt_novo.TabIndex = 33;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(201, 459);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(90, 34);
            this.bt_atualizar.TabIndex = 34;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(391, 459);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(98, 34);
            this.bt_limpar.TabIndex = 35;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(607, 459);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(98, 34);
            this.bt_excluir.TabIndex = 36;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(802, 459);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(98, 34);
            this.bt_fechar.TabIndex = 37;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // cb_idprofessor
            // 
            this.cb_idprofessor.FormattingEnabled = true;
            this.cb_idprofessor.Location = new System.Drawing.Point(12, 84);
            this.cb_idprofessor.Name = "cb_idprofessor";
            this.cb_idprofessor.Size = new System.Drawing.Size(322, 21);
            this.cb_idprofessor.TabIndex = 38;
            // 
            // cb_idhorario
            // 
            this.cb_idhorario.FormattingEnabled = true;
            this.cb_idhorario.Location = new System.Drawing.Point(12, 154);
            this.cb_idhorario.Name = "cb_idhorario";
            this.cb_idhorario.Size = new System.Drawing.Size(322, 21);
            this.cb_idhorario.TabIndex = 39;
            // 
            // cb_idcurso
            // 
            this.cb_idcurso.FormattingEnabled = true;
            this.cb_idcurso.Location = new System.Drawing.Point(12, 350);
            this.cb_idcurso.Name = "cb_idcurso";
            this.cb_idcurso.Size = new System.Drawing.Size(322, 21);
            this.cb_idcurso.TabIndex = 40;
            // 
            // F_GerenciamentoTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 505);
            this.Controls.Add(this.cb_idcurso);
            this.Controls.Add(this.cb_idhorario);
            this.Controls.Add(this.cb_idprofessor);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.num_qtdaluno);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.dgv_turma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GerenciamentoTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_GerenciamentoTurma";
            this.Load += new System.EventHandler(this.F_GerenciamentoTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qtdaluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_turma;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.NumericUpDown num_qtdaluno;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.ComboBox cb_idprofessor;
        private System.Windows.Forms.ComboBox cb_idhorario;
        private System.Windows.Forms.ComboBox cb_idcurso;
    }
}