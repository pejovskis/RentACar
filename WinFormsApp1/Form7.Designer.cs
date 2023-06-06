namespace WinFormsApp1
{
    partial class Form7
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
            button2 = new Button();
            button1 = new Button();
            dtpMietStarten = new DateTimePicker();
            label5 = new Label();
            tbxAutoNr = new TextBox();
            label3 = new Label();
            tbxKundenNr = new TextBox();
            label2 = new Label();
            tbxVermietungsNr = new TextBox();
            label7 = new Label();
            dtpMietBeenden = new DateTimePicker();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(116, 218);
            button2.Name = "button2";
            button2.Size = new Size(171, 23);
            button2.TabIndex = 39;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnVermietungsManagerAbbrechen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(329, 218);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 38;
            button1.Text = "Vermieten";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAutoVermieten_Click;
            // 
            // dtpMietStarten
            // 
            dtpMietStarten.Location = new Point(247, 139);
            dtpMietStarten.Name = "dtpMietStarten";
            dtpMietStarten.Size = new Size(253, 23);
            dtpMietStarten.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 145);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 36;
            label5.Text = "Miet Starten";
            // 
            // tbxAutoNr
            // 
            tbxAutoNr.Location = new Point(247, 110);
            tbxAutoNr.Name = "tbxAutoNr";
            tbxAutoNr.Size = new Size(253, 23);
            tbxAutoNr.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 113);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 32;
            label3.Text = "AutoNr";
            // 
            // tbxKundenNr
            // 
            tbxKundenNr.Location = new Point(247, 81);
            tbxKundenNr.Name = "tbxKundenNr";
            tbxKundenNr.Size = new Size(253, 23);
            tbxKundenNr.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 84);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 30;
            label2.Text = "KundenNr";
            // 
            // tbxVermietungsNr
            // 
            tbxVermietungsNr.Location = new Point(247, 52);
            tbxVermietungsNr.Name = "tbxVermietungsNr";
            tbxVermietungsNr.Size = new Size(253, 23);
            tbxVermietungsNr.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(116, 55);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 28;
            label7.Text = "Vermietungs Nummer";
            label7.Click += label7_Click;
            // 
            // dtpMietBeenden
            // 
            dtpMietBeenden.Location = new Point(247, 168);
            dtpMietBeenden.Name = "dtpMietBeenden";
            dtpMietBeenden.Size = new Size(253, 23);
            dtpMietBeenden.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 174);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 42;
            label1.Text = "Miet Beenden";
            // 
            // button3
            // 
            button3.Location = new Point(227, 253);
            button3.Name = "button3";
            button3.Size = new Size(171, 23);
            button3.TabIndex = 44;
            button3.Text = "Vermietung Beenden";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnVermietungBeenden_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 288);
            Controls.Add(button3);
            Controls.Add(dtpMietBeenden);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpMietStarten);
            Controls.Add(label5);
            Controls.Add(tbxAutoNr);
            Controls.Add(label3);
            Controls.Add(tbxKundenNr);
            Controls.Add(label2);
            Controls.Add(tbxVermietungsNr);
            Controls.Add(label7);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private DateTimePicker dtpMietStarten;
        private Label label5;
        private TextBox tbxAutoNr;
        private Label label3;
        private TextBox tbxKundenNr;
        private Label label2;
        private TextBox tbxVermietungsNr;
        private Label label7;
        private DateTimePicker dtpMietBeenden;
        private Label label1;
        private Button button3;
    }
}