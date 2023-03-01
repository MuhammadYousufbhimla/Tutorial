namespace Tutorial
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
            label1 = new Label();
            txtname = new TextBox();
            txtfname = new TextBox();
            label2 = new Label();
            txtclass = new TextBox();
            label3 = new Label();
            txtgpa = new TextBox();
            label4 = new Label();
            txtfees = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(104, 263);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 38);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // txtname
            // 
            txtname.Location = new Point(206, 35);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 2;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(206, 73);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(100, 23);
            txtfname.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "F_name:";
            // 
            // txtclass
            // 
            txtclass.Location = new Point(206, 113);
            txtclass.Name = "txtclass";
            txtclass.Size = new Size(100, 23);
            txtclass.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 116);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Class";
            // 
            // txtgpa
            // 
            txtgpa.Location = new Point(206, 154);
            txtgpa.Name = "txtgpa";
            txtgpa.Size = new Size(100, 23);
            txtgpa.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 157);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "GPA";
            // 
            // txtfees
            // 
            txtfees.Location = new Point(206, 195);
            txtfees.Name = "txtfees";
            txtfees.Size = new Size(100, 23);
            txtfees.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 198);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 9;
            label5.Text = "Fees";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 317);
            Controls.Add(txtfees);
            Controls.Add(label5);
            Controls.Add(txtgpa);
            Controls.Add(label4);
            Controls.Add(txtclass);
            Controls.Add(label3);
            Controls.Add(txtfname);
            Controls.Add(label2);
            Controls.Add(txtname);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtname;
        private TextBox txtfname;
        private Label label2;
        private TextBox txtclass;
        private Label label3;
        private TextBox txtgpa;
        private Label label4;
        private TextBox txtfees;
        private Label label5;
    }
}