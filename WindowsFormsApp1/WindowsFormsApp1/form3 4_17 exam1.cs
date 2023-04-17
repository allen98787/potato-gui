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
    public partial class form3_4_17_exam1 : Form
    {
        public form3_4_17_exam1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void transform_Click(object sender, EventArgs e)
        {
            string temp = C_textBox.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) + 1;
            }
            catch (Exception)
            {
                C_textBox.Text = "0";
            }
            string str = C_textBox.Text;
            int input = Int32.Parse(str);  //華氏= (input)(9/5) + 32
            F_label3.Text = input*(1.8) +32+"°F";
          
        }
    }
}
