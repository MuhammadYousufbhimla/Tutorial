namespace Tutorial
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtname = new TextBox();
            txtfname = new TextBox();
            txtgender = new TextBox();
            txtage = new TextBox();
            txtfees = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(166, 231);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Display";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 65);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "F_name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 102);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 137);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 5;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 183);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 6;
            label5.Text = "Fees:";
            // 
            // txtname
            // 
            txtname.Location = new Point(166, 24);
            txtname.Name = "txtname";
            txtname.Size = new Size(136, 23);
            txtname.TabIndex = 7;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(166, 57);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(136, 23);
            txtfname.TabIndex = 8;
            // 
            // txtgender
            // 
            txtgender.Location = new Point(166, 94);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(136, 23);
            txtgender.TabIndex = 9;
            // 
            // txtage
            // 
            txtage.Location = new Point(166, 129);
            txtage.Name = "txtage";
            txtage.Size = new Size(136, 23);
            txtage.TabIndex = 10;
            // 
            // txtfees
            // 
            txtfees.Location = new Point(166, 175);
            txtfees.Name = "txtfees";
            txtfees.Size = new Size(136, 23);
            txtfees.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(272, 231);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 310);
            Controls.Add(button3);
            Controls.Add(txtfees);
            Controls.Add(txtage);
            Controls.Add(txtgender);
            Controls.Add(txtfname);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtname;
        private TextBox txtfname;
        private TextBox txtgender;
        private TextBox txtage;
        private TextBox txtfees;
        private Button button3;
    }
}