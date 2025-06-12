using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gratuation_project
{
    public partial class text_detection : Form
    {
        public text_detection(string receivedText)
        {
            InitializeComponent();
            textBox1.Text = receivedText;
        }

        private void text_detection_Load(object sender, EventArgs e)
        {
            int formWidth = this.Width * 2;
            int formHeight = this.Height * 2;
            int spaceFromBottom = 120; // Space from the bottom
            int spaceFromLeft = 50;


            Image image = Image.FromFile(@"images\bgfordechipher.png");
            pictureBox1.Image = image;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //for plain text enter
            label1.Text = "Enter the plain text :";
            label1.Font = new Font("Arial", 15, FontStyle.Bold);
            label1.ForeColor = ColorTranslator.FromHtml("#80c1d8");
            label1.Location = new Point(50, 60);
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

            textBox1.Location = new Point(50, 105);
            textBox1.Width = 500;
            textBox1.Height = this.ClientSize.Height / 2 - panel1.Height;
            textBox1.Multiline = true;
            textBox1.BackColor = ColorTranslator.FromHtml("#00132b");
            textBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.Fixed3D;

            label2.Text = "The result :";
            label2.Font = new Font("Arial", 15, FontStyle.Bold);
            label2.ForeColor = ColorTranslator.FromHtml("#80c1d8");
            label2.Location = new Point(this.Width - textBox2.Width - 430 - label2.Width, 60);
            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;

            textBox2.Location = new Point(this.Width - textBox2.Width - 575, 105);
            textBox2.Width = 500;
            textBox2.Height = this.ClientSize.Height / 2 - panel1.Height;
            textBox2.Multiline = true;
            textBox2.BackColor = ColorTranslator.FromHtml("#00132b");
            textBox2.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.Fixed3D;

            button1.BackColor = ColorTranslator.FromHtml("#00132b");
            button1.Size = new Size(250, 100);
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.Location = new Point(Bottom, Left);
            button1.Text = "Return to the main page";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Location = new Point(spaceFromLeft, this.ClientSize.Height - spaceFromBottom - 130);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button1.ForeColor = Color.WhiteSmoke;
            button1.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            button2.BackColor = ColorTranslator.FromHtml("#00132b");
            button2.Size = new Size(250, 100);
            button2.Font = new Font("Arial", 10, FontStyle.Bold);
            button2.Location = new Point(Bottom, Left);
            button2.Text = "Frequency";
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Location = new Point(this.Width - textBox2.Width + 30, this.ClientSize.Height - spaceFromBottom - 130);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button2.ForeColor = Color.WhiteSmoke;
            button2.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            panel1.BackColor = ColorTranslator.FromHtml("#80c1d8");
            panel1.Height = 50;
            panel1.Width = this.ClientSize.Width;
            panel1.Location = new Point(0, (this.ClientSize.Height / 2) + 150);

            button3.BackColor = ColorTranslator.FromHtml("#00132b");
            button3.Size = new Size(250, 100);
            button3.Font = new Font("Arial", 10, FontStyle.Bold);
            button3.Location = new Point(Bottom, Left);
            button3.Text = "Analysis";
            button3.TextAlign = ContentAlignment.MiddleCenter;
            button3.Location = new Point(this.ClientSize.Width / 2 - 150, this.ClientSize.Height / 2 - 200);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button3.ForeColor = Color.WhiteSmoke;
            button3.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));
        }
        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left corner
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right corner
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner

            path.CloseFigure();
            return path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrequencyAnalysis FA = new FrequencyAnalysis();
            FA.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Load dictionary only once (if not already loaded)
            if (wordDictionary.Count == 0)
            {
                LoadDictionary();
            }

            string[] sentences = textBox1.Lines; // Get all sentences
            List<string> validSentences = new List<string>();

            foreach (string sentence in sentences)
            {
                string[] words = Regex.Split(sentence.ToLower(), @"\W+"); // Split words, remove punctuation
                int totalWords = words.Length;
                int correctWords = words.Count(word => wordDictionary.Contains(word));

                if (totalWords > 0)
                {
                    double accuracy = (correctWords / (double)totalWords) * 100;

                    if (accuracy >= 60) // Threshold check
                    {
                        validSentences.Add($"[Accuracy: {accuracy:F1}%] {sentence}");
                    }
                }
            }

            // Display valid sentences in textBox2
            textBox2.Text = validSentences.Count > 0 ? string.Join("\r\n", validSentences) : "No valid sentences found.";

        }
        private HashSet<string> wordDictionary = new HashSet<string>();
        private void LoadDictionary()
        {
            string wordsFile = @"C:\photos\programming\my graduation project\words.txt"; // Update with actual path
            string indexFile = @"C:\photos\programming\my graduation project\indexWords.txt"; // Update with actual path

            if (File.Exists(wordsFile))
            {
                foreach (string line in File.ReadLines(wordsFile))
                {
                    wordDictionary.Add(line.Trim().ToLower());
                }
            }
        }
    }
}
