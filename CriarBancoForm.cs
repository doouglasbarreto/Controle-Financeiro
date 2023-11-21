using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Controle_Financeiro
{
    public partial class CriarBancoForm : Form
    {
        private int progressoAtual = 0;

        public CriarBancoForm()
        {
            InitializeComponent();
        }

        private void CriarBancoForm_Load(object sender, EventArgs e)
        {
            // Inicie o timer quando o formulário for carregado
            timer1.Start();

            // Defina os limites da barra de progresso
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }


        private void CriarBanco()
        {
            informaProgesso.Text = "Iniciando a criação do Banco de dados...";
            GerenciadorBanco.CriarBancoSQLite();
            informaProgesso.Text = "Banco de dados criado com sucesso...";
        }

        private void CriarTabelaGeUsuario()
        {
            informaProgesso.Text = "Iniciando a criação da Tabela de Usuários...";
            GerenciadorBanco.CriarTabelaGeUsuario();
            informaProgesso.Text = "Tabela de Usuários criada com sucesso...";
        }

        private void CriarTabelaGeContas()
        {
            informaProgesso.Text = "Iniciando a criação da Tabela de Contas...";
            GerenciadorBanco.CriarTabelaGeContas();
            informaProgesso.Text = "Tabela de Contas criada com sucesso...";
        }

        private void CriarTriggerCalcularDiasAtraso()
        {
            informaProgesso.Text = "Iniciando a criação das Triggers da Tabela de Contas...";
            GerenciadorBanco.CriarTriggerCalcularDiasAtraso();
            informaProgesso.Text = "Triggers da Tabela de Contas criada com sucesso...";

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Reinicie o progresso atual
            progressoAtual = 0;
            // Inicie o timer quando o botão "Iniciar" for clicado
            timer1.Start();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Pare o timer e feche o formulário quando o botão "Cancelar" for clicado
            timer1.Stop();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            // Execute o método correspondente ao progresso atual
            switch (progressoAtual)
            {
                case 0:
                    CriarBanco();
                    break;
                case 1:
                    CriarTabelaGeUsuario();
                    break;
                case 2:
                    CriarTabelaGeContas();
                    break;
                case 3:
                    CriarTriggerCalcularDiasAtraso();
                    break;
                case 4:
                    informaProgesso.Text = "Todos os objetos do banco compilados...";
                    break;
                default:
                    // Todos os métodos foram executados, pare o timer
                    timer1.Stop();
                    MessageBox.Show("Processo concluído com sucesso!");
                    caminhoDoBanco.Text = "Caminho do Banco de Dados: " + ConnectionFactory.Instance.ConnectionString;
                    btnCancelar.Enabled = false;
                    btnIniciar.Enabled = false;
                    btnAbrir.Enabled = true;
                    btnAbrir.Visible = true;
                    btnAbrir.Focus();
                    break;
            }

            Thread.Sleep(600);
            // Atualize a barra de progresso
            int novoValor = (progressoAtual + 1) * (100 / 4);

            // Verifique se o novo valor está dentro dos limites válidos antes de atribuir à barra de progresso.
            if (novoValor >= progressBar1.Minimum && novoValor <= progressBar1.Maximum)
            {
                progressBar1.Value = novoValor;
            }
            else
            {
                // Trate o caso em que o valor calculado está fora dos limites válidos, se necessário.
                // Você pode ajustar essa parte de acordo com a lógica do seu aplicativo.
                // Por exemplo, definir o valor para o mínimo ou máximo válido.
                progressBar1.Value = (novoValor < progressBar1.Minimum) ? progressBar1.Minimum : progressBar1.Maximum;
            }

            // Avance para o próximo progresso
            progressoAtual++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CriarBancoForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
