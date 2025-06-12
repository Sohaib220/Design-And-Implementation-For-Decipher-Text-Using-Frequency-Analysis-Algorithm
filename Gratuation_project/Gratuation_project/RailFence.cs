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
    public partial class RailFence : Form
    {
        public RailFence()
        {
            InitializeComponent();
        }
        private void RailFence_Load(object sender, EventArgs e)
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

            textBox2.Location = new Point(55, 470);
            textBox2.Width = 175;
            textBox2.Height = 50;
            textBox2.Multiline = true;
            textBox2.BackColor = ColorTranslator.FromHtml("#00132b");
            textBox2.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.Fixed3D;

            button7.BackColor = ColorTranslator.FromHtml("#00132b");
            button7.Size = new Size(175, 50);
            button7.Font = new Font("Arial", 10, FontStyle.Bold);
            button7.Text = "Zigzag Down";
            button7.TextAlign = ContentAlignment.MiddleCenter;
            button7.Location = new Point(270, 470);
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button7.ForeColor = Color.WhiteSmoke;

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

            button10.BackColor = ColorTranslator.FromHtml("#00132b");
            button10.Size = new Size(250, 80);
            button10.Font = new Font("Arial", 10, FontStyle.Bold);
            button10.Location = new Point(Bottom, Left);
            button10.Text = "Make Brute Force";
            button10.TextAlign = ContentAlignment.MiddleCenter;
            button10.Location = new Point(this.ClientSize.Width / 2 - 120, this.ClientSize.Height - spaceFromBottom - 160);
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 5;
            button10.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button10.ForeColor = Color.WhiteSmoke;
            button10.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            button11.BackColor = ColorTranslator.FromHtml("#00132b");
            button11.Size = new Size(250, 80);
            button11.Font = new Font("Arial", 10, FontStyle.Bold);
            button11.Location = new Point(Bottom, Left);
            button11.Text = "Text Detection";
            button11.TextAlign = ContentAlignment.MiddleCenter;
            button11.Location = new Point(this.ClientSize.Width / 2 - 120, this.ClientSize.Height - spaceFromBottom - 60);
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 5;
            button11.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button11.ForeColor = Color.WhiteSmoke;
            button11.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));
            button11.Visible = false;



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

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Rail Fence cipher is a form of transposition cipher that gets its name from the way in which it is encoded. " +
                   "In the rail fence cipher, the plaintext is written downwards on successive 'rails' of an imaginary fence, then moving up when we get to the bottom." +
                   " The message is then read off in rows. See https://en.wikipedia.org/wiki/Transposition_cipher for more information." +
                   "\r\n\r\nInstructions:\r\n1. Enter the plaintext/ciphertext in the main textbox.\r\n2. Enter " +
                   "a rail key - this should be an integer.\r\n3. Choose a 'zigzag' direction by pressing the button (the setting\t\t displayed on the button is the setting that will be used). The default\t    setting is 'Zigzag Down'." +
                   "\r\n4. Select 'Encrypt' or 'Decrypt' accordingly to see the encrypted/decrypted message.", "The Rail Fence Cipher");

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

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Zigzag Down")
            {
                button7.Text = "Zigzag Up";
            }
            else
            {
                button7.Text = "Zigzag Down";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please enter a valid message to encrypt.", "Validation Error");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int rails) || rails < 2)
            {
                MessageBox.Show("Please enter a valid number of rails (>= 2).", "Validation Error");
                return;
            }

            string zigzagType = button7.Text; // Check the zigzag type
            string result = RailFenceEncrypt(message, rails, zigzagType);
            textBox3.Text = result; // Display the encrypted message
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string encryptedMessage = textBox1.Text;
            if (string.IsNullOrWhiteSpace(encryptedMessage))
            {
                MessageBox.Show("Please enter a valid encrypted message to decrypt.", "Validation Error");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int rails) || rails < 2)
            {
                MessageBox.Show("Please enter a valid number of rails (>= 2).", "Validation Error");
                return;
            }

            string zigzagType = button7.Text; // Check the zigzag type
            string result = RailFenceDecrypt(encryptedMessage, rails, zigzagType);
            textBox3.Text = result; // Display the decrypted message
        }
        // Rail Fence Cipher Encryption Logic
        private string RailFenceEncrypt(string message, int rails, string zigzagType)
        {
            char[,] rail = new char[rails, message.Length];
            for (int i = 0; i < rails; i++)
                for (int j = 0; j < message.Length; j++)
                    rail[i, j] = '\n';

            bool down = zigzagType == "Zigzag Down"; // Determine the initial direction
            int row = down ? 0 : rails - 1; // Start from the top or bottom based on zigzag type
            int col = 0;

            foreach (char c in message)
            {
                rail[row, col++] = c;

                if (down)
                {
                    row++;
                    if (row == rails) // Reverse direction if bottom reached
                    {
                        down = false;
                        row -= 2;
                    }
                }
                else
                {
                    row--;
                    if (row == -1) // Reverse direction if top reached
                    {
                        down = true;
                        row += 2;
                    }
                }
            }

            string result = "";
            for (int i = 0; i < rails; i++)
                for (int j = 0; j < message.Length; j++)
                    if (rail[i, j] != '\n')
                        result += rail[i, j];

            return result;
        }


        private string RailFenceDecrypt(string encryptedMessage, int rails, string zigzagType)
        {
            char[,] rail = new char[rails, encryptedMessage.Length];
            for (int i = 0; i < rails; i++)
                for (int j = 0; j < encryptedMessage.Length; j++)
                    rail[i, j] = '\n';

            bool down = zigzagType == "Zigzag Down"; // Determine the initial direction
            int row = down ? 0 : rails - 1; // Start from the top or bottom based on zigzag type
            int col = 0;

            // Mark the pattern with '*'
            foreach (char c in encryptedMessage)
            {
                rail[row, col++] = '*';

                if (down)
                {
                    row++;
                    if (row == rails)
                    {
                        down = false;
                        row -= 2;
                    }
                }
                else
                {
                    row--;
                    if (row == -1)
                    {
                        down = true;
                        row += 2;
                    }
                }
            }

            // Fill the rail with the encrypted message
            int index = 0;
            for (int i = 0; i < rails; i++)
                for (int j = 0; j < encryptedMessage.Length; j++)
                    if (rail[i, j] == '*' && index < encryptedMessage.Length)
                        rail[i, j] = encryptedMessage[index++];

            // Read the message using the zigzag pattern
            string result = "";
            row = down ? 0 : rails - 1;
            col = 0;
            foreach (char c in encryptedMessage)
            {
                result += rail[row, col++];

                if (down)
                {
                    row++;
                    if (row == rails)
                    {
                        down = false;
                        row -= 2;
                    }
                }
                else
                {
                    row--;
                    if (row == -1)
                    {
                        down = true;
                        row += 2;
                    }
                }
            }

            return result;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string encryptedMessage = textBox1.Text; // Get the encrypted message from textBox1
            StringBuilder output = new StringBuilder();

            // Brute force for Rail Fence Cipher
            for (int numRails = 2; numRails <= encryptedMessage.Length; numRails++) // Try all possible rail numbers
            {
                // Try both zigzag directions
                string decryptedZigzagDown = DecryptRailFence(encryptedMessage, numRails, true);
                string decryptedZigzagUp = DecryptRailFence(encryptedMessage, numRails, false);

                output.AppendLine($"{decryptedZigzagDown}");
                output.AppendLine($"{decryptedZigzagUp}");
            }

            textBox3.Text = output.ToString();
            button11.Visible = true;
        }
        private string DecryptRailFence(string cipherText, int numRails, bool isZigzagDown)
        {
            // Prepare the rail matrix
            char[,] railMatrix = new char[numRails, cipherText.Length];
            bool directionDown = isZigzagDown; // Use the specified zigzag direction
            int row = isZigzagDown ? 0 : numRails - 1; // Start from top or bottom
            int col = 0;

            // Mark positions in the rail matrix
            for (int i = 0; i < cipherText.Length; i++)
            {
                railMatrix[row, col++] = '*';

                // Switch direction if we reach the top or bottom
                if (row == 0)
                    directionDown = true;
                else if (row == numRails - 1)
                    directionDown = false;

                // Move the row up or down based on the direction
                row += directionDown ? 1 : -1;
            }

            // Fill the rail matrix with the cipher text
            int index = 0;
            for (int r = 0; r < numRails; r++)
            {
                for (int c = 0; c < cipherText.Length; c++)
                {
                    if (railMatrix[r, c] == '*' && index < cipherText.Length)
                        railMatrix[r, c] = cipherText[index++];
                }
            }

            // Read the plaintext from the rail matrix
            StringBuilder decrypted = new StringBuilder();
            directionDown = isZigzagDown; // Reset the direction for reading
            row = isZigzagDown ? 0 : numRails - 1; // Start from top or bottom
            col = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                decrypted.Append(railMatrix[row, col++]);

                // Switch direction if we reach the top or bottom
                if (row == 0)
                    directionDown = true;
                else if (row == numRails - 1)
                    directionDown = false;

                // Move the row up or down based on the direction
                row += directionDown ? 1 : -1;
            }

            return decrypted.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string textToSend = textBox3.Text;
            text_detection text_Detection = new text_detection(textToSend);
            text_Detection.ShowDialog();
        }
    }
}
