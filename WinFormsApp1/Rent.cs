using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Rent
    {
        public string VermietungsNr { get; private set; }
        public Kunde Kunde { get; private set; }
        public Auto Auto { get; private set; }
        public DateTime StartMieteDatum { get; private set; }
        public DateTime EndMieteDatum { get; private set; }

        //Constructor
        public Rent(Kunde Kunde, Auto Auto, DateTime StartMieteDatum, DateTime EndMieteDatum)
        {
            this.Kunde = Kunde;
            this.Auto = Auto;
            this.StartMieteDatum = StartMieteDatum;
            this.EndMieteDatum = EndMieteDatum;
            VermietungsNr = GenerateVermietungsNr();
        }

        //Vermietungs Nr generator
        public string GenerateVermietungsNr()
        {
            // Convert the hour in 12-hour format with "hh:mm tt" specifier
            string hourString = StartMieteDatum.ToString("hhmmtt");

            // Get the year, month, and day from the StartMieteDatum
            string year = StartMieteDatum.Year.ToString();
            string month = StartMieteDatum.Month.ToString("00");

            // Combine KundenNr, AutoNr, date, and hourString to generate VermietungsNr
            return Kunde.GetKundenNr() + Auto.GetAutoNr() + year + month + hourString;
        }

        //Vertrag Hinfuegen
        public void VertragHinfuegen()
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            int AutoNr = Auto.GetAutoNr();
            string KundenNr = Kunde.GetKundenNr();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO vermietungs_vertrag (vermietungs_nr, auto_nr, kunden_nr, miete_start, miete_end) " +
                                   "VALUES (@VermietungsNr, @AutoNr, @KundenNr, @StartMieteDatum, @EndMieteDatum)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VermietungsNr", VermietungsNr);
                        command.Parameters.AddWithValue("@AutoNr", AutoNr);
                        command.Parameters.AddWithValue("@KundenNr", KundenNr);
                        command.Parameters.AddWithValue("@StartMieteDatum", StartMieteDatum);
                        command.Parameters.AddWithValue("@EndMieteDatum", EndMieteDatum);

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

        // Auto Zurück
        public void AutoZurück()
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the AutoNr based on VermietungsNr
                    string sqlQueryRetrieve = "SELECT auto_nr FROM vermietungs_vertrag WHERE vermietungs_nr=@VermietungsNr";
                    int autoNr = Auto.GetAutoNr();

                    using (MySqlCommand retrieveCommand = new MySqlCommand(sqlQueryRetrieve, connection))
                    {
                        retrieveCommand.Parameters.AddWithValue("@VermietungsNr", VermietungsNr);

                        using (MySqlDataReader reader = retrieveCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                autoNr = reader.GetInt32("auto_nr");
                            }
                        }
                    }

                    if (autoNr != 0)
                    {
                        // Update the vermietet status to false for the retrieved AutoNr
                        string sqlQueryUpdate = "UPDATE auto SET vermietet=false WHERE auto_nr=@AutoNr";

                        using (MySqlCommand updateCommand = new MySqlCommand(sqlQueryUpdate, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@AutoNr", autoNr);
                            updateCommand.ExecuteNonQuery();
                            MessageBox.Show("Auto erfolgreich abgemeldet.", "Erfolg", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Auto nicht gefunden.", "Fehler", MessageBoxButtons.OK);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei der Datenbankoperation!", MessageBoxButtons.OK);
            }
        }


    }

}
