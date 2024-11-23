using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            string newText = currentButton.Text;

            string operators = "+-*/.";

            string lastChar = cTextBox1.Text.Length > 0 ? cTextBox1.Text[cTextBox1.Text.Length - 1].ToString() : "";

            if (newText == "%" || newText == ",")
            {

                if (cTextBox1.Text.Length > 0 && char.IsDigit(lastChar[0]))
                {
                    cTextBox1.Text += newText;
                }
                return;
            }

            if (lastChar == "," && operators.Contains(newText))
            {
                return;
            }


            if (operators.Contains(newText) && operators.Contains(lastChar))
            {
                return;
            }
            else if (newText == "." && lastChar == ".")
            {
                return;
            }
            cTextBox1.Text += newText;
        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            string expression = cTextBox1.Text;

            expression = cTextBox1.Text.Replace(",", ".");
            expression = expression.Replace("%", "/100");

            try
            {
                var d = new DataTable();
                cTextBox1.Text = d.Compute(expression, "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в выражении: " + ex.Message);
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            cTextBox1.Text = "";
        }

        private void Button99_Click(object sender, EventArgs e)
        {

        }
        bool drag = false;
        Point start_point = new Point(0, 0);

        private void button1_MouseEnter(object sender, EventArgs e) { button1.BackColor = Color.Maroon; }

        private void button1_MouseLeave(object sender, EventArgs e) { button1.BackColor = Color.FromArgb(64, 64, 64); }

        private void button2_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void button99_Click(object sender, EventArgs e) { Application.Exit(); }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
