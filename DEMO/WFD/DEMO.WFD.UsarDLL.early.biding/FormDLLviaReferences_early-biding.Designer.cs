namespace DEMO.WFD.UsarDLL.early.biding
{
    partial class FormDLLviaReferences
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
            this.txtbNomeResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNomeViaReferences = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_SemDeclararDLL = new System.Windows.Forms.RadioButton();
            this.rb_DeclararDLL = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_ModoIMP = new System.Windows.Forms.RadioButton();
            this.rb_ModoEXP = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNomeDigitado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbNomeResultado
            // 
            this.txtbNomeResultado.Location = new System.Drawing.Point(0, 95);
            this.txtbNomeResultado.Name = "txtbNomeResultado";
            this.txtbNomeResultado.ReadOnly = true;
            this.txtbNomeResultado.Size = new System.Drawing.Size(302, 20);
            this.txtbNomeResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Qual seu Nome:";
            // 
            // btnNomeViaReferences
            // 
            this.btnNomeViaReferences.Location = new System.Drawing.Point(308, 92);
            this.btnNomeViaReferences.Name = "btnNomeViaReferences";
            this.btnNomeViaReferences.Size = new System.Drawing.Size(110, 23);
            this.btnNomeViaReferences.TabIndex = 5;
            this.btnNomeViaReferences.Text = "Chamar Nome";
            this.btnNomeViaReferences.UseVisualStyleBackColor = true;
            this.btnNomeViaReferences.Click += new System.EventHandler(this.btnNomeViaReferences_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbNomeDigitado);
            this.groupBox1.Controls.Add(this.btnNomeViaReferences);
            this.groupBox1.Controls.Add(this.txtbNomeResultado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usando DLL via References";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_SemDeclararDLL);
            this.panel2.Controls.Add(this.rb_DeclararDLL);
            this.panel2.Location = new System.Drawing.Point(308, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 40);
            this.panel2.TabIndex = 11;
            // 
            // rb_SemDeclararDLL
            // 
            this.rb_SemDeclararDLL.AutoSize = true;
            this.rb_SemDeclararDLL.Location = new System.Drawing.Point(4, 22);
            this.rb_SemDeclararDLL.Name = "rb_SemDeclararDLL";
            this.rb_SemDeclararDLL.Size = new System.Drawing.Size(112, 17);
            this.rb_SemDeclararDLL.TabIndex = 1;
            this.rb_SemDeclararDLL.TabStop = true;
            this.rb_SemDeclararDLL.Text = "Sem Declarar DLL";
            this.rb_SemDeclararDLL.UseVisualStyleBackColor = true;
            // 
            // rb_DeclararDLL
            // 
            this.rb_DeclararDLL.AutoSize = true;
            this.rb_DeclararDLL.Location = new System.Drawing.Point(4, 5);
            this.rb_DeclararDLL.Name = "rb_DeclararDLL";
            this.rb_DeclararDLL.Size = new System.Drawing.Size(103, 17);
            this.rb_DeclararDLL.TabIndex = 0;
            this.rb_DeclararDLL.TabStop = true;
            this.rb_DeclararDLL.Text = "Declarando DLL";
            this.rb_DeclararDLL.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_ModoIMP);
            this.panel1.Controls.Add(this.rb_ModoEXP);
            this.panel1.Location = new System.Drawing.Point(308, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 39);
            this.panel1.TabIndex = 10;
            // 
            // rb_ModoIMP
            // 
            this.rb_ModoIMP.AutoSize = true;
            this.rb_ModoIMP.Location = new System.Drawing.Point(3, 3);
            this.rb_ModoIMP.Name = "rb_ModoIMP";
            this.rb_ModoIMP.Size = new System.Drawing.Size(108, 17);
            this.rb_ModoIMP.TabIndex = 8;
            this.rb_ModoIMP.TabStop = true;
            this.rb_ModoIMP.Text = "Modo IMPLICITO";
            this.rb_ModoIMP.UseVisualStyleBackColor = true;
            // 
            // rb_ModoEXP
            // 
            this.rb_ModoEXP.AutoSize = true;
            this.rb_ModoEXP.Location = new System.Drawing.Point(3, 19);
            this.rb_ModoEXP.Name = "rb_ModoEXP";
            this.rb_ModoEXP.Size = new System.Drawing.Size(110, 17);
            this.rb_ModoEXP.TabIndex = 9;
            this.rb_ModoEXP.TabStop = true;
            this.rb_ModoEXP.Text = "Modo EXPLICITO";
            this.rb_ModoEXP.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite um Nome:";
            // 
            // txtbNomeDigitado
            // 
            this.txtbNomeDigitado.Location = new System.Drawing.Point(0, 56);
            this.txtbNomeDigitado.Name = "txtbNomeDigitado";
            this.txtbNomeDigitado.Size = new System.Drawing.Size(302, 20);
            this.txtbNomeDigitado.TabIndex = 6;
            // 
            // FormDLLviaReferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 144);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDLLviaReferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form DLL via References “early biding”";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNomeResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNomeViaReferences;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNomeDigitado;
        private System.Windows.Forms.RadioButton rb_ModoEXP;
        private System.Windows.Forms.RadioButton rb_ModoIMP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_SemDeclararDLL;
        private System.Windows.Forms.RadioButton rb_DeclararDLL;
    }
}