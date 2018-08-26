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
    public partial class Internet2 : Form
    {
        public Internet2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = "" + (Convert.ToInt32(label4.Text) + 1);
            Data.money -= 5;
            ((Form1)Owner.Owner).lMoney.Text = "" + Data.money;
        }
    }
}
