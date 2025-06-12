using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gratuation_project
{
    public partial class FrequencyAnalysis : Form
    {
        public FrequencyAnalysis()
        {
            InitializeComponent();
        }
        private void FrequencyAnalysis_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"images\fbg.png");
            pictureBox1.Image = image;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            label1.Text = "TEXT :";
            label1.Font = new Font("Arial", 15, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 15);
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

            richTextBox1.Location = new Point(25, 50);
            richTextBox1.Width = 644;


            Image image2 = Image.FromFile(@"images\letters.png");
            pictureBox2.Image = image2;
            pictureBox2.Size = new Size(644, 131);
            pictureBox2.Location = new Point(25, 275);
            pictureBox2.BorderStyle = BorderStyle.None;



            label2.Text = "";
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 312);
            label2.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label2.BringToFront();

            label15.Text = "";
            label15.Font = new Font("Arial", 12, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(42, 377);
            label15.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label15.BringToFront();

            label3.Text = "";
            label3.Font = new Font("Arial", 12, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(92, 312);
            label3.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label3.BringToFront();

            label16.Text = "";
            label16.Font = new Font("Arial", 12, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(92, 377);
            label16.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label16.BringToFront();

            label4.Text = "";
            label4.Font = new Font("Arial", 12, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(141, 312);
            label4.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label4.BringToFront();

            label17.Text = "";
            label17.Font = new Font("Arial", 12, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(141, 377);
            label17.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label17.BringToFront();

            label5.Text = "";
            label5.Font = new Font("Arial", 12, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(191, 312);
            label5.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label5.BringToFront();

            label18.Text = "";
            label18.Font = new Font("Arial", 12, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(191, 377);
            label18.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label18.BringToFront();

            label6.Text = "";
            label6.Font = new Font("Arial", 12, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(240, 312);
            label6.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label6.BringToFront();

            label19.Text = "";
            label19.Font = new Font("Arial", 12, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Location = new Point(240, 377);
            label19.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label19.BringToFront();

            label7.Text = "";
            label7.Font = new Font("Arial", 12, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(290, 312);
            label7.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label7.BringToFront();

            label20.Text = "";
            label20.Font = new Font("Arial", 12, FontStyle.Bold);
            label20.ForeColor = Color.White;
            label20.Location = new Point(290, 377);
            label20.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label20.BringToFront();

            label8.Text = "";
            label8.Font = new Font("Arial", 12, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(339, 312);
            label8.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label8.BringToFront();

            label21.Text = "";
            label21.Font = new Font("Arial", 12, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(339, 377);
            label21.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label21.BringToFront();

            label9.Text = "";
            label9.Font = new Font("Arial", 12, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(389, 312);
            label9.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label9.BringToFront();

            label22.Text = "";
            label22.Font = new Font("Arial", 12, FontStyle.Bold);
            label22.ForeColor = Color.White;
            label22.Location = new Point(389, 377);
            label22.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label22.BringToFront();

            label10.Text = "";
            label10.Font = new Font("Arial", 12, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(438, 312);
            label10.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label10.BringToFront();

            label23.Text = "";
            label23.Font = new Font("Arial", 12, FontStyle.Bold);
            label23.ForeColor = Color.White;
            label23.Location = new Point(438, 377);
            label23.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label23.BringToFront();

            label11.Text = "";
            label11.Font = new Font("Arial", 12, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(488, 312);
            label11.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label11.BringToFront();

            label24.Text = "";
            label24.Font = new Font("Arial", 12, FontStyle.Bold);
            label24.ForeColor = Color.White;
            label24.Location = new Point(488, 377);
            label24.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label24.BringToFront();

            label12.Text = "";
            label12.Font = new Font("Arial", 12, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(537, 312);
            label12.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label12.BringToFront();

            label25.Text = "";
            label25.Font = new Font("Arial", 12, FontStyle.Bold);
            label25.ForeColor = Color.White;
            label25.Location = new Point(537, 377);
            label25.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label25.BringToFront();

            label13.Text = "";
            label13.Font = new Font("Arial", 12, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(587, 312);
            label13.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label13.BringToFront();

            label26.Text = "";
            label26.Font = new Font("Arial", 12, FontStyle.Bold);
            label26.ForeColor = Color.White;
            label26.Location = new Point(587, 377);
            label26.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label26.BringToFront();

            label14.Text = "";
            label14.Font = new Font("Arial", 12, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(636, 312);
            label14.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label14.BringToFront();

            label27.Text = "";
            label27.Font = new Font("Arial", 12, FontStyle.Bold);
            label27.ForeColor = Color.White;
            label27.Location = new Point(636, 377);
            label27.BackColor = ColorTranslator.FromHtml("#eed5cb");
            label27.BringToFront();

            label2.TextAlign = ContentAlignment.MiddleCenter;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label17.TextAlign = ContentAlignment.MiddleCenter;
            label18.TextAlign = ContentAlignment.MiddleCenter;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            label20.TextAlign = ContentAlignment.MiddleCenter;
            label21.TextAlign = ContentAlignment.MiddleCenter;
            label22.TextAlign = ContentAlignment.MiddleCenter;
            label23.TextAlign = ContentAlignment.MiddleCenter;
            label24.TextAlign = ContentAlignment.MiddleCenter;
            label25.TextAlign = ContentAlignment.MiddleCenter;
            label26.TextAlign = ContentAlignment.MiddleCenter;
            label27.TextAlign = ContentAlignment.MiddleCenter;


            radioButton1.Text = "Letter counts";
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Parent = pictureBox1;
            radioButton1.Font = new Font("Arial", 15, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(27, 430);

            radioButton2.Text = "Percentage";
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Parent = pictureBox1;
            radioButton2.Font = new Font("Arial", 15, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(27, 480);

            button1.BackColor = ColorTranslator.FromHtml("#5d325c");
            button1.Size = new Size(230, 40);
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.Text = "TABLES";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Location = new Point(437, 430);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;

            button2.BackColor = Color.Crimson;
            button2.Size = new Size(230, 40);
            button2.Font = new Font("Arial", 10, FontStyle.Bold);
            button2.Text = "Exit";
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Location = new Point(437, 480);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                UpdateLabels();
                UpdateLabelPositions(true);
            }
            else
            {
                UpdateLabelPositions(false);
            }

        }
        private void UpdateLabels()
        {
            // Get the text from the RichTextBox
            string text = richTextBox1.Text;

            // Calculate total number of letters for percentage calculation
            int totalLetters = text.Count(char.IsLetter);

            // Initialize an array to hold counts for each letter
            int[] letterCounts = new int[26];

            // Count occurrences of each letter (case insensitive)
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int index = char.ToUpper(c) - 'A';
                    letterCounts[index]++;
                }
            }

            // Update labels based on selected radio button
            for (int i = 0; i < 26; i++)
            {
                Label label = (Label)this.Controls.Find($"label{i + 2}", true).FirstOrDefault();

                if (label != null)
                {
                    if (radioButton1.Checked) // Show letter counts
                    {
                        label.Text = letterCounts[i].ToString();
                        label.Font = new Font("Arial", 12, FontStyle.Bold);
                    }
                    else if (radioButton2.Checked) // Show percentages
                    {
                        double percentage = totalLetters > 0 ? (letterCounts[i] / (double)totalLetters) * 100 : 0;
                        label.Text = $"{percentage:F0}%";
                        label.Font = new Font("Arial", 8, FontStyle.Bold);
                    }
                }
            }
        }
        private void UpdateLabelPositions(bool isPercentageMode)
        {
            // Adjust position offsets
            int offsetX = isPercentageMode ? -5 : 5; // Move left if percentage mode, right if number mode
            int offsetY = isPercentageMode ? 2 : -2;// Move down if percentage mode, up if number mode

            // Iterate over all labels from label2 to label27
            for (int i = 2; i <= 27; i++)
            {
                Label label = (Label)Controls.Find($"label{i}", true).FirstOrDefault();
                if (label != null)
                {
                    // Update label position
                    label.Location = new Point(label.Location.X + offsetX, label.Location.Y + offsetY);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablesFA tb = new tablesFA();
            tb.ShowDialog();


        }
    }
}
