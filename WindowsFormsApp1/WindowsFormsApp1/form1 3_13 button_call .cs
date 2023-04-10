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

    public partial class button_call : Form
    {
        short times;
        public button_call()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            times++;
            if (times == 0)
            {
                button1.Text = "還沒按過";
            }
            
            else if(times == 1)  //3/20
            {
                button1.Text = "被按過了";

            }
            else if (times == 2)
            {
                button1.Text = "你又按了";

            }
            else if (times == 3)
            {

                button1.Text = "你双按了";

            }
            else if (times >=4)
            {
                if(times <10 )
                button1.Text = "你按了" + times + "下";

                else if (times == 10)
                {
                    button1.Text = "再按一下重置";
                    times = 0;
                }

            }
            

        }

        private void plusone_button_Click(object sender, EventArgs e)
        {
            string temp = plusone_label.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) + 1;
            }
            catch (Exception )
            {
                plusone_label.Text = "0";
            }
            //label2.Text = count+""
            plusone_label.Text = count.ToString();
            if (count < 100)
            {
                if (count >= 0)
                {
                    progressBar1.Value = count;
                }
            }
        }

        private void minus_one_Click(object sender, EventArgs e)
        {
            string temp = plusone_label.Text;
            int count = 0;
            try
            {
                count = Int32.Parse(temp) - 1;
            }
            catch (Exception)
            {
                plusone_label.Text = "0";
            }
            plusone_label.Text = count.ToString();
            if (count < 100)
            {
                if (count >= 0)
                {
                    progressBar1.Value = count;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                short sizeNum = 10;
                button4.Size = new Size(button4.Width + sizeNum, button4.Height + sizeNum);
                button4.Location = new Point(button4.Location.X - sizeNum / 2, button4.Location.Y - sizeNum / 2);            
        }
    }
}
