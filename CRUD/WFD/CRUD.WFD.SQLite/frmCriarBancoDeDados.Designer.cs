﻿namespace CRUD.WFD.SQLite
{
    partial class frmCriarBancoDeDados
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
            this.btn_CriarBanco = new System.Windows.Forms.Button();
            this.textBox_CaminhoCriar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarBanco = new System.Windows.Forms.Button();
            this.checkBox_Caminho = new System.Windows.Forms.CheckBox();
            this.checkBox_Senha = new System.Windows.Forms.CheckBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Tipo_Backup = new System.Windows.Forms.ComboBox();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ir_Backup = new System.Windows.Forms.Button();
            this.textBox_CaminhoBackup = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CriarBanco
            // 
            this.btn_CriarBanco.Location = new System.Drawing.Point(118, 117);
            this.btn_CriarBanco.Name = "btn_CriarBanco";
            this.btn_CriarBanco.Size = new System.Drawing.Size(96, 23);
            this.btn_CriarBanco.TabIndex = 0;
            this.btn_CriarBanco.Text = "Criar DB";
            this.btn_CriarBanco.UseVisualStyleBackColor = true;
            this.btn_CriarBanco.Click += new System.EventHandler(this.btn_CriarBancoA_Click);
            // 
            // textBox_CaminhoCriar
            // 
            this.textBox_CaminhoCriar.Location = new System.Drawing.Point(7, 42);
            this.textBox_CaminhoCriar.Name = "textBox_CaminhoCriar";
            this.textBox_CaminhoCriar.Size = new System.Drawing.Size(207, 20);
            this.textBox_CaminhoCriar.TabIndex = 2;
            this.textBox_CaminhoCriar.Text = "C:\\SQLite\\SQLiteDEMO.db3";
            this.textBox_CaminhoCriar.Click += new System.EventHandler(this.textBox_CaminhoCriar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BuscarBanco);
            this.groupBox1.Controls.Add(this.checkBox_Caminho);
            this.groupBox1.Controls.Add(this.checkBox_Senha);
            this.groupBox1.Controls.Add(this.textBox_Senha);
            this.groupBox1.Controls.Add(this.textBox_CaminhoCriar);
            this.groupBox1.Controls.Add(this.btn_CriarBanco);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar DB";
            // 
            // btn_BuscarBanco
            // 
            this.btn_BuscarBanco.Location = new System.Drawing.Point(220, 42);
            this.btn_BuscarBanco.Name = "btn_BuscarBanco";
            this.btn_BuscarBanco.Size = new System.Drawing.Size(20, 20);
            this.btn_BuscarBanco.TabIndex = 10;
            this.btn_BuscarBanco.Text = "ir";
            this.btn_BuscarBanco.UseVisualStyleBackColor = true;
            this.btn_BuscarBanco.Click += new System.EventHandler(this.btn_BuscarBanco_Click);
            // 
            // checkBox_Caminho
            // 
            this.checkBox_Caminho.AutoSize = true;
            this.checkBox_Caminho.Location = new System.Drawing.Point(7, 19);
            this.checkBox_Caminho.Name = "checkBox_Caminho";
            this.checkBox_Caminho.Size = new System.Drawing.Size(183, 17);
            this.checkBox_Caminho.TabIndex = 9;
            this.checkBox_Caminho.Text = "Definir Caminho ( C:\\SQLite.db3 )";
            this.checkBox_Caminho.UseVisualStyleBackColor = true;
            this.checkBox_Caminho.CheckStateChanged += new System.EventHandler(this.checkBox_Caminho_CheckStateChanged);
            // 
            // checkBox_Senha
            // 
            this.checkBox_Senha.AutoSize = true;
            this.checkBox_Senha.Location = new System.Drawing.Point(7, 68);
            this.checkBox_Senha.Name = "checkBox_Senha";
            this.checkBox_Senha.Size = new System.Drawing.Size(90, 17);
            this.checkBox_Senha.TabIndex = 8;
            this.checkBox_Senha.Text = "Definir Senha";
            this.checkBox_Senha.UseVisualStyleBackColor = true;
            this.checkBox_Senha.CheckedChanged += new System.EventHandler(this.checkBox_Senha_CheckedChanged);
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(7, 91);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(207, 20);
            this.textBox_Senha.TabIndex = 2;
            this.textBox_Senha.Text = "Senha";
            this.textBox_Senha.Click += new System.EventHandler(this.textBox_Senha_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Tipo_Backup);
            this.groupBox2.Controls.Add(this.btn_Backup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_ir_Backup);
            this.groupBox2.Controls.Add(this.textBox_CaminhoBackup);
            this.groupBox2.Location = new System.Drawing.Point(4, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 91);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criar Backup";
            // 
            // comboBox_Tipo_Backup
            // 
            this.comboBox_Tipo_Backup.FormattingEnabled = true;
            this.comboBox_Tipo_Backup.Items.AddRange(new object[] {
            "Mover Banco de Dados",
            "Copiar Banco de Dados"});
            this.comboBox_Tipo_Backup.Location = new System.Drawing.Point(6, 58);
            this.comboBox_Tipo_Backup.Name = "comboBox_Tipo_Backup";
            this.comboBox_Tipo_Backup.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Tipo_Backup.TabIndex = 5;
            this.comboBox_Tipo_Backup.Text = "Escolha o tipo de Backup";
            // 
            // btn_Backup
            // 
            this.btn_Backup.Location = new System.Drawing.Point(164, 58);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(75, 23);
            this.btn_Backup.TabIndex = 4;
            this.btn_Backup.Text = "Backup";
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arquivo para Backup";
            // 
            // btn_ir_Backup
            // 
            this.btn_ir_Backup.Location = new System.Drawing.Point(219, 32);
            this.btn_ir_Backup.Name = "btn_ir_Backup";
            this.btn_ir_Backup.Size = new System.Drawing.Size(20, 20);
            this.btn_ir_Backup.TabIndex = 2;
            this.btn_ir_Backup.Text = "ir";
            this.btn_ir_Backup.UseVisualStyleBackColor = true;
            this.btn_ir_Backup.Click += new System.EventHandler(this.btn_ir_Backup_Click);
            // 
            // textBox_CaminhoBackup
            // 
            this.textBox_CaminhoBackup.Location = new System.Drawing.Point(6, 32);
            this.textBox_CaminhoBackup.Name = "textBox_CaminhoBackup";
            this.textBox_CaminhoBackup.Size = new System.Drawing.Size(207, 20);
            this.textBox_CaminhoBackup.TabIndex = 0;
            // 
            // frmCriarBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCriarBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO Criar Banco de Dados Exemplo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CriarBanco;
        private System.Windows.Forms.TextBox textBox_CaminhoCriar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Senha;
        private System.Windows.Forms.CheckBox checkBox_Caminho;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.Button btn_BuscarBanco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ir_Backup;
        private System.Windows.Forms.TextBox textBox_CaminhoBackup;
        private System.Windows.Forms.ComboBox comboBox_Tipo_Backup;
    }
}