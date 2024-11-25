namespace Planning_3ITB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            radioButton3 = new RadioButton();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            colorDialog1 = new ColorDialog();
            checkedListBox1 = new CheckedListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            hScrollBar1 = new HScrollBar();
            button5 = new Button();
            label1 = new Label();
            radioButton4 = new RadioButton();
            groupBox4 = new GroupBox();
            textBox5 = new TextBox();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(53, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 174);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Posun o";
            // 
            // button1
            // 
            button1.Location = new Point(258, 132);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox2.Location = new Point(26, 79);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Y";
            textBox2.Size = new Size(257, 47);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(26, 26);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "X";
            textBox1.Size = new Size(257, 47);
            textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += CommandTypeChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 207);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += CommandTypeChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(53, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 174);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Posun na";
            // 
            // button2
            // 
            button2.Location = new Point(258, 139);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox3.Location = new Point(26, 79);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Y";
            textBox3.Size = new Size(257, 47);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox4.Location = new Point(26, 26);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "X";
            textBox4.Size = new Size(257, 47);
            textBox4.TabIndex = 2;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(30, 409);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += CommandTypeChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(53, 409);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(369, 174);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Změň barvu";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(115, 44);
            button4.Name = "button4";
            button4.Size = new Size(100, 80);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(269, 139);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(451, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(292, 884);
            checkedListBox1.TabIndex = 4;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(749, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 884);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(266, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(80, 76);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 76);
            label2.TabIndex = 0;
            label2.Text = "A";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(30, 854);
            hScrollBar1.Maximum = 1000;
            hScrollBar1.Minimum = 10;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(283, 26);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Value = 10;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // button5
            // 
            button5.Location = new Point(328, 854);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "Start";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 824);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 8;
            label1.Text = "Interval";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(24, 601);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(17, 16);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += CommandTypeChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(button7);
            groupBox4.Location = new Point(47, 601);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(369, 174);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nastav text";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox5.Location = new Point(56, 64);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Y";
            textBox5.Size = new Size(257, 47);
            textBox5.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(269, 139);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 4;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 910);
            Controls.Add(radioButton4);
            Controls.Add(groupBox4);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(hScrollBar1);
            Controls.Add(panel1);
            Controls.Add(checkedListBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(radioButton1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button4;
        private Button button3;
        private ColorDialog colorDialog1;
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private HScrollBar hScrollBar1;
        private Button button5;
        private Label label1;
        private RadioButton radioButton4;
        private GroupBox groupBox4;
        private Button button7;
        private TextBox textBox5;
        private Label label2;
    }
}
