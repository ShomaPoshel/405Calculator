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

            string lastChar = textBox1.Text.Length > 0 ? textBox1.Text[^1].ToString() : "";

            if (newText == "%" || newText == ",")
            {

                if (textBox1.Text.Length > 0 && char.IsDigit(lastChar[0]))
                {
                    textBox1.Text += newText;
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
            textBox1.Text += newText;
        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;

            expression = textBox1.Text.Replace(",", ".");
            expression = expression.Replace("%", "/100");

            try
            {
                var d = new DataTable();
                textBox1.Text = d.Compute(expression, "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в выражении: " + ex.Message);
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}