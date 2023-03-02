namespace Tutorial
{
    partial class Array1d
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
            button3 = new Button();
            txtrollno = new TextBox();
            txtname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(319, 173);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 39;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // txtrollno
            // 
            txtrollno.Location = new Point(213, 80);
            txtrollno.Name = "txtrollno";
            txtrollno.Size = new Size(136, 23);
            txtrollno.TabIndex = 35;
            // 
            // txtname
            // 
            txtname.Location = new Point(213, 47);
            txtname.Name = "txtname";
            txtname.Size = new Size(136, 23);
            txtname.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 88);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 30;
            label2.Text = "Roll_no";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 55);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 29;
            label1.Text = "Name:";
            // 
            // button2
            // 
            button2.Location = new Point(213, 173);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Display";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(77, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Array1d
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 324);
            Controls.Add(button3);
            Controls.Add(txtrollno);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Array1d";
            Text = "Array1d";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox txtrollno;
        private TextBox txtname;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}