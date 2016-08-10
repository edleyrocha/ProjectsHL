using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOYLER.Data.Access;
namespace CRUD.WFD.Access
{
    public partial class frmCriarBancoDeDados : Form
    {
        public frmCriarBancoDeDados()
        {
            this.InitializeComponent();
            this.CheckSenhaTxT(@myStatus: checkBox_Senha.Checked);
            this.CheckCaminhoTxT(@myCaminho: checkBox_Caminho.Checked);
        }
        private void CheckSenhaTxT(Boolean myStatus)
        {
            this.textBox_Senha.Enabled = (myStatus);
        }
        private void CheckCaminhoTxT(Boolean myCaminho)
        {
            this.textBox_Caminho.Enabled = (myCaminho);
            this.btn_Buscar.Enabled = (myCaminho);
            this.btn_CriarBanco.Enabled = (myCaminho);
        }
        private void checkBox_Senha_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckSenhaTxT(@myStatus: checkBox_Senha.Checked);
        }
        private void checkBox_Caminho_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckCaminhoTxT(@myCaminho: checkBox_Caminho.Checked);
        }
        private void btn_CriarBanco_Click(object sender, EventArgs e)
        {
            var myPatchDB = (textBox_Caminho.Text);
            var Passwd = (textBox_Senha.Text);

            var resultCreate = (String.Empty);

            if (textBox_Senha.Enabled == true)
            {
                resultCreate = (H_AccessDatabase.CreateFileDBClean(@myPatchDB: myPatchDB, @myPassword: Passwd));
            }
            else if (textBox_Senha.Enabled == false)
            {
                resultCreate = (H_AccessDatabase.CreateFileDBClean(@myPatchDB: myPatchDB));
            };
           
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
    }
}
