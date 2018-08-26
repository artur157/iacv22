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
    public partial class Virus : Form
    {
        public Virus()
        {
            InitializeComponent();
        }

        void bad_situation()
        {
            int sum = new Random().Next(5, 20);
            MessageBox.Show("Вирус уничтожил " + sum + "$  с вашего счета.", "Надо было покупать хороший антивирус.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Data.money -= sum;
            ((Form1)Owner).lMoney.Text = "" + Data.money;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bad_situation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (Data.antivirus)
            {
                case 0:
                    MessageBox.Show("У вас нет антивируса.", "Надо было антивирус покупать.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bad_situation();
                    break;
                case 1:
                    MessageBox.Show("К сожалению антивирус Касперского не смог уничтожить этот вирус.", "Надо было покупать хороший антивирус.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bad_situation();
                    break;
                case 2:
                    MessageBox.Show("Вам удалось уничтожить вирус", "Ура. Вирус убит.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    break;
            }
        }
    }
}
