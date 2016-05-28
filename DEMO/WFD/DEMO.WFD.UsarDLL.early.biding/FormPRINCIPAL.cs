using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO.WFD.UsarDLL.early.biding
{
    public partial class FormPRINCIPAL : Form
    {
        public FormPRINCIPAL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para Mostar Mensagem Escolher
        /// IMPLICITO 
        /// EXPLICITO
        /// </summary>
        public static void Escolha_IMP_EXP()
        {
            MessageBox.Show("Escolha um Tipo. \n\n IMPLICITO \n EXPLICITO", "Leia-Me", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnAutomatico_Click(object sender, EventArgs e)
        {
    
            
          
            /*
             * C# type inference?
             *  var i = 10; // implicitly typed
             *  int i = 10; // explicitly typed
            */
            if (rbAuto_IMP.Checked)
            {
                // Nao Passo o tipo somente o valor
                var f1 = new FormDLLviaReferences();
                f1.ShowDialog();
            }
            else if (rbAuto_EXP.Checked)
            {
                // Passo o tipo e valor
                FormDLLviaReferences f1 = new FormDLLviaReferences();
                f1.ShowDialog();
            }
            else
            {
                Escolha_IMP_EXP();
            }
        }
    }
}
