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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAutoManagerAddAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAuto_Click(object sender, EventArgs e)
        {
            //int AutoNr = Convert.ToInt32(tbxAutoNr.Text);
            DateTime Baujahr = dtpBaujahr.Value;
            string Hersteller = tbxHersteller.Text;
            string Model = tbxModel.Text;
            string Farbe = tbxFarbe.Text;
            int Ps = 0;
            double MietPreis = 0;

            try
            {
                MietPreis = Convert.ToDouble(tbxMietPreis.Text);
                Ps = Convert.ToInt32(tbxPs.Text);

                //Auto Object
                Auto newAuto = new Auto(Baujahr, Hersteller, Model, Farbe, Ps, false, MietPreis);

                //Success Message
                MessageBox.Show(newAuto.ToString(), "Success", MessageBoxButtons.OK);

                //Zur Datenkbank hinfügen
                newAuto.AddAutoInDb();

            }
            catch (Exception er)
            {
                MessageBox.Show("Bitte nur Ziffer für das Feld \"Preis\" oder \"Ps\" benutzen!",
                    "error", MessageBoxButtons.OK);
            }

        }
    }
}
