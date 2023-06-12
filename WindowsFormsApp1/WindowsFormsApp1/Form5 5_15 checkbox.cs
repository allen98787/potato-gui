using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Files input output

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            /*File.WriteAllText("Temp.csv","HI");//覆蓋文件內全部文字          .csv(逗點分隔值檔案)可用於
            File.AppendAllText("Temp.txt","IH");//                     ^不同程式之間的資料轉換
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);*/
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配餐\n", Encoding.UTF8);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string mainFood = "";
            string sideFood = "";
            string takeaway = "";
            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                { 
                    if(((CheckBox)c).Checked == true)
                    {
                        mainFood += c.Text + " ";
                    }
                }
                else if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked == true)
                    {
                        takeaway += c.Text + " ";
                    }
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        sideFood += c.Text + " ";
                    }
                }
            }
            
            //MessageBox.Show("主食:" + mainFood+Environment.NewLine+"配菜:" + sideFood + takeaway);

            DateTime curentDateTime = DateTime.Now;
            string formateDateTime = curentDateTime.ToString("yyyy/MM/dd HH:mm:ss");
            File.AppendAllText("OrderData.csv", formateDateTime+"," + mainFood+ "," + sideFood+ "," + takeaway+ "\n");
            MessageBox.Show("點餐成功");

           
            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }
                else if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked == true)
                    {
                        ((RadioButton)c).Checked = false;
                    }
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }
            }
        }

     
    }
}
