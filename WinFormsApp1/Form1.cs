namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAutoManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 AutoManager = new Form2();
            AutoManager.ShowDialog(this);
            this.Show();
        }

        private void btnKundenManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 KundenManager = new Form4();
            KundenManager.ShowDialog(this);
            this.Show();
        }

        private void btnVermietung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 VermietungsManager = new Form7();
            VermietungsManager.ShowDialog(this);
            this.Show();
        }
    }
}