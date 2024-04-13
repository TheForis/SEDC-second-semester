namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 138);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Click below!!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 36);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Number1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 94);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 141);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(132, 187);
            button1.Name = "button1";
            button1.Size = new Size(225, 371);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(196, 54);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "Wrong Input!";
            label4.Hide();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(196, 112);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "Wrong Input!";
            label5.Hide();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 638);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}
