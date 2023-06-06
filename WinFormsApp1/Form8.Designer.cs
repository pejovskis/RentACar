namespace WinFormsApp1
{
    partial class Form8
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
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(225, 187);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(253, 23);
            dateTimePicker2.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 193);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 54;
            label1.Text = "Miet Beenden";
            // 
            // button2
            // 
            button2.Location = new Point(94, 237);
            button2.Name = "button2";
            button2.Size = new Size(171, 23);
            button2.TabIndex = 53;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(307, 237);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 52;
            button1.Text = "Aendern";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(225, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 23);
            dateTimePicker1.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 164);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 50;
            label5.Text = "Miet Starten";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 23);
            textBox3.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 132);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 48;
            label3.Text = "Auto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 103);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 46;
            label2.Text = "Kunde";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 74);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 44;
            label7.Text = "Vermietungs Nummer";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 332);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label7;
    }
}