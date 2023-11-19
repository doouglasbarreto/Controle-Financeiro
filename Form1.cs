namespace Controle_Financeiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cadastroDeUsuarios = new Form2();
            // Configurar o formulário como um controle de nível inferior
            cadastroDeUsuarios.TopLevel = false;

            // Adicionar ao TableLayoutPanel
            tableLayoutPanel1.Controls.Add(cadastroDeUsuarios);

            // Exibir o formulário
            cadastroDeUsuarios.Show();


        }
    }
}