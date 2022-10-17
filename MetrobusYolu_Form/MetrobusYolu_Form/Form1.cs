using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetrobusYolu_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int zaman = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman++;
            label6.Text = zaman.ToString();

            Random random = new Random();
            int x = random.Next(255);
            int y = random.Next(255);
            int z = random.Next(255);
            if (zaman < 25)
            {
                pictureBox1.Left += 8;
                label4.Text = "-" + label4.Text;
            }
            if (zaman >= 25 && zaman <= 45)
            {
                label1.BackColor = Color.FromArgb(x, y, z);
                if (zaman == 45)
                {
                    label1.BackColor = Color.DarkGray;
                }
            }
            if (zaman >=45 && zaman <= 80)
            {
                pictureBox1.Left += 8;
                label4.Text = "-" + label4.Text;
            }
            if (zaman >= 80 && zaman <= 105)
            {
                label2.BackColor = Color.FromArgb(x, y, z);
                if (zaman == 105)
                {
                    label2.BackColor = Color.DarkGray;
                }
            }
            if (zaman >= 105 && zaman <= 135)
            {
                pictureBox1.Left += 8;
                label4.Text = "-" + label4.Text;
            }
            if (zaman >= 135 && zaman <= 155)
            {
                label3.BackColor = Color.FromArgb(x, y, z);
                if (zaman == 155)
                {
                    label3.BackColor = Color.DarkGray;
                }
            }
            if (zaman >= 155 && zaman <= 185)
            {
                pictureBox1.Left += 8;
                label4.Text = "-" + label4.Text;
            }
            if (zaman >= 185 && zaman <= 215)
            {
                label5.BackColor = Color.FromArgb(x, y, z);
                if (zaman == 215)
                {
                    label5.BackColor = Color.DarkGray;
                    timer1.Stop();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            zaman--;
            label7.Text = zaman.ToString();
            Random random = new Random();
            int x = random.Next(255);
            int y = random.Next(255);
            int z = random.Next(255);
            if (zaman <= 215 && zaman >= 185)
            {
                pictureBox1.Left -= 8;
            }
            if (zaman <= 185 && zaman >= 145)
            {
                label3.BackColor = Color.FromArgb(x, y, z);
                if (zaman == 145)
                {
                    label3.BackColor = Color.DarkGray;
                }
            }
            if (zaman <= 145 && zaman >= 115)
            {
                pictureBox1.Left -= 8;
            }
            if (zaman <= 115 && zaman >= 75)
            {
                label2.BackColor = Color.FromArgb(x, y, z);
                if (zaman == 75)
                {
                    label2.BackColor = Color.DarkGray;
                }
            }

            if (zaman <= 75 && zaman >= 42)
            {
                pictureBox1.Left -= 8;

            }
            if (zaman <= 42 && zaman >= 25)
            {
                label1.BackColor = Color.FromArgb(x, y, z);
                if (zaman == 45)
                {
                    label1.BackColor = Color.DarkGray;
                }
            }
            if (zaman <= 25 && zaman >= 0)
            {
                pictureBox1.Left -=8;
            }
            if (zaman == 0)
            {
                timer2.Stop();
            }
        }
    }
}
