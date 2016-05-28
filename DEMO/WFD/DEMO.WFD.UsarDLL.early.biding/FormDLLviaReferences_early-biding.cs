using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Referencia ao namespace MinhaDLL
using MinhaDLL;

namespace DEMO.WFD.UsarDLL.early.biding
{
    public partial class FormDLLviaReferences : Form
    {
        /// <summary>
        /// Metodo Contrutor Simples
        /// </summary>
        public FormDLLviaReferences()
        {
            InitializeComponent();
            rb_ModoIMP.Checked = true;
            rb_DeclararDLL.Checked = true;
        }
        private void MsgLocal_herry()
        {
            String PatchDLL_1 = AppDomain.CurrentDomain.BaseDirectory.ToString();
            String PatchDLL_2 = System.IO.Directory.GetCurrentDirectory();
            String PatchDLL_3 = System.Reflection.Assembly.GetExecutingAssembly().Location;
            String PatchDLL_4 = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            String PatchDLL_5 = System.IO.Path.GetDirectoryName(PatchDLL_3);
            String PatchDLL_6 = Environment.GetCommandLineArgs()[0].ToString();
            String PatchDLL_7 = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]).ToString();
            String PatchDLL_8 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            MessageBox.Show(PatchDLL_1 + "\n" +
                            PatchDLL_2 + "\n" +
                            PatchDLL_3 + "\n" +
                            PatchDLL_4 + "\n" +
                            PatchDLL_5 + "\n" +
                            PatchDLL_6 + "\n" +
                            PatchDLL_7 + "\n" +
                            PatchDLL_8 + "\n");
        }
        /// <summary>
        /// Metodo Click do Botao  btnNomeDLL
        /// </summary>
        /// <param name="sender">Objeto Sender </param>
        /// <param name="e">EventArgs e </param>
        private void btnNomeViaReferences_Click(object sender, EventArgs e)
        {
            if (rb_DeclararDLL.Checked)
            {
                if (rb_ModoIMP.Checked)
                {
                    /// Metodos Retonar esta com o nameSpace ja Declaro no TOP
                    var dll = (new MinhaDLL_Exemplo());
                    txtbNomeResultado.Text = dll.GetNome(txtbNomeDigitado.Text.ToString() + (" | Declarando DLL IMP"));

                }
                else if (rb_ModoEXP.Checked)
                {
                    ///// Metodos Retonar esta com o nameSpace ja Declaro no TOP
                    MinhaDLL_Exemplo dll = (new MinhaDLL_Exemplo());
                    txtbNomeResultado.Text = dll.GetNome(txtbNomeDigitado.Text.ToString() + (" | Declarando DLL EXP"));
                }
                else
                {
                    FormPRINCIPAL.Escolha_IMP_EXP();
                } // end if rb_ModoIMP e rb_ModoEXP

            }
            else if (rb_SemDeclararDLL.Checked)
            {
                if (rb_ModoIMP.Checked)
                {
                    /// Metodos Retonar esta sendo Usado Direto sem usar o Using no top e de modo IMPLICITO
                    var dll = (new MinhaDLL.MinhaDLL_Exemplo());
                    txtbNomeResultado.Text = dll.GetNome(txtbNomeDigitado.Text.ToString() + (" | Sem Declarar DLL IMP "));
                }
                else if (rb_ModoEXP.Checked)
                {
                    /// Metodos Retonar esta sendo Usado Direto sem usar o Using no top e de modo EXPLICITO
                    MinhaDLL.MinhaDLL_Exemplo dll = (new MinhaDLL.MinhaDLL_Exemplo());
                    txtbNomeResultado.Text = dll.GetNome(txtbNomeDigitado.Text.ToString() + ("  | Sem Declarar DLL + EXP"));
                }
                else
                {
                    FormPRINCIPAL.Escolha_IMP_EXP();
                } // end if rb_ModoIMP e rb_ModoEXP

            };  // end if rb_DeclararDLL e rb_SemDeclararDLL


            MsgLocal_herry();

        }

    } // end CLASS FormDLLviaReferences : Form

} // end NAMESPACE DEMO.WFD.UsarDLL
