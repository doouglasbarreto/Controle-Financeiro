using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Controle_Financeiro
{
    public class GerenciadorBanco
    {
        private static string ObterCaminhoBancoSQLite()
        {
            // Obtém o caminho para o diretório do executável
            string? diretorioExecutavel = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory))));

            // Verifica se diretorioExecutavel é nulo e lança uma exceção se for o caso
            if (diretorioExecutavel is null)
            {
                throw new InvalidOperationException("Caminho do diretório do executável é nulo.");
            }

            // Define o caminho completo para o banco de dados SQLite com extensão .db
            return Path.Combine(diretorioExecutavel, "banco.db");
        }


        public static void CriarBancoSQLite()
        {
            // Cria o caminho completo para o banco de dados SQLite com extensão .db
            string caminhoBancoSQLite = ObterCaminhoBancoSQLite();

            // Verifica se o banco de dados já existe
            if (!File.Exists(caminhoBancoSQLite))
            {
                // Cria a string de conexão com o banco de dados SQLite
                string connectionString = $"Data Source={caminhoBancoSQLite};Version=3;";

                // Cria a conexão com o banco de dados
                using (SQLiteConnection conexao = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        // Abre a conexão
                        conexao.Open();

                        // Não cria tabela neste método, apenas o banco de dados

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao criar banco de dados SQLite: {ex.Message}");
                    }
                }
            }
           
        }



        public static void CriarTabelaGeUsuario()
        {
            // Cria a string de conexão com o banco de dados SQLite
            string connectionString = $"Data Source={ObterCaminhoBancoSQLite()};Version=3;";

            // Cria a conexão com o banco de dados
            using (SQLiteConnection conexao = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Abre a conexão
                    conexao.Open();

                    // Cria a tabela ge_usuario
                    string queryCriarTabela = "CREATE TABLE IF NOT EXISTS ge_usuario (" +
                        "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "Nome VARCHAR(20) UNIQUE NOT NULL," +
                        "DataNascimento DATE NOT NULL," +
                        "DataRegistro DATE NOT NULL DEFAULT (strftime('%Y-%m-%d', 'now'))," +
                        "DataAlteracao DATE" +
                        ");";

                    // Executa a query
                    using (SQLiteCommand comando = new SQLiteCommand(queryCriarTabela, conexao))
                    {
                        comando.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar tabela 'ge_usuario': {ex.Message}");
                }
            }
        }

        public static void CriarTabelaGeContas()
        {
            // Cria a string de conexão com o banco de dados SQLite
            string connectionString = $"Data Source={ObterCaminhoBancoSQLite()};Version=3;";

            // Cria a conexão com o banco de dados
            using (SQLiteConnection conexao = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Abre a conexão
                    conexao.Open();

                    // Cria a tabela ge_contas
                    string queryCriarTabela = "CREATE TABLE IF NOT EXISTS ge_contas (" +
                        "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "UsuarioID INTEGER NOT NULL," +
                        "Descricao VARCHAR(30) NOT NULL," +
                        "DataDivida DATE DEFAULT (strftime('%Y-%m-%d', 'now'))," +
                        "ValorDivida DECIMAL DEFAULT 0," +
                        "ValorPago DECIMAL DEFAULT 0," +
                        "ValorRestante DECIMAL DEFAULT 0," +
                        "DataVencimento DATE DEFAULT (strftime('%Y-%m-%d', 'now', '+7 days'))," +
                        "DiasAtraso INTEGER DEFAULT 0," +
                        "DividaMensal CHAR(1) DEFAULT 'N'," +
                        "DividaSemanal CHAR(1) DEFAULT 'N'," +
                        "DividaAnual CHAR(1) DEFAULT 'N'," +
                        "DividaDiaria CHAR(1) DEFAULT 'N'," +
                        "FOREIGN KEY(UsuarioID) REFERENCES ge_usuario(ID)" +
                        ");";

                    // Executa a query
                    using (SQLiteCommand comando = new SQLiteCommand(queryCriarTabela, conexao))
                    {
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar tabela 'ge_contas': {ex.Message}");
                }
            }
        }

        public static void CriarTriggerCalcularDiasAtraso()
        {
            // Cria a string de conexão com o banco de dados SQLite
            string connectionString = $"Data Source={ObterCaminhoBancoSQLite()};Version=3;";

            // Cria a conexão com o banco de dados
            using (SQLiteConnection conexao = new SQLiteConnection(connectionString))
            {
                try
                {
                    // Abre a conexão
                    conexao.Open();

                    // Cria a trigger calcularDiasAtraso para INSERT
                    string queryCriarTriggerInsert = @"
                CREATE TRIGGER IF NOT EXISTS calcularDiasAtraso_insert
                AFTER INSERT ON ge_contas
                FOR EACH ROW
                BEGIN
                    UPDATE ge_contas
                    SET DiasAtraso = (SELECT julianday('now') - julianday(DataVencimento))
                    WHERE ge_contas.ID = NEW.ID;
                END;
            ";

                    // Executa a query
                    using (SQLiteCommand comandoInsert = new SQLiteCommand(queryCriarTriggerInsert, conexao))
                    {
                        comandoInsert.ExecuteNonQuery();
                    }

                    // Cria a trigger calcularDiasAtraso para UPDATE
                    string queryCriarTriggerUpdate = @"
                CREATE TRIGGER IF NOT EXISTS calcularDiasAtraso_update
                AFTER UPDATE ON ge_contas
                FOR EACH ROW
                BEGIN
                    UPDATE ge_contas
                    SET DiasAtraso = (SELECT julianday('now') - julianday(DataVencimento))
                    WHERE ge_contas.ID = NEW.ID;
                END;
            ";

                    // Executa a query
                    using (SQLiteCommand comandoUpdate = new SQLiteCommand(queryCriarTriggerUpdate, conexao))
                    {
                        comandoUpdate.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar as triggers 'calcularDiasAtraso': {ex.Message}");
                }
            }
        }





    }
}
