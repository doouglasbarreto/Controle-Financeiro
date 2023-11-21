using System;
using System.IO;
using System.Windows.Forms;

namespace Controle_Financeiro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Obt�m o caminho completo para o banco de dados SQLite
            string caminhoBancoSQLite = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)))), "banco.db");

            // Verifica se o banco de dados existe
            if (!File.Exists(caminhoBancoSQLite))
            {
                // Se o banco n�o existir, abre o CriarBancoForm para cri�-lo
                using (CriarBancoForm criarBancoForm = new CriarBancoForm())
                {
                    Application.Run(criarBancoForm);

                    // Ap�s criar o banco, verifica novamente se o banco existe (pode ser �til se o usu�rio cancelar o processo)
                    if (!File.Exists(caminhoBancoSQLite))
                    {
                        // Se ainda n�o existir, encerra o programa
                        MessageBox.Show("O banco de dados n�o foi criado. O programa ser� encerrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Se o banco existir (ou foi criado com sucesso), inicia o Form1
            Application.Run(new Form1());
        }
    }
}
