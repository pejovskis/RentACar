namespace WinFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbxKundenNr = new TextBox();
            tbxVorName = new TextBox();
            label2 = new Label();
            tbxNachName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpKundenAnmeldeDatum = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            tbxKundenPunkte = new TextBox();
            label6 = new Label();
            tbxAdresse = new TextBox();
            label7 = new Label();
            dtpGeburtstag = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 38);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Kunden Nummer";
            // 
            // tbxKundenNr
            // 
            tbxKundenNr.Location = new Point(297, 35);
            tbxKundenNr.Name = "tbxKundenNr";
            tbxKundenNr.ReadOnly = true;
            tbxKundenNr.Size = new Size(253, 23);
            tbxKundenNr.TabIndex = 1;
            tbxKundenNr.TextChanged += textBox1_TextChanged;
            tbxKundenNr.KeyUp += KundenNr_Generate;
            // 
            // tbxVorName
            // 
            tbxVorName.Location = new Point(297, 64);
            tbxVorName.Name = "tbxVorName";
            tbxVorName.Size = new Size(253, 23);
            tbxVorName.TabIndex = 3;
            tbxVorName.TextChanged += tbxVorname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 67);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Vorname";
            // 
            // tbxNachName
            // 
            tbxNachName.Location = new Point(297, 93);
            tbxNachName.Name = "tbxNachName";
            tbxNachName.Size = new Size(253, 23);
            tbxNachName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 96);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Nachname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 154);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Adresse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 215);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 8;
            label5.Text = "Anmeldung Datum";
            // 
            // dtpKundenAnmeldeDatum
            // 
            dtpKundenAnmeldeDatum.Location = new Point(297, 209);
            dtpKundenAnmeldeDatum.Name = "dtpKundenAnmeldeDatum";
            dtpKundenAnmeldeDatum.Size = new Size(253, 23);
            dtpKundenAnmeldeDatum.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(379, 244);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 10;
            button1.Text = "Kunde Hinfuegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(166, 244);
            button2.Name = "button2";
            button2.Size = new Size(171, 23);
            button2.TabIndex = 11;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbxKundenPunkte
            // 
            tbxKundenPunkte.Location = new Point(297, 180);
            tbxKundenPunkte.Name = "tbxKundenPunkte";
            tbxKundenPunkte.Size = new Size(253, 23);
            tbxKundenPunkte.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 183);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Kunden Punkte";
            // 
            // tbxAdresse
            // 
            tbxAdresse.Location = new Point(297, 151);
            tbxAdresse.Name = "tbxAdresse";
            tbxAdresse.Size = new Size(253, 23);
            tbxAdresse.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 125);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 14;
            label7.Text = "Geburtstag";
            label7.Click += label7_Click;
            // 
            // dtpGeburtstag
            // 
            dtpGeburtstag.Location = new Point(297, 122);
            dtpGeburtstag.Name = "dtpGeburtstag";
            dtpGeburtstag.Size = new Size(253, 23);
            dtpGeburtstag.TabIndex = 16;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 279);
            Controls.Add(dtpGeburtstag);
            Controls.Add(tbxAdresse);
            Controls.Add(label7);
            Controls.Add(tbxKundenPunkte);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpKundenAnmeldeDatum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbxNachName);
            Controls.Add(label3);
            Controls.Add(tbxVorName);
            Controls.Add(label2);
            Controls.Add(tbxKundenNr);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxKundenNr;
        private TextBox tbxVorName;
        private Label label2;
        private TextBox tbxNachName;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpKundenAnmeldeDatum;
        private Button button1;
        private Button button2;
        private TextBox tbxKundenPunkte;
        private Label label6;
        private TextBox tbxAdresse;
        private Label label7;
        private DateTimePicker dtpGeburtstag;
    }
}