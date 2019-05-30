using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storn
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int b=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            a = rd.Next(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = Int32.Parse(maskedTextBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\storn\\0.jpg");//布
                label1.Text = "剪刀";
            }
            if (b == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\storn\\1.jpg");//剪刀
                label1.Text = "石頭";
            }
            if (b == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\storn\\2.jpg");//石頭
                label1.Text = "布";
            }
            if (a == 0)
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\storn\\0.jpg");
                label4.Text = "剪刀";
            }
            if (a == 1)
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\storn\\1.jpg");
                label4.Text = "石頭";
            }
            if (a == 2)
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\admin\\Desktop\\storn\\2.jpg");
                label4.Text = "布";
            }

            if (a == b)
                label5.Text = "平手";
            if (a==0 && b==1)
                label5.Text = "你贏了";
            if (a == 0 && b == 2)
                label5.Text = "你輸了";
            if (a == 1 && b == 0)
                label5.Text = "你輸了";
            if (a == 1 && b == 2)
                label5.Text = "你贏了";
            if (a == 2 && b == 0)
                label5.Text = "你贏了";
            if (a == 2 && b == 1)
                label5.Text = "你輸了";











            timer1.Enabled = false;
        }
    }
}
