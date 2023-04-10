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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
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

    }
}
