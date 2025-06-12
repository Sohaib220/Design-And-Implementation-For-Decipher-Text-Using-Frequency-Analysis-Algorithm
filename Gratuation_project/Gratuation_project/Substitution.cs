using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gratuation_project
{
    public partial class Substitution : Form
    {
        public Substitution()
        {
            InitializeComponent();
        }

        private void Substitution_Load(object sender, EventArgs e)
        {
            int formWidth = this.Width * 2;
            int formHeight = this.Height * 2;
            int spaceFromBottom = 120; // Space from the bottom
            int spaceFromLeft = 50;   // Space from the left


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
            textBox1.Height = 280;
            textBox1.Multiline = true;
            textBox1.BackColor = ColorTranslator.FromHtml("#00132b");
            textBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.Fixed3D;

            // for key entry
            label2.Text = "Enter the Key :";
            label2.Font = new Font("Arial", 15, FontStyle.Bold);
            label2.ForeColor = ColorTranslator.FromHtml("#80c1d8");
            label2.Location = new Point(50, 420);
            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;

            textBox2.Location = new Point(50, 470);
            textBox2.Width = 500;
            textBox2.Height = 50;
            textBox2.Multiline = true;
            textBox2.BackColor = ColorTranslator.FromHtml("#00132b");
            textBox2.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.Fixed3D;

            //show the result 
            label3.Text = "The result :";
            label3.Font = new Font("Arial", 15, FontStyle.Bold);
            label3.ForeColor = ColorTranslator.FromHtml("#80c1d8");
            label3.Location = new Point(this.Width - textBox3.Width - 430 - label3.Width, 60);
            label3.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;

            textBox3.Location = new Point(this.Width - textBox3.Width - 200, 105);
            textBox3.Width = 500;
            textBox3.Height = this.ClientSize.Height / 2 - panel1.Height;
            textBox3.Multiline = true;
            textBox3.BackColor = ColorTranslator.FromHtml("#00132b");
            textBox3.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox3.ForeColor = Color.WhiteSmoke;
            textBox3.BorderStyle = BorderStyle.Fixed3D;

            //show the number of characters 
            label4.Font = new Font("Arial", 15, FontStyle.Bold);
            label4.ForeColor = ColorTranslator.FromHtml("#80c1d8");
            label4.Location = new Point(50, 470 + textBox2.Height + 40);
            label4.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.Text = $"Character Count: {textBox1.Text.Length}     " +
                          $"Letter Count: {textBox1.Text.Count(Char.IsLetter)}";


            //for returning to the main page
            button1.BackColor = ColorTranslator.FromHtml("#00132b");
            button1.Size = new Size(250, 100);
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.Location = new Point(Bottom, Left);
            button1.Text = "Return to the main page";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Location = new Point(spaceFromLeft, this.ClientSize.Height - spaceFromBottom);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button1.ForeColor = Color.WhiteSmoke;
            button1.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            //for reverse Text the letters 
            button2.BackColor = ColorTranslator.FromHtml("#00132b");
            button2.Size = new Size(250, 100);
            button2.Font = new Font("Arial", 10, FontStyle.Bold);
            button2.Location = new Point(Bottom, Left);
            button2.Text = "Reverse Text";
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Location = new Point(spaceFromLeft, this.ClientSize.Height - spaceFromBottom - 150);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button2.ForeColor = Color.WhiteSmoke;
            button2.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            //for letter only 
            button3.BackColor = ColorTranslator.FromHtml("#00132b");
            button3.Size = new Size(250, 100);
            button3.Font = new Font("Arial", 10, FontStyle.Bold);
            button3.Location = new Point(Bottom, Left);
            button3.Text = "Letter only";
            button3.TextAlign = ContentAlignment.MiddleCenter;
            button3.Location = new Point(spaceFromLeft + 300, this.ClientSize.Height - spaceFromBottom);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button3.ForeColor = Color.WhiteSmoke;
            button3.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            //fint and replace
            button4.BackColor = ColorTranslator.FromHtml("#00132b");
            button4.Size = new Size(250, 100);
            button4.Font = new Font("Arial", 10, FontStyle.Bold);
            button4.Location = new Point(Bottom, Left);
            button4.Text = "Find and replace";
            button4.TextAlign = ContentAlignment.MiddleCenter;
            button4.Location = new Point(spaceFromLeft + 300, this.ClientSize.Height - spaceFromBottom - 150);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 5;
            button4.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button4.ForeColor = Color.WhiteSmoke;
            button4.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            //Frequency Analysis
            button5.BackColor = ColorTranslator.FromHtml("#00132b");
            button5.Size = new Size(250, 100);
            button5.Font = new Font("Arial", 10, FontStyle.Bold);
            button5.Location = new Point(Bottom, Left);
            button5.Text = "Frequency Analysis";
            button5.TextAlign = ContentAlignment.MiddleCenter;
            button5.Location = new Point(this.Width - textBox3.Width + 30, this.ClientSize.Height - spaceFromBottom);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 5;
            button5.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button5.ForeColor = Color.WhiteSmoke;
            button5.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            //Encryption the message
            button6.BackColor = ColorTranslator.FromHtml("#00132b");
            button6.Size = new Size(250, 100);
            button6.Font = new Font("Arial", 10, FontStyle.Bold);
            button6.Location = new Point(Bottom, Left);
            button6.Text = "Encrypt the text";
            button6.TextAlign = ContentAlignment.MiddleCenter;
            button6.Location = new Point(this.Width - textBox3.Width - 120, this.ClientSize.Height - spaceFromBottom - 150);
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 5;
            button6.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button6.ForeColor = Color.WhiteSmoke;
            button6.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            //Dycryption the text
            button8.BackColor = ColorTranslator.FromHtml("#00132b");
            button8.Size = new Size(250, 100);
            button8.Font = new Font("Arial", 10, FontStyle.Bold);
            button8.Location = new Point(Bottom, Left);
            button8.Text = "Decrypt the text";
            button8.TextAlign = ContentAlignment.MiddleCenter;
            button8.Location = new Point(this.Width - 320, this.ClientSize.Height - spaceFromBottom - 150);
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 5;
            button8.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button8.ForeColor = Color.WhiteSmoke;
            button8.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            //panel
            panel1.BackColor = ColorTranslator.FromHtml("#80c1d8");
            panel1.Height = 50;
            panel1.Width = this.ClientSize.Width;
            panel1.Location = new Point(0, (this.ClientSize.Height / 2) + 150);


            //For details ?
            button9.BackColor = ColorTranslator.FromHtml("#80c1d8");
            Size = new Size(100, 100);
            button9.Font = new Font("Arial", 10, FontStyle.Bold);
            button9.Text = "?";
            button9.TextAlign = ContentAlignment.MiddleCenter;
            button9.Location = new Point(this.Width - 100, 60);
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 5;
            button9.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#00132b");
            button9.ForeColor = Color.WhiteSmoke;

            label5.Text = "How does the Cipher work?";
            label5.Font = new Font("Arial", 15, FontStyle.Bold);
            label5.ForeColor = ColorTranslator.FromHtml("#80c1d8");
            label5.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.Visible = false;
            label5.Location = new Point(this.Width - 450, 60);            

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
            MainMenu M = new MainMenu();
            M.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = new string(textBox1.Text.Reverse().ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = new string(textBox1.Text.Where(Char.IsLetter).ToArray());
        }
        private void Label4_UpdateCharacterCount()
        {
            label4.Text = $"Character Count: {textBox1.Text.Length}     " +
                          $"Letter Count: {textBox1.Text.Count(Char.IsLetter)}";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Label4_UpdateCharacterCount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrequencyAnalysis FA = new FrequencyAnalysis();
            FA.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The simple substitution cipher consists of substituting every plaintext character for a different " +
                    "ciphertext character. It differs from the Caesar cipher in that the cipher alphabet is not simply the alphabet shifted," +
                    " it is completely jumbled. Keys for the simple substitution cipher usually consist of 26 letters." +
                    "\r\n\r\nInstructions:\r\n1. Enter the plaintext/ciphertext in the main textbox.\r\n2. Enter " +
                    "the key in the smaller textbox - this should be a string of length     26 containing letters and/or hyphens (-) " +
                    "in place of letters that are           unknown.\r\n3. Press GO to see the encrypted/decrypted message.", "The Substitution Cipher");
        }

        private void button9_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a circular path for button9
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, button9.Width, button9.Height);
                button9.Region = new Region(path);

                // Draw the circular background
                using (Brush brush = new SolidBrush(button9.BackColor))
                {
                    graphics.FillEllipse(brush, 0, 0, button9.Width, button9.Height);
                }

                // Draw the text in the center
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                graphics.DrawString(button9.Text, button9.Font, Brushes.Black, button9.ClientRectangle, sf);
            }
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightBlue;
            label5.Visible = true;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
            button9.BackColor = ColorTranslator.FromHtml("#80c1d8");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Find_and_Replace find = new Find_and_Replace();
            find.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please provide both the plaintext and the key.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string plainText = textBox1.Text;
            string key = textBox2.Text;

            try
            {
                string encryptedText = SubstitutionCipherEncrypt(plainText, key);
                textBox3.Text = encryptedText;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please provide both the ciphertext and the key.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cipherText = textBox1.Text;
            string key = textBox2.Text;

            try
            {
                string decryptedText = SubstitutionCipherDecrypt(cipherText, key);
                textBox3.Text = decryptedText;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string SubstitutionCipherEncrypt(string text, string key)
        {
            if (key.Length != 26 || !key.All(char.IsLetter))
                throw new ArgumentException("The key must be 26 letters long and contain only alphabetic characters.");

            Dictionary<char, char> substitutionMap = new Dictionary<char, char>();
            for (int i = 0; i < 26; i++)
            {
                substitutionMap.Add((char)('A' + i), char.ToUpper(key[i]));
                substitutionMap.Add((char)('a' + i), char.ToLower(key[i]));
            }

            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (substitutionMap.ContainsKey(c))
                    result.Append(substitutionMap[c]);
                else
                    result.Append(c); // Non-alphabetic characters remain unchanged
            }

            return result.ToString();
        }

        // Substitution Cipher Decryption Method
        private string SubstitutionCipherDecrypt(string text, string key)
        {
            if (key.Length != 26 || !key.All(char.IsLetter))
                throw new ArgumentException("The key must be 26 letters long and contain only alphabetic characters.");

            Dictionary<char, char> reverseSubstitutionMap = new Dictionary<char, char>();
            for (int i = 0; i < 26; i++)
            {
                reverseSubstitutionMap.Add(char.ToUpper(key[i]), (char)('A' + i));
                reverseSubstitutionMap.Add(char.ToLower(key[i]), (char)('a' + i));
            }

            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (reverseSubstitutionMap.ContainsKey(c))
                    result.Append(reverseSubstitutionMap[c]);
                else
                    result.Append(c); // Non-alphabetic characters remain unchanged
            }

            return result.ToString();
        }
    }
}
