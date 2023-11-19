using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace Controle_Financeiro
{
    internal class ConnectionFactory
    {
        private static string databaseFileName = "banco.db";
        private static string projectRoot = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory))));
        private static string connectionString = $"Data Source={Path.Combine(projectRoot, databaseFileName)}";
        private static readonly object lockObj = new object();
        private static ConnectionFactory instance = new ConnectionFactory(); // Inicializa diretamente

        private ConnectionFactory()
        {
            // Construtor privado para evitar instanciação direta
        }

        public static ConnectionFactory Instance
        {
            get
            {
                lock (lockObj)
                {
                    return instance;
                }
            }
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public void TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();
                    // Mostrar mensagem ou log de sucesso
                    MessageBox.Show("Conexão realizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}
