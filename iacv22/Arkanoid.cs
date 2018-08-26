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
    public partial class Arkanoid : Form
    {
        byte direction;
        int x1, x2 = 0, y1, y2 = 0, step_x = 7, step_y = 7;
        float special_width = 72;
        Image image_racket, image_ball;
        Graphics g;

        public Arkanoid()
        {
            InitializeComponent();

            KeyPreview = true;

            x1 = panel1.Width / 2 - 45;
            y1 = panel1.Height - 30;

            image_racket = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid1");
            image_ball = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid11");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;

            timer1.Start();   // мячик поехал
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            image_racket = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid1");
            panel1.Invalidate();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            image_racket = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid2");
            panel1.Invalidate();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            image_racket = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid3");
            panel1.Invalidate();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            image_ball = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid11");
            panel1.Invalidate();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            image_ball = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid22");
            panel1.Invalidate();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            image_ball = (Image)iacv22.Properties.Resources.ResourceManager.GetObject("arkanoid33");
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.DrawImageUnscaledAndClipped(image_racket, new Rectangle(x1, y1, (int)special_width, image_ball.Height));   // ракетка
            g.DrawImage(image_ball, x2, y2);     // мяч
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            direction = 0;
            timer2.Start();
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (direction == 0 && x1 > 4)
            {
                x1 -= 10;
                panel1.Invalidate();
            }

            if (direction == 1 && x1 < panel1.Width - special_width - 7)  
            {
                x1 += 10;
                panel1.Invalidate();
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            direction = 1;
            timer2.Start();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    if (x1 > 4)
                    {
                        x1 -= 10;
                        panel1.Invalidate();
                    };
                    break;
                case Keys.Right:
                    if (x1 < panel1.Width - special_width - 7)
                    {
                        x1 += 10;
                        panel1.Invalidate();
                    }
                    break;
            }
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: e.IsInputKey = true; break;
                case Keys.Right: e.IsInputKey = true; break;
            }
        }

        bool otskok()   // 19 72
        {
            return x2 >= x1 - 5 && x2 + 19 <= x1 + special_width + 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x2 += step_x;
            y2 += step_y;
            special_width -= 0.2F;

            if (special_width <= 18)
            {
                timer1.Stop();

                DialogResult result = MessageBox.Show(this, "Ура-а-а вы выиграли! Хотите начать снова?", "Вы выиграли.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Data.mood += 20;
                Data.money += 35;
                ((Form1)Owner.Owner).lMood.Text = "" + Data.mood;
                ((Form1)Owner.Owner).lMoney.Text = "" + Data.money;

                x2 = 1;
                y2 = 1;
                step_x = 7;
                step_y = 7;
                special_width = 72;

                if (result == DialogResult.Yes)
                {
                    timer1.Start();
                }
                else
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    radioButton5.Enabled = true;
                    radioButton6.Enabled = true;
                    radioButton7.Enabled = true;
                    radioButton8.Enabled = true;
                }
            }

            if (step_x > 0 && x2 > panel1.Width - 30)
            {
                step_x *= -1;
            }

            if (step_x < 0 && x2 < 10)
            {
                step_x *= -1;
            }

            if (step_y > 0 && y2 > panel1.Height - 55)
            {
                if (y2 <= panel1.Height - 40 )
                {
                    if (otskok())
                        step_y *= -1;
                }
                else if (y2 > panel1.Height - 20) // всё плохо
                {
                    timer1.Stop();

                    DialogResult result = MessageBox.Show(this, "К сожалению вы проиграли. Хотите начать снова?", "Вы проиграли.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    Data.mood -= 8;
                    Data.money -= 20;
                    ((Form1)Owner.Owner).lMood.Text = "" + Data.mood;
                    ((Form1)Owner.Owner).lMoney.Text = "" + Data.money;

                    x2 = 1;
                    y2 = 1;
                    step_x = 7;
                    step_y = 7;
                    special_width = 72;

                    if (result == DialogResult.Yes)
                    {
                        timer1.Start();
                    }
                    else
                    {
                        button1.Enabled = true;
                        button2.Enabled = true;
                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                        radioButton3.Enabled = true;
                        radioButton4.Enabled = true;
                        radioButton5.Enabled = true;
                        radioButton6.Enabled = true;
                        radioButton7.Enabled = true;
                        radioButton8.Enabled = true;
                    }
                }
            }

            if (step_y < 0 && y2 < 10)
            {
                step_y *= -1;
            }

            panel1.Invalidate();
        }
    }
}
