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
    public partial class Internet : Form
    {
        public Internet()
        {
            InitializeComponent();

            button1.Enabled = !Data.internet_access;
            button2.Enabled = Data.internet_access;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.modem > 0 && Data.ie && Data.dialer){
                if (Data.money > 30) {
                    Data.money -= 30;
                    ((Form1)Owner).lMoney.Text = "" + Data.money;
                    Data.internet_access = true;
                    ((Form1)Owner).lInternet.Text = "Есть";
                    button1.Enabled = !Data.internet_access;
                    button2.Enabled = Data.internet_access;
                    MessageBox.Show("Вы подключились к интернету за 5$ в час.", "Подключение произошло.");
                }
                else
                {
                    MessageBox.Show("Денег маловато.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else{
                MessageBox.Show("Вы не можете подключиться к интернету без модема, браузера и звонилки.", "Подключение не произошло.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = true;
            Invalidate();
        }

        private void Internet_Paint(object sender, PaintEventArgs e)
        {
            if (button3.Visible)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.White, 3);
                g.DrawLine(pen, 75, 260, 75, 325);
                g.DrawLine(pen, 75, 293, 140, 293);
                g.DrawLine(pen, 75, 325, 140, 325);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            (new Internet1()).ShowDialog(this);
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            (new Internet2()).ShowDialog(this);
            Show();
        }
    }
}
