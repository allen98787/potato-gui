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
        Random r = new Random();
        int answer = 0;
        int Max = 0;
        int Min = 0;
        public FormEX_5_1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            
            answer= r.Next(100) ;
            Max = 100;
            Min = 1;
            count_label.Text = "請輸入" + Min + "~" + Max + "的整數";
        }

        private void guess_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Max != 0 |  Min != 0)
                {
                    int guess = Int32.Parse(tb_type.Text);
                    if ( guess > Min & guess < Max )
                    {
                        if (guess > answer)
                        {
                            Max = guess;
                        }
                        else if (guess < answer)
                        {

                            Min = guess;
                        }
                        else if (guess == answer)
                        {
                            MessageBox.Show("恭喜答對 按下確定後自動重置");
                            answer = r.Next(100);
                            Max = 100;
                            Min = 1;
                        }
                        count_label.Text = "請輸入" + Min + "~" + Max + "的整數";
                    }
                    else
                    {
                        MessageBox.Show("請輸入範圍內的整數");
                    }
                    
                }
                else
                {
                    MessageBox.Show("請先按下開始按鈕進行重置");
                    PB_point1.Visible= true; 
                    PB_point2.Visible= true;
                }
            }
               catch
            {
                MessageBox.Show("請輸入整數");
            }
        }
    }
}
