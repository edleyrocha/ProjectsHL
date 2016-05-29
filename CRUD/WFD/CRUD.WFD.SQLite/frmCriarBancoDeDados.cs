using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.HOYLER.Data;


namespace CRUD.WFD.SQLite
{
    public partial class frmCriarBancoDeDados : Form
    {
        public frmCriarBancoDeDados()
        {
            InitializeComponent();
            comboBox_Versao.Enabled = !comboBox_Versao.Enabled;
            comboBox_Tamanho.Enabled = !comboBox_Tamanho.Enabled;
            checkBox_Caminho.Checked = !checkBox_Caminho.Checked;
           
         
        }
        private void checkBox_Versao_CheckedChanged(object sender, EventArgs e)
        {
            bool status;
            status = comboBox_Versao.Enabled;

            if (status == true)
            {
                comboBox_Versao.Enabled = !status;
            }
            else
            {
                comboBox_Versao.Enabled = !status;
            };
        }
 


        private void checkBox_TamanhoDB_CheckedChanged(object sender, EventArgs e)
        {
            bool status;
            status = comboBox_Tamanho.Enabled;

            if (status == true)
            {
                comboBox_Tamanho.Enabled = !status;
            }
            else
            {
                comboBox_Tamanho.Enabled = !status;
            };

        }

        private void textBox_Tamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void checkBox_Caminho_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Caminho.Enabled = !textBox_Caminho.Enabled;
            checkBox_Versao.Enabled = textBox_Caminho.Enabled;
            checkBox_TamanhoDB.Enabled = textBox_Caminho.Enabled;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            var SDC = new HOYLER.Data.SQLite.SQLiteDatabaseCreate();
            var myHexPassword = (HOYLER.Data.SQLite.SQLiteDatabaseHexPassword.GetBytes("123456789"));
            var myDataSource = (System.IO.Path.Combine((AppDomain.CurrentDomain.BaseDirectory.ToString()), ("HOYLER.Connection.db3")).ToString());
            //var myDataSource = AppDomain.CurrentDomain.BaseDirectory.ToString() + "HOYLER.Connection.db3";
            var msg = SDC.DatabaseCreateFile(myDataSource, myHexPassword);
            MessageBox.Show(msg);
          

          //  var c = new HOYLER.Data.SQLite.SQLiteConnectionDEFAULT();
          //  var result = c.CreateDatabaseDEFAULTaa();
          //if (result== "OK")
          //{
          //    MessageBox.Show(result,"Sucessso");
          //}
          //else
          //{
          //    MessageBox.Show(result);
          //}
        }






    }
}
