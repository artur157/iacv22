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
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();

            if (Data.job == 0)
                label19.Text = "безработный";
            else
                label19.Text = Data.arr_job[Data.job];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Эта работа очень проста. Вам просто необходимо таскать всякие тяжелые ящики.";
            label15.Visible = false;
        }

        void changeJob()
        {
            label19.Text = Data.arr_job[Data.job];
            ((Form1)Owner).lJob.Text = Data.arr_job[Data.job];
            ((Form1)Owner).lJob2.Text = Data.arr_job[Data.job];
            ((Form1)Owner).lSalary.Text = "" + Data.cost_job[Data.job];

            string prof = ("" + Data.arr_job[Data.job][0]).ToLower() + Data.arr_job[Data.job].Substring(1);
            MessageBox.Show("Вы теперь " + prof + ". Ваша зарплата " + Data.cost_job[Data.job] + " $. ", "Вы " + prof + ".");

            if (Data.job == Data.arr_job.Length - 1)
            {
                Data.show_win = true;
                this.Close();
            }
        }

        bool canWork(int job)
        {
            switch (job)
            {
                case 1: return true; 
                case 2: return Data.education > 0 && Data.bathroom > 0 && Data.clothes > 0;
                case 3: return Data.education > 0 && Data.status > 0 && Data.english > 0 && Data.clothes > 0 && Data.rooms > 1 && Data.furniture > 0 && Data.programming > 0;
                case 4: return Data.education > 1 && Data.status > 1 && Data.english > 1 && Data.clothes > 1 && Data.rooms > 2 && Data.kitchen > 0 && Data.programming > 1 && Data.car > 0 && Data.fishes >= 20;
                case 5: return Data.education > 1 && Data.status > 2 && Data.english > 2 && Data.clothes > 2 && Data.furniture > 1 && Data.bathroom > 1 && Data.programming > 1 && Data.graphics > 0 && Data.modem > 0;
                case 6: return Data.education > 2 && Data.status > 2 && Data.english > 3 && Data.clothes > 3 && Data.rooms > 3 && Data.programming > 2 && Data.graphics > 1 && Data.modem > 1 && Data.internet_access && Data.car > 1;
                case 7: return Data.education > 2 && Data.status > 2 && Data.english > 4 && Data.clothes > 3 && Data.furniture > 2 && Data.kitchen > 1 && Data.programming > 2 && Data.graphics > 1 && Data.modem > 2 && Data.internet_access && Data.car > 1 && Data.scanner > 0 && Data.anecdotes;
                case 8: return Data.education > 3 && Data.status > 4 && Data.english > 5 && Data.clothes > 5 && Data.rooms > 4 && Data.furniture > 3 && Data.bathroom > 2 && Data.programming > 2 && Data.modem > 2 && Data.internet_access && Data.car > 2 && Data.fishes >= 40;
                case 9: return Data.education > 3 && Data.status > 5 && Data.english > 6 && Data.clothes > 6 && Data.rooms > 5 && Data.furniture > 4 && Data.kitchen > 2 && Data.graphics > 2 && Data.scanner > 1 && Data.car > 3;
                case 10: return Data.education > 3 && Data.status > 7 && Data.english > 7 && Data.clothes > 7 && Data.rooms > 6 && Data.furniture > 5 && Data.kitchen > 3 && Data.bathroom > 3 && Data.programming > 3 && Data.graphics > 3 && Data.modem > 2 && Data.internet_access && Data.car > 4 && Data.fishes >= 70;  
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.job = 1;
            changeJob();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Здесь вы должны просто напросто перевозить людей.";
            label15.Visible = !canWork(2);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Вам нужно будет сажать цветочки и т.д..";
            label15.Visible = !canWork(3);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Эта работа более серьезная, чем остальные.";
            label15.Visible = !canWork(4);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "На этой работе вы будете составлять программы для различных фирм.";
            label15.Visible = !canWork(5);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Здесь вам необходимо работать с интернетом.";
            label15.Visible = !canWork(6);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Создавайте стильные информативные сайты.";
            label15.Visible = !canWork(7);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Здесь ваши хакерские задания усложнятся.";
            label15.Visible = !canWork(8);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Вы будете создавать текстуры, 3D объекты и остальную графику.";
            label15.Visible = !canWork(9);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = "Это самая замечательная работа. Вы сможете командовать всеми компьютерными фирмами.";
            label15.Visible = !canWork(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (canWork(2))
            {
                Data.job = 2;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать таксистом.\n\nУ вас должно быть как минимум:\nобразование неполное среднее,\nодежда спорт. костюм,\nванная: Ведро.","Вы не таксист.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (canWork(3))
            {
                Data.job = 3;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать садовником.\n\nУ вас должно быть как минимум:\nобразование неполное среднее,\nстатус любитель,\nангл.яз. 1 уровень,\nодежда спорт. костюм,\nколичество комнат в квартире 2,\nПодержанная мебель,\nпрог-ование Basic.", "Вы не садовник.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (canWork(4))
            {
                Data.job = 4;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать начинающим программистом.\n\nУ вас должно быть как минимум:\nобразование среднее,\nстатус новичок,\nангл.яз. 2 уровень,\nодежда летняя,\nколичество комнат в квартире 3,\nМаленькая кухня,\nпрог-ование Pascal,\nмашина марки Пятерка 2105,\nобщее кол-во пойманной вами рыбы должно быть не менее 20.", "Вы не начинающий программист.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (canWork(5))
            {
                Data.job = 5;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать программистом.\n\nУ вас должно быть как минимум:\nобразование среднее,\nстатус программист,\nангл.яз. 3 уровень,\nодежда джинсы,\nДачная мебель,\nванная: Стандартная,\nпрог-ование Pascal,\nграф. редактор Corel Xara,\nмодем 36.6.", "Вы не программист.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (canWork(6))
            {
                Data.job = 6;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать провайдером.\n\nУ вас должно быть как минимум:\nобразование неполное высшее,\nстатус программист,\nангл.яз. 4 уровень,\nодежда костюм,\nколичество комнат в квартире 4,\nпрог-ование Visual Basic,\nграф. редактор Photoshop,\nмодем 56K,\nвыход в интернет,\nмашина марки Девятка 21093.", "Вы не провайдер.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (canWork(7))
            {
                Data.job = 7;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать вебмастером.\n\nУ вас должно быть как минимум:\nобразование неполное высшее,\nстатус программист,\nангл.яз. 5 уровень,\nодежда костюм,\nДСП мебель,\nОборудованная кухня,\nпрог-ование Visual Basic,\nграф. редактор Photoshop,\nмодем V90,\nвыход в интернет,\nсканер ручной,\nмашина марки Девятка 21093,\nа так же вы должны скачать в интрнете (на сайте Анекдотов) базу анекдотов, т.к. вы будете мастерить развлекательный сайт.", "Вы не вебмастер.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (canWork(8))
            {
                Data.job = 8;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать хакером.\n\nУ вас должно быть как минимум:\nобразование высшее,\nстатус хакер,\nангл.яз. 6 уровень,\nодежда рубашка,\nколичество комнат в квартире 5,\nЛаминированная мебель,\nванная: Джакузи,\nпрог-ование Visual Basic,\nмодем V90,\nвыход в интернет,\nмашина марки Десятка 2110,\nобщее кол-во пойманной вами рыбы должно быть не меньше 40.", "Вы не хакер.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (canWork(9))
            {
                Data.job = 9;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать граф.диз.\n\nУ вас должно быть как минимум:\nобразование высшее,\nстатус администратор,\nангл.яз. 7 уровень,\nодежда футболка и т.д.,\nколичество комнат в квартире 6,\nОфисная мебель,\nКомфортная кухня,\nграф. редактор 3D Studio Max II,\nсканер планшетный,\nвыход в интернет,\nмашина марки Волга 3110.", "Вы не граф. диз..");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (canWork(10))
            {
                Data.job = 10;
                changeJob();
            }
            else
            {
                MessageBox.Show("Вы не можете работать ком.през.\n\nУ вас должно быть как минимум:\nобразование высшее,\nстатус сверх профессионал,\nангл.яз. 8 уровень,\nодежда посл. моды,\nколичество комнат в квартире 7,\nпрог-ование Visual C++,\nмодем V90,\nвыход в интернет,\nграф. редактор 3D Studio Max III,\nЭлитная мебель,\nСверхкомфортная кухня,\nванная: Бассейн,\nмашина марки Mercedes,\nобщее кол-во пойманной вами рыбы должно быть не меньше 70.", "Вы не ком.през.");
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}
