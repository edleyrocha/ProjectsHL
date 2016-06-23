namespace CRUD.WFD.SQLite
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
            this.cBox_TipoBackup = new System.Windows.Forms.ComboBox();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ir_Backup = new System.Windows.Forms.Button();
            this.textBox_CaminhoBackup = new System.Windows.Forms.TextBox();
            this.btn_CriarDefaultDB = new System.Windows.Forms.Button();
            this.btn_ExecuteDefaultComman = new System.Windows.Forms.Button();
            this.grv_Principal = new System.Windows.Forms.DataGridView();
            this.btn_ExecComGrid = new System.Windows.Forms.Button();
            this.rtb_CommandSQL = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Principal)).BeginInit();
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
            this.groupBox2.Controls.Add(this.cBox_TipoBackup);
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
            // cBox_TipoBackup
            // 
            this.cBox_TipoBackup.FormattingEnabled = true;
            this.cBox_TipoBackup.Location = new System.Drawing.Point(6, 59);
            this.cBox_TipoBackup.Name = "cBox_TipoBackup";
            this.cBox_TipoBackup.Size = new System.Drawing.Size(126, 21);
            this.cBox_TipoBackup.TabIndex = 5;
            // 
            // btn_Backup
            // 
            this.btn_Backup.Location = new System.Drawing.Point(138, 58);
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
            // btn_CriarDefaultDB
            // 
            this.btn_CriarDefaultDB.Location = new System.Drawing.Point(272, 25);
            this.btn_CriarDefaultDB.Name = "btn_CriarDefaultDB";
            this.btn_CriarDefaultDB.Size = new System.Drawing.Size(102, 23);
            this.btn_CriarDefaultDB.TabIndex = 5;
            this.btn_CriarDefaultDB.Text = "Criar Default DB";
            this.btn_CriarDefaultDB.UseVisualStyleBackColor = true;
            this.btn_CriarDefaultDB.Click += new System.EventHandler(this.btn_CriarDefaultDB_Click);
            // 
            // btn_ExecuteDefaultComman
            // 
            this.btn_ExecuteDefaultComman.Location = new System.Drawing.Point(272, 288);
            this.btn_ExecuteDefaultComman.Name = "btn_ExecuteDefaultComman";
            this.btn_ExecuteDefaultComman.Size = new System.Drawing.Size(264, 23);
            this.btn_ExecuteDefaultComman.TabIndex = 6;
            this.btn_ExecuteDefaultComman.Text = "Execute Non Query Command";
            this.btn_ExecuteDefaultComman.UseVisualStyleBackColor = true;
            this.btn_ExecuteDefaultComman.Click += new System.EventHandler(this.btn_ExecuteDefaultComman_Click);
            // 
            // grv_Principal
            // 
            this.grv_Principal.AllowUserToAddRows = false;
            this.grv_Principal.AllowUserToDeleteRows = false;
            this.grv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Principal.Location = new System.Drawing.Point(272, 156);
            this.grv_Principal.Name = "grv_Principal";
            this.grv_Principal.ReadOnly = true;
            this.grv_Principal.Size = new System.Drawing.Size(396, 126);
            this.grv_Principal.TabIndex = 7;
            // 
            // btn_ExecComGrid
            // 
            this.btn_ExecComGrid.Location = new System.Drawing.Point(272, 317);
            this.btn_ExecComGrid.Name = "btn_ExecComGrid";
            this.btn_ExecComGrid.Size = new System.Drawing.Size(264, 23);
            this.btn_ExecComGrid.TabIndex = 8;
            this.btn_ExecComGrid.Text = "Execute Command Dataset Return Grid";
            this.btn_ExecComGrid.UseVisualStyleBackColor = true;
            this.btn_ExecComGrid.Click += new System.EventHandler(this.btn_ExecComGrid_Click);
            // 
            // rtb_CommandSQL
            // 
            this.rtb_CommandSQL.Location = new System.Drawing.Point(272, 54);
            this.rtb_CommandSQL.Name = "rtb_CommandSQL";
            this.rtb_CommandSQL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_CommandSQL.Size = new System.Drawing.Size(396, 96);
            this.rtb_CommandSQL.TabIndex = 9;
            this.rtb_CommandSQL.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Execute Command DataTable Return Grid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCriarBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_CommandSQL);
            this.Controls.Add(this.btn_ExecComGrid);
            this.Controls.Add(this.grv_Principal);
            this.Controls.Add(this.btn_ExecuteDefaultComman);
            this.Controls.Add(this.btn_CriarDefaultDB);
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
            ((System.ComponentModel.ISupportInitialize)(this.grv_Principal)).EndInit();
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
        private System.Windows.Forms.Button btn_CriarDefaultDB;
        private System.Windows.Forms.Button btn_ExecuteDefaultComman;
        private System.Windows.Forms.DataGridView grv_Principal;
        private System.Windows.Forms.Button btn_ExecComGrid;
        private System.Windows.Forms.RichTextBox rtb_CommandSQL;
        private System.Windows.Forms.ComboBox cBox_TipoBackup;
        private System.Windows.Forms.Button button1;
    }
}