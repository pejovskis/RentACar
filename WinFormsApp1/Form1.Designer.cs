namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVermietung = new Button();
            btnAutoMenager = new Button();
            btnKundenMenager = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVermietung
            // 
            btnVermietung.Location = new Point(315, 161);
            btnVermietung.Name = "btnVermietung";
            btnVermietung.Size = new Size(216, 23);
            btnVermietung.TabIndex = 0;
            btnVermietung.Text = "Vermietung";
            btnVermietung.UseVisualStyleBackColor = true;
            btnVermietung.Click += btnVermietung_Click;
            // 
            // btnAutoMenager
            // 
            btnAutoMenager.Location = new Point(315, 12);
            btnAutoMenager.Name = "btnAutoMenager";
            btnAutoMenager.Size = new Size(216, 23);
            btnAutoMenager.TabIndex = 1;
            btnAutoMenager.Text = "Auto Manager";
            btnAutoMenager.UseVisualStyleBackColor = true;
            btnAutoMenager.Click += btnAutoManager_Click;
            // 
            // btnKundenMenager
            // 
            btnKundenMenager.Location = new Point(315, 86);
            btnKundenMenager.Name = "btnKundenMenager";
            btnKundenMenager.Size = new Size(216, 23);
            btnKundenMenager.TabIndex = 2;
            btnKundenMenager.Text = "Kunden Manager";
            btnKundenMenager.UseVisualStyleBackColor = true;
            btnKundenMenager.Click += btnKundenManager_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 172);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 214);
            Controls.Add(pictureBox1);
            Controls.Add(btnKundenMenager);
            Controls.Add(btnAutoMenager);
            Controls.Add(btnVermietung);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVermietung;
        private Button btnAutoMenager;
        private Button btnKundenMenager;
        private PictureBox pictureBox1;
    }
}