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
    public partial class Madfish : Form
    {
        int counter = 0, x1, y1, x2, y2;
        Random rnd = new Random();

        public Madfish()
        {
            InitializeComponent();
        }

        private void Madfish_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 1, 1, 1, 470);
            g.DrawLine(pen, 1, 1, 600, 1);
            g.DrawLine(pen, 600, 1, 600, 470);
            g.DrawLine(pen, 1, 470, 600, 470);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter <= 60)
            {
                button1.Hide();
                label7.Hide();
                pictureBox1.Show();
                timer1.Start();
            }
            else
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = "" + counter / 2;
            counter++;

            // определяем координаты рыб
            x1 = rnd.Next(50, 400);  // 30 70 
            x2 = rnd.Next(50, 400);
            y1 = rnd.Next(70, 350);
            y2 = rnd.Next(70, 350);

            if (counter > 60)
            {
                timer1.Stop();
                label7.Text = "Вам удалось поймать рыб: " + label4.Text + "\nУ вас улучшилось настроение на: " + label6.Text + "\nСъев пойманную рыбу, сытость у вас увеличилась на: " + label9.Text;
                button1.Text = "Поехать домой";
                label7.Show();
                button1.Show();
                pictureBox1.Hide();

                // отобр. сытость, настроение в главной форме, а также рыбы и прикормка
                if (Data.prikormka > 0)
                    --Data.prikormka;
                Data.fishes += Convert.ToInt32(label4.Text);
                Data.mood += Convert.ToInt32(label6.Text);
                Data.hungry += Convert.ToInt32(label9.Text);
                ((Form1)(Owner.Owner)).lMood.Text = "" + Data.mood;
                ((Form1)(Owner.Owner)).lHungry.Text = "" + Data.hungry;
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image1 = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("fish1");
            Image image2 = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("fish2");

            if (counter > 0 && counter <= 60)
            {
                // рисуем рыбу
                g.DrawImage(image1, x1, y1);

                // или две
                if (Data.prikormka > 0)
                    g.DrawImage(image2, x2, y2);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.X >= x1 && e.X <= x1 + 70 && e.Y >= y1 && e.Y <= y1 + 30 || e.X >= x2 && e.X <= x2 + 70 && e.Y >= y2 && e.Y <= y2 + 30 && Data.prikormka > 0)
            {
                label4.Text = "" + (Convert.ToInt32(label4.Text) + 1);

                if (Convert.ToInt32(label4.Text) % 5 == 0)
                {
                    label6.Text = "" + (Convert.ToInt32(label6.Text) + 1);
                }

                if (Convert.ToInt32(label4.Text) % 6 == 0)
                {
                    label9.Text = "" + (Convert.ToInt32(label9.Text) + 1);
                }
            }
        }
    }
}
