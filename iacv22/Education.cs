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
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();

            this.ControlBox = false;

            button1.Text = Data.school ? "Закончить ходить в школу" : "Ходить в вечернюю школу";
            button2.Text = Data.eng_course ? "Закончить ходить на курсы англ.яз." : "Ходить на курсы англ.яз.";
            button3.Text = Data.com_course ? "Закончить ходить на компьютерные курсы" : "Ходить на компьютерные курсы";

            if (Data.education == Data.arr_education.Length - 1)
            {
                button1.Text = "Вы уже выучились в школе.";
                button1.Enabled = false;
            }

            if (Data.english == Data.arr_english.Length - 1)
            {
                button2.Text = "Вы уже выучились англ.языку.";
                button2.Enabled = false;
            }

            if (Data.status == Data.arr_status.Length - 1)
            {
                button3.Text = "Вы уже выучились на ком. курсах.";
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.money <= 0 && !Data.school)
            {
                MessageBox.Show("У вас не хватает денег на обучение в школе", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            Data.school = !Data.school;
            button1.Text = Data.school ? "Закончить ходить в школу" : "Ходить в вечернюю школу";

            ((Form1)Owner).lCourse1.Text = Data.school ? "Веч.школа" : "Не учусь";
            ((Form1)Owner).lCost1.Text = Data.school ? "6" : "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.money <= 0 && !Data.eng_course)
            {
                MessageBox.Show("У вас не хватает денег на обучение англ. языку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            Data.eng_course = !Data.eng_course;
            button2.Text = Data.eng_course ? "Закончить ходить на курсы англ.яз." : "Ходить на курсы англ.яз.";

            ((Form1)Owner).lCourse2.Text = Data.eng_course ? "Курсы" : "Не учусь";
            ((Form1)Owner).lCost2.Text = Data.eng_course ? "8" : "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.money <= 0 && !Data.com_course)
            {
                MessageBox.Show("У вас не хватает денег на обучение комп. курсам", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            Data.com_course = !Data.com_course;
            button3.Text = Data.com_course ? "Закончить ходить на компьютерные курсы" : "Ходить на компьютерные курсы";

            ((Form1)Owner).lCourse3.Text = Data.com_course ? "Курсы" : "Не учусь";
            ((Form1)Owner).lCost3.Text = Data.com_course ? "8" : "0";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "00";
            label5.Text = "--------";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "6";
            label5.Text = "Вечерняя школа";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "8";
            label5.Text = "Курсы";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "8";
            label5.Text = "Ком.курсы";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Data.education == Data.arr_education.Length - 1)
            {
                button1.Text = "Вы уже выучились в школе.";
                button1.Enabled = false;
            }

            if (Data.english == Data.arr_english.Length - 1)
            {
                button2.Text = "Вы уже выучились англ.языку.";
                button2.Enabled = false;
            }

            if (Data.status == Data.arr_status.Length - 1)
            {
                button3.Text = "Вы уже выучились на ком. курсах.";
                button3.Enabled = false;
            }
        }
    }
}
