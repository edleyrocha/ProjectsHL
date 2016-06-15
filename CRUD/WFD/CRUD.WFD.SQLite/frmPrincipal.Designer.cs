namespace CRUD.WFD.SQLite
{
    partial class frmPrincipal
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
            this.btn_CreateDB = new System.Windows.Forms.Button();
            this.dtv_Principal = new System.Windows.Forms.DataGridView();
            this.btn_dell = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreateDB
            // 
            this.btn_CreateDB.Location = new System.Drawing.Point(0, 308);
            this.btn_CreateDB.Name = "btn_CreateDB";
            this.btn_CreateDB.Size = new System.Drawing.Size(93, 23);
            this.btn_CreateDB.TabIndex = 0;
            this.btn_CreateDB.Text = "Criar DB SQLite";
            this.btn_CreateDB.UseVisualStyleBackColor = true;
            this.btn_CreateDB.Click += new System.EventHandler(this.btn_CreateDB_Click);
            // 
            // dtv_Principal
            // 
            this.dtv_Principal.AllowUserToAddRows = false;
            this.dtv_Principal.AllowUserToDeleteRows = false;
            this.dtv_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Principal.Location = new System.Drawing.Point(0, 73);
            this.dtv_Principal.Name = "dtv_Principal";
            this.dtv_Principal.ReadOnly = true;
            this.dtv_Principal.Size = new System.Drawing.Size(721, 229);
            this.dtv_Principal.TabIndex = 1;
            // 
            // btn_dell
            // 
            this.btn_dell.Location = new System.Drawing.Point(552, 308);
            this.btn_dell.Name = "btn_dell";
            this.btn_dell.Size = new System.Drawing.Size(75, 23);
            this.btn_dell.TabIndex = 2;
            this.btn_dell.Text = "Deletar";
            this.btn_dell.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(471, 308);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(390, 308);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(634, 308);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Read.TabIndex = 5;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 423);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_dell);
            this.Controls.Add(this.dtv_Principal);
            this.Controls.Add(this.btn_CreateDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO SQLite";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateDB;
        private System.Windows.Forms.DataGridView dtv_Principal;
        private System.Windows.Forms.Button btn_dell;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Read;
    }
}

