using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAutoManagerZurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutoManagerAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 AutoManager = new Form3();
            AutoManager.ShowDialog(this);
            this.Show();
        }

        private void lvAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void GenerateAutoTable()
        {
            // Clear the ListView control
            lvAuto.Items.Clear();
            // Add columns to the ListView control
            lvAuto.Columns.Add("Auto Nr");
            lvAuto.Columns.Add("Hersteller");
            lvAuto.Columns.Add("Modell");
            lvAuto.Columns.Add("Baujahr");
            lvAuto.Columns.Add("PS");
            lvAuto.Columns.Add("Farbe");
            lvAuto.Columns.Add("Vermietet");
            lvAuto.Columns.Add("Mietpreis");


            try
            {
                string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
                string sqlQuery = "SELECT * FROM auto";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int autoNr = reader.GetInt32("auto_nr");
                                string hersteller = reader.GetString("hersteller");
                                string model = reader.GetString("model");
                                DateTime baujahr = reader.GetDateTime("baujahr");
                                int ps = reader.GetInt32("ps");
                                string farbe = reader.GetString("farbe");
                                bool vermietet = reader.GetBoolean("vermietet");
                                double mietpries = reader.GetDouble("mietpries");

                                // Create a new ListViewItem and populate it with the data
                                ListViewItem item = new ListViewItem(autoNr.ToString());
                                item.SubItems.Add(hersteller);
                                item.SubItems.Add(model);
                                item.SubItems.Add(baujahr.ToString());
                                item.SubItems.Add(ps.ToString());
                                item.SubItems.Add(farbe);
                                item.SubItems.Add(vermietet.ToString());
                                item.SubItems.Add(mietpries.ToString());

                                // Add the ListViewItem to the ListView control
                                lvAuto.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei der Datenbankoperation!", MessageBoxButtons.OK);
            }
        }
    }
}

