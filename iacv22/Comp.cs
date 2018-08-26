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
    public partial class Comp : Form
    {
        public Comp()
        {
            InitializeComponent();

            if (Data.monitor >= Data.arr_monitor.Length - 1)
                button2.Enabled = false;
            if (Data.printer >= Data.arr_printer.Length - 1)
                button3.Enabled = false;
            if (Data.scanner >= Data.arr_scanner.Length - 1)
                button4.Enabled = false;
            if (Data.modem >= Data.arr_modem.Length - 1)
                button5.Enabled = false;
            if (Data.cpu >= Data.arr_cpu.Length - 1)
                button1.Enabled = false;
            if (Data.videocard >= Data.arr_videocard.Length - 1)
                button6.Enabled = false;
            if (Data.audiocard >= Data.arr_audiocard.Length - 1)
                button7.Enabled = false;
            if (Data.ram >= Data.arr_ram.Length - 1)
                button8.Enabled = false;
            if (Data.cd_rom >= Data.arr_cd_rom.Length - 1)
                button9.Enabled = false;
            if (Data.hdd >= Data.arr_hdd.Length - 1)
                button10.Enabled = false;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_cpu[Data.cpu])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_cpu[Data.cpu];
                Data.cpu++;
                ++Data.mood;
            }

            if (Data.cpu >= Data.arr_cpu.Length - 1)
                button1.Enabled = false;
            else
                button1_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lCpu.Text = Data.arr_cpu[Data.cpu];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
            ((Form1)Owner).lMood.Text = "" + Data.mood;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_cpu[Data.cpu];
            label5.Text = Data.arr_cpu[Data.cpu + 1];

            richTextBox1.Text = "Купить процессор " + Data.arr_cpu[Data.cpu + 1] + ".";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "0";
            label5.Text = "--------";

            richTextBox1.Text = "";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_monitor[Data.monitor];
            label5.Text = Data.arr_monitor[Data.monitor + 1];

            richTextBox1.Text = "Купить монитор с диагональю " + Data.arr_monitor[Data.monitor + 1] + ".";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_printer[Data.printer];
            label5.Text = Data.arr_printer[Data.printer + 1];

            richTextBox1.Text = "Купить " + Data.arr_printer[Data.printer + 1] + " принтер.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_scanner[Data.scanner];
            label5.Text = Data.arr_scanner[Data.scanner + 1];

            richTextBox1.Text = "Купить " + Data.arr_scanner[Data.scanner + 1] + " сканер.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_modem[Data.modem];
            label5.Text = Data.arr_modem[Data.modem + 1];

            richTextBox1.Text = "Купить модем " + Data.arr_modem[Data.modem + 1] + ".";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_hdd[Data.hdd];
            label5.Text = Data.arr_hdd[Data.hdd + 1];

            richTextBox1.Text = "Купить винчестер емкостью " + Data.arr_hdd[Data.hdd + 1] + ".";
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            label1.Focus();
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_cd_rom[Data.cd_rom];
            label5.Text = Data.arr_cd_rom[Data.cd_rom + 1];

            richTextBox1.Text = "Купить CD-ROM " + Data.arr_cd_rom[Data.cd_rom + 1] + ".";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_ram[Data.ram];
            label5.Text = Data.arr_ram[Data.ram + 1];

            richTextBox1.Text = "Купить " + Data.arr_ram[Data.ram + 1] + " RAM.";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_audiocard[Data.audiocard];
            label5.Text = Data.arr_audiocard[Data.audiocard + 1];

            richTextBox1.Text = "Купить звуковую карту " + Data.arr_audiocard[Data.audiocard + 1] + ".";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = "" + Data.cost_videocard[Data.videocard];
            label5.Text = Data.arr_videocard[Data.videocard + 1];

            richTextBox1.Text = "Купить видео карту " + Data.arr_videocard[Data.videocard + 1] + ".";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_monitor[Data.monitor])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_monitor[Data.monitor];
                Data.monitor++;
            }

            if (Data.monitor >= Data.arr_monitor.Length - 1)
                button2.Enabled = false;
            else
                button2_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lMonitor.Text = Data.arr_monitor[Data.monitor];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_printer[Data.printer])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_printer[Data.printer];
                Data.printer++;
            }

            if (Data.printer >= Data.arr_printer.Length - 1)
                button3.Enabled = false;
            else
                button3_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lPrinter.Text = Data.arr_printer[Data.printer];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_scanner[Data.scanner])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_scanner[Data.scanner];
                Data.scanner++;
            }

            if (Data.scanner >= Data.arr_scanner.Length - 1)
                button4.Enabled = false;
            else
                button4_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lScanner.Text = Data.arr_scanner[Data.scanner];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_modem[Data.modem])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_modem[Data.modem];
                Data.modem++;
            }

            if (Data.modem >= Data.arr_modem.Length - 1)
                button5.Enabled = false;
            else
                button5_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lModem.Text = Data.arr_modem[Data.modem];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_hdd[Data.hdd])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_hdd[Data.hdd];
                Data.hdd++;
                ++Data.mood;
            }

            if (Data.hdd >= Data.arr_hdd.Length - 1)
                button10.Enabled = false;
            else
                button10_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lHdd.Text = Data.arr_hdd[Data.hdd];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
            ((Form1)Owner).lMood.Text = "" + Data.mood;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_cd_rom[Data.cd_rom])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_cd_rom[Data.cd_rom];
                Data.cd_rom++;
            }

            if (Data.cd_rom >= Data.arr_cd_rom.Length - 1)
                button9.Enabled = false;
            else
                button9_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lCdrom.Text = Data.arr_cd_rom[Data.cd_rom];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_ram[Data.ram])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_ram[Data.ram];
                Data.ram++;
                ++Data.mood;
            }

            if (Data.ram >= Data.arr_ram.Length - 1)
                button8.Enabled = false;
            else
                button8_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lRam.Text = Data.arr_ram[Data.ram];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
            ((Form1)Owner).lMood.Text = "" + Data.mood;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_audiocard[Data.audiocard])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_audiocard[Data.audiocard];
                Data.audiocard++;
            }

            if (Data.audiocard >= Data.arr_audiocard.Length - 1)
                button7.Enabled = false;
            else
                button7_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lAudiocard.Text = Data.arr_audiocard[Data.audiocard];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Data.money < Data.cost_videocard[Data.videocard])
            {
                MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data.money -= Data.cost_videocard[Data.videocard];
                Data.videocard++;
                ++Data.mood;
            }

            if (Data.videocard >= Data.arr_videocard.Length - 1)
                button6.Enabled = false;
            else
                button6_MouseEnter(sender, e);

            // отобразить в главной форме 
            ((Form1)Owner).lVideocard.Text = Data.arr_videocard[Data.videocard];
            ((Form1)Owner).lMoney.Text = "" + Data.money;
            ((Form1)Owner).lMood.Text = "" + Data.mood;
        }
    }
}
