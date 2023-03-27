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
    }
}
