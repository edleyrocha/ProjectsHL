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
            InitializeComponent();
        }

        private void btn_CriarBanco_Click(object sender, EventArgs e)
        {
            var myPatchDB = (textBox_CaminhoCriar.Text);
            var Passwd = (textBox_Senha.Text);

            var resultCreate = (H_AccessDatabase.CreateFileDB(@myPatchDB: myPatchDB));
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
    }
}
