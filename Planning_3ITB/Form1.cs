using System.Diagnostics;

namespace Planning_3ITB
{
    public partial class Form1 : Form
    {
        CommandInvoker invoker = new CommandInvoker();

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            SetInterval(hScrollBar1.Value);
        }

        private void CommandTypeChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;

            groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled = groupBox4.Enabled = false;

            if (rb == radioButton1)
                groupBox1.Enabled = true;
            if (rb == radioButton2)
                groupBox2.Enabled = true;
            if (rb == radioButton3)
                groupBox3.Enabled = true;
            if (rb == radioButton4)
                groupBox4.Enabled = true;
        }

        private void AddCommand(Command cmd)
        {
            invoker.AddCommand(cmd);
            UpdateList();
        }

        private void UpdateList()
        {
            checkedListBox1.Items.Clear();
            foreach (var cmd in invoker.Queue)
            {
                checkedListBox1.Items.Add(cmd);
            }

            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, invoker.Queue.Get(i).enabled);
            }
            //MessageBox.Show(invoker.Queue.Count().ToString());
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
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var nextCmd = invoker.Queue.Get(0);
            if(nextCmd == null)
            {
                DeactivateTimer();
                return;
            }
            if (!nextCmd.enabled) // wait for enable
                return;

            bool commandInvoked = invoker.ExecuteCommand();
            if (!commandInvoked)
            {
                DeactivateTimer();
            }

            UpdateList();
        }

        private void DeactivateTimer()
        {
            timer1.Enabled = false;
            button5.Text = "Start";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button5.Text = timer1.Enabled ? "Stop" : "Start";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SetInterval(hScrollBar1.Value);
        }

        private void SetInterval(int interval)
        {
            timer1.Interval = interval;
            label1.Text = $"Interval: {interval}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddCommand(new ChangeTextCommand(panel2, textBox5.Text));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1) return;

            var index = checkedListBox1.SelectedIndex;
            invoker.Get(index).enabled = checkedListBox1.GetItemChecked(index);
            // TODO
        }
    }
}
