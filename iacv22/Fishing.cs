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
    public partial class Fishing : Form
    {
        public Fishing()
        {
            InitializeComponent();

            button4.Enabled = !Data.udochka;
            button5.Enabled = !Data.snasti;
            label1.Text = "" + Data.prikormka;
            label2.Text = "" + Data.fishes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.udochka && Data.snasti)
            {
                if (Data.car == 0)
                {
                    DialogResult result = MessageBox.Show("До озера \"MAD FISH\" пешком не дойдешь. Без машины вам не удастся до него. Но вы можете сесть на автобус, заплатив за билет 10$ и доехать до озера, либо купить собственную машину в магазине. Хотите ли вы поехать на автобусе?",
                                                          "Требуется машина. Хотите ли вы поехать на автобусе?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (Data.money >= 10)
                        {
                            Data.money -= 10;
                            ((Form1)(Owner)).lMoney.Text = "" + Data.money;
                            Hide();
                            (new Madfish()).ShowDialog(this);
                            label1.Text = "" + Data.prikormka;
                            label2.Text = "" + Data.fishes;
                            Show();
                        }
                        else
                        {
                            MessageBox.Show("У вас нет денег на билет.", "Нет денег.");
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show(this, "Чтобы доехать до озера вам требуется бензин.\n\nХотите ли вы купить бензин (его цена 5$)?", 
                                                                "Требуется бензин. Хотите ли вы купить бензин?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (Data.money >= 5)
                        {
                            Data.money -= 5;
                            ((Form1)(Owner)).lMoney.Text = "" + Data.money;
                            Hide();
                            (new Madfish()).ShowDialog(this);
                            label1.Text = "" + Data.prikormka;
                            label2.Text = "" + Data.fishes;
                            Show();
                        }
                        else
                        {
                            MessageBox.Show("У вас нет денег на бензин.", "Нет денег.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не готовы к рыбалке. Проверьте, есть ли у вас удочка и снасти.", "Не готовы.");
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "Прикормка даст вам возможность приманить и соответственно поймать больше рыбы. Вы можете не покупать прикормку, но тогда рыбы будет меньше. Для одной поездки на озеро достаточно одного покета прикормки, но вы можете купить больше пакетов и оставить их про запас.";
            label4.Text = "6";
            pictureBox1.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("fishing1");
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "Без снастей вы не сможете ловить. Сейчас у вас нет снастей и вам надо их купить.";
            label4.Text = "20";
            pictureBox1.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("fishing3");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "Без удочки вы не сможете ловить. Сейчас у вас нет удочки и вам надо ее купить.";
            label4.Text = "30";
            pictureBox1.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("fishing2");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "Рыбалка - это отличный способ поднять себе настроение, утолить голод (рыбою, которую вы поймали и просто хорошо и весело отдохнуть. Рыбачьте и вы не пожалеете.";
            label4.Text = "00";
            pictureBox1.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("fishing0");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "Озеро \"MAD FISH\" славится своей неописуемой красотой и своими рыбами.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.money >= 30)
            {
                MessageBox.Show("Поздравляю! Вы купили удочку.", "Вы купили удочку");
                Data.money -= 30;
                ((Form1)(Owner)).lMoney.Text = "" + Data.money;
                Data.udochka = true;
                button4.Enabled = false;
            }
            else
            {
                MessageBox.Show("У вас нет денег на удочку.", "Нет денег.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.money >= 6)
            {
                MessageBox.Show("Вы купили пакет прикормки.", "Вы купили пакет прикормки");
                Data.money -= 6;
                ((Form1)(Owner)).lMoney.Text = "" + Data.money;
                ++Data.prikormka;
                label1.Text = "" + Data.prikormka;
            }
            else
            {
                MessageBox.Show("У вас нет денег на прикормку.", "Нет денег.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Data.money >= 20)
            {
                MessageBox.Show("Поздравляю! Вы купили снасти.", "Вы купили снасти");
                Data.money -= 20;
                ((Form1)(Owner)).lMoney.Text = "" + Data.money;
                Data.snasti = true;
                button5.Enabled = false;
            }
            else
            {
                MessageBox.Show("У вас нет денег на снасти.", "Нет денег.");
            }
        }
    }
}
