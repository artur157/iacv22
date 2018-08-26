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
    public partial class Amusement : Form
    {
        public Amusement()
        {
            InitializeComponent();

            label7.Text = "" + Data.mood;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "5";
            label6.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "8";
            label6.Text = "9";
        }

        private void Amuse(int cost, int power)
        {
            if (Data.money <= 0)
            {
                MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Data.mood > 150)
            {
                if (cost == 8)
                    MessageBox.Show("Вы уже распухли от радости", "Не хочу идти на дискотеку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Вы уже распухли от радости", "Не хочу идти на вечеринку!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= cost;
                Data.mood += power;
            }

            label7.Text = "" + Data.mood;

            // отобразить в главной форме 
            ((Form1)Owner).lMood.Text = "" + Data.mood;
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Amuse(5, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amuse(8, 9);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Text = "РАЗВЛЕЧЕНИЯ РАЗВЛЕЧЕНИЯ РАЗВЛЕЧЕНИЯ";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Здесь вы можете заработать деньги. Поиграть в игровые автоматы, поднять себе настроение и т.д.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Show();
            button6.Show();
            button7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            (new Roulette1()).ShowDialog(this);
            Show();
            label7.Text = "" + Data.mood;
            button5.Hide();
            button6.Hide();
            button7.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            (new Roulette2()).ShowDialog(this);
            Show();
            label7.Text = "" + Data.mood;
            button5.Hide();
            button6.Hide();
            button7.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            (new Arkanoid()).ShowDialog(this);
            Show();
            label7.Text = "" + Data.mood;
            button5.Hide();
            button6.Hide();
            button7.Hide();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Здесь вы можете заработать деньги и поднять себе настроение.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
