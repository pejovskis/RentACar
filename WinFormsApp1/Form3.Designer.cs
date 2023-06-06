namespace WinFormsApp1
{
    partial class Form3
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
            tbxAutoNr = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxHersteller = new TextBox();
            label3 = new Label();
            tbxModel = new TextBox();
            label4 = new Label();
            tbxPs = new TextBox();
            label5 = new Label();
            tbxFarbe = new TextBox();
            label6 = new Label();
            tbxMietPreis = new TextBox();
            btnAddAuto = new Button();
            button2 = new Button();
            label7 = new Label();
            dtpBaujahr = new DateTimePicker();
            SuspendLayout();
            // 
            // tbxAutoNr
            // 
            tbxAutoNr.Location = new Point(248, 18);
            tbxAutoNr.Name = "tbxAutoNr";
            tbxAutoNr.Size = new Size(237, 23);
            tbxAutoNr.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 21);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Auto Nummer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 79);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Hersteller";
            // 
            // tbxHersteller
            // 
            tbxHersteller.Location = new Point(248, 76);
            tbxHersteller.Name = "tbxHersteller";
            tbxHersteller.Size = new Size(237, 23);
            tbxHersteller.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 108);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Model";
            // 
            // tbxModel
            // 
            tbxModel.Location = new Point(248, 105);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(237, 23);
            tbxModel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 137);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 7;
            label4.Text = "Ps";
            // 
            // tbxPs
            // 
            tbxPs.Location = new Point(248, 134);
            tbxPs.Name = "tbxPs";
            tbxPs.Size = new Size(237, 23);
            tbxPs.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 166);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Farbe";
            // 
            // tbxFarbe
            // 
            tbxFarbe.Location = new Point(248, 163);
            tbxFarbe.Name = "tbxFarbe";
            tbxFarbe.Size = new Size(237, 23);
            tbxFarbe.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 195);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 11;
            label6.Text = "Miet Preis";
            label6.Click += label6_Click;
            // 
            // tbxMietPreis
            // 
            tbxMietPreis.Location = new Point(248, 192);
            tbxMietPreis.Name = "tbxMietPreis";
            tbxMietPreis.Size = new Size(237, 23);
            tbxMietPreis.TabIndex = 10;
            // 
            // btnAddAuto
            // 
            btnAddAuto.Location = new Point(305, 224);
            btnAddAuto.Name = "btnAddAuto";
            btnAddAuto.Size = new Size(180, 23);
            btnAddAuto.TabIndex = 12;
            btnAddAuto.Text = "Add Auto";
            btnAddAuto.UseVisualStyleBackColor = true;
            btnAddAuto.Click += btnAddAuto_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 224);
            button2.Name = "button2";
            button2.Size = new Size(180, 23);
            button2.TabIndex = 13;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAutoManagerAddAbbrechen_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 50);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 15;
            label7.Text = "Baujahr";
            // 
            // dtpBaujahr
            // 
            dtpBaujahr.Location = new Point(248, 47);
            dtpBaujahr.Name = "dtpBaujahr";
            dtpBaujahr.Size = new Size(237, 23);
            dtpBaujahr.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 266);
            Controls.Add(dtpBaujahr);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(btnAddAuto);
            Controls.Add(label6);
            Controls.Add(tbxMietPreis);
            Controls.Add(label5);
            Controls.Add(tbxFarbe);
            Controls.Add(label4);
            Controls.Add(tbxPs);
            Controls.Add(label3);
            Controls.Add(tbxModel);
            Controls.Add(label2);
            Controls.Add(tbxHersteller);
            Controls.Add(label1);
            Controls.Add(tbxAutoNr);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxAutoNr;
        private Label label1;
        private Label label2;
        private TextBox tbxHersteller;
        private Label label3;
        private TextBox tbxModel;
        private Label label4;
        private TextBox tbxPs;
        private Label label5;
        private TextBox tbxFarbe;
        private Label label6;
        private TextBox tbxMietPreis;
        private Button btnAddAuto;
        private Button button2;
        private Label label7;
        private DateTimePicker dtpBaujahr;
    }
}