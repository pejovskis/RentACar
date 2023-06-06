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
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
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
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(247, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 23);
            dateTimePicker1.TabIndex = 37;
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
            // textBox3
            // 
            textBox3.Location = new Point(247, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 23);
            textBox3.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 113);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 32;
            label3.Text = "Auto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 84);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 30;
            label2.Text = "Kunde";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 29;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(247, 168);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(253, 23);
            dateTimePicker2.TabIndex = 43;
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
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 288);
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
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DateTimePicker dateTimePicker2;
        private Label label1;
    }
}