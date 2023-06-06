namespace WinFormsApp1
{
    partial class Form4
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
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 384);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(138, 415);
            button1.Name = "button1";
            button1.Size = new Size(195, 23);
            button1.TabIndex = 1;
            button1.Text = "Neuer Kunde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnKundenManagerAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(593, 415);
            button2.Name = "button2";
            button2.Size = new Size(195, 23);
            button2.TabIndex = 2;
            button2.Text = "Kunde Entfernen";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(367, 415);
            button3.Name = "button3";
            button3.Size = new Size(195, 23);
            button3.TabIndex = 3;
            button3.Text = "Kundeninfo Aendern";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnKundeninfoAendern_click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 415);
            button4.Name = "button4";
            button4.Size = new Size(76, 23);
            button4.TabIndex = 4;
            button4.Text = "Zurueck";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnKundenManagerZurueck_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}