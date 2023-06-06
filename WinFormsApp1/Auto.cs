using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Auto
    {
        private string AutoNr;
        private string Hersteller;
        private string Model;
        //private string Baujahr;
        private float Ps;
        private string Farbe;
        private Boolean Vermietet;
        private float MietPreis;

        public Auto(string AutoNr, string Hersteller, string Model, string Farbe, Boolean Vermietet, float MietPreis)
        {
            this.AutoNr = AutoNr;
            this.Hersteller = Hersteller;
            this.Model = Model;
            //this.Baujahr = Baujahr;
            this.Farbe = Farbe;
            this.Vermietet = Vermietet;
            this.MietPreis = MietPreis;
        }

        //Getter
        public string GetAutoNr()
        {
            return AutoNr;
        }
        public float GetMietPreis()
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
        public void SetMietPreis(float MietPreis)
        {
            this.MietPreis = MietPreis;
        }

    }
}
