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
    public partial class Programs : Form
    {
        public Programs()
        {
            InitializeComponent();

            // ОС
            if (Data.os > 0)
            {
                label2.Text = Data.arr_os[Data.os];
                button1.Enabled = false;
                if (Data.os > 1)
                {
                    button2.Enabled = false;
                    if (Data.os > 2)
                    {
                        button3.Enabled = false;
                        if (Data.os > 3)
                        {
                            button4.Enabled = false;
                            if (Data.os > 4)
                            {
                                button5.Enabled = false;
                            }
                        }
                    }
                }
            }
              
            // Прогр
            if (Data.programming > 0)
            {
                label3.Text = Data.arr_programming[Data.programming];
                button10.Enabled = false;
                if (Data.programming > 1)
                {
                    button9.Enabled = false;
                    if (Data.programming > 2)
                    {
                        button8.Enabled = false;
                        if (Data.programming > 3)
                        {
                            button7.Enabled = false;
                        }
                    }
                }
            }

            // Граф. ред.
            if (Data.graphics > 0)
            {
                label5.Text = Data.arr_graphics[Data.graphics];
                button13.Enabled = false;
                if (Data.graphics > 1)
                {
                    button12.Enabled = false;
                    if (Data.graphics > 2)
                    {
                        button11.Enabled = false;
                        if (Data.graphics > 3)
                        {
                            button6.Enabled = false;
                        }
                    }
                }
            }

            // Антивирус
            if (Data.antivirus > 0)
            {
                button20.Enabled = true;
                button19.Enabled = false;
                if (Data.antivirus > 1)
                {
                    button18.Enabled = false;
                }
            }

            // Браузер, звонилка, закачка
            button17.Enabled = !Data.ie;
            button16.Enabled = !Data.dialer;
            button15.Enabled = !Data.downloader;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_os[0];
            label7.Text = Data.arr_os[1];

            richTextBox1.Text = "Минимальные системные требования:\nпроцессор Intel 486; монитор 14\"; винчестер 10 Gb; CD-ROM 16xSpeed; RAM 32Mb; видео карта 8Mb S3 Savage 4.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = "0";
            label7.Text = "--------";

            richTextBox1.Text = "";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_os[1];
            label7.Text = Data.arr_os[2];

            richTextBox1.Text = "Минимальные системные требования:\nпроцессор Pentium 166; монитор 14\"; винчестер 20 Gb; CD-ROM 32xSpeed; RAM 64Mb; видео карта 8Mb S3 Savage 4; звуковая карта 16 KHZ; принтер матричный.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_os[2];
            label7.Text = Data.arr_os[3];

            richTextBox1.Text = "Минимальные системные требования:\nпроцессор Pentium 233 MMX; монитор 14\"; винчестер 30 Gb; CD-ROM 40xSpeed; RAM 128Mb; видео карта 8Mb S3 Savage 4; звуковая карта 16 KHZ; принтер матричный.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_os[3];
            label7.Text = Data.arr_os[4];

            richTextBox1.Text = "Минимальные системные требования:\nпроцессор Pentium II 650; монитор 14\"; винчестер 40 Gb; CD-ROM 48xSpeed; RAM 256Mb; видео карта 16Mb RivaTNT; звуковая карта 22 KHZ; принтер матричный.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_os[4];
            label7.Text = Data.arr_os[5];

            richTextBox1.Text = "Минимальные системные требования:\nпроцессор Pentium III 800; монитор 15\"; винчестер 50 Gb; CD-ROM 56xSpeed; RAM 512Mb; видео карта 32Mb Geforce2; звуковая карта 44 KHZ; принтер струйный.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_programming[0];
            label7.Text = Data.arr_programming[1];

            richTextBox1.Text = "Минимальные системные требования:\nNC.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_programming[1];
            label7.Text = Data.arr_programming[2];

            richTextBox1.Text = "Минимальные системные требования:\nNC; процессор Pentium 166; винчестер 20 Gb.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_programming[2];
            label7.Text = Data.arr_programming[3];

            richTextBox1.Text = "Минимальные системные требования:\nW95; видео карта 16Mb RivaTNT.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_programming[3];
            label7.Text = Data.arr_programming[4];

            richTextBox1.Text = "Минимальные системные требования:\nW95; RAM 256Mb; видео карта 16Mb RivaTNT.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_graphics[0];
            label7.Text = Data.arr_graphics[1];

            richTextBox1.Text = "Минимальные системные требования:\nсистема W3.11.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_graphics[1];
            label7.Text = Data.arr_graphics[2];

            richTextBox1.Text = "Минимальные системные требования:\nсистема W95; видео карта 16Mb RivaTNT.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_graphics[2];
            label7.Text = Data.arr_graphics[3];

            richTextBox1.Text = "Минимальные системные требования:\nсистема W98; монитор 15\"; винчестер 50Gb; видео карта 32Mb Geforce2; принтер струйный.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_graphics[3];
            label7.Text = Data.arr_graphics[4];

            richTextBox1.Text = "Минимальные системные требования:\nсистема W2000; процессор Pentium IV 1700; монитор 17\"; винчестер 60Gb; видео карта 64Mb Geforce2 MX; принтер лазерный.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_antivirus[0];
            label7.Text = Data.arr_antivirus[1];

            richTextBox1.Text = "Минимальные системные требования:\nсистема Windows 95.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "" + Data.cost_antivirus[1];
            label7.Text = Data.arr_antivirus[2];

            richTextBox1.Text = "Минимальные системные требования:\nсистема Windows 2000.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "15";
            label7.Text = "Браузер";

            richTextBox1.Text = "Минимальные системные требования:\nсистема Windows 95.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "5";
            label7.Text = "Звонилка";

            richTextBox1.Text = "Минимальные системные требования:\nсистема Windows 95.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "7";
            label7.Text = "Закачка";

            richTextBox1.Text = "Минимальные системные требования:\nсистема Windows 95.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.cpu > 0 && Data.monitor > 0 && Data.hdd > 0 && Data.cd_rom > 0 && Data.ram > 0 && Data.videocard > 0){
                if (Data.money < Data.cost_os[0])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_os[0];
                    Data.os = 1;

                    button1.Enabled = false;

                    label2.Text = Data.arr_os[1];

                    // отобразить в главной форме 
                    ((Form1)Owner).lOs.Text = Data.arr_os[1];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    ((Form1)Owner).timerVirus.Start();

                    MessageBox.Show("Вы установили Norton Commander", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else{
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.cpu > 1 && Data.monitor > 0 && Data.hdd > 1 && Data.cd_rom > 1 && Data.ram > 1 && Data.videocard > 0 && Data.audiocard > 0 && Data.printer > 0)
            {
                if (Data.money < Data.cost_os[1])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_os[1];
                    Data.os = 2;

                    button1.Enabled = false;
                    button2.Enabled = false;

                    label2.Text = Data.arr_os[2];

                    // отобразить в главной форме 
                    ((Form1)Owner).lOs.Text = Data.arr_os[2];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    ((Form1)Owner).timerVirus.Start();

                    MessageBox.Show("Вы установили Windows 3.11", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.cpu > 2 && Data.monitor > 0 && Data.hdd > 2 && Data.cd_rom > 2 && Data.ram > 2 && Data.videocard > 0 && Data.audiocard > 0 && Data.printer > 0)
            {
                if (Data.money < Data.cost_os[2])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_os[2];
                    Data.os = 3;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;

                    label2.Text = Data.arr_os[3];

                    // отобразить в главной форме 
                    ((Form1)Owner).lOs.Text = Data.arr_os[3];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    ((Form1)Owner).timerVirus.Start();

                    MessageBox.Show("Вы установили Windows 95", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.cpu > 3 && Data.monitor > 0 && Data.hdd > 3 && Data.cd_rom > 3 && Data.ram > 3 && Data.videocard > 1 && Data.audiocard > 1 && Data.printer > 0)
            {
                if (Data.money < Data.cost_os[3])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_os[3];
                    Data.os = 4;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;

                    label2.Text = Data.arr_os[4];

                    // отобразить в главной форме 
                    ((Form1)Owner).lOs.Text = Data.arr_os[4];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    ((Form1)Owner).timerVirus.Start();

                    MessageBox.Show("Вы установили Windows 98", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Data.cpu > 4 && Data.monitor > 1 && Data.hdd > 4 && Data.cd_rom > 4 && Data.ram > 4 && Data.videocard > 2 && Data.audiocard > 2 && Data.printer > 1)
            {
                if (Data.money < Data.cost_os[4])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_os[4];
                    Data.os = 5;
                    ++Data.mood;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;

                    label2.Text = Data.arr_os[5];

                    // отобразить в главной форме 
                    ((Form1)Owner).lOs.Text = Data.arr_os[5];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;
                    ((Form1)Owner).lMood.Text = "" + Data.mood;

                    ((Form1)Owner).timerVirus.Start();

                    MessageBox.Show("Вы установили Windows 2000", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Data.os > 0)
            {
                if (Data.money < Data.cost_programming[0])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_programming[0];
                    Data.programming = 1;

                    button10.Enabled = false;

                    label3.Text = Data.arr_programming[1];

                    // отобразить в главной форме 
                    ((Form1)Owner).lProgramming.Text = Data.arr_programming[1];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили Basic", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Data.os > 0 && Data.cpu > 1 && Data.hdd > 1)
            {
                if (Data.money < Data.cost_programming[1])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_programming[1];
                    Data.programming = 2;

                    button10.Enabled = false;
                    button9.Enabled = false;

                    label3.Text = Data.arr_programming[2];

                    // отобразить в главной форме 
                    ((Form1)Owner).lProgramming.Text = Data.arr_programming[2];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили Паскаль", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Data.os > 2 && Data.videocard > 1)
            {
                if (Data.money < Data.cost_programming[2])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_programming[2];
                    Data.programming = 3;

                    button10.Enabled = false;
                    button9.Enabled = false;
                    button8.Enabled = false;

                    label3.Text = Data.arr_programming[3];

                    // отобразить в главной форме 
                    ((Form1)Owner).lProgramming.Text = Data.arr_programming[3];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили Visual Basic", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Data.os > 2 && Data.ram > 3 && Data.videocard > 1)
            {
                if (Data.money < Data.cost_programming[3])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_programming[3];
                    Data.programming = 4;

                    button10.Enabled = false;
                    button9.Enabled = false;
                    button8.Enabled = false;
                    button7.Enabled = false;

                    label3.Text = Data.arr_programming[4];

                    // отобразить в главной форме 
                    ((Form1)Owner).lProgramming.Text = Data.arr_programming[4];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили Visual C++", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Data.os > 1)
            {
                if (Data.money < Data.cost_graphics[0])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_graphics[0];
                    Data.graphics = 1;

                    button13.Enabled = false;

                    label5.Text = Data.arr_graphics[1];

                    // отобразить в главной форме 
                    ((Form1)Owner).lGraphics.Text = Data.arr_graphics[1];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили граф. редактор Corel Xara", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Data.os > 2 && Data.videocard > 1)
            {
                if (Data.money < Data.cost_graphics[1])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_graphics[1];
                    Data.graphics = 2;

                    button13.Enabled = false;
                    button12.Enabled = false;

                    label5.Text = Data.arr_graphics[2];

                    // отобразить в главной форме 
                    ((Form1)Owner).lGraphics.Text = Data.arr_graphics[2];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили граф. редактор Photoshop", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Data.os > 3 && Data.monitor > 1 && Data.hdd > 4 && Data.videocard > 2 && Data.printer > 1)
            {
                if (Data.money < Data.cost_graphics[2])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_graphics[2];
                    Data.graphics = 3;

                    button13.Enabled = false;
                    button12.Enabled = false;
                    button11.Enabled = false;

                    label5.Text = Data.arr_graphics[3];

                    // отобразить в главной форме 
                    ((Form1)Owner).lGraphics.Text = Data.arr_graphics[3];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили граф. редактор 3D Studio Max II", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Data.os > 4 && Data.cpu > 5 && Data.monitor > 2 && Data.hdd > 5 && Data.videocard > 3 && Data.printer > 2)
            {
                if (Data.money < Data.cost_graphics[3])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_graphics[3];
                    Data.graphics = 4;
                    ++Data.mood;

                    button13.Enabled = false;
                    button12.Enabled = false;
                    button11.Enabled = false;
                    button6.Enabled = false;

                    label5.Text = Data.arr_graphics[4];

                    // отобразить в главной форме 
                    ((Form1)Owner).lGraphics.Text = Data.arr_graphics[4];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;
                    ((Form1)Owner).lMood.Text = "" + Data.mood;

                    MessageBox.Show("Вы установили граф. редактор 3D Studio Max III", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Data.os > 2)
            {
                if (Data.money < Data.cost_antivirus[0])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_antivirus[0];
                    Data.antivirus = 1;

                    button19.Enabled = false;
                    button20.Enabled = true;

                    // отобразить в главной форме 
                    ((Form1)Owner).lAntivirus.Text = Data.arr_antivirus[1];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили антивирус Касперского (v.I). Не забывайте проверять ваш компьютер на вирусы.", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Data.os > 4)
            {
                if (Data.money < Data.cost_antivirus[1])
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= Data.cost_antivirus[1];
                    Data.antivirus = 2;
                    ++Data.mood;

                    button19.Enabled = false;
                    button18.Enabled = false;
                    button20.Enabled = true;

                    // отобразить в главной форме 
                    ((Form1)Owner).lAntivirus.Text = Data.arr_antivirus[2];
                    ((Form1)Owner).lMoney.Text = "" + Data.money;
                    ((Form1)Owner).lMood.Text = "" + Data.mood;

                    MessageBox.Show("Вы установили мощный антивирус IVP 100. Не забывайте проверять ваш компьютер на вирусы.", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вам удалось уничтожить вирус", "Ура. Вирус убит.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Data.money -= 10;
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Data.os > 2)
            {
                if (Data.money < 15)
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= 15;
                    Data.ie = true;

                    button17.Enabled = false;

                    // отобразить в главной форме 
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили браузер Internet Explorer.", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Data.os > 2)
            {
                if (Data.money < 5)
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= 5;
                    Data.dialer = true;

                    button16.Enabled = false;

                    // отобразить в главной форме 
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили звонилку.", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Data.os > 2)
            {
                if (Data.money < 7)
                {
                    MessageBox.Show("У вас не хватает денег на это.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Data.money -= 7;
                    Data.downloader = true;

                    button15.Enabled = false;

                    // отобразить в главной форме 
                    ((Form1)Owner).lMoney.Text = "" + Data.money;

                    MessageBox.Show("Вы установили Закачку (Downloader).", "Установлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Конфигурация вашего компьютера не подходит", "Не подходит конфигурация компьютера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "10";
            label7.Text = "Проверка";

            richTextBox1.Text = "Проверить и уничтожить (если возможно) вирусы с\nкомпьютера. Если удалить не удастся, тогда вам не\nнужно будет платить за проверку.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
