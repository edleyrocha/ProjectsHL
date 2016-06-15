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
            btn_CriarBanco.Enabled = !btn_CriarBanco.Enabled;
        }

        private void checkBox_Caminho_CheckStateChanged(object sender, EventArgs e)
        {
            textBox_CaminhoCriar.Enabled = !textBox_CaminhoCriar.Enabled;
            textBox_CaminhoCriar.Text = @"C:\SQLite\SQLiteDEMO.db3";

            if (checkBox_Caminho.Checked)
            {
                checkBox_Senha.Enabled = true;
                btn_CriarBanco.Enabled = true;
                btn_BuscarBanco.Enabled = true;

            }
            else if (!checkBox_Caminho.Checked)
            {
                checkBox_Senha.Checked = false;
                checkBox_Senha.Enabled = false;
                btn_CriarBanco.Enabled = false;
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
                var msgResult = HOYLER.Data.SQLite.H_SQLiteDatabase.BackupCopyDB(patchBackup, true);
                System.Windows.Forms.MessageBox.Show(msgResult);
            }
            else if (backupIndex == 1)
            {
                var patchBackup = textBox_CaminhoBackup.Text;
                var msgResult = HOYLER.Data.SQLite.H_SQLiteDatabase.BackupCopyDB(patchBackup, false);
                MessageBox.Show(msgResult);
            }
            else
            {
                MessageBox.Show("Outros");
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
            var Patch = (textBox_CaminhoCriar.Text);
            var Passwd = (textBox_Senha.Text);
            var PasswdHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.GetBytes(Passwd));

            H_SQLiteConnectionStringBuilder Parametros = new H_SQLiteConnectionStringBuilder()
            {
                @StringBuilder_1_SetDataSource = (Patch),
                @StringBuilder_2_SetHexPassword = (PasswdHex),
                StringBuilder_4_SetFailIfMissing = (false)
            };

            var resultCreate = (HOYLER.Data.SQLite.H_SQLiteDatabase.CreateFileDB(Parametros: Parametros));
            var msgTitle = ("Banco de Dados");
            var msgText = ("Criado com Sucesso");


            if (resultCreate == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultCreate, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_CriarDefaultDB_Click(object sender, EventArgs e)
        {
            var resultCreate = ( HOYLER.Data.SQLite.H_SQLiteDatabase.CreateFileDBDefault());
            var msgTitle = ("Banco de Dados");
            var msgText = ("Criado com Sucesso");
            if (resultCreate == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultCreate, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExecuteDefaultComman_Click(object sender, EventArgs e)
        {
            var ParametroSQL = (rtb_CommandSQL.Text);

            var resultCreate = (HOYLER.Data.SQLite.H_SQLiteDatabase.SQLExecuteNonQueryDefault(ParametroSQL: ParametroSQL));
            var msgTitle = ("Banco de Dados");
            var msgText = ("Criado com Sucesso");
            if (resultCreate == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultCreate, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExecComGrid_Click(object sender, EventArgs e)
        {
            var ParametroSQL = (rtb_CommandSQL.Text);
            var DirectoryName = (System.IO.Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (System.IO.Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (System.IO.Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            //var PasswdHex = (HOYLER.Data.SQLite.H_SQLiteDatabaseHexPassword.GetBytes("balada"));
            H_SQLiteConnectionStringBuilder Parametros = (new H_SQLiteConnectionStringBuilder()
            {
                @StringBuilder_1_SetDataSource = (FileNameComExtencao),
                @StringBuilder_3_SetPassword = ("balada")
            });
            var ParametroSaida = (String.Empty);
            var ds = (HOYLER.Data.SQLite.H_SQLiteDatabase.ExecuteSQLReturnDataset
            (
            @Parametros: Parametros,
            @ParametroSQL: ParametroSQL,
            @ParametroSaida: ref ParametroSaida
            ));
            int numero = (ds.Tables.Count);
            if (numero >= 1)
            {
                grv_Principal.DataSource = (ds.Tables[0]);
            }
        }
    }
}
