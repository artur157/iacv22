using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iacv22
{
    public partial class Form1 : Form
    {
        private DateTime time;

        public Form1()
        {
            InitializeComponent();

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            time = DateTime.Now;
            time = time.AddHours(- time.Hour);
            textBox1.Text = time.ToString("Дата: dd/MM/yy            Время: HH:00");

            UpdateDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Flat()).ShowDialog(this);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 100, 25, 100, 147);
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 100, 25, 100, 90);
            g.DrawLine(pen, 100, 110, 100, 215);
            g.DrawLine(pen, 5, 100, 220, 100);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 100, 25, 100, 125);
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 100, 25, 100, 93);
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, 100, 25, 100, 39);
        }

        private void changeHungry(int d)
        {
            Data.hungry += d;
            lHungry.Text = "" + Data.hungry;
        }

        private void changeMood(int d)
        {
            Data.mood += d;
            lMood.Text = "" + Data.mood;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddHours(1);
            textBox1.Text = time.ToString("Дата: dd/MM/yy            Время: HH:00");

            // БАНК и З/П
            if (time.Hour == 0)
            {
                Data.account += Data.account / 20;
                Data.money += Data.cost_job[Data.job];
                lMoney.Text = "" + Data.money;
            }

            // ВОПРОСЫ ЖИЗНЕДЕЯТЕЛЬНОСТИ
            if (time.Hour % 12 == 9)
            {
                changeHungry(-2);
                changeMood(-2);

                if (Data.hungry <= -30)
                {
                    MessageBox.Show("К сожалению, вы умерли от голода.", "+СМЕРТЬ+", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // сдохнуть
                    Application.Exit();
                }
                if (Data.mood <= -40)
                {
                    MessageBox.Show("К сожалению, вы умерли от тоски.", "+СМЕРТЬ+", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // сдохнуть
                    Application.Exit();
                }
                if (Data.hungry <= -22)
                {
                    MessageBox.Show("Внимание, опасность голода! Вам необходимо сходить в Бытовой магазин и поесть вдоволь. ВНИМАНИЕ: если ваше состояние сытости достигнет -30, тогда вас постигнет лютая смерть!!!", "ОПАСНОСТЬ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // напоминание
                }
                if (Data.mood <= -32)
                {
                    MessageBox.Show("Внимание, опасность! Вам необходимо развлечься. ВНИМАНИЕ: если ваше настроение достигнет -40, тогда вас постигнет лютая смерть!!!", "ОПАСНОСТЬ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // напоминание
                }
            }

            // ШКОЛА
            if (time.Hour % 12 == 2 && Data.school)
            {
                Data.money -= 3;
                lMoney.Text = "" + Data.money;
                ++Data.sch_points;

                switch (Data.sch_points)
                {
                    case 12: ++Data.education; lEducation.Text = Data.arr_education[1]; MessageBox.Show("Ваше образование теперь неполное среднее.", "Образование Неполное среднее", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 21: ++Data.education; lEducation.Text = Data.arr_education[2]; MessageBox.Show("Ваше образование теперь среднее.", "Образование Среднее", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 31: ++Data.education; lEducation.Text = Data.arr_education[3]; MessageBox.Show("Ваше образование теперь неполное высшее.", "Образование Неполное высшее", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 40: ++Data.education; lEducation.Text = Data.arr_education[4]; Data.school = false; lCourse1.Text = "Вы выучились в школе."; lCost1.Text = "0"; MessageBox.Show("Ваше образование теперь высшее.", "Образование Высшее", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                }
            }

            // АНГЛ. ЯЗ.
            if (time.Hour % 12 == 5 && Data.eng_course)
            {
                Data.money -= 4;
                lMoney.Text = "" + Data.money;
                ++Data.eng_points;

                switch (Data.eng_points)
                {
                    case 15: ++Data.english; lEnglish.Text = Data.arr_english[1]; MessageBox.Show("Вы перешли на 1 уровень.", "Английский язык (English language). Вы на 1 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 25: ++Data.english; lEnglish.Text = Data.arr_english[2]; MessageBox.Show("Вы перешли на 2 уровень.", "Английский язык (English language). Вы на 2 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 33: ++Data.english; lEnglish.Text = Data.arr_english[3]; MessageBox.Show("Вы перешли на 3 уровень.", "Английский язык (English language). Вы на 3 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 43: ++Data.english; lEnglish.Text = Data.arr_english[4]; MessageBox.Show("Вы перешли на 4 уровень.", "Английский язык (English language). Вы на 4 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 52: ++Data.english; lEnglish.Text = Data.arr_english[5]; MessageBox.Show("Вы перешли на 5 уровень.", "Английский язык (English language). Вы на 5 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 61: ++Data.english; lEnglish.Text = Data.arr_english[6]; MessageBox.Show("Вы перешли на 6 уровень.", "Английский язык (English language). Вы на 6 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 70: ++Data.english; lEnglish.Text = Data.arr_english[7]; MessageBox.Show("Вы перешли на 7 уровень.", "Английский язык (English language). Вы на 7 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 78: ++Data.english; lEnglish.Text = Data.arr_english[8]; Data.eng_course = false; lCourse2.Text = "Вы выучили англ. яз."; lCost2.Text = "0"; MessageBox.Show("Вы перешли на 8 уровень.", "Английский язык (English language). Вы на 8 Уровне", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                }
            }

            // КОМ. КУРСЫ
            if (time.Hour % 12 == 8 && Data.com_course)
            {
                Data.money -= 4;
                lMoney.Text = "" + Data.money;
                ++Data.com_points;

                switch (Data.com_points)
                {
                    case 14: ++Data.status; lStatus.Text = Data.arr_status[1]; MessageBox.Show("Ваш статус стал теперь любитель.", "Вы Любитель", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 22: ++Data.status; lStatus.Text = Data.arr_status[2]; MessageBox.Show("Ваш статус стал теперь новичок.", "Вы Новичок", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 30: ++Data.status; lStatus.Text = Data.arr_status[3]; MessageBox.Show("Ваш статус стал теперь программист.", "Вы Программист", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 42: ++Data.status; lStatus.Text = Data.arr_status[4]; MessageBox.Show("Ваш статус стал теперь почти хакер.", "Вы Почти хакер", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 51: ++Data.status; lStatus.Text = Data.arr_status[5]; MessageBox.Show("Ваш статус стал теперь хакер.", "Вы Хакер", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 60: ++Data.status; lStatus.Text = Data.arr_status[6]; MessageBox.Show("Ваш статус стал теперь администратор.", "Вы Администратор", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 69: ++Data.status; lStatus.Text = Data.arr_status[7]; MessageBox.Show("Ваш статус стал теперь профессионал.", "Вы Профессионал", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case 76: ++Data.status; lStatus.Text = Data.arr_status[8]; Data.com_course = false; lCourse3.Text = "Вы сверх программист."; lCost3.Text = "0"; MessageBox.Show("Ваш статус стал теперь сверх профессионал.", "Вы Сверх профессионал", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)  
        {
            (new Shop()).ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Amusement()).ShowDialog(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Data.hungry > -30 && Data.mood > -40){
                DialogResult result = MessageBox.Show(this, "Вы действительно хотите выйти?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = result == DialogResult.No;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // такси предлагаем
            if (Data.car == 0)
            {
                DialogResult result = MessageBox.Show(this, "Банк - это отличный способ сохранения и накопления денег. К сожалению, банк находится далеко от вашего дома и без машины вам не удастся доехать до него. Но вы можете взять такси за 10$ и доехать до банка, либо купить собственную машину в магазине.\n\nХотите ли вы взять такси за 10$ и доехать до банка?", "Требуется машина. Хотите ли вы взять такси?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Data.money >= 10) { 
                        Data.money -= 10;
                        lMoney.Text = "" + Data.money;

                        // возможна авария
                        Random rnd = new Random();
                        if (rnd.Next(1, 15) > 10)
                        {
                            MessageBox.Show("Случилось несчастье. Таксист попал в аварию, и вы сильно пострадали. На лечение пришлось потратить большие деньги: 30$.", ":-(((");
                            Data.money -= 30;
                            Data.mood -= 4;
                            lMoney.Text = "" + Data.money;
                            lMood.Text = "" + Data.mood;

                            DialogResult result2 = MessageBox.Show(this, "Ваш адвокат предлагает вам подать в суд на таксиста.\nЕсли вы выиграете на суде, то сможете получить компенсацию за ущерб.\n" +
                                "Если же вы проиграете, то, возможно, вам придется заплатить штраф за беспокойство суда.\n\nЖелаете ли вы подать в суд на таксиста?", "Суд?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result2 == DialogResult.Yes)
                            {
                                switch (rnd.Next(0, 3))
                                {
                                    case 0:
                                        MessageBox.Show("К сожалению, вы проиграли дело и вам пришлось заплатить штраф 15$ за беспокойство суда.", "Дело проиграно");
                                        Data.money -= 15;
                                        lMoney.Text = "" + Data.money;
                                        break;
                                    case 1:
                                        MessageBox.Show("Вам не удалось ничего доказать, но и таксист ничего не доказал. Вам выплатили небольшую компенсацию 10$.", "Дело не выиграно, но и не проиграно.");
                                        Data.money += 10;
                                        lMoney.Text = "" + Data.money;
                                        break;
                                    case 2:
                                        MessageBox.Show("Поздравляю! Вы выиграли дело и получаете компенсацию 25$.", "Дело выиграно");
                                        Data.money += 25;
                                        Data.mood += 9;
                                        lMoney.Text = "" + Data.money;
                                        lMood.Text = "" + Data.mood;
                                        break;
                                }
                            }
                        }

                        (new Bank()).ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("У вас нет денег на такси.", "Нет денег.");
                    }
                }
            }
            else
                (new Bank()).ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Job()).ShowDialog(this);

            if (Data.show_win)
            {
                Data.show_win = false;
                (new Win()).ShowDialog(this);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new Comp()).ShowDialog(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new Programs()).ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Education()).ShowDialog(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Data.status > 4){
                (new Hacking()).ShowDialog(this);
            }
            else{
                MessageBox.Show("Ваш статус должен быть хакер.", "Вы должны быть хакер.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            (new Internet()).ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Fishing()).ShowDialog(this);
        }

        private void timerVirus_Tick(object sender, EventArgs e)
        {
            if (Data.os > 0)
            {
                timerVirus.Stop();
                (new Virus()).ShowDialog(this);
                timerVirus.Start();
            }
        }

        private void timerBank_Tick(object sender, EventArgs e)
        {
            if (Data.account > 50)
            {
                timerBank.Stop();
                int sum = new Random().Next(Data.account / 6, Data.account / 3);
                MessageBox.Show("Компьютерная система банка, в котором вы храните деньги, сломалась. У вас со счета было снято " + sum + "$.", "Система банка сломалась");
                Data.account -= sum;
                timerBank.Start();
            }
        }

        void UpdateDisplay()
        {
            lMoney.Text = "" + Data.money;
            lStatus.Text = Data.arr_status[Data.status];
            lJob.Text = Data.arr_job[Data.job];
            lJob2.Text = Data.arr_job[Data.job];
            lSalary.Text = "" + Data.cost_job[Data.job];
            lMood.Text = "" + Data.mood;
            lHungry.Text = "" + Data.hungry;
            lEducation.Text = Data.arr_education[Data.education];
            lEnglish.Text = Data.arr_english[Data.english];

            lRooms.Text = "" + Data.rooms;
            lFurniture.Text = Data.arr_furniture[Data.furniture];
            lKitchen.Text = Data.arr_kitchen[Data.kitchen];
            lBathroom.Text = Data.arr_bathroom[Data.bathroom];
            lClothes.Text = Data.arr_clothes[Data.clothes];
            lCar.Text = Data.arr_car[Data.car];

            lMonitor.Text = Data.arr_monitor[Data.monitor];
            lPrinter.Text = Data.arr_printer[Data.printer];
            lScanner.Text = Data.arr_scanner[Data.scanner];
            lModem.Text = Data.arr_modem[Data.modem];
            lCpu.Text = Data.arr_cpu[Data.cpu];
            lHdd.Text = Data.arr_hdd[Data.hdd];
            lCdrom.Text = Data.arr_cd_rom[Data.cd_rom];
            lRam.Text = Data.arr_ram[Data.ram];
            lAudiocard.Text = Data.arr_audiocard[Data.audiocard];
            lVideocard.Text = Data.arr_videocard[Data.videocard];

            lOs.Text = Data.arr_os[Data.os];
            lProgramming.Text = Data.arr_programming[Data.programming];
            lGraphics.Text = Data.arr_graphics[Data.graphics];
            lAntivirus.Text = Data.arr_antivirus[Data.antivirus];

            lInternet.Text = Data.internet_access ? "Есть" : "Пока нет";

            lCourse1.Text = Data.school ? "Веч.школа" : "Не учусь";
            lCost1.Text = Data.school ? "6" : "0";
            lCourse2.Text = Data.eng_course ? "Курсы" : "Не учусь";
            lCost2.Text = Data.eng_course ? "8" : "0";
            lCourse3.Text = Data.com_course ? "Курсы" : "Не учусь";
            lCost3.Text = Data.com_course ? "8" : "0";
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.money = 170;
            Data.status = 0;
            Data.job = 0;
            Data.mood = 30;
            Data.hungry = 30;
            Data.education = 0;
            Data.english = 0;

            Data.sch_points = 0;
            Data.eng_points = 0;
            Data.com_points = 0;

            Data.rooms = 1;
            Data.furniture = 0;
            Data.kitchen = 0;
            Data.bathroom = 0;
            Data.clothes = 0;
            Data.car = 0;

            Data.monitor = 0;
            Data.printer = 0;
            Data.scanner = 0;
            Data.modem = 0;
            Data.cpu = 0;
            Data.hdd = 0;
            Data.cd_rom = 0;
            Data.ram = 0;
            Data.audiocard = 0;
            Data.videocard = 0;

            Data.os = 0;
            Data.programming = 0;
            Data.graphics = 0;
            Data.antivirus = 0;

            Data.ie = false;
            Data.dialer = false;
            Data.downloader = false;
            Data.internet_access = false;
            Data.anecdotes = false;

            Data.school = false;
            Data.eng_course = false;
            Data.com_course = false;

            Data.account = 0;

            Data.snasti = false;
            Data.udochka = false;
            Data.prikormka = 0;
            Data.fishes = 0;

            // теперь отображение
            UpdateDisplay();

            // таймер
            timer1.Stop();

            time = DateTime.Now;
            time = time.AddHours(-time.Hour);
            textBox1.Text = time.ToString("Дата: dd/MM/yy            Время: HH:00");

            timer1.Start();
            timerBank.Stop();
            timerVirus.Stop();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Игра \"Я и Компьютер\"\nВерсия 1.1 (22.08.2018)\n\nПрограммист: Гумеров Артур", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);              
        }

        void writeData(StreamWriter writer)
        {
            writer.WriteLine("ВНИМАНИЕ: НИЧЕГО НЕ ИЗМЕНЯЙТЕ В ЭТОМ ФАЙЛЕ. ИЗМЕНЕНИЕ ДАННОГО ФАЙЛА МОЖЕТ ПРИВЕСТИ К НЕКОРРЕКТНОЙ РАБОТЕ ПРОГРАММЫ");
            writer.WriteLine(time);

            writer.WriteLine(Data.money);
            writer.WriteLine(Data.status);
            writer.WriteLine(Data.job);
            writer.WriteLine(Data.mood); 
            writer.WriteLine(Data.hungry); 
            writer.WriteLine(Data.education);;
            writer.WriteLine(Data.english);

            writer.WriteLine(Data.sch_points); 
            writer.WriteLine(Data.eng_points);
            writer.WriteLine(Data.com_points);

            writer.WriteLine(Data.rooms);
            writer.WriteLine(Data.furniture);
            writer.WriteLine(Data.kitchen); 
            writer.WriteLine(Data.bathroom);
            writer.WriteLine(Data.clothes);
            writer.WriteLine(Data.car); 

            writer.WriteLine(Data.monitor);
            writer.WriteLine(Data.printer);
            writer.WriteLine(Data.scanner); 
            writer.WriteLine(Data.modem); 
            writer.WriteLine(Data.cpu);
            writer.WriteLine(Data.hdd);
            writer.WriteLine(Data.cd_rom);
            writer.WriteLine(Data.ram);
            writer.WriteLine(Data.audiocard);
            writer.WriteLine(Data.videocard);

            writer.WriteLine(Data.os);
            writer.WriteLine(Data.programming);
            writer.WriteLine(Data.graphics);
            writer.WriteLine(Data.antivirus);

            writer.WriteLine(Data.ie);
            writer.WriteLine(Data.dialer);
            writer.WriteLine(Data.downloader);
            writer.WriteLine(Data.internet_access);
            writer.WriteLine(Data.anecdotes);

            writer.WriteLine(Data.school);
            writer.WriteLine(Data.eng_course);
            writer.WriteLine(Data.com_course);

            writer.WriteLine(Data.account);

            writer.WriteLine(Data.snasti);
            writer.WriteLine(Data.udochka);
            writer.WriteLine(Data.prikormka);
            writer.WriteLine(Data.fishes);
        }

        void readData(StreamReader reader)
        {
            reader.ReadLine();
            time = Convert.ToDateTime(reader.ReadLine());

            Data.money = Convert.ToInt32(reader.ReadLine());
            Data.status = Convert.ToByte(reader.ReadLine());
            Data.job = Convert.ToByte(reader.ReadLine());
            Data.mood = Convert.ToInt32(reader.ReadLine());
            Data.hungry = Convert.ToInt32(reader.ReadLine());
            Data.education = Convert.ToByte(reader.ReadLine()); ;
            Data.english = Convert.ToByte(reader.ReadLine());

            Data.sch_points = Convert.ToByte(reader.ReadLine());
            Data.eng_points = Convert.ToByte(reader.ReadLine());
            Data.com_points = Convert.ToByte(reader.ReadLine());

            Data.rooms = Convert.ToByte(reader.ReadLine());
            Data.furniture = Convert.ToByte(reader.ReadLine());
            Data.kitchen = Convert.ToByte(reader.ReadLine());
            Data.bathroom = Convert.ToByte(reader.ReadLine());
            Data.clothes = Convert.ToByte(reader.ReadLine());
            Data.car = Convert.ToByte(reader.ReadLine());

            Data.monitor = Convert.ToByte(reader.ReadLine());
            Data.printer = Convert.ToByte(reader.ReadLine());
            Data.scanner = Convert.ToByte(reader.ReadLine());
            Data.modem = Convert.ToByte(reader.ReadLine());
            Data.cpu = Convert.ToByte(reader.ReadLine());
            Data.hdd = Convert.ToByte(reader.ReadLine());
            Data.cd_rom = Convert.ToByte(reader.ReadLine());
            Data.ram = Convert.ToByte(reader.ReadLine());
            Data.audiocard = Convert.ToByte(reader.ReadLine());
            Data.videocard = Convert.ToByte(reader.ReadLine());

            Data.os = Convert.ToByte(reader.ReadLine());
            Data.programming = Convert.ToByte(reader.ReadLine());
            Data.graphics = Convert.ToByte(reader.ReadLine());
            Data.antivirus = Convert.ToByte(reader.ReadLine());

            Data.ie = Convert.ToBoolean(reader.ReadLine());
            Data.dialer = Convert.ToBoolean(reader.ReadLine());
            Data.downloader = Convert.ToBoolean(reader.ReadLine());
            Data.internet_access = Convert.ToBoolean(reader.ReadLine());
            Data.anecdotes = Convert.ToBoolean(reader.ReadLine());

            Data.school = Convert.ToBoolean(reader.ReadLine());
            Data.eng_course = Convert.ToBoolean(reader.ReadLine());
            Data.com_course = Convert.ToBoolean(reader.ReadLine());

            Data.account = Convert.ToInt32(reader.ReadLine());

            Data.snasti = Convert.ToBoolean(reader.ReadLine());
            Data.udochka = Convert.ToBoolean(reader.ReadLine());
            Data.prikormka = Convert.ToInt32(reader.ReadLine());
            Data.fishes = Convert.ToInt32(reader.ReadLine());

            if (Data.account > 50)
            {
                timerBank.Start();
            }

            if (Data.os > 0)
            {
                timerVirus.Start();
            }
        }

        private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Я и компьютер (*.iac)|*.iac";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(fd.FileName, FileMode.Create, FileAccess.Write); 
                StreamWriter writer = new StreamWriter(file);
                writeData(writer);
                writer.Close(); 
            }
        }

        private void загрузитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Я и компьютер (*.iac)|*.iac";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                readData(reader);
                reader.Close();
                UpdateDisplay();
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}
