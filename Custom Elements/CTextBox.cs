using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Calculator.Custom_Elements
{
    [DefaultEvent("_TextChanged")]
    public partial class CTextBox : UserControl
    {
        private Color borderColor = Color.Blue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.Pink;
        private bool isFocus = false;

        public CTextBox()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        [Category("CTextBox Code Advance")]
        public Color BorderColor { 
            get { return borderColor; }
            set { borderColor = value;
                this.Invalidate(); }
        }
        [Category("CTextBox Code Advance")]
        public int BorderSize {
            get { return borderSize; }
            set { borderSize = value;
                this.Invalidate(); }
        }
        [Category("CTextBox Code Advance")]
        public bool UnderlinedStyle {
            get { return underlinedStyle; }
            set { underlinedStyle = value;
                this.Invalidate(); }
        }
        [Category("CTextBox Code Advance")]
        public bool PassvordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("CTextBox Code Advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("CTextBox Code Advance")]
        public override Color BackColor  
        { 
            get { return base.BackColor; }
            set { base.BackColor = value;
                textBox1.BackColor = value; }
        }
        [Category("CTextBox Code Advance")]
        public override Color ForeColor 
        { 
            get { return base.ForeColor; }
            set { base.ForeColor = value;
                textBox1.ForeColor = value; }
        }
        [Category("CTextBox Code Advance")]
        public override Font Font 
        {
            get { return base.Font; }
            set { base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateContronHeight();
            }
        }
        [Category("CTextBox Code Advance")]
        public override string Text 
        { 
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        [Category("CTextBox Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; } 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!isFocus)
                {
                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateContronHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateContronHeight();
        }

        private void UpdateContronHeight()
        {
            if(textBox1.Multiline == false)
            {
                int txtHeigth = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeigth);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocus = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocus = false;
            this.Invalidate();
        }
    }
}
