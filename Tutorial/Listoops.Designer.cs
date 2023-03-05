namespace Tutorial
{
    partial class Listoops
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
            // txtrollno
            // 
            txtrollno.Location = new Point(220, 20);
            txtrollno.Name = "txtrollno";
            txtrollno.Size = new Size(136, 23);
            txtrollno.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 28);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 44;
            label6.Text = "Rollno:";
            // 
            // button4
            // 
            button4.Location = new Point(396, 240);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 43;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(298, 240);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 42;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtfees
            // 
            txtfees.Location = new Point(220, 200);
            txtfees.Name = "txtfees";
            txtfees.Size = new Size(136, 23);
            txtfees.TabIndex = 41;
            // 
            // txtage
            // 
            txtage.Location = new Point(220, 154);
            txtage.Name = "txtage";
            txtage.Size = new Size(136, 23);
            txtage.TabIndex = 40;
            // 
            // txtgender
            // 
            txtgender.Location = new Point(220, 119);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(136, 23);
            txtgender.TabIndex = 39;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(220, 82);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(136, 23);
            txtfname.TabIndex = 38;
            // 
            // txtname
            // 
            txtname.Location = new Point(220, 49);
            txtname.Name = "txtname";
            txtname.Size = new Size(136, 23);
            txtname.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 208);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 36;
            label5.Text = "Fees:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 162);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 35;
            label4.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 127);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 34;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 33;
            label2.Text = "F_name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 57);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 32;
            label1.Text = "Name:";
            // 
            // button2
            // 
            button2.Location = new Point(195, 240);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(85, 240);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Listoops
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 363);
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
            Name = "Listoops";
            Text = "Listoops";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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