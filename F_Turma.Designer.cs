namespace ProjetoEscola2
{
    partial class F_Turma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.cb_idprofessor = new System.Windows.Forms.ComboBox();
            this.cb_idhorario = new System.Windows.Forms.ComboBox();
            this.num_qtdaluno = new System.Windows.Forms.NumericUpDown();
            this.cb_idcurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_qtdaluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Professor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qnt de Alunos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Curso:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "F",
            "I"});
            this.cb_status.Location = new System.Drawing.Point(26, 263);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(108, 21);
            this.cb_status.TabIndex = 15;
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(12, 404);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(98, 34);
            this.bt_limpar.TabIndex = 16;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(134, 404);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(98, 34);
            this.bt_salvar.TabIndex = 17;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(257, 404);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(98, 34);
            this.bt_fechar.TabIndex = 18;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // cb_idprofessor
            // 
            this.cb_idprofessor.FormattingEnabled = true;
            this.cb_idprofessor.Location = new System.Drawing.Point(26, 65);
            this.cb_idprofessor.Name = "cb_idprofessor";
            this.cb_idprofessor.Size = new System.Drawing.Size(322, 21);
            this.cb_idprofessor.TabIndex = 23;
            // 
            // cb_idhorario
            // 
            this.cb_idhorario.FormattingEnabled = true;
            this.cb_idhorario.Location = new System.Drawing.Point(26, 136);
            this.cb_idhorario.Name = "cb_idhorario";
            this.cb_idhorario.Size = new System.Drawing.Size(322, 21);
            this.cb_idhorario.TabIndex = 24;
            // 
            // num_qtdaluno
            // 
            this.num_qtdaluno.Location = new System.Drawing.Point(26, 200);
            this.num_qtdaluno.Name = "num_qtdaluno";
            this.num_qtdaluno.Size = new System.Drawing.Size(322, 20);
            this.num_qtdaluno.TabIndex = 21;
            // 
            // cb_idcurso
            // 
            this.cb_idcurso.FormattingEnabled = true;
            this.cb_idcurso.Location = new System.Drawing.Point(26, 336);
            this.cb_idcurso.Name = "cb_idcurso";
            this.cb_idcurso.Size = new System.Drawing.Size(322, 21);
            this.cb_idcurso.TabIndex = 25;
            // 
            // F_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 452);
            this.Controls.Add(this.cb_idcurso);
            this.Controls.Add(this.cb_idhorario);
            this.Controls.Add(this.cb_idprofessor);
            this.Controls.Add(this.num_qtdaluno);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Turma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Turma";
            this.Load += new System.EventHandler(this.F_Turma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_qtdaluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.ComboBox cb_idprofessor;
        private System.Windows.Forms.ComboBox cb_idhorario;
        private System.Windows.Forms.NumericUpDown num_qtdaluno;
        private System.Windows.Forms.ComboBox cb_idcurso;
    }
}