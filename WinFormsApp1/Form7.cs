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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnVermietungsManagerAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutoVermieten_Click(object sender, EventArgs e)
        {
            string KundenNr = string.Empty;
            string AutoNr = string.Empty;
            string VermietungsNr = string.Empty;

            string KundenNrCandidat = tbxKundenNr.Text;
            string AutoNrCandidat = tbxAutoNr.Text;
            DateTime StartMieteDatum = dtpMietStarten.Value;
            DateTime EndMieteDatum = dtpMietBeenden.Value;


            Boolean kundeExistiert = Kunde.KundeExist(KundenNrCandidat);
            Boolean autoExistiert = Auto.AutoExist(AutoNrCandidat);
            Boolean autoVermietet = false;
            if (autoExistiert)
            {
                autoVermietet = Auto.CheckIfVermietet(AutoNr);
            }

            //Check If Vermietung möglich ist
            if (kundeExistiert && autoExistiert && !(autoVermietet))
            {
                try
                {
                    KundenNr = KundenNrCandidat;
                    AutoNr = AutoNrCandidat;

                    Rent autoVermieten = new Rent(KundenNr, AutoNr, StartMieteDatum, EndMieteDatum);

                    autoVermieten.VertragHinfuegen();
                    Auto.AutoVermieten(AutoNr);
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                //Check If Kunde Existiert
                if (!(kundeExistiert))
                {
                    MessageBox.Show("Kunde Existiert Nicht", "Ne", MessageBoxButtons.OK);
                }

                //Check If Auto Existiert
                if (!(autoExistiert))
                {
                    MessageBox.Show("Auto Existiert Nicht", "Ne", MessageBoxButtons.OK);
                }

                //Check if Auto is Vermietet
                if (autoVermietet)
                {
                    MessageBox.Show("Auto Existiert Nicht", "Ne", MessageBoxButtons.OK);
                }
            }

        }

        private void btnVermietungBeenden_Click(object sender, EventArgs e)
        {
            string VermietungsNr = string.Empty;

            string VermietungsNrCandiat = tbxVermietungsNr.Text;

            Auto.AutoZurück(VermietungsNr);
        }
    }
}
