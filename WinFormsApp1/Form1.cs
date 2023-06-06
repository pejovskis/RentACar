using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAutoManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 AutoManager = new Form2();
            AutoManager.ShowDialog(this);
            this.Show();
        }

        private void btnKundenManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 KundenManager = new Form4();
            KundenManager.ShowDialog(this);
            this.Show();
        }

        private void btnVermietung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 VermietungsManager = new Form7();
            VermietungsManager.ShowDialog(this);
            this.Show();
        }

        private void btnDatenbankReset_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query3 = "delete from auto;";
                    string query2 = "delete from kunde;";
                    string query = "delete from vermietungs_vertrag;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    using (MySqlCommand command = new MySqlCommand(query2, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    using (MySqlCommand command = new MySqlCommand(query3, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                MessageBox.Show("Datenbank erfolgreich resetet!", "Erfolg", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}