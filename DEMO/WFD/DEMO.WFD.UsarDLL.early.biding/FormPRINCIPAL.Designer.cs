namespace DEMO.WFD.UsarDLL.early.biding
{
    partial class FormPRINCIPAL
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
            this.btnAutomatico = new System.Windows.Forms.Button();
            this.rbAuto_EXP = new System.Windows.Forms.RadioButton();
            this.rbAuto_IMP = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAutomatico
            // 
            this.btnAutomatico.Location = new System.Drawing.Point(37, 91);
            this.btnAutomatico.Name = "btnAutomatico";
            this.btnAutomatico.Size = new System.Drawing.Size(227, 23);
            this.btnAutomatico.TabIndex = 1;
            this.btnAutomatico.Text = "Automatico com References \"Early Bding\"";
            this.btnAutomatico.UseVisualStyleBackColor = true;
            this.btnAutomatico.Click += new System.EventHandler(this.btnAutomatico_Click);
            // 
            // rbAuto_EXP
            // 
            this.rbAuto_EXP.AutoSize = true;
            this.rbAuto_EXP.Location = new System.Drawing.Point(68, 148);
            this.rbAuto_EXP.Name = "rbAuto_EXP";
            this.rbAuto_EXP.Size = new System.Drawing.Size(159, 17);
            this.rbAuto_EXP.TabIndex = 2;
            this.rbAuto_EXP.TabStop = true;
            this.rbAuto_EXP.Text = "Criar Novo Form EXPLICITO";
            this.rbAuto_EXP.UseVisualStyleBackColor = true;
            // 
            // rbAuto_IMP
            // 
            this.rbAuto_IMP.AutoSize = true;
            this.rbAuto_IMP.Location = new System.Drawing.Point(68, 120);
            this.rbAuto_IMP.Name = "rbAuto_IMP";
            this.rbAuto_IMP.Size = new System.Drawing.Size(157, 17);
            this.rbAuto_IMP.TabIndex = 3;
            this.rbAuto_IMP.TabStop = true;
            this.rbAuto_IMP.Text = "Criar Novo Form IMPLICITO";
            this.rbAuto_IMP.UseVisualStyleBackColor = true;
            // 
            // FormPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rbAuto_IMP);
            this.Controls.Add(this.rbAuto_EXP);
            this.Controls.Add(this.btnAutomatico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutomatico;
        private System.Windows.Forms.RadioButton rbAuto_EXP;
        private System.Windows.Forms.RadioButton rbAuto_IMP;
    }
}

