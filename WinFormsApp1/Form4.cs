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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnKundenManagerZurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKundenManagerAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 AddKunde = new Form5();
            AddKunde.ShowDialog(this);
            this.Show();
        }

        private void btnKundeninfoAendern_click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 EditKunde = new Form6();
            EditKunde.ShowDialog(this);
            this.Show();
        }

        private void lvKunde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void GenerateKundeTable()
        {
            // Clear the ListView control
            lvKunde.Items.Clear();
            // Add columns to the ListView control
            lvKunde.Columns.Add("KundenNr");
            lvKunde.Columns.Add("Vorname");
            lvKunde.Columns.Add("Nachname");
            lvKunde.Columns.Add("Geburtstag");
            lvKunde.Columns.Add("Adresse");
            lvKunde.Columns.Add("Datum der Anmeldung");
            lvKunde.Columns.Add("Kunden Punkte");

            try
            {
                string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
                string sqlQuery = "SELECT * FROM kunde";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string KundenNr = reader.GetString("kunden_nr");
                                string Vorname = reader.GetString("vorname");
                                string Nachname = reader.GetString("nachname");
                                DateTime geburtstag = reader.GetDateTime("geburtstag");
                                string adresse = reader.GetString("adresse");
                                DateTime DatumAnmedlung = reader.GetDateTime("datum_anmeldung");
                                int KundenPunkte = reader.GetInt32("kunden_punkte");

                                // Create a new ListViewItem and populate it with the data
                                ListViewItem item = new ListViewItem(KundenNr);
                                item.SubItems.Add(Vorname);
                                item.SubItems.Add(Nachname);
                                item.SubItems.Add(geburtstag.ToString());
                                item.SubItems.Add(adresse);
                                item.SubItems.Add(DatumAnmedlung.ToString());
                                item.SubItems.Add(KundenPunkte.ToString());

                                // Add the ListViewItem to the ListView control
                                lvKunde.Items.Add(item);
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
