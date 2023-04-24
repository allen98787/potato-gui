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

        private void button2_Click(object sender, EventArgs e)
        {
             Form form_button = new button_call();
            form_button.Show();
        }

        private void button_to_text_Click(object sender, EventArgs e)
        {
            //Form form_button = new button_call();
            //form_button.Show();

            Form form_button = new Form2();
            form_button.Show();
        }

        private void button3_Click(object sender, EventArgs e)//exam1_button
        {
            Form form_button = new form3_4_17_exam1();
            form_button.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
