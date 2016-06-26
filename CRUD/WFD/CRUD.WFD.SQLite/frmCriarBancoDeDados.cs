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
using System.IO;


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
            var resultCreate = (H_SQLiteDatabaseDefault.CreateFileDBDefault());
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

        private void btn_ExecuteDefaultCommand_Click(object sender, EventArgs e)
        {
            var ParametroSQL = (rtb_CommandSQL.Text);
            var resultCreate = (H_SQLiteDatabaseDefault.SQLExecuteNonQueryDefault(@myParametroSQL: ParametroSQL));
            var msgTitle = ("Banco de Dados");
            var msgText = ("Sucesso");
            if (resultCreate == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(resultCreate, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_ExecCommDataSetGrid_Click(object sender, EventArgs e)
        {
            var myParametroSQL = (rtb_CommandSQL.Text);
            var myParametroSaida = (String.Empty);
            var ds = (H_SQLiteDatabaseDefault.ExecuteSQLReturnDatasetDefault(@myParametroSQL: myParametroSQL, @myParametroSaida: ref myParametroSaida));
            int numero = (ds.Tables.Count);
            if (numero >= 1)
            {
                grv_Principal.DataSource = (ds.Tables[0]);
            }
            else if (numero == 0)
            {
                grv_Principal.DataSource = null;
            }
            var msgTitle = ("Banco de Dados");
            var msgText = ("Sucesso");
            if (myParametroSaida == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(myParametroSaida, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_ExecCommDataTableGrid_Click(object sender, EventArgs e)
        {
            var myParametroSQL = (rtb_CommandSQL.Text);
            var myParametroSaida = (String.Empty);
            var dt = (H_SQLiteDatabaseDefault.ExecuteSQLReturnDataTableDefault(@myParametroSQL: myParametroSQL, @myParametroSaida: ref myParametroSaida));
            if (dt != null)
            {
                if (dt.Rows.Count >= 1)
                {
                    grv_Principal.DataSource = (dt);
                }
                else if (dt.Rows.Count == 1)
                {
                    grv_Principal.DataSource = null;
                }
            }
            var msgTitle = ("Banco de Dados");
            var msgText = ("Sucesso");
            if (myParametroSaida == "OK")
            {
                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(myParametroSaida, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
    }
}
