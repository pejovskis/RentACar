using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Rent
    {
        private string VermietungsNr;
        private float MietDauerStunden;
        private Kunde Kunde;
        private Auto Auto;
        private DateTime StartMieteDatum;
        private DateTime EndMieteDatum;

        public Rent(string VermietungsNr, float MietDauerStunden, Kunde Kunde, Auto Auto, 
            DateTime StartMieteDatum, DateTime EndMieteDatum)
        {
            this.VermietungsNr = VermietungsNr;
            this.MietDauerStunden = MietDauerStunden;
            this.Kunde = Kunde;
            this.Auto = Auto;
            this.StartMieteDatum = StartMieteDatum;
            this.EndMieteDatum = EndMieteDatum;
        }

        public string AutoVermieten()
        {
            //Vermietungs Nr Return Code
            return Auto.GetAutoNr() + Kunde.GetKundenNr() + StartMieteDatum;
        }

        public float AutoZurueckGeben()
        {
            return 1;
        }

    }

}
