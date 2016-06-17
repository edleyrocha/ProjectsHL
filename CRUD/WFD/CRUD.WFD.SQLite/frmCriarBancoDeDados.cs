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
            this.InitializeComponent();
            this.textBox_CaminhoCriar.Enabled = !textBox_CaminhoCriar.Enabled;
            this.textBox_Senha.Enabled = !textBox_Senha.Enabled;
            this.checkBox_Senha.Enabled = !checkBox_Senha.Enabled;
            this.btn_BuscarBanco.Enabled = !btn_BuscarBanco.Enabled;
            this.btn_CriarBanco.Enabled = !btn_CriarBanco.Enabled;
            this.cBoxCarregarItens();
        }

        private void cBoxCarregarItens()
        {
            //cBox_TipoBackup.DataSource = Enum.GetValues(typeof(H_SQLiteBackup.EscolhaTipo));
            cBox_TipoBackup.Text = ("Escolha Modo Backup");
            foreach (var myItem in Enum.GetValues(typeof(H_SQLiteBackup.EscolhaTipo)))
            {
                var myIndex = (int)((H_SQLiteBackup.EscolhaTipo)myItem);
                cBox_TipoBackup.Items.Insert(index: myIndex, item: myItem);
                //cBox_TipoBackup.Items.Add(myItem);
            }
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

            var msgResult = (String.Empty);
            var myDataSource = (textBox_CaminhoBackup.Text);
            var myBackupIndex = (cBox_TipoBackup.SelectedIndex);
            var myExecTipo = (H_SQLiteBackup.EscolhaTipo)(myBackupIndex);

            if ((myExecTipo) == (H_SQLiteBackup.EscolhaTipo.Move))
            {
                msgResult = (HOYLER.Data.SQLite.H_SQLiteBackup.BackupDB(myDataSource: myDataSource, myExecTipo: myExecTipo));
            }
            else if ((myExecTipo) == (H_SQLiteBackup.EscolhaTipo.Copy))
            {
                msgResult = (HOYLER.Data.SQLite.H_SQLiteBackup.BackupDB(myDataSource: myDataSource, myExecTipo: myExecTipo));
            }
            else if ((myExecTipo) == (H_SQLiteBackup.EscolhaTipo.Backup))
            {
                var myPassword = ("balada");
                msgResult = (HOYLER.Data.SQLite.H_SQLiteBackup.BackupDB(myDataSource: myDataSource, myPassword: myPassword, myExecTipo: myExecTipo));
            };

            var msgTitle = ("Banco de Dados");
            var msgText = ("Criado com Sucesso");

            if (msgResult == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msgResult, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
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
                @SetStringBuilder1_DataSource = (Patch),
                @SetStringBuilder2_HexPassword = (PasswdHex),
                @SetStringBuilder3_FailIfMissing = (false)
            };

            var resultCreate = (HOYLER.Data.SQLite.H_SQLiteDatabase.CreateFileDB(myParametros: Parametros));
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
            var resultCreate = (HOYLER.Data.SQLite.H_SQLiteDatabase.CreateFileDBDefault());
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
            ParametroSQL = (ParametroSQL.Replace("\t", "").Trim());
            ParametroSQL = (ParametroSQL.Replace("\n", "").Trim());
            var resultCreate = (HOYLER.Data.SQLite.H_SQLiteDatabase.SQLExecuteNonQueryDefault(myParametroSQL: ParametroSQL));
            var msgTitle = ("Banco de Dados");
            var msgText = ("Criado com Sucesso");
            if (resultCreate == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultCreate, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_ExecComGrid_Click(object sender, EventArgs e)
        {
            var ParametroSQL = (rtb_CommandSQL.Text);
            var DirectoryName = (System.IO.Directory.GetCurrentDirectory());
            var DirectoryName_FileName = (System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var FileNameSemExtencao = (System.IO.Path.GetFileNameWithoutExtension(DirectoryName_FileName));
            var Extencao = (".db3");
            var FileNameComExtencao = (System.IO.Path.Combine((DirectoryName), ((FileNameSemExtencao) + (Extencao))));
            var Passwd = ("balada");
            H_SQLiteConnectionStringBuilder Parametros = (new H_SQLiteConnectionStringBuilder()
            {
                @SetStringBuilder1_DataSource = (FileNameComExtencao),
                @SetStringBuilder2_Password = (Passwd)
            });
            var ParametroSaida = (String.Empty);
            var ds = (HOYLER.Data.SQLite.H_SQLiteDatabase.ExecuteSQLReturnDataset
                     (
                     @myParametros: Parametros,
                     @myParametroSQL: ParametroSQL,
                     @myParametroSaida: ref ParametroSaida
                     ));
            int numero = (ds.Tables.Count);
            if (numero >= 1)
            {
                grv_Principal.DataSource = (ds.Tables[0]);
            }
        }
    }
}
