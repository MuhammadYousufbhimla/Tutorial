namespace Tutorial
{
    partial class genericclass
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
            button5 = new Button();
            txtrollno = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            txtfees = new TextBox();
            txtage = new TextBox();
            txtgender = new TextBox();
            txtfname = new TextBox();
            txtname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(423, 22);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 79;
            button5.Text = "Start";
            button5.UseVisualStyleBackColor = true;
            // 
            // txtrollno
            // 
            txtrollno.Location = new Point(181, 45);
            txtrollno.Name = "txtrollno";
            txtrollno.Size = new Size(136, 23);
            txtrollno.TabIndex = 78;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 53);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 77;
            label6.Text = "Rollno:";
            // 
            // button4
            // 
            button4.Location = new Point(357, 265);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 76;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(259, 265);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 75;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtfees
            // 
            txtfees.Location = new Point(181, 225);
            txtfees.Name = "txtfees";
            txtfees.Size = new Size(136, 23);
            txtfees.TabIndex = 74;
            // 
            // txtage
            // 
            txtage.Location = new Point(181, 179);
            txtage.Name = "txtage";
            txtage.Size = new Size(136, 23);
            txtage.TabIndex = 73;
            // 
            // txtgender
            // 
            txtgender.Location = new Point(181, 144);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(136, 23);
            txtgender.TabIndex = 72;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(181, 107);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(136, 23);
            txtfname.TabIndex = 71;
            // 
            // txtname
            // 
            txtname.Location = new Point(181, 74);
            txtname.Name = "txtname";
            txtname.Size = new Size(136, 23);
            txtname.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 233);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 69;
            label5.Text = "Fees:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 187);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 68;
            label4.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 152);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 67;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 115);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 66;
            label2.Text = "F_name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 82);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 65;
            label1.Text = "Name:";
            // 
            // button2
            // 
            button2.Location = new Point(156, 265);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 64;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 63;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // genericclass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 311);
            Controls.Add(button5);
            Controls.Add(txtrollno);
            Controls.Add(label6);
            Controls.Add(button4);
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
            Name = "genericclass";
            Text = "genericclass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox txtrollno;
        private Label label6;
        private Button button4;
        private Button button3;
        private TextBox txtfees;
        private TextBox txtage;
        private TextBox txtgender;
        private TextBox txtfname;
        private TextBox txtname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}