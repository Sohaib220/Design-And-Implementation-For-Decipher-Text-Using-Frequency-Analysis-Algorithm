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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Image imagepath = Image.FromFile(@"images\bg.png");
            pictureBox1.Image = imagepath;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            label1.Font = new Font("Arial", 25, FontStyle.Bold);
            label1.ForeColor = ColorTranslator.FromHtml("#87f1c3");
            label1.Text = "Design And Implementation For Decipher Text\nUsing Frequency Analysis Algorithm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.AutoSize = true;
            label1.Parent = pictureBox1;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

            label2.Text = "Choice the type of cipher";
            label2.Font = new Font("Arial", 20, FontStyle.Bold);
            label2.ForeColor = ColorTranslator.FromHtml("#87f1c3");
            label2.AutoSize = true;
            label2.Parent = pictureBox1;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            label2.BackColor = Color.Transparent;

            //buttons 
            button1.Text = "Caesar Cipher";
            button1.BackColor = ColorTranslator.FromHtml("#00132b");
            button1.Width = 300;
            button1.Height = 100;
            button1.Font = new Font("Arial", 14, FontStyle.Bold);
            button1.Left = (this.ClientSize.Width - (button1.Width * 5)) / 4;
            button1.Top = (this.ClientSize.Height - 420);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button1.ForeColor = Color.WhiteSmoke;

            button2.Text = "Affine Cipher";
            button2.BackColor = ColorTranslator.FromHtml("#00132b");
            button2.Width = 300;
            button2.Height = 100;
            button2.Font = new Font("Arial", 14, FontStyle.Bold);
            button2.Left = (this.ClientSize.Width - (button2.Width * 5) + (button1.Width * 6)) / 4;
            button2.Top = (this.ClientSize.Height - 420);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button2.ForeColor = Color.WhiteSmoke;

            button3.Text = "Rail Fence Cipher";
            button3.BackColor = ColorTranslator.FromHtml("#00132b");
            button3.Width = 300;
            button3.Height = 100;
            button3.Font = new Font("Arial", 14, FontStyle.Bold);
            button3.Left = (this.ClientSize.Width - (button3.Width * 5) + (button1.Width * 6) + (button2.Width * 6)) / 4;
            button3.Top = (this.ClientSize.Height - 420);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button3.ForeColor = Color.WhiteSmoke;

            button4.Text = "Vigenère Cipher";
            button4.BackColor = ColorTranslator.FromHtml("#00132b");
            button4.Width = 300;
            button4.Height = 100;
            button4.Font = new Font("Arial", 14, FontStyle.Bold);
            button4.Left = (this.ClientSize.Width - (button4.Width * 5) + (button1.Width * 6) + (button2.Width * 6) + (button3.Width * 6)) / 4;
            button4.Top = (this.ClientSize.Height - 420);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 5;
            button4.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button4.ForeColor = Color.WhiteSmoke;
            /*
            button5.Text = "Hill Cipher";
            button5.BackColor = ColorTranslator.FromHtml("#00132b");
            button5.Width = 300;
            button5.Height = 100;
            button5.Font = new Font("Arial", 14, FontStyle.Bold);
            button5.Left = (this.ClientSize.Width - (button1.Width * 5)) / 4;
            button5.Top = (this.ClientSize.Height - 250);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 5;
            button5.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button5.ForeColor = Color.WhiteSmoke;*/


            button6.Text = "Substitution Cipher";
            button6.BackColor = ColorTranslator.FromHtml("#00132b");
            button6.Width = 300;
            button6.Height = 100;
            button6.Font = new Font("Arial", 14, FontStyle.Bold);
            button6.Left = (this.ClientSize.Width - (button1.Width * 5)) / 4;
            button6.Top = (this.ClientSize.Height - 250);
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 5;
            button6.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button6.ForeColor = Color.WhiteSmoke;

            button7.Text = "Beaufort Cipher";
            button7.BackColor = ColorTranslator.FromHtml("#00132b");
            button7.Width = 300;
            button7.Height = 100;
            button7.Font = new Font("Arial", 14, FontStyle.Bold);
            button7.Left = (this.ClientSize.Width - (button3.Width * 5) + (button1.Width * 6) + (button2.Width * 6)) / 4 -220;
            button7.Top = (this.ClientSize.Height - 250);
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 5;
            button7.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button7.ForeColor = Color.WhiteSmoke;

            button8.Text = "Columnar Transposition";
            button8.BackColor = ColorTranslator.FromHtml("#00132b");
            button8.Width = 300;
            button8.Height = 100;
            button8.Font = new Font("Arial", 14, FontStyle.Bold);
            button8.Left = (this.ClientSize.Width - (button4.Width * 5) + (button1.Width * 6) + (button2.Width * 6) + (button3.Width * 6)) / 4;
            button8.Top = (this.ClientSize.Height - 250);
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 5;
            button8.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button8.ForeColor = Color.WhiteSmoke;

            button9.Text = "Frequency Analysis";
            button9.BackColor = ColorTranslator.FromHtml("#00132b");
            button9.Width = 300;
            button9.Height = 100;
            button9.Font = new Font("Arial", 14, FontStyle.Bold);
            button9.Left = (this.ClientSize.Width / 2 - 170);
            button9.Top = (this.ClientSize.Height / 2 - 70);
            button9.FlatStyle = FlatStyle.Flat;
            button9.FlatAppearance.BorderSize = 5;
            button9.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button9.ForeColor = Color.WhiteSmoke;

            button11.Text = "DES";
            button11.BackColor = ColorTranslator.FromHtml("#00132b");
            button11.Width = 300;
            button11.Height = 100;
            button11.Font = new Font("Arial", 14, FontStyle.Bold);
            button11.Left = (this.ClientSize.Width / 2 + 275);
            button11.Top = (this.ClientSize.Height / 2 - 70);
            button11.FlatStyle = FlatStyle.Flat;
            button11.FlatAppearance.BorderSize = 5;
            button11.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button11.ForeColor = Color.WhiteSmoke;

            button12.Text = "AES";
            button12.BackColor = ColorTranslator.FromHtml("#00132b");
            button12.Width = 300;
            button12.Height = 100;
            button12.Font = new Font("Arial", 14, FontStyle.Bold);
            button12.Left = (this.ClientSize.Width / 4 -140);
            button12.Top = (this.ClientSize.Height / 2 - 70);
            button12.FlatStyle = FlatStyle.Flat;
            button12.FlatAppearance.BorderSize = 5;
            button12.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#80c1d8");
            button12.ForeColor = Color.WhiteSmoke;

        }
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                label1.Font = new Font("Arial", 30, FontStyle.Bold);
                label2.Font = new Font("Arial", 20, FontStyle.Bold);
                label1.Top = 70;
                label2.Top = 200;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                label1.Font = new Font("Arial", 14, FontStyle.Bold);
                label2.Font = new Font("Arial", 12, FontStyle.Bold);
                label1.Top = 30;
                label2.Top = 90;

            }
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaesarCipher Caesar = new CaesarCipher();
            Caesar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Affine affine = new Affine();
            affine.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RailFence fence = new RailFence();
            fence.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vigenère vig = new Vigenère();
            vig.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hill hill = new Hill();
            hill.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Columnar columnar = new Columnar();
            columnar.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Beaufort beaufort = new Beaufort();
            beaufort.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Substitution substitution = new Substitution();
            substitution.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frequency frequency = new Frequency();
            frequency.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DES dES = new DES();
            dES.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            aes.Show();
            this.Hide();
        }
    }
}
