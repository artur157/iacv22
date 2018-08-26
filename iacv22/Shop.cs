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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();

            label4.Text = "" + Data.hungry;
            label10.Text = Data.arr_car[Data.car];
            pictureBox1.Image = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("cars" + (Data.car + 1));

            if (Data.clothes >= Data.arr_clothes.Length - 1)
                button6.Enabled = false;

            if (Data.car >= Data.arr_car.Length - 1)
                button4.Enabled = false;
            else label5.Text = Data.arr_car[Data.car + 1];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "5";
            label11.Text = "5";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "00";
            label11.Text = "00";
            richTextBox1.Text = "";
            label7.Text = "";
        }

        private void Eat(int d)
        {
            if (Data.money <= 0)
            {
                MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Data.hungry > 100)
            {
                MessageBox.Show("Вы уже распухли от еды и не можете впихнуть в себя еще", "Не хочу есть!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= d;
                Data.hungry += d;
            }

            label4.Text = "" + Data.hungry;

            // отобразить в главной форме 
            ((Form1)Owner).lHungry.Text = "" + Data.hungry;
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eat(8);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "8";
            label11.Text = "8";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "6";
            label11.Text = "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eat(5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eat(6);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label7.Text = Data.arr_clothes[Data.clothes + 1];
            richTextBox1.Text = "Купить " + Data.arr_clothes_long[Data.clothes] + ".";
            label11.Text = "" + Data.cost_clothes[Data.clothes];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_clothes[Data.clothes])
            {
                MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_clothes[Data.clothes];
                Data.clothes++;
            }

            if (Data.clothes >= Data.arr_clothes.Length - 1)
                button6.Enabled = false;
            else
                button6_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lClothes.Text = Data.arr_clothes[Data.clothes];
            ((Form1)Owner).lMoney.Text = "" + Data.money;

            label1.Focus();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label11.Text = "" + Data.cost_car[Data.car];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_car[Data.car])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Поздравляю! Вы купили машину марки " + Data.arr_car[Data.car + 1] + ".", "Вы купили машину");
                Data.money -= Data.cost_car[Data.car];
                Data.car++;
                Data.mood += 5;
                label10.Text = Data.arr_car[Data.car];
                pictureBox1.Image = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("cars" + (Data.car + 1));

                // отобразить в главной форме 
                ((Form1)Owner).lCar.Text = Data.arr_car[Data.car];
                ((Form1)Owner).lMoney.Text = "" + Data.money;
                ((Form1)Owner).lMood.Text = "" + Data.mood;
            }

            if (Data.car >= Data.arr_car.Length - 1)
            {
                label5.Text = "";
                button4.Enabled = false;
            }
            else
            {
                label5.Text = Data.arr_car[Data.car + 1];
                button4_MouseEnter(sender, e);
            }

            label1.Focus();
        }
    }
}
