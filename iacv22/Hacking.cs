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
    public partial class Hacking : Form
    {
        int index, percent, the_percent;
        Random rnd = new Random();

        public Hacking()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!label2.Visible)
            { 
                // надо выдать задание
                index = rnd.Next(0, Data.arr_hacking.Length);
                label1.Text = Data.arr_hacking[index];

                button1.Text = "Отказаться";
                button2.Show();
                button2.Enabled = true;
                label2.Show();
                button3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Жаль, что вы не взялись за выполнение этого задания.", "Задание не выполнено, по причине отказа.");
                label1.Text = "Задания нет ...";
                button1.Text = "Получить задание";
                button2.Hide();
                label2.Hide();
                button3.Enabled = true;
                Data.money -= 5;
                ((Form1)Owner).lMoney.Text = "" + Data.money;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            percent = 0;
            the_percent = rnd.Next(5, 100 * 3 * (Data.status - 2) / (index / 2 + 1));  // решаем, успех это будет или неудача - в зав от сложности и статуса // если неудача, то на каком проценте вырубаемся
            timer1.Interval = rnd.Next(20, 50);    // решаем, скорость от 2 сек до 5   // (int)(150 + (8-index)*12.5 + (Data.status - 5)*50)
            timer1.Start();
            label3.Show();
            progressBar1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++percent;
            progressBar1.Value = percent;
            label3.Text = ":: Выполнение ( " + percent + "%) ::";

            if (percent >= the_percent)
            {
                // неудачное завершение
                timer1.Stop();
                MessageBox.Show("Boom! Задание провалено.\nПришлось заплатить штраф в размере " + (index + 1), "Booooom!!!");
                label3.Hide();
                progressBar1.Hide();
                button1.Enabled = true;

                label1.Text = "Задания нет ...";
                button1.Text = "Получить задание";
                button2.Hide();
                button2.Enabled = true;
                label2.Hide();
                button3.Enabled = true;
                Data.money -= index + 1;
                ((Form1)Owner).lMoney.Text = "" + Data.money;

                progressBar1.Value = 0;
            }

            if (percent >= 100)
            {
                // удачное завершение
                timer1.Stop();
                label3.Hide();
                progressBar1.Hide();
                button1.Enabled = true;

                label1.Text = "Задания нет ...";
                button1.Text = "Получить задание";
                button2.Hide();
                button2.Enabled = true;
                label2.Hide();
                button3.Enabled = true;
                MessageBox.Show("Ура! Задание выполнено. Вы получаете " + (index + 4) + "$.", "Задание выполнено.");
                Data.money += index + 4;
                ((Form1)Owner).lMoney.Text = "" + Data.money;
                ++Data.mood;
                ++Data.hungry;
                ((Form1)Owner).lMood.Text = "" + Data.mood;
                ((Form1)Owner).lHungry.Text = "" + Data.hungry;

                progressBar1.Value = 0;
            }
        }
    }
}
