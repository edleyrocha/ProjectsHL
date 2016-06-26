namespace CRUD.WFD.Access
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BuscarBanco = new System.Windows.Forms.Button();
            this.checkBox_Caminho = new System.Windows.Forms.CheckBox();
            this.checkBox_Senha = new System.Windows.Forms.CheckBox();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.textBox_CaminhoCriar = new System.Windows.Forms.TextBox();
            this.btn_CriarBanco = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(247, 146);
            this.groupBox1.TabIndex = 4;
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
            // 
            // checkBox_Caminho
            // 
            this.checkBox_Caminho.AutoSize = true;
            this.checkBox_Caminho.Location = new System.Drawing.Point(7, 19);
            this.checkBox_Caminho.Name = "checkBox_Caminho";
            this.checkBox_Caminho.Size = new System.Drawing.Size(186, 17);
            this.checkBox_Caminho.TabIndex = 9;
            this.checkBox_Caminho.Text = "Definir Caminho C:\\Access.accdb";
            this.checkBox_Caminho.UseVisualStyleBackColor = true;
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
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.Location = new System.Drawing.Point(7, 91);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(207, 20);
            this.textBox_Senha.TabIndex = 2;
            this.textBox_Senha.Text = "Senha";
            // 
            // textBox_CaminhoCriar
            // 
            this.textBox_CaminhoCriar.Location = new System.Drawing.Point(7, 42);
            this.textBox_CaminhoCriar.Name = "textBox_CaminhoCriar";
            this.textBox_CaminhoCriar.Size = new System.Drawing.Size(207, 20);
            this.textBox_CaminhoCriar.TabIndex = 2;
            this.textBox_CaminhoCriar.Text = "C:\\Access\\Access.accdb";
            // 
            // btn_CriarBanco
            // 
            this.btn_CriarBanco.Location = new System.Drawing.Point(118, 117);
            this.btn_CriarBanco.Name = "btn_CriarBanco";
            this.btn_CriarBanco.Size = new System.Drawing.Size(96, 23);
            this.btn_CriarBanco.TabIndex = 0;
            this.btn_CriarBanco.Text = "Criar DB";
            this.btn_CriarBanco.UseVisualStyleBackColor = true;
            this.btn_CriarBanco.Click += new System.EventHandler(this.btn_CriarBanco_Click);
            // 
            // frmCriarBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCriarBancoDeDados";
            this.Text = "DEMO Criar Banco de Dados Exemplo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BuscarBanco;
        private System.Windows.Forms.CheckBox checkBox_Caminho;
        private System.Windows.Forms.CheckBox checkBox_Senha;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.TextBox textBox_CaminhoCriar;
        private System.Windows.Forms.Button btn_CriarBanco;
    }
}

