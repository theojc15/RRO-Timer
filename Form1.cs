using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RRO
{
    public partial class Form1 : Form
    {
        int min, sec;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            min = 0;
            sec = 0;
            button1.Text = "90 Menit";
            button2.Text = "60 Menit";
            button4.Text = "30 Menit";
            button3.Text = "START";
            textBox1.ForeColor = Color.Black;
            textBox1.Text = min.ToString("D2") + " : " + sec.ToString("D2");
            pictureBox2.Image = new Bitmap(RRO.Properties.Resources.LOGO_RK_VECTOR__HI_RES__Preview);
            pictureBox3.Image = new Bitmap(RRO.Properties.Resources.RRO_Logo__1_);
            pictureBox4.Image = new Bitmap(RRO.Properties.Resources.Promo_Awal_Events__IG____RRO_22_1a);
            pictureBox5.Image = new Bitmap(RRO.Properties.Resources.logo_its_biru_transparan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                min = min - 1;
                sec = 60;
                sec = sec - 1;
            }
            else
            {
                sec = sec - 1;
            }

            if (min == 0 && sec <= 0)
            {
                timer1.Enabled = false;
                button3.Text = "START";
            }

            if (min < 5)
            {
                if(textBox1.ForeColor == Color.Red)
                {
                    textBox1.ForeColor = Color.Black;
                }
                else if (textBox1.ForeColor == Color.Black)
                {
                    textBox1.ForeColor = Color.Red;
                }
            }
            textBox1.Text = min.ToString("D2") + " : " + sec.ToString("D2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            min = 90;
            sec = 0;
            textBox1.Text = min.ToString("D2") + " : " + sec.ToString("D2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            min = 60;
            sec = 0;
            textBox1.Text = min.ToString("D2") + " : " + sec.ToString("D2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            min = 30;
            sec = 0;
            textBox1.Text = min.ToString("D2") + " : " + sec.ToString("D2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (min != 0 && button3.Text == "START")
            {
                timer1.Enabled = true;
                button3.Text = "STOP";
            }
            else if (button3.Text == "STOP")
            {
                timer1.Enabled = false;
                button3.Text = "START";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Location = new Point((this.Width / 2) - (textBox1.Width / 2), (this.Height / 2) - (textBox1.Height / 2));
        }
    }
}
