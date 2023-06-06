using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Kunde
    {
        public string KundenNr;
        public string KundenVorName { get; private set; }
        public string KundenName { get; private set; }
        public DateTime Geburtstag { get; private set; }
        public string Adresse { get; private set; }
        public DateTime DatumDerAnmeldung { get; private set; }
        public int KundenPunkte { get; private set; }

        public Kunde(string kundenVorName, string kundenName, DateTime geburtstag,
            string adresse, DateTime datumDerAnmeldung, int kundenPunkte)
        {
            this.KundenVorName = kundenVorName;
            this.KundenName = kundenName;
            this.Geburtstag = geburtstag;
            this.Adresse = adresse;
            this.DatumDerAnmeldung = datumDerAnmeldung;
            this.KundenPunkte = kundenPunkte;

            //Kunden Nr generator
            string JahrGeburt = geburtstag.Year.ToString();
            string JahrAnmeldung = datumDerAnmeldung.Year.ToString();

            this.KundenNr = $"{kundenVorName[0]}{kundenName[0]}{JahrGeburt.Substring(JahrGeburt.Length - 2)}{JahrAnmeldung.Substring(JahrAnmeldung.Length - 2)}";
        }

        //Neuer Kunde Zur Datenbank Hinfügen
        public void AddInDb()
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO kunde (kunden_nr, vorname, nachname, geburtstag, adresse," +
                        "datum_anmeldung, kunden_punkte) " +
                        "VALUES (@KundenNr, @KundenVorName, @KundenName, @Geburtstag, @Adresse," +
                        "@DatumDerAnmeldung, @KundenPunkte);";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KundenNr", KundenNr);
                        command.Parameters.AddWithValue("@KundenVorName", KundenVorName);
                        command.Parameters.AddWithValue("@KundenName", KundenName);
                        command.Parameters.AddWithValue("@Geburtstag", Geburtstag);
                        command.Parameters.AddWithValue("@Adresse", Adresse);
                        command.Parameters.AddWithValue("@DatumDerAnmeldung", DatumDerAnmeldung);
                        command.Parameters.AddWithValue("@KundenPunkte", KundenPunkte);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    MessageBox.Show("Daten erfolgreich hinzugefügt.", "Erfolg", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei der Verbindung mit der Datenbank", MessageBoxButtons.OK);
            }
        }

        //Check Ob Kunde Existiert in der Datenbank
        public Boolean KundeExist()
        {

            //SQL Connection
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT kunden_nr FROM kunde WHERE kunden_nr=@KundenNr";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@KundenNr", KundenNr);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei der Datenkbank Search Versuch!", MessageBoxButtons.OK);
                return false;
            }
        }

        public string GetKundenNr()
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT kunden_nr FROM kunde WHERE kunden_nr=@KundenNr";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@KundenNr", KundenNr);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string retrievedKundenNr = reader.GetString("kunden_nr");
                                return retrievedKundenNr;
                            }
                            else
                            {
                                return null; // Return null if the customer number doesn't exist
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei der Kundensuche", MessageBoxButtons.OK);
                return null; // Return null in case of an exception
            }
        }

    }
}
