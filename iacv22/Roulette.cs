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
    public partial class Roulette1 : Form
    {
        int guess, the_guess, bet;
        Random rnd = new Random();

        public Roulette1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Нажмите на кнопку <" + button3.Text + ">", "Нажми на <" + button3.Text + ">", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length >= 2 && e.KeyChar != 8){
                e.Handled = true;
            }
            else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Это не число!", "Это не число!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text.Length >= 3 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Это не число!", "Это не число!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {

            }
            else
            {
                guess = Convert.ToInt32(textBox1.Text);
                bet = Convert.ToInt32(textBox2.Text);

                if (guess < 0 || guess > 13)
                {
                    MessageBox.Show("Необходимо вводить числа не больше 13!", "Не больше 13!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (bet > Data.money){
                    MessageBox.Show("У вас нет таких денег.", "У вас нет таких денег.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    label1.Hide();
                    button2.Enabled = false;
                    button3.Enabled = true;
                    textBox1.Text = "" + Convert.ToInt32(textBox1.Text);
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    button3.Text = "СТОП";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "СТОП")
            {
                the_guess = rnd.Next(0, 14);
                label1.Show();
                label1.Text = "" + the_guess;
                button3.Text = "OK";
            }
            else
            {
                if (guess == the_guess)
                {
                    Data.mood += 25;
                    Data.money += 3 * bet;
                    ((Form1)Owner.Owner).lMood.Text = "" + Data.mood;
                    ((Form1)Owner.Owner).lMoney.Text = "" + Data.money;
                    MessageBox.Show("Вы выиграли! У вас поднялось настроение и вы выиграли " + 3 * bet + "$", "Ура-а-а-а-а!!!");
                }
                else
                {
                    Data.mood -= 2;
                    Data.money -= bet;
                    ((Form1)Owner.Owner).lMood.Text = "" + Data.mood;
                    ((Form1)Owner.Owner).lMoney.Text = "" + Data.money;
                    MessageBox.Show("Вы проиграли и потеряли " + bet + "$", "Ой Ой Ой");
                }

                button2.Enabled = true;
                button3.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }
    }
}
