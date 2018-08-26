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
    public partial class Roulette2 : Form
    {
        byte spin = 0, win;
        int[] el;
        Random rnd = new Random();

        public Roulette2()
        {
            InitializeComponent();

            el = new int[3];

            label2.Text = "" + Data.money;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            spin = 5;
            label1.Text = "" + spin;

            Data.mood -= 4;
            Data.money -= 10;
            ((Form1)Owner.Owner).lMood.Text = "" + Data.mood;
            ((Form1)Owner.Owner).lMoney.Text = "" + Data.money;
            label2.Text = "" + Data.money;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            --spin;
            label1.Text = "" + spin;

            for (int i = 0; i < el.Length; i++)
            {
                el[i] = rnd.Next(0, 3);
            }

            pictureBox1.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("elem" + (el[0] + 1));
            pictureBox2.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("elem" + (el[1] + 1));
            pictureBox3.BackgroundImage = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("elem" + (el[2] + 1));

            win = 0;

            if (el[0] == el[1])
            {
                switch (el[2])
                {
                    case 0:
                        switch (el[0])
                        {
                            case 0: win = 20; break;
                            case 1: win = 6; break;
                            case 2: win = 5; break;
                        }
                        break;
                    case 1: 
                        switch (el[0])
                        {
                            case 0: win = 4; break;
                            case 1: win = 15; break;
                            case 2: win = 3; break;
                        }
                        break;
                    case 2: 
                        switch (el[0])
                        {
                            case 0: win = 2; break;
                            case 1: win = 1; break;
                            case 2: win = 10; break;
                        }
                        break;
                }
            }

            if (win > 0)
            {
                MessageBox.Show("Вы выиграли " + win + " $", "You WON!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Data.mood += 2;
                Data.money += win;
                ((Form1)Owner.Owner).lMood.Text = "" + Data.mood;
                ((Form1)Owner.Owner).lMoney.Text = "" + Data.money;
                label2.Text = "" + Data.money;
            }

            // критерий окончания
            if (spin <= 0)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }

        }
    }
}
