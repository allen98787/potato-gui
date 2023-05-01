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
    public partial class FormEX_5_1 : Form
    {
        int answer = 0;
        public FormEX_5_1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            answer= r.Next(100) =;
            
        }

        private void guess_button_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(tb_type.Text);
                if(num > answer)
                    { }
               
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
