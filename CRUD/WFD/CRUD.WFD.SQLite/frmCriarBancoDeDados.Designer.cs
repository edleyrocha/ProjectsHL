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
            this.btnCriar = new System.Windows.Forms.Button();
            this.textBox_Caminho = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Tamanho = new System.Windows.Forms.ComboBox();
            this.checkBox_Caminho = new System.Windows.Forms.CheckBox();
            this.checkBox_Versao = new System.Windows.Forms.CheckBox();
            this.checkBox_TamanhoDB = new System.Windows.Forms.CheckBox();
            this.comboBox_Versao = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(333, 197);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // textBox_Caminho
            // 
            this.textBox_Caminho.Location = new System.Drawing.Point(7, 42);
            this.textBox_Caminho.Name = "textBox_Caminho";
            this.textBox_Caminho.Size = new System.Drawing.Size(234, 20);
            this.textBox_Caminho.TabIndex = 2;
            this.textBox_Caminho.Text = "C:\\SQLite\\SQLiteDEMO.db3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox_Tamanho);
            this.groupBox1.Controls.Add(this.checkBox_Caminho);
            this.groupBox1.Controls.Add(this.checkBox_Versao);
            this.groupBox1.Controls.Add(this.checkBox_TamanhoDB);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox_Versao);
            this.groupBox1.Controls.Add(this.textBox_Caminho);
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Location = new System.Drawing.Point(71, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 241);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar DB";
            // 
            // comboBox_Tamanho
            // 
            this.comboBox_Tamanho.FormattingEnabled = true;
            this.comboBox_Tamanho.Location = new System.Drawing.Point(7, 91);
            this.comboBox_Tamanho.Name = "comboBox_Tamanho";
            this.comboBox_Tamanho.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Tamanho.TabIndex = 10;
            this.comboBox_Tamanho.Text = "Escolha o Tamanho";
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
            this.checkBox_Caminho.CheckedChanged += new System.EventHandler(this.checkBox_Caminho_CheckedChanged);
            // 
            // checkBox_Versao
            // 
            this.checkBox_Versao.AutoSize = true;
            this.checkBox_Versao.Location = new System.Drawing.Point(246, 19);
            this.checkBox_Versao.Name = "checkBox_Versao";
            this.checkBox_Versao.Size = new System.Drawing.Size(92, 17);
            this.checkBox_Versao.TabIndex = 8;
            this.checkBox_Versao.Text = "Definir Versão";
            this.checkBox_Versao.UseVisualStyleBackColor = true;
            this.checkBox_Versao.CheckedChanged += new System.EventHandler(this.checkBox_Versao_CheckedChanged);
            // 
            // checkBox_TamanhoDB
            // 
            this.checkBox_TamanhoDB.AutoSize = true;
            this.checkBox_TamanhoDB.Location = new System.Drawing.Point(7, 68);
            this.checkBox_TamanhoDB.Name = "checkBox_TamanhoDB";
            this.checkBox_TamanhoDB.Size = new System.Drawing.Size(129, 17);
            this.checkBox_TamanhoDB.TabIndex = 7;
            this.checkBox_TamanhoDB.Text = "Definir Tamanho (MB)";
            this.checkBox_TamanhoDB.UseVisualStyleBackColor = true;
            this.checkBox_TamanhoDB.CheckedChanged += new System.EventHandler(this.checkBox_TamanhoDB_CheckedChanged);
            // 
            // comboBox_Versao
            // 
            this.comboBox_Versao.FormattingEnabled = true;
            this.comboBox_Versao.Items.AddRange(new object[] {
            "SQLite2x (Default)",
            "SQLite3x"});
            this.comboBox_Versao.Location = new System.Drawing.Point(246, 42);
            this.comboBox_Versao.Name = "comboBox_Versao";
            this.comboBox_Versao.Size = new System.Drawing.Size(135, 21);
            this.comboBox_Versao.TabIndex = 4;
            this.comboBox_Versao.Text = "Escolha Versão";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(142, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "UTF Encoding";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UTF 8 (Default)",
            "UTF 16"});
            this.comboBox1.Location = new System.Drawing.Point(142, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Escolha Encoding";
            // 
            // frmCriarBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 389);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCriarBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO Criar Banco de Dados Exemplo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox textBox_Caminho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Versao;
        private System.Windows.Forms.CheckBox checkBox_TamanhoDB;
        private System.Windows.Forms.CheckBox checkBox_Versao;
        private System.Windows.Forms.CheckBox checkBox_Caminho;
        private System.Windows.Forms.ComboBox comboBox_Tamanho;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}