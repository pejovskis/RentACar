using System;
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
                            VALUES (@AutoNr, @Hersteller, @Model, @Baujahr, @Ps, @Farbe, @Vermietet, @MietPreis)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AutoNr", this.AutoNr);
                        command.Parameters.AddWithValue("@Hersteller", this.Hersteller);
                        command.Parameters.AddWithValue("@Model", this.Model);
                        command.Parameters.AddWithValue("@Baujahr", this.Baujahr.ToString("yyyy-MM"));
                        command.Parameters.AddWithValue("@Ps", this.Ps);
                        command.Parameters.AddWithValue("@Farbe", this.Farbe);
                        command.Parameters.AddWithValue("@Vermietet", this.Vermietet);
                        command.Parameters.AddWithValue("@MietPreis", this.MietPreis);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Neue Daten erfolgreich hinzugefügt", "Erfolg", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK);
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
            return $"AutoNr: {AutoNr}, Baujahr: {Baujahr}, Hersteller: {Hersteller}, Model: {Model}, Farbe: {Farbe}, MietPreis: {MietPreis}";
        }

    }
}
