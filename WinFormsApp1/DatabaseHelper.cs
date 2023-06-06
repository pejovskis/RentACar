using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.WellKnownTypes.Field.Types;

namespace WinFormsApp1
{
    internal class DatabaseHelper
    {
        public static Auto GetAuto(int AutoNr)
        {

            Auto auto = null;
            
            string sqlQuery = "SELECT * FROM auto where auto_nr=@AutoNr";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@AutoNr", AutoNr); // Define and assign the parameter value
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int autoNr = reader.GetInt32("auto_nr");
                            DateTime baujahr = reader.GetDateTime("baujahr");
                            string hersteller = reader.GetString("hersteller");
                            string model = reader.GetString("model");
                            string farbe = reader.GetString("farbe");
                            int ps = reader.GetInt32("ps");
                            bool vermietet = reader.GetBoolean("vermietet");
                            double mietPreis = reader.GetDouble("mietpries");

                            auto = new Auto(autoNr, baujahr, hersteller, model, farbe, ps, vermietet, mietPreis);
                            
                        }
                    }
                }
            }
            return auto;
        }

        private static MySqlConnection GetConnection()
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            return new MySqlConnection(connectionString);
        }

        public static Rent GetRent(String VermietungsVertrag)
        {
            Rent rent = null;
            string sqlQuery = "SELECT * FROM vermietungs_vertrag where vermietungs_nr=@VermietungsVertrag";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@VermietungsVertrag", VermietungsVertrag); // Define and assign the parameter value
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int autoNr = reader.GetInt32("auto_nr");
                            Auto Auto = DatabaseHelper.GetAuto(autoNr);
                            string kundenNr = reader.GetString("kunden_nr");
                            Kunde Kunde = DatabaseHelper.GetKunden(kundenNr);
                            DateTime miete_start = reader.GetDateTime("miete_start");
                            DateTime miete_end = reader.GetDateTime("miete_end");

                            rent = new Rent(Kunde, Auto, miete_start, miete_end);
                        }
                    }
                }
            }

            return rent;
        }

        
        public static Kunde GetKunden(string KundenNr)
        {
            Kunde kunde = null;
            string sqlQuery = "SELECT * FROM kunde where kunden_nr=@KundenNr";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@KundenNr", KundenNr); // Define and assign the parameter value
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string kundenNr = reader.GetString("kunden_nr");
                            string vorname = reader.GetString("vorname");
                            string nachname = reader.GetString("nachname");
                            DateTime geburtstag = reader.GetDateTime("geburtstag");
                            string adresse = reader.GetString("adresse");
                            DateTime datumAnmeldung = reader.GetDateTime("datum_anmeldung");
                            int KundenPunkte = reader.GetInt32("kunden_punkte");

                            kunde = new Kunde(vorname, nachname, geburtstag, adresse, datumAnmeldung, KundenPunkte);
                        }
                    }
                }
            }

            return kunde;
        }

    }
}
