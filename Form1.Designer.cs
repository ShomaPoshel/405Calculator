
namespace Money_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cButton18 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton17 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton16 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton15 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton14 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton13 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton12 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton11 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton10 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton9 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton8 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton7 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton6 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton5 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton4 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton3 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton2 = new Money_Calculator.Custom_Elements.CButton();
            this.cButton1 = new Money_Calculator.Custom_Elements.CButton();
            this.cTextBox1 = new Money_Calculator.Custom_Elements.CTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(314, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "−";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(341, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button99_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // cButton18
            // 
            this.cButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton18.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton18.BorderColor = System.Drawing.Color.Black;
            this.cButton18.BorderRadius = 40;
            this.cButton18.BorderSize = 0;
            this.cButton18.FlatAppearance.BorderSize = 0;
            this.cButton18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton18.Location = new System.Drawing.Point(292, 395);
            this.cButton18.Name = "cButton18";
            this.cButton18.Size = new System.Drawing.Size(64, 64);
            this.cButton18.TabIndex = 24;
            this.cButton18.Text = "+";
            this.cButton18.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton18.UseVisualStyleBackColor = false;
            this.cButton18.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton17
            // 
            this.cButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton17.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton17.BorderColor = System.Drawing.Color.Black;
            this.cButton17.BorderRadius = 40;
            this.cButton17.BorderSize = 0;
            this.cButton17.FlatAppearance.BorderSize = 0;
            this.cButton17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton17.Location = new System.Drawing.Point(291, 315);
            this.cButton17.Name = "cButton17";
            this.cButton17.Size = new System.Drawing.Size(64, 64);
            this.cButton17.TabIndex = 23;
            this.cButton17.Text = "-";
            this.cButton17.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton17.UseVisualStyleBackColor = false;
            this.cButton17.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton16
            // 
            this.cButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton16.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton16.BorderColor = System.Drawing.Color.Black;
            this.cButton16.BorderRadius = 40;
            this.cButton16.BorderSize = 0;
            this.cButton16.FlatAppearance.BorderSize = 0;
            this.cButton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton16.Location = new System.Drawing.Point(291, 234);
            this.cButton16.Name = "cButton16";
            this.cButton16.Size = new System.Drawing.Size(64, 64);
            this.cButton16.TabIndex = 22;
            this.cButton16.Text = "*";
            this.cButton16.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton16.UseVisualStyleBackColor = false;
            this.cButton16.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton15
            // 
            this.cButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton15.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton15.BorderColor = System.Drawing.Color.Black;
            this.cButton15.BorderRadius = 40;
            this.cButton15.BorderSize = 0;
            this.cButton15.FlatAppearance.BorderSize = 0;
            this.cButton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton15.Location = new System.Drawing.Point(291, 154);
            this.cButton15.Name = "cButton15";
            this.cButton15.Size = new System.Drawing.Size(64, 64);
            this.cButton15.TabIndex = 21;
            this.cButton15.Text = "/";
            this.cButton15.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton15.UseVisualStyleBackColor = false;
            this.cButton15.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton14
            // 
            this.cButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton14.BorderColor = System.Drawing.Color.Black;
            this.cButton14.BorderRadius = 40;
            this.cButton14.BorderSize = 0;
            this.cButton14.FlatAppearance.BorderSize = 0;
            this.cButton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton14.Location = new System.Drawing.Point(13, 474);
            this.cButton14.Name = "cButton14";
            this.cButton14.Size = new System.Drawing.Size(343, 64);
            this.cButton14.TabIndex = 20;
            this.cButton14.Text = "Result";
            this.cButton14.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton14.UseVisualStyleBackColor = false;
            this.cButton14.Click += new System.EventHandler(this.buttonresult_Click);
            // 
            // cButton13
            // 
            this.cButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton13.BorderColor = System.Drawing.Color.Black;
            this.cButton13.BorderRadius = 40;
            this.cButton13.BorderSize = 0;
            this.cButton13.FlatAppearance.BorderSize = 0;
            this.cButton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton13.Location = new System.Drawing.Point(12, 84);
            this.cButton13.Name = "cButton13";
            this.cButton13.Size = new System.Drawing.Size(343, 64);
            this.cButton13.TabIndex = 19;
            this.cButton13.Text = "Clear";
            this.cButton13.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton13.UseVisualStyleBackColor = false;
            this.cButton13.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // cButton12
            // 
            this.cButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton12.BorderColor = System.Drawing.Color.Black;
            this.cButton12.BorderRadius = 40;
            this.cButton12.BorderSize = 0;
            this.cButton12.FlatAppearance.BorderSize = 0;
            this.cButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton12.Location = new System.Drawing.Point(203, 395);
            this.cButton12.Name = "cButton12";
            this.cButton12.Size = new System.Drawing.Size(64, 64);
            this.cButton12.TabIndex = 18;
            this.cButton12.Text = ",";
            this.cButton12.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton12.UseVisualStyleBackColor = false;
            this.cButton12.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton11
            // 
            this.cButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton11.BorderColor = System.Drawing.Color.Black;
            this.cButton11.BorderRadius = 40;
            this.cButton11.BorderSize = 0;
            this.cButton11.FlatAppearance.BorderSize = 0;
            this.cButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton11.Location = new System.Drawing.Point(111, 395);
            this.cButton11.Name = "cButton11";
            this.cButton11.Size = new System.Drawing.Size(64, 64);
            this.cButton11.TabIndex = 17;
            this.cButton11.Text = "0";
            this.cButton11.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton11.UseVisualStyleBackColor = false;
            this.cButton11.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton10
            // 
            this.cButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton10.BorderColor = System.Drawing.Color.Black;
            this.cButton10.BorderRadius = 40;
            this.cButton10.BorderSize = 0;
            this.cButton10.FlatAppearance.BorderSize = 0;
            this.cButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton10.Location = new System.Drawing.Point(17, 395);
            this.cButton10.Name = "cButton10";
            this.cButton10.Size = new System.Drawing.Size(64, 64);
            this.cButton10.TabIndex = 16;
            this.cButton10.Text = "%";
            this.cButton10.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton10.UseVisualStyleBackColor = false;
            this.cButton10.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton9
            // 
            this.cButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton9.BorderColor = System.Drawing.Color.Black;
            this.cButton9.BorderRadius = 40;
            this.cButton9.BorderSize = 0;
            this.cButton9.FlatAppearance.BorderSize = 0;
            this.cButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton9.Location = new System.Drawing.Point(203, 315);
            this.cButton9.Name = "cButton9";
            this.cButton9.Size = new System.Drawing.Size(64, 64);
            this.cButton9.TabIndex = 15;
            this.cButton9.Text = "9";
            this.cButton9.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton9.UseVisualStyleBackColor = false;
            this.cButton9.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton8
            // 
            this.cButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton8.BorderColor = System.Drawing.Color.Black;
            this.cButton8.BorderRadius = 40;
            this.cButton8.BorderSize = 0;
            this.cButton8.FlatAppearance.BorderSize = 0;
            this.cButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton8.Location = new System.Drawing.Point(111, 315);
            this.cButton8.Name = "cButton8";
            this.cButton8.Size = new System.Drawing.Size(64, 64);
            this.cButton8.TabIndex = 14;
            this.cButton8.Text = "8";
            this.cButton8.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton8.UseVisualStyleBackColor = false;
            this.cButton8.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton7
            // 
            this.cButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton7.BorderColor = System.Drawing.Color.Black;
            this.cButton7.BorderRadius = 40;
            this.cButton7.BorderSize = 0;
            this.cButton7.FlatAppearance.BorderSize = 0;
            this.cButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton7.Location = new System.Drawing.Point(17, 315);
            this.cButton7.Name = "cButton7";
            this.cButton7.Size = new System.Drawing.Size(64, 64);
            this.cButton7.TabIndex = 13;
            this.cButton7.Text = "7";
            this.cButton7.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton7.UseVisualStyleBackColor = false;
            this.cButton7.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton6
            // 
            this.cButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton6.BorderColor = System.Drawing.Color.Black;
            this.cButton6.BorderRadius = 40;
            this.cButton6.BorderSize = 0;
            this.cButton6.FlatAppearance.BorderSize = 0;
            this.cButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton6.Location = new System.Drawing.Point(203, 234);
            this.cButton6.Name = "cButton6";
            this.cButton6.Size = new System.Drawing.Size(64, 64);
            this.cButton6.TabIndex = 12;
            this.cButton6.Text = "6";
            this.cButton6.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton6.UseVisualStyleBackColor = false;
            this.cButton6.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton5
            // 
            this.cButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton5.BorderColor = System.Drawing.Color.Black;
            this.cButton5.BorderRadius = 40;
            this.cButton5.BorderSize = 0;
            this.cButton5.FlatAppearance.BorderSize = 0;
            this.cButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton5.Location = new System.Drawing.Point(111, 234);
            this.cButton5.Name = "cButton5";
            this.cButton5.Size = new System.Drawing.Size(64, 64);
            this.cButton5.TabIndex = 11;
            this.cButton5.Text = "5";
            this.cButton5.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton5.UseVisualStyleBackColor = false;
            this.cButton5.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton4
            // 
            this.cButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton4.BorderColor = System.Drawing.Color.Black;
            this.cButton4.BorderRadius = 40;
            this.cButton4.BorderSize = 0;
            this.cButton4.FlatAppearance.BorderSize = 0;
            this.cButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton4.Location = new System.Drawing.Point(17, 234);
            this.cButton4.Name = "cButton4";
            this.cButton4.Size = new System.Drawing.Size(64, 64);
            this.cButton4.TabIndex = 10;
            this.cButton4.Text = "4";
            this.cButton4.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton4.UseVisualStyleBackColor = false;
            this.cButton4.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton3
            // 
            this.cButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton3.BorderColor = System.Drawing.Color.Black;
            this.cButton3.BorderRadius = 40;
            this.cButton3.BorderSize = 0;
            this.cButton3.FlatAppearance.BorderSize = 0;
            this.cButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton3.Location = new System.Drawing.Point(203, 154);
            this.cButton3.Name = "cButton3";
            this.cButton3.Size = new System.Drawing.Size(64, 64);
            this.cButton3.TabIndex = 9;
            this.cButton3.Text = "3";
            this.cButton3.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton3.UseVisualStyleBackColor = false;
            this.cButton3.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton2.BorderColor = System.Drawing.Color.Black;
            this.cButton2.BorderRadius = 40;
            this.cButton2.BorderSize = 0;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton2.Location = new System.Drawing.Point(111, 154);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(64, 64);
            this.cButton2.TabIndex = 8;
            this.cButton2.Text = "2";
            this.cButton2.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton2.UseVisualStyleBackColor = false;
            this.cButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cButton1.BorderColor = System.Drawing.Color.Black;
            this.cButton1.BorderRadius = 40;
            this.cButton1.BorderSize = 0;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.cButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cButton1.Location = new System.Drawing.Point(17, 154);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(64, 64);
            this.cButton1.TabIndex = 7;
            this.cButton1.Text = "1";
            this.cButton1.TextColor = System.Drawing.SystemColors.ControlLight;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.Color.White;
            this.cTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.cTextBox1.BorderSize = 2;
            this.cTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cTextBox1.ForeColor = System.Drawing.Color.Black;
            this.cTextBox1.Location = new System.Drawing.Point(13, 34);
            this.cTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cTextBox1.Multiline = true;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.cTextBox1.PassvordChar = false;
            this.cTextBox1.Size = new System.Drawing.Size(343, 43);
            this.cTextBox1.TabIndex = 6;
            this.cTextBox1.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 550);
            this.Controls.Add(this.cButton18);
            this.Controls.Add(this.cButton17);
            this.Controls.Add(this.cButton16);
            this.Controls.Add(this.cButton15);
            this.Controls.Add(this.cButton14);
            this.Controls.Add(this.cButton13);
            this.Controls.Add(this.cButton12);
            this.Controls.Add(this.cButton11);
            this.Controls.Add(this.cButton10);
            this.Controls.Add(this.cButton9);
            this.Controls.Add(this.cButton8);
            this.Controls.Add(this.cButton7);
            this.Controls.Add(this.cButton6);
            this.Controls.Add(this.cButton5);
            this.Controls.Add(this.cButton4);
            this.Controls.Add(this.cButton3);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.cTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Custom_Elements.CTextBox cTextBox1;
        private Custom_Elements.CButton cButton1;
        private Custom_Elements.CButton cButton2;
        private Custom_Elements.CButton cButton3;
        private Custom_Elements.CButton cButton4;
        private Custom_Elements.CButton cButton5;
        private Custom_Elements.CButton cButton6;
        private Custom_Elements.CButton cButton7;
        private Custom_Elements.CButton cButton8;
        private Custom_Elements.CButton cButton9;
        private Custom_Elements.CButton cButton10;
        private Custom_Elements.CButton cButton11;
        private Custom_Elements.CButton cButton12;
        private Custom_Elements.CButton cButton13;
        private Custom_Elements.CButton cButton14;
        private Custom_Elements.CButton cButton15;
        private Custom_Elements.CButton cButton16;
        private Custom_Elements.CButton cButton17;
        private Custom_Elements.CButton cButton18;
    }
}

