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
        public string KundenNr { get; private set; }
        public int AutoNr { get; private set; }
        public DateTime StartMieteDatum { get; private set; }
        public DateTime EndMieteDatum { get; private set; }

        public Rent(string KundenNr, int AutoNr, DateTime StartMieteDatum, DateTime EndMieteDatum)
        {
            this.KundenNr = KundenNr;
            this.AutoNr = AutoNr;
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
            return KundenNr + AutoNr + year + month + hourString;
        }




        public float AutoZurueckGeben()
        {
            return 1;
        }

        public void VertragHinfuegen()
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";

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




    }

}
