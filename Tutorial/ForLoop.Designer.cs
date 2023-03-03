namespace Tutorial
{
    partial class ForLoop
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
            label1 = new Label();
            button1 = new Button();
            txtnotable = new TextBox();
            txtstarttable = new TextBox();
            label2 = new Label();
            txtendtable = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 31);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "notable:";
            // 
            // button1
            // 
            button1.Location = new Point(141, 209);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Forloop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtnotable
            // 
            txtnotable.Location = new Point(265, 23);
            txtnotable.Name = "txtnotable";
            txtnotable.Size = new Size(100, 23);
            txtnotable.TabIndex = 2;
            // 
            // txtstarttable
            // 
            txtstarttable.Location = new Point(265, 70);
            txtstarttable.Name = "txtstarttable";
            txtstarttable.Size = new Size(100, 23);
            txtstarttable.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "starttable:";
            // 
            // txtendtable
            // 
            txtendtable.Location = new Point(265, 118);
            txtendtable.Name = "txtendtable";
            txtendtable.Size = new Size(100, 23);
            txtendtable.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 126);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "endtable";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 40);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "showtable";
            // 
            // ForLoop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 297);
            Controls.Add(label4);
            Controls.Add(txtendtable);
            Controls.Add(label3);
            Controls.Add(txtstarttable);
            Controls.Add(label2);
            Controls.Add(txtnotable);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ForLoop";
            Text = "ForLoop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtnotable;
        private TextBox txtstarttable;
        private Label label2;
        private TextBox txtendtable;
        private Label label3;
        private Label label4;
    }
}