using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) //標籤1
        {
           MessageBox.Show("123");
        }

        private void button1_Click(object sender, EventArgs e)//按鈕1
        {
            MessageBox.Show("3/13");

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)//工作列圖示
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form_button = new button_call();
            form_button.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string temp = label2.Text;
            int count = 0 ;
            try
            {
                count = Int32.Parse(temp) + 1;
            }
            catch (Exception e1)
            {
                label2.Text = "0";
            }

            //label2.Text = count+""
            label2.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            short sizeNum = 10;
            button4.Size = new Size(button4.Width + sizeNum, button4.Height + sizeNum);
            button4.Location = new Point(button4.Location.X - sizeNum/2, button4.Location.Y - sizeNum/2);
        }
    }

    

}
