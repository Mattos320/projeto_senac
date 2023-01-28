namespace ProjetoEscola2
{
    partial class F_escola
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tools = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.tools.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.alunosToolStripMenuItem1});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(858, 24);
            this.tools.TabIndex = 0;
            this.tools.Text = "tb";
            this.tools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.f_escola_ItemClicked);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoofToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoofToolStripMenuItem
            // 
            this.logoofToolStripMenuItem.Name = "logoofToolStripMenuItem";
            this.logoofToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoofToolStripMenuItem.Text = "Logoff";
            this.logoofToolStripMenuItem.Click += new System.EventHandler(this.logoofToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.visualizarToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciamentoToolStripMenuItem.Text = "Gestão de usuários";
            this.gerenciamentoToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem2});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.alunosToolStripMenuItem.Text = "Professores";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem2
            // 
            this.novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            this.novoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem2.Text = "Novo";
            this.novoToolStripMenuItem2.Click += new System.EventHandler(this.novoToolStripMenuItem2_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.novoToolStripMenuItem1.Text = "Novo ";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // alunosToolStripMenuItem1
            // 
            this.alunosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem3});
            this.alunosToolStripMenuItem1.Name = "alunosToolStripMenuItem1";
            this.alunosToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem1.Text = "Alunos";
            // 
            // novoToolStripMenuItem3
            // 
            this.novoToolStripMenuItem3.Name = "novoToolStripMenuItem3";
            this.novoToolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.novoToolStripMenuItem3.Text = "Novo";
            this.novoToolStripMenuItem3.Click += new System.EventHandler(this.novoToolStripMenuItem3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pb_login);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_Usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 94);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nível:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Location = new System.Drawing.Point(112, 70);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(13, 13);
            this.lb_Usuario.TabIndex = 3;
            this.lb_Usuario.Text = "--";
            this.lb_Usuario.Click += new System.EventHandler(this.lb_Usuario_Click);
            // 
            // pb_login
            // 
            this.pb_login.Image = global::ProjetoEscola2.Properties.Resources.bvermelha;
            this.pb_login.Location = new System.Drawing.Point(3, 66);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(25, 25);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login.TabIndex = 0;
            this.pb_login.TabStop = false;
            this.pb_login.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // F_escola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tools);
            this.MainMenuStrip = this.tools;
            this.Name = "F_escola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tools;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_Usuario;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem3;
    }
}

