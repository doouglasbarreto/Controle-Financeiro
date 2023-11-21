using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Controle_Financeiro
{
    public partial class Form2 : Form
    {
        private ConnectionFactory connector = ConnectionFactory.Instance;
        public Form2()
        {
            InitializeComponent();
            connector.TestConnection();
            
            consultaBanco();
        }


        public void consultaBanco()
        {
            try
            {
                using (SQLiteConnection conn = connector.GetConnection())
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT nome FROM cadastro WHERE id = 1", conn))
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            label1.Text = dr["nome"].ToString();
                        }
                        else
                        {
                            // Se não houver resultados, você pode definir um valor padrão ou tratar conforme necessário
                            label1.Text = "Registro não encontrado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na consulta ao banco de dados: " + ex.Message);
            }
        }

        
    }
}
