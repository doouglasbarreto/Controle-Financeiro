using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Financeiro
{
    public partial class InputDialogForm : Form
    {
        public string InputValue { get; private set; }
        public InputDialogForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define o valor da propriedade com o conteúdo da TextBox
            InputValue = textBox1.Text;

            // Fecha o formulário
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
