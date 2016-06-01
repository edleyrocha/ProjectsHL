using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HOYLER.Data.SQLite;


namespace CRUD.WFD.SQLite
{
    public partial class frmCriarBancoDeDados : Form
    {
        public frmCriarBancoDeDados()
        {
            InitializeComponent();
            textBox_CaminhoCriar.Enabled = !textBox_CaminhoCriar.Enabled;
            textBox_Senha.Enabled = !textBox_Senha.Enabled;
            checkBox_Senha.Enabled = !checkBox_Senha.Enabled;
            btn_BuscarBanco.Enabled = !btn_BuscarBanco.Enabled;
            btn_CriarBancoA.Enabled = !btn_CriarBancoA.Enabled;
            btn_CriarBancoB.Enabled = !btn_CriarBancoB.Enabled;
        }

        private void checkBox_Caminho_CheckStateChanged(object sender, EventArgs e)
        {
            textBox_CaminhoCriar.Enabled = !textBox_CaminhoCriar.Enabled;
            textBox_CaminhoCriar.Text = @"C:\SQLite\SQLiteDEMO.db3";

            if (checkBox_Caminho.Checked)
            {
                checkBox_Senha.Enabled = true;
                btn_CriarBancoA.Enabled = true;
                btn_CriarBancoB.Enabled = true;
                btn_BuscarBanco.Enabled = true;

            }
            else if (!checkBox_Caminho.Checked)
            {
                checkBox_Senha.Checked = false;
                checkBox_Senha.Enabled = false;
                btn_CriarBancoA.Enabled = false;
                btn_CriarBancoB.Enabled = false;
                btn_BuscarBanco.Enabled = false;
            }
        }

        private void checkBox_Senha_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Senha.Text = ("Senha...");
            textBox_Senha.Enabled = !textBox_Senha.Enabled;

        }

        private void textBox_Senha_Click(object sender, EventArgs e)
        {
            textBox_Senha.Text = String.Empty;
        }

        private void textBox_CaminhoCriar_Click(object sender, EventArgs e)
        {
            textBox_CaminhoCriar.Text = String.Empty;
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            var backupIndex = comboBox_Tipo_Backup.SelectedIndex;
            if (backupIndex == 0)
            {
                var patchBackup = textBox_CaminhoBackup.Text;
                var msgResult = HOYLER.Data.SQLite.H_SQLiteDatabaseBackup.BackupDatabaseCopyDB(patchBackup, true);
                MessageBox.Show(msgResult);
            }
            else if (backupIndex == 1)
            {
                var patchBackup = textBox_CaminhoBackup.Text;
                var msgResult = HOYLER.Data.SQLite.H_SQLiteDatabaseBackup.BackupDatabaseCopyDB(patchBackup, false);
                MessageBox.Show(msgResult);
            }
            else
            {
                MessageBox.Show("xxxx");
            }
        }

        private void btn_ir_Backup_Click(object sender, EventArgs e)
        {
            var openFileDialog = (new OpenFileDialog());
            openFileDialog.Title = "Localizar Arquivos de Banco de Dados SQLite *.db3";
            openFileDialog.InitialDirectory = (@"C:\");
            openFileDialog.Filter = "db3 files (*.db3)|*.db3|All files (*.*)|*.*";
            openFileDialog.DefaultExt = ("db3");
            openFileDialog.CheckFileExists = (true);
            openFileDialog.CheckPathExists = (true);
            openFileDialog.Multiselect = (false);
            openFileDialog.ReadOnlyChecked = (true);
            openFileDialog.ShowReadOnly = (true);
            openFileDialog.AutoUpgradeEnabled = (true);
            openFileDialog.ShowDialog();
            textBox_CaminhoBackup.Text = openFileDialog.FileName;
        }

        private void btn_CriarBancoA_Click(object sender, EventArgs e)
        {
            var PatchA = (textBox_CaminhoCriar.Text);
            var passwdA = (textBox_Senha.Text);
            var passwdAHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.H_GetBytes(passwdA));
            var StringConn = (HOYLER.Data.SQLite.H_SQLiteDatabaseConnectionString.GetConnectionString(PatchA, passwdAHex));
            var createFileA = (HOYLER.Data.SQLite.H_SQLiteDatabaseCreateDB.H_DatabaseCreateFile(StringConn));
            var msgTitle = ("Banco de Dados");
            var msgText = ("Criado com Sucesso");
            if (createFileA == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(createFileA, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CriarBancoB_Click(object sender, EventArgs e)
        {
            var PatchB = (textBox_CaminhoCriar.Text);
            var passwdB = (textBox_Senha.Text);
            var passwdBHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.H_GetBytes(passwdB));
            var createFileB = (HOYLER.Data.SQLite.H_SQLiteDatabaseCreateDB.H_DatabaseCreateFile(PatchB, passwdBHex));
            var msgTitle = ("Banco de Dados");
            var msgText = ("Criado com Sucesso");
            if (createFileB == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(createFileB, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BuscarBanco_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            var openFileDialog = (new OpenFileDialog());
            saveFileDialog.Title = "Cria Arquivo de Banco de Dados SQLite *.db3";
            saveFileDialog.InitialDirectory = (@"C:\");
            saveFileDialog.Filter = "db3 files (*.db3)|*.db3|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = ("db3");
            saveFileDialog.CheckPathExists = (true);
            saveFileDialog.AutoUpgradeEnabled = (true);
            saveFileDialog.ShowDialog();
            textBox_CaminhoCriar.Text = saveFileDialog.FileName;
        }
    }
}
