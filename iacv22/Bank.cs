using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iacv22
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();

            textBox3.Text = "" + Data.account;
            textBox4.Text = "" + (Data.account / 20);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                button1.Enabled = !(textBox1.Text.Length <= 1 && e.KeyChar == 8);
                return;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Это не число!", "Это не число!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                button2.Enabled = !(textBox2.Text.Length <= 1 && e.KeyChar == 8);
                return;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Это не число!", "Это не число!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox1.Text);
            if (sum > Data.money){
                MessageBox.Show("У вас нет таких денег!","Денег нету.");
            }
            else
            {
                Data.account += sum;
                Data.money -= sum;

                textBox3.Text = "" + Data.account;
                textBox4.Text = "" + (Data.account / 20);
                ((Form1)Owner).lMoney.Text = "" + Data.money;

                textBox1.Text = "";
                button1.Enabled = false;

                if (Data.account - sum < 50 && Data.account > 50)
                {
                    ((Form1)Owner).timerBank.Start();
                }
            }

            label1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox2.Text);
            if (sum > Data.account)
            {
                MessageBox.Show("У вас нет таких денег на счету!", "Денег нету.");
            }
            else
            {
                Data.account -= sum;
                Data.money += sum;

                textBox3.Text = "" + Data.account;
                textBox4.Text = "" + (Data.account / 20);
                label1.Focus();
                ((Form1)Owner).lMoney.Text = "" + Data.money;

                textBox2.Text = "";
                button2.Enabled = false;

                if (Data.account + sum > 50 && Data.account < 50)
                {
                    ((Form1)Owner).timerBank.Stop();
                }
            }

            label1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = "" + Data.account;
            textBox4.Text = "" + (Data.account / 20);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
