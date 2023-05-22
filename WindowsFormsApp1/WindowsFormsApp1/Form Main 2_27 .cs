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
       
        private void button1_Click(object sender, EventArgs e)//按鈕1
        {
            MessageBox.Show("3/13");

        }


        private void button2_Click(object sender, EventArgs e)
        {
             Form form_button = new button_call();
            form_button.Show();
        }

        private void button_to_text_Click(object sender, EventArgs e)
        {
     
            Form form_textbox = new Form2();    
            form_textbox.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form_examl = new form3_4_17_exam1();    
            form_examl.Show(); 
        }

        private void Extra_button1_Click(object sender, EventArgs e)
        {
            Form formEX_code = new FormEX_5_1();
            formEX_code.Show();
        }

        private void Timer_button_Click(object sender, EventArgs e)
        {
            Form form4_timer = new Form4_5_8();
            form4_timer.Show();
        }

        private void checkbox_button_Click_1(object sender, EventArgs e)
        {
            Form form5_checkbox = new Form5();
            form5_checkbox.Show();
        }

       
    }
}
