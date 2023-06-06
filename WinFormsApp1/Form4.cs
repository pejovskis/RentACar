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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnKundenManagerZurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKundenManagerAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 AddKunde = new Form5();
            AddKunde.ShowDialog(this);
            this.Show();
        }

        private void btnKundeninfoAendern_click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 EditKunde = new Form6();
            EditKunde.ShowDialog(this);
            this.Show();
        }
    }
}
