using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Kunde
    {
        private string KundenNr;
        private string KundenVorName;
        private string KundenName;
        private string Adresse;
        private DateTime DatumDerAnmeldung;
        private int KundenPunkte;


        public Kunde(string KundenNr, string KundenVorName, string KundenName, string Adresse, DateTime DatumDerAnmeldung, int KundenPunkte) 
        {
            this.KundenNr = KundenNr;
            this.KundenVorName = KundenVorName;
            this.KundenName = KundenName;
            this.Adresse = Adresse;
            this.DatumDerAnmeldung = DatumDerAnmeldung;
            this.KundenPunkte = KundenPunkte;
        }

        //Getter
        public string GetKundenNr()
        {
            return KundenNr;
        }
        public string GetKundenVorName()
        {
            return KundenVorName;
        }
        public string GetKundenName()
        {
            return KundenName;
        }
        public string GetAdresse()
        {
            return Adresse;
        }
        public DateTime GetDatumDerAnmeldung()
        {
            return DatumDerAnmeldung;
        }

        //Setter
        private void SetAdresse(string Adresse)
        {
            this.Adresse = Adresse;
        }




    }
 
}
