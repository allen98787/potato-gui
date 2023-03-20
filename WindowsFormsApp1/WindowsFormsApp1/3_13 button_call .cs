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
        public button_call()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short times = 0;
            if (button1.Text == "還沒按過")  //3/20
            {
                button1.Text = "被按過了";
                times++;
            }
            else if (button1.Text == "被按過了")
            {
                button1.Text = "你又按了"; 
                times++;
            }
            else if (button1.Text == "你又按了")
            {

                button1.Text = "你双按了";
                times++;
            }
            else if (times == 3)
            {
                button1.Text = "你按了" + times + "下";
                times++;
            }
            else if (times == 10)
            {
                button1.Text = "再按一下重置";
                times = 0;
            }


        }
    }
}
