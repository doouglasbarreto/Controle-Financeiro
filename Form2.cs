using Microsoft.Data.Sqlite;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void BuscarValor()
        {
            string querySQL = "SELECT nome FROM cadastro WHERE id = 1;";

            using (SqliteConnection conexao = new SqliteConnection("Data Source=banco.db"))
            {
                conexao.Open();

                using (SqliteCommand comando = new SqliteCommand(querySQL, conexao))
                {
                    using (SqliteDataReader dados = comando.ExecuteReader())
                    {
                        string nome = "";

                        while (dados.Read())
                        {
                            nome = dados.GetString(0);
                            label1.Text = nome;
                        }
                    }
                }
            }
        }
    }
}
