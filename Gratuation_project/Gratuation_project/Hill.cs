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
    public partial class Hill : Form
    {

        public Hill()
        {
            InitializeComponent();
        }
        private int matrixSize;
        private TextBox[,] keyTextBoxes;

        private void Hill_Load(object sender, EventArgs e)
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
            label2.Text = "Enter the size of matrix here :";
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


            label6.Text = "Enter the matrix :";
            label6.Font = new Font("Arial", 15, FontStyle.Bold);
            label6.ForeColor = ColorTranslator.FromHtml("#80c1d8");
            label6.Location = new Point(600, 60);
            label6.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;

            textBox4.Location = new Point(600, 105);
            textBox4.Width = 500;
            textBox4.Height = 280;
            textBox4.Multiline = true;
            textBox4.BackColor = ColorTranslator.FromHtml("#00132b");
            textBox4.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox4.ForeColor = Color.WhiteSmoke;
            textBox4.BorderStyle = BorderStyle.Fixed3D;

            button7.BackColor = ColorTranslator.FromHtml("#00132b");
            button7.Size = new Size(200, 100);
            button7.Font = new Font("Arial", 10, FontStyle.Bold);
            button7.Location = new Point(Bottom, Left);
            button7.Text = "Check the matrix";
            button7.TextAlign = ContentAlignment.MiddleCenter;
            button7.Location = new Point(this.ClientSize.Width / 2 - 80, this.ClientSize.Height / 2 - 75);
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 5;
            button7.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button7.ForeColor = Color.WhiteSmoke;
            button7.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));

            button10.BackColor = ColorTranslator.FromHtml("#00132b");
            button10.Size = new Size(200, 100);
            button10.Font = new Font("Arial", 10, FontStyle.Bold);
            button10.Location = new Point(Bottom, Left);
            button10.Text = "Submit";
            button10.TextAlign = ContentAlignment.MiddleCenter;
            button10.Location = new Point(this.ClientSize.Width / 2 - 330, this.ClientSize.Height / 2 - 75);
            button10.FlatStyle = FlatStyle.Flat;
            button10.FlatAppearance.BorderSize = 5;
            button10.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button10.ForeColor = Color.WhiteSmoke;
            button10.Region = new Region(GetRoundedRectangle(button1.ClientRectangle, 4));


            //white
            pictureBox1.Image = null;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            textBox3.ForeColor = Color.Black;

            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial", 20, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;
            button2.Font = new Font("Arial", 20, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.BackColor = Color.White;
            button3.Font = new Font("Arial", 20, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.BackColor = Color.White;
            button4.Font = new Font("Arial", 20, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.BackColor = Color.White;
            button5.Font = new Font("Arial", 20, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.BackColor = Color.White;
            button6.Font = new Font("Arial", 20, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.BackColor = Color.White;
            button7.Font = new Font("Arial", 20, FontStyle.Bold);
            button8.ForeColor = Color.Black;
            button8.BackColor = Color.White;
            button8.Font = new Font("Arial", 20, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.BackColor = Color.White;
            button9.Font = new Font("Arial", 20, FontStyle.Bold);
            button10.ForeColor = Color.Black;
            button10.BackColor = Color.White;
            button10.Font = new Font("Arial", 20, FontStyle.Bold);

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
            MessageBox.Show("The Hill cipher encrypts messages using matrix multiplication. The key is a square n x n matrix (generally 3 x 3) containing " +
                    "values between 0-25 chosen by the user. The plaintext is split into many n-letter chunks (if the length of the text is not a multiple " +
                    "of n, extra letters can be appended to make it work) and each chunk is converted into a n x 1 vector using the numerical values of the " +
                    "letters (where A = 0, B = 1 etc.). Each plaintext vector is multiplied by the key matrix to form ciphertext vectors which are converted " +
                    "to letters.\r\n\r\nTo enter the key matrix into this program, type in each number (or letter) from the matrix row by row, separating each value with a space." +
                    "\r\n\r\nInstructions:\r\n1. Enter the plaintext/ciphertext in the main textbox.\r\n2. Enter the key - this should be a string of either integers OR letters,\t    each separated by a space. There should be a square number of\t    letters/integers." +
                    "\r\n3. Select 'Encrypt' or 'Decrypt' accordingly.\r\n4. Press GO to see the encrypted/decrypted message.", "The Hill Cipher");
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

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string matrixSizeInput = textBox2.Text.Trim();
                if (!ParseMatrixSize(matrixSizeInput, out matrixSize))
                {
                    MessageBox.Show("Invalid matrix size. Enter as '2x2' or '3x3'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Matrix size {matrixSize}x{matrixSize} configured. Enter the keys in TextBox4.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and parse the matrix size
                if (string.IsNullOrWhiteSpace(textBox2.Text) || !ParseMatrixSize(textBox2.Text.Trim(), out matrixSize))
                {
                    MessageBox.Show("Matrix size is invalid or not set. Please enter a valid size in TextBox2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Read the key matrix from textbox4
                int[,] keyMatrix = ReadKeyMatrix();

                // Check if the determinant is non-zero
                if (CalculateDeterminant(keyMatrix) == 0)
                {
                    MessageBox.Show("The key matrix is not invertible (determinant is zero). Please provide a valid matrix.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("The key matrix is valid and can be used for decryption.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Matrix validation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CalculateDeterminant(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            if (size == 2)
            {
                return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            }
            else if (size == 3)
            {
                return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                     - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                     + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            }
            else
            {
                throw new NotImplementedException("Determinant calculation is implemented only for 2x2 and 3x3 matrices.");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string message = textBox1.Text.ToUpper().Replace(" ", "");
                int[,] keyMatrix = ReadKeyMatrix();
                string encryptedMessage = EncryptMessage(message, keyMatrix);
                textBox3.Text = encryptedMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string encryptedMessage = textBox1.Text.ToUpper().Replace(" ", "");
                int[,] keyMatrix = ReadKeyMatrix();
                string decryptedMessage = DecryptMessage(encryptedMessage, keyMatrix);
                textBox3.Text = decryptedMessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input message cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !ParseMatrixSize(textBox2.Text.Trim(), out matrixSize))
            {
                MessageBox.Show("Matrix size is invalid or not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                ReadKeyMatrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Key validation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private int[,] ReadKeyMatrix()
        {
            int[,] keyMatrix = new int[matrixSize, matrixSize];

            try
            {
                string[] rows = textBox4.Text.Trim().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                if (rows.Length != matrixSize)
                {
                    throw new Exception("Number of rows does not match the matrix size.");
                }

                for (int i = 0; i < matrixSize; i++)
                {
                    string[] elements = rows[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (elements.Length != matrixSize)
                    {
                        throw new Exception($"Row {i + 1} does not contain {matrixSize} elements.");
                    }

                    for (int j = 0; j < matrixSize; j++)
                    {
                        if (!int.TryParse(elements[j], out int value))
                        {
                            throw new Exception($"Invalid value at row {i + 1}, column {j + 1}.");
                        }

                        keyMatrix[i, j] = value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading key matrix: {ex.Message}");
            }

            return keyMatrix;
        }
        private string EncryptMessage(string message, int[,] keyMatrix)
        {
            int[] messageVector = CreateMessageVector(message);
            int[] encryptedVector = new int[messageVector.Length];

            for (int i = 0; i < messageVector.Length; i += matrixSize)
            {
                for (int row = 0; row < matrixSize; row++)
                {
                    encryptedVector[i + row] = 0;
                    for (int col = 0; col < matrixSize; col++)
                    {
                        encryptedVector[i + row] += keyMatrix[row, col] * messageVector[i + col];
                    }
                    encryptedVector[i + row] %= 26;
                }
            }

            return ConvertVectorToMessage(encryptedVector);
        }
        private string DecryptMessage(string message, int[,] keyMatrix)
        {
            int[,] inverseMatrix = CalculateInverseMatrix(keyMatrix);
            int[] messageVector = CreateMessageVector(message);
            int[] decryptedVector = new int[messageVector.Length];

            for (int i = 0; i < messageVector.Length; i += matrixSize)
            {
                for (int row = 0; row < matrixSize; row++)
                {
                    decryptedVector[i + row] = 0;
                    for (int col = 0; col < matrixSize; col++)
                    {
                        decryptedVector[i + row] += inverseMatrix[row, col] * messageVector[i + col];
                    }
                    decryptedVector[i + row] %= 26;
                }
            }

            return ConvertVectorToMessage(decryptedVector);
        }
        private int[,] CalculateInverseMatrix(int[,] matrix)
        {
            // Logic to compute the inverse of the key matrix modulo 26
            // Include determinant and adjoint calculations
            throw new NotImplementedException("Inverse matrix calculation logic here.");
        }

        private int[] CreateMessageVector(string message)
        {
            int[] vector = new int[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                vector[i] = message[i] - 'A';
            }
            return vector;
        }
        private string ConvertVectorToMessage(int[] vector)
        {
            char[] message = new char[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                message[i] = (char)(vector[i] + 'A');
            }
            return new string(message);
        }
        private bool ParseMatrixSize(string input, out int size)
        {
            size = 0;
            string[] dimensions = input.Split('x');

            if (dimensions.Length == 2 && int.TryParse(dimensions[0], out int rows) && int.TryParse(dimensions[1], out int cols))
            {
                if (rows == cols && (rows == 2 || rows == 3))
                {
                    size = rows;
                    return true;
                }
            }

            return false;
        }
    }
}
