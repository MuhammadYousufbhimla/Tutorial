namespace Tutorial
{
    partial class Dictionary
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            txtname = new TextBox();
            SuspendLayout();
            // 
            // txtcity
            // 
            txtcity.Location = new Point(219, 58);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(136, 23);
            txtcity.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 66);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 60;
            label6.Text = "City:";
            // 
            // button4
            // 
            button4.Location = new Point(375, 171);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 59;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(277, 171);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 58;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 171);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 47;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(64, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 46;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 95);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 48;
            label1.Text = "Name:";
            // 
            // txtname
            // 
            txtname.Location = new Point(219, 87);
            txtname.Name = "txtname";
            txtname.Size = new Size(136, 23);
            txtname.TabIndex = 53;
            // 
            // Dictionary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 305);
            Controls.Add(txtcity);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtname);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Dictionary";
            Text = "Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcity;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox txtname;
    }
}