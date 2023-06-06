namespace WinFormsApp1
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lvAuto = new ListView();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(273, 442);
            button1.Name = "button1";
            button1.Size = new Size(172, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Auto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAutoManagerAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(800, 442);
            button2.Name = "button2";
            button2.Size = new Size(172, 23);
            button2.TabIndex = 1;
            button2.Text = "Remove Auto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(533, 442);
            button3.Name = "button3";
            button3.Size = new Size(172, 23);
            button3.TabIndex = 2;
            button3.Text = "Schaden Melden";
            button3.UseVisualStyleBackColor = true;
            // 
            // lvAuto
            // 
            lvAuto.Location = new Point(12, 12);
            lvAuto.Name = "lvAuto";
            lvAuto.Size = new Size(1058, 424);
            lvAuto.TabIndex = 3;
            lvAuto.UseCompatibleStateImageBehavior = false;
            lvAuto.View = View.Details;
            lvAuto.SelectedIndexChanged += lvAuto_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(12, 442);
            button4.Name = "button4";
            button4.Size = new Size(172, 23);
            button4.TabIndex = 4;
            button4.Text = "Zurueck";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnAutoManagerZurueck_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 474);
            Controls.Add(button4);
            Controls.Add(lvAuto);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListView lvAuto;
        private Button button4;
    }
}