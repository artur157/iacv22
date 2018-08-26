using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace iacv22
{
    public partial class Flat : Form
    {
        public Flat()
        {
            InitializeComponent();

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Select(0, 0);

            if (Data.rooms >= 7)
                button1.Enabled = false;
            if (Data.furniture >= Data.arr_furniture.Length - 1)
                button2.Enabled = false;
            if (Data.kitchen >= Data.arr_kitchen.Length - 1)
                button3.Enabled = false;
            if (Data.bathroom >= Data.arr_bathroom.Length - 1)
                button4.Enabled = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + (Data.cost_flat[Data.rooms - 1]);
            label5.Text = "" + (Data.rooms + 1);

            richTextBox1.Text = "Купить квартиру с \"" + (Data.rooms + 1) + "\" комнатами.";
            pictureBox2.BackgroundImage= (Image)iacv22.Properties.Resources.ResourceManager.GetObject("flat1");
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            label1.Focus();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "0";
            label5.Text = "--------";

            richTextBox1.Text = "Покупайте и обустраивайте вашу квартиру";
            pictureBox2.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("flat0");
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            //richTextBox1.SelectionLength = 0;
            label1.Focus();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_furniture[Data.furniture];
            label5.Text = Data.arr_furniture[Data.furniture + 1];

            richTextBox1.Text = Data.arr_furniture[Data.furniture + 1] + " мебель. Купить.";
            pictureBox2.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("flat2");
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            label1.Focus();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_kitchen[Data.kitchen];
            label5.Text = Data.arr_kitchen[Data.kitchen + 1];

            richTextBox1.Text = Data.arr_kitchen[Data.kitchen + 1] + " кухня. Купить.";
            pictureBox2.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("flat3");
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            label1.Focus();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_bathroom[Data.bathroom];
            label5.Text = Data.arr_bathroom[Data.bathroom + 1];

            richTextBox1.Text = Data.arr_bathroom[Data.bathroom + 1] + ". Купить.";
            pictureBox2.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("flat4");
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            label1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_flat[Data.rooms - 1])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_flat[Data.rooms - 1];
                Data.rooms++;
                Data.mood += 6;
                Data.hungry += 3;

                // отобразить в главной форме 
                ((Form1)Owner).lRooms.Text = "" + Data.rooms;
                ((Form1)Owner).lMoney.Text = "" + Data.money;
                ((Form1)Owner).lMood.Text = "" + Data.mood;
                ((Form1)Owner).lHungry.Text = "" + Data.hungry;
            }

            if (Data.rooms >= 7)
                button1.Enabled = false;
            else
                button1_MouseEnter(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_furniture[Data.furniture])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_furniture[Data.furniture];
                Data.furniture++;

                // отобразить в главной форме 
                ((Form1)Owner).lFurniture.Text = Data.arr_furniture[Data.furniture];
                ((Form1)Owner).lMoney.Text = "" + Data.money;
            }

            if (Data.furniture >= Data.arr_furniture.Length - 1)
                button2.Enabled = false;
            else
                button2_MouseEnter(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_kitchen[Data.kitchen])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_kitchen[Data.kitchen];
                Data.kitchen++;
                Data.hungry += 4;

                // отобразить в главной форме 
                ((Form1)Owner).lKitchen.Text = Data.arr_kitchen[Data.kitchen];
                ((Form1)Owner).lMoney.Text = "" + Data.money;
                ((Form1)Owner).lHungry.Text = "" + Data.hungry;
            }

            if (Data.kitchen >= Data.arr_kitchen.Length - 1)
                button3.Enabled = false;
            else
                button3_MouseEnter(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_bathroom[Data.bathroom])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_bathroom[Data.bathroom];
                Data.bathroom++;

                // отобразить в главной форме 
                ((Form1)Owner).lBathroom.Text = Data.arr_bathroom[Data.bathroom];
                ((Form1)Owner).lMoney.Text = "" + Data.money;
            }

            if (Data.bathroom >= Data.arr_bathroom.Length - 1)
                button4.Enabled = false;
            else
                button4_MouseEnter(sender, e);
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}
