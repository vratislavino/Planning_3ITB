namespace Planning_3ITB
{
    public partial class Form1 : Form
    {
        CommandInvoker invoker = new CommandInvoker();

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void CommandTypeChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;

            groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled = false;

            if (rb == radioButton1)
                groupBox1.Enabled = true;
            if (rb == radioButton2)
                groupBox2.Enabled = true;
            if (rb == radioButton3)
                groupBox3.Enabled = true;
        }

        private void AddCommand(Command cmd)
        {
            invoker.AddCommand(cmd);
        }

        // MOVE BY
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int x))
            {
                if (int.TryParse(textBox2.Text, out int y))
                {
                    AddCommand(new MoveByCommand(panel2, x, y));
                }
                else
                {
                    MessageBox.Show("Invalid Y value");
                }
            }
            else
            {
                MessageBox.Show("Invalid X value");
            }
        }

        // MOVE TO
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int x))
            {
                if (int.TryParse(textBox4.Text, out int y))
                {
                    AddCommand(new MoveToCommand(panel2, x, y));
                }
                else
                {
                    MessageBox.Show("Invalid Y value");
                }
            }
            else
            {
                MessageBox.Show("Invalid X value");
            }
        }

        // CHANGE COLOR
        private void button3_Click(object sender, EventArgs e)
        {
            AddCommand(new ChangeColorCommand(panel2, button4.BackColor));
        }

        // nastavení barvy
        private void button4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
            }
        }
    }
}
