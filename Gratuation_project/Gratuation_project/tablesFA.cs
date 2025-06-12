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
    public partial class tablesFA : Form
    {
        public tablesFA()
        {
            InitializeComponent();
        }

        private void tablesFA_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"images\fbg.png");
            Image image2 = Image.FromFile(@"images\firstimage.png");
            Image image3 = Image.FromFile(@"images\secondimage.png");
            Image image4 = Image.FromFile(@"images\thirdimage.png");


            pictureBox1.Image = image;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            label1.Text = "Frequency Of Letters In English :";
            label1.Font = new Font("Arial", 15, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 15);
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

            pictureBox2.Image = image2;
            pictureBox2.Size = new Size(644, 131);
            pictureBox2.Location = new Point(25, 75);
            pictureBox2.BorderStyle = BorderStyle.None;

            pictureBox3.Image = image3;
            pictureBox3.Size = new Size(644, 131);
            pictureBox3.Location = new Point(25, 225);
            pictureBox3.BorderStyle = BorderStyle.None;

            pictureBox4.Image = image4;
            pictureBox4.Size = new Size(644, 131);
            pictureBox4.Location = new Point(25, 375);
            pictureBox4.BorderStyle = BorderStyle.None;



            button1.BackColor = Color.Crimson;
            button1.Size = new Size(230, 40);
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Location = new Point(25, 530);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
