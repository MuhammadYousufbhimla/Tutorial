namespace Tutorial
{
    partial class Hashing
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
            txtcity = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            txtname = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtcity
            // 
            txtcity.Location = new Point(196, 29);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(136, 23);
            txtcity.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 37);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 68;
            label6.Text = "City:";
            // 
            // button4
            // 
            button4.Location = new Point(352, 142);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 67;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(254, 142);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 66;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(196, 58);
            txtname.Name = "txtname";
            txtname.Size = new Size(136, 23);
            txtname.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 66);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 64;
            label1.Text = "Name:";
            // 
            // button2
            // 
            button2.Location = new Point(151, 142);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 63;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 62;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Hashing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 254);
            Controls.Add(txtcity);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtname);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Hashing";
            Text = "Hashing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcity;
        private Label label6;
        private Button button4;
        private Button button3;
        private TextBox txtname;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}