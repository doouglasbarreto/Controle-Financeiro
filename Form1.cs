namespace Controle_Financeiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void cadastrarUsu�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cadastroDeUsuarios = new Form2();
            // Configurar o formul�rio como um controle de n�vel inferior
            cadastroDeUsuarios.TopLevel = false;

            // Adicionar ao TableLayoutPanel
            tableLayoutPanel1.Controls.Add(cadastroDeUsuarios);

            // Exibir o formul�rio
            cadastroDeUsuarios.Show();


        }
    }
}