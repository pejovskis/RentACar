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

            string KundenNr = tbxKundenNr.Text;
            int AutoNr = Convert.ToInt32(tbxAutoNr.Text);
            string VermietungsNr = string.Empty;

            Auto auto = DatabaseHelper.GetAuto(AutoNr);
            Kunde kunde = DatabaseHelper.GetKunden(KundenNr);

            bool KundeExistiert = kunde.KundeExist();
            bool AutoExistiert = auto.AutoExist();
            bool AutoVermietet = auto.GetVermietet();

            DateTime MieteStartDatum = dtpMietStarten.Value;
            DateTime MieteEndDatum = dtpMietBeenden.Value;

            if (KundeExistiert && AutoExistiert && !AutoVermietet)
            {
                try
                {
                    
                    Rent autoVermieten = new Rent(kunde, auto, MieteStartDatum, MieteEndDatum);

                    autoVermieten.VertragHinfuegen();
                    auto.AutoVermieten();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK);
                }
            }
            else
            {
                // Check If Kunde Existiert
                if (!KundeExistiert)
                {
                    MessageBox.Show("Kunde existiert nicht.", "Fehler", MessageBoxButtons.OK);
                }

                // Check If Auto Existiert
                if (!AutoExistiert)
                {
                    MessageBox.Show("Auto existiert nicht.", "Fehler", MessageBoxButtons.OK);
                }

                // Check if Auto is Vermietet
                if (AutoVermietet)
                {
                    MessageBox.Show("Das Auto ist bereits vermietet.", "Fehler", MessageBoxButtons.OK);
                }
            }
        }


        private void btnVermietungBeenden_Click(object sender, EventArgs e)
        {

            string VermietungsNrCandidat = tbxVermietungsNr.Text;

            Rent VermietungsVertrag = DatabaseHelper.GetRent(VermietungsNrCandidat);

            VermietungsVertrag.AutoZurück();

        }
    }
}
