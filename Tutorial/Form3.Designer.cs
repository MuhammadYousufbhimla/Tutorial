namespace Tutorial
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtsecondnum = new TextBox();
            txtfirstnum = new TextBox();
            txtresult = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(140, 194);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Sub";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(239, 194);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Mul";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(352, 194);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Div";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 64);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "First_num:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 101);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Second_num:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 143);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Result";
            // 
            // txtsecondnum
            // 
            txtsecondnum.Location = new Point(210, 93);
            txtsecondnum.Name = "txtsecondnum";
            txtsecondnum.Size = new Size(100, 23);
            txtsecondnum.TabIndex = 7;
            // 
            // txtfirstnum
            // 
            txtfirstnum.Location = new Point(210, 56);
            txtfirstnum.Name = "txtfirstnum";
            txtfirstnum.Size = new Size(100, 23);
            txtfirstnum.TabIndex = 7;
            // 
            // txtresult
            // 
            txtresult.Location = new Point(210, 135);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(100, 23);
            txtresult.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 9);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 9;
            label4.Text = "Mini Calculator";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 291);
            Controls.Add(label4);
            Controls.Add(txtresult);
            Controls.Add(txtfirstnum);
            Controls.Add(txtsecondnum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtsecondnum;
        private TextBox txtfirstnum;
        private TextBox txtresult;
        private Label label4;
    }
}