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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void text_plus10_button_Click(object sender, EventArgs e)
        {
            string temp = textBox_input.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) + 1;
            }
            catch (Exception)
            {
                textBox_input.Text = "0";
            }
            string str = textBox_input.Text;
            int input = Int32.Parse(str);
            label_output.Text = (input + 10).ToString();

            // MessageBox.Show(str);
        }
        private void result_Click(object sender, EventArgs e)
        {
            int add1 = 0, add2 = 0;
            try
            {
                add1 = Int32.Parse(TB_add1.Text);
                add2 = Int32.Parse(TB_add2.Text);
                LB_add_result.Text = (add1 + add2).ToString();
               
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入整數");
            }
            
        }
        private void BT_reduce_Click(object sender, EventArgs e)
        {
            int red1 = 0, red2 = 0;
            try
            {
                red1 = Int32.Parse(TB_reduce1.Text);
                red2 = Int32.Parse(TB_reduce2.Text);
               LB_reduce_result.Text = (red1 - red2).ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入整數");
            }
        }
        private void BT_multi_Click(object sender, EventArgs e)
        {
            int mul1 = 0, mul2 = 0;
            try
            {
                mul1 = Int32.Parse(TB_multi1.Text);
                mul2 = Int32.Parse(TB_multi2.Text);
                LB_multi_result.Text = (mul1 * mul2).ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入整數");
            }
        }
        private void BT_divide_Click(object sender, EventArgs e)
        {
            int div1 = 0, div2 = 0;
            try
            {
                div1 = Int32.Parse(TB_divide1.Text);
                div2 = Int32.Parse(TB_divide2.Text);
                LB_divide_result.Text = (div1 / div2).ToString();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入整數");
            }
            catch (System.DivideByZeroException)
            {
                MessageBox.Show("請勿除以零");
            }
        }
    }
}
