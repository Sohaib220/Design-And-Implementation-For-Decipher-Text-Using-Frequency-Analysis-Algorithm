using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Gratuation_project
{
    public partial class Find_and_Replace : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private List<int> matchIndices = new List<int>();
        private int currentMatchIndex = -1;
        public Find_and_Replace()
        {
            InitializeComponent();
        }
        private void Find_and_Replace_Load(object sender, EventArgs e)
        {
            // the background
            Image image = Image.FromFile(@"images\findbg.png");
            pictureBox1.Image = image;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SendToBack();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            label1.Text = "Find";
            label1.Font = new Font("Arial", 15, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 35);
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

            textBox1.Location = new Point(17, 70);
            textBox1.Width = 260;


            label2.Text = "Enter a string to locate.";
            label2.Font = new Font("Arial", 9, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 110);
            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;

            label3.Text = "";
            label3.Font = new Font("Arial", 9, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(250, 110);
            label3.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;

            button1.BackColor = Color.DeepSkyBlue;
            button1.Size = new Size(120, 50);
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.Text = "←";
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Location = new Point(15, 140);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;

            button2.BackColor = Color.DeepSkyBlue;
            button2.Size = new Size(120, 50);
            button2.Font = new Font("Arial", 10, FontStyle.Bold);
            button2.Text = "→";
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Location = new Point(170, 140);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;

            checkBox1.Text = "Case Sensitive";
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Parent = pictureBox1;
            checkBox1.Font = new Font("Arial", 15, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(15, 210);

            label4.Text = "Replace";
            label4.Font = new Font("Arial", 15, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 300);
            label4.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;

            textBox2.Location = new Point(17, 340);
            textBox2.Width = 260;

            button3.BackColor = Color.DodgerBlue;
            button3.Size = new Size(260, 40);
            button3.Font = new Font("Arial", 10, FontStyle.Bold);
            button3.Text = "REPLACE";
            button3.TextAlign = ContentAlignment.MiddleCenter;
            button3.Location = new Point(15, 380);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;

            button4.BackColor = Color.Crimson;
            button4.Size = new Size(260, 40);
            button4.Font = new Font("Arial", 10, FontStyle.Bold);
            button4.Text = "Exit";
            button4.TextAlign = ContentAlignment.MiddleCenter;
            button4.Location = new Point(15, 500);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HighlightMatches();
        }
        private void HighlightMatches()
        {
            string searchText = textBox1.Text;
            string richTextContent = richTextBox1.Text;
            bool caseSensitive = checkBox1.Checked;

            if (string.IsNullOrEmpty(searchText))
            {
                ClearHighlights();
                return;
            }

            matchIndices.Clear();

            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            int index = richTextContent.IndexOf(searchText, 0, comparison);
            while (index != -1)
            {
                matchIndices.Add(index);
                index = richTextContent.IndexOf(searchText, index + searchText.Length, comparison);
            }

            if (matchIndices.Count > 0)
            {
                currentMatchIndex = 0;
            }
            else
            {
                currentMatchIndex = -1;
                ClearHighlights();
                return;
            }

            UpdateLabels();
            HighlightCurrentMatch();
        }

        private void ClearHighlights()
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            richTextBox1.SelectionLength = 0;
            label2.Text = "Matches: 0";
            label3.Text = "";
        }

        private void HighlightCurrentMatch()
        {
            if (matchIndices.Count == 0)
                return;

            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;

            foreach (var index in matchIndices)
            {
                richTextBox1.Select(index, textBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.Green;
            }

            if (currentMatchIndex >= 0 && currentMatchIndex < matchIndices.Count)
            {
                int startIndex = matchIndices[currentMatchIndex];
                richTextBox1.Select(startIndex, textBox1.Text.Length);
                richTextBox1.SelectionBackColor = Color.Blue;
            }
            richTextBox1.SelectionLength = 0;
        }

        private void UpdateLabels()
        {
            label2.Text = $"Matches: {matchIndices.Count}";
            label3.Text = currentMatchIndex >= 0
                ? $"({currentMatchIndex + 1}/{matchIndices.Count})"
                : "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (matchIndices.Count == 0)
                return;

            currentMatchIndex--;
            if (currentMatchIndex < 0)
                currentMatchIndex = matchIndices.Count - 1;

            HighlightCurrentMatch();
            UpdateLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (matchIndices.Count == 0)
                return;

            currentMatchIndex++;
            if (currentMatchIndex >= matchIndices.Count)
                currentMatchIndex = 0;

            HighlightCurrentMatch();
            UpdateLabels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string replaceText = textBox2.Text;
            if (string.IsNullOrEmpty(replaceText) || matchIndices.Count == 0)
                return;

            string searchText = textBox1.Text;
            bool caseSensitive = checkBox1.Checked;
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            for (int i = matchIndices.Count - 1; i >= 0; i--)
            {
                int index = matchIndices[i];
                richTextBox1.Select(index, searchText.Length);
                richTextBox1.SelectedText = replaceText;
            }

            HighlightMatches();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HighlightMatches();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_and_Replace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }

        }

        private void Find_and_Replace_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }

        }

        private void Find_and_Replace_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }

        }

        private void Find_and_Replace_Move(object sender, EventArgs e)
        {

        }
    }
}
