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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxVorname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Vorname = tbxVorName.Text;
            string Nachname = tbxNachName.Text;
            string Adresse = tbxAdresse.Text;
            DateTime Geburtstag = dtpGeburtstag.Value;
            DateTime AnmeldungDatum = dtpKundenAnmeldeDatum.Value;

            try
            {
                int KundenPunkte = Convert.ToInt32(tbxKundenPunkte.Text);
                Kunde newKunde = new Kunde(Vorname, Nachname, Geburtstag, Adresse, AnmeldungDatum, KundenPunkte);
                newKunde.AddInDb();
                MessageBox.Show("Neuer Kunde erfolgreich zur Datenbank hinzugefügt.", "Erfolg.", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei der Objekt Initializierung.", MessageBoxButtons.OK);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void KundenNr_Generate(object sender, KeyEventArgs e)
        {

        }
    }
}
