namespace Gratuation_project
{
    partial class Frequency
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
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(2, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 24);
            panel1.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(47, 500);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 26;
            button1.Text = "return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 20;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(999, 564);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(785, 30);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 28;
            label2.Text = "label2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(785, 67);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 29;
            textBox2.WordWrap = false;
            // 
            // button2
            // 
            button2.Location = new Point(837, 500);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "frequency";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(432, 239);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 31;
            button3.Text = "Analysis";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Frequency
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 564);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Frequency";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Frequency_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}