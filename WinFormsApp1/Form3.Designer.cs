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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Auto Nummer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Hersteller";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 73);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Model";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 23);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 102);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 7;
            label4.Text = "Ps";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(248, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(237, 23);
            textBox4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 131);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Farbe";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(248, 128);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(237, 23);
            textBox5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 160);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 11;
            label6.Text = "Miet Preis";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(248, 157);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(237, 23);
            textBox6.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(305, 214);
            button1.Name = "button1";
            button1.Size = new Size(180, 23);
            button1.TabIndex = 12;
            button1.Text = "Add Auto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(103, 214);
            button2.Name = "button2";
            button2.Size = new Size(180, 23);
            button2.TabIndex = 13;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 249);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}