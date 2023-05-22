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
    public partial class Form4_5_8 : Form
    {
        int count1 = 0; //timer為每秒重複執行的元件 不會記錄時間 須設定變數
        int count2 = 0;
        public Form4_5_8()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//用程式設定屬性
            timer_label1.Text = String.Format("{0}秒", count1++.ToString()); // count++ //timer1每秒
        }

        private void timer2_Tick(object sender, EventArgs e)   //timer2每秒
        {
            timer2.Interval = 1000;//用程式設定屬性
            timer_label2.Text = String.Format("{0}秒", count2++.ToString());
        }
        private void timer2_start_bt_Click(object sender, EventArgs e)   //timer2開始按鍵
        {
            timer2.Start();
        }
        private void timer2_pause_button_Click(object sender, EventArgs e) //暫停  
        {
            timer2.Stop();
        }
        private void timer2_zero_button_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            count2 = 0;
            timer_label2.Text = String.Format("{0}秒", count2.ToString());
        }
    }
}
