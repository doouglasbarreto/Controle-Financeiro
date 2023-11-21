using System.Text;

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

        private void criarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciadorBanco.CriarBancoSQLite();
        }

        private void criarTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GerenciadorBanco.CriarTabelaCadastro();
        }

        private void inserirRegistroTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InputDialogForm iDForm = new InputDialogForm())
            {
                if (iDForm.ShowDialog() == DialogResult.OK)
                {
                    // Obtém o valor inserido pelo usuário
                    string nomeInserido = iDForm.InputValue;

                    //GerenciadorBanco.RegistrarNome(nomeInserido);
                }
            }

        }

        private void cosultarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InputDialogForm iDForm = new InputDialogForm())
            {
                if (iDForm.ShowDialog() == DialogResult.OK)
                {
                    // Obtém o valor inserido pelo usuário
                    string nomeParaConsultar = iDForm.InputValue;

                    // Chama o método para consultar um nome
                    //List<string> resultados = GerenciadorBanco.ConsultarNome(nomeParaConsultar);

                    // Constrói a mensagem para exibir na MessageBox
                    StringBuilder mensagem = new StringBuilder();
                    mensagem.AppendLine("Resultados da Consulta:");

                    /*foreach (string resultado in resultados)
                    {
                        mensagem.AppendLine(resultado);
                    }*/

                    // Exibe os resultados em uma MessageBox
                    MessageBox.Show(mensagem.ToString(), "Consulta de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void criarTabelaUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciadorBanco.CriarTabelaGeUsuario();
            //AGUARDAR 2 SEGUNDOS PRA EXECUTAR O PRÓXIMO MÉTODO
            GerenciadorBanco.CriarTriggerCalcularDiasAtraso();
        }

        private void criarTabelaContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciadorBanco.CriarTabelaGeContas();
        }

        private void criarTriggersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciadorBanco.CriarTriggerCalcularDiasAtraso();
        }

        private void verificarCaminhoDoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caminho do Banco de Dados:" + ConnectionFactory.Instance.ConnectionString);
        }
    }
}