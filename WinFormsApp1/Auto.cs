﻿using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    internal class Auto
    {
        private string AutoNr;
        private string Hersteller;
        private string Model;
        private DateTime Baujahr;
        private int Ps;
        private string Farbe;
        private Boolean Vermietet;
        private double MietPreis;

        public Auto(string AutoNr, DateTime Baujahr, string Hersteller, 
            string Model, string Farbe, int Ps, Boolean Vermietet, double MietPreis)
        {
            this.AutoNr = AutoNr;
            this.Hersteller = Hersteller;
            this.Model = Model;
            this.Baujahr = Baujahr;
            this.Farbe = Farbe;
            this.Ps = Ps;
            this.Vermietet = Vermietet;
            this.MietPreis = MietPreis;
        }


        //Add Auto In Database
        public void AddAutoInDb()
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = @"INSERT INTO auto (auto_nr, hersteller, model, baujahr, ps, farbe, vermietet, mietpries)
                            VALUES (@AutoNrIn2, @Hersteller, @Model, @Baujahr, @Ps, @Farbe, @Vermietet, @MietPreis)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AutoNrIn2", this.AutoNr);
                        command.Parameters.AddWithValue("@Hersteller", this.Hersteller);
                        command.Parameters.AddWithValue("@Model", this.Model);
                        command.Parameters.AddWithValue("@Baujahr", this.Baujahr.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@Ps", this.Ps);
                        command.Parameters.AddWithValue("@Farbe", this.Farbe);
                        command.Parameters.AddWithValue("@Vermietet", this.Vermietet);
                        command.Parameters.AddWithValue("@MietPreis", this.MietPreis);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Neue Daten erfolgreich hinzugefügt", "Erfolg", MessageBoxButtons.OK);
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK);
            }
        }
        
        //Check if Auto Existiert
        public static Boolean AutoExist(int AutoNr)
        {

            //SQL Connection
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT auto_nr FROM auto WHERE auto_nr=@AutoNr";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AutoNr", AutoNr);
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

        public static bool CheckVermietet(int AutoNr)
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT vermietet FROM auto WHERE auto_nr=@AutoNr";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AutoNr", AutoNr);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Call Read() to advance to the first row
                            {
                                return reader.GetBoolean("vermietet");
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
                return true;
            }
        }


        //Auto Unavailable
        public static void AutoVermieten(int AutoNr)
        {
            // SQL Connection
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sqlQuery = "UPDATE auto SET vermietet=true WHERE auto_nr=@AutoNr";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AutoNr", AutoNr);
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Auto erfolgreich vermietet.", "Erfolg", MessageBoxButtons.OK);
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei der Datenkbank Search Versuch!", MessageBoxButtons.OK);
            }
        }

        // Auto Zurück
        public static void AutoZurück(string VermietungsNr)
        {
            string connectionString = "Server=localhost; Database=rentacar; Uid=root; Pwd=;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the AutoNr based on VermietungsNr
                    string sqlQueryRetrieve = "SELECT auto_nr FROM vermietungs_vertrag WHERE vermietungs_nr=@VermietungsNr";
                    int autoNr = 0;

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

        //Getter
        public string GetAutoNr()
        {
            return AutoNr;
        }
        public double GetMietPreis()
        {
            return MietPreis;
        }
        public Boolean GetVermietet()
        { 
            return Vermietet; 
        }

        //Setter
        public void SetVermietet(Boolean Vermietet)
        {
            this.Vermietet = Vermietet;
        }
        public void SetMietPreis(double MietPreis)
        {
            this.MietPreis = MietPreis;
        }

        public override string ToString()
        {
            return $"AutoNrIn2: {AutoNr}, Baujahr: {Baujahr}, Hersteller: {Hersteller}, Model: {Model}, Farbe: {Farbe}, MietPreis: {MietPreis}";
        }

    }
}
