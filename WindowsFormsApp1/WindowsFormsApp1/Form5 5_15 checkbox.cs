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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false & checkBox4.Checked == false)
            {
                MessageBox.Show("請選擇菜品");
            }
            else
            {
                if (radioButton1.Checked == false & radioButton2.Checked == false)
                {
                    MessageBox.Show("請選擇外帶或內用");
                }
                else
                {
                    string mainFood = "";
                    string sideFood = "";
                    string takeaway = "";

                    foreach (Control c in panel1.Controls)
                    {
                        mainFood = Check.Checking(c);
                        /*
                        if (c is CheckBox)
                        {
                            if (((CheckBox)c).Checked == true)
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
                        }*/
                    }
                    Check.Checken = "";
                    foreach (Control c in panel2.Controls)
                    {
                        sideFood = Check.Checking(c);
                    }
                    Check.Checken = "";
                    foreach (Control c in panel3.Controls)
                    {
                        takeaway = Check.Checking(c);
                    }
                    Check.Checken = "";
                    //MessageBox.Show("主食:" + mainFood+Environment.NewLine+"配菜:" + sideFood + takeaway);
                    DateTime curentDateTime = DateTime.Now;
                    string formateDateTime = curentDateTime.ToString("yyyy/MM/dd HH:mm:ss");
                    File.AppendAllText("OrderData.csv", formateDateTime + "," + mainFood + "," + sideFood + "," + takeaway + "\n");
                    MessageBox.Show("點餐成功");

                    Check.Uncheck = 0;

                    foreach (Control c in panel1.Controls)
                    {
                        Check.Checking(c);
                    }
                    foreach (Control c in panel2.Controls)
                    {
                        Check.Checking(c);
                    }
                    foreach (Control c in panel3.Controls)
                    {
                        Check.Checking(c);
                    }
                    Check.Uncheck = 1;

                }
            }
        }

        
    }

    internal class Check
    {
        internal static string Checken = "";
        internal static int Uncheck =1;
        public static string Checking(Control c)
        {
            if (c is CheckBox & Uncheck == 1)
            {
                if (((CheckBox)c).Checked == true)
                {

                    Checken += c.Text + " ";
                }
            }
            else if (c is RadioButton & Uncheck == 1)
            {
                if (((RadioButton)c).Checked == true)
                {
                    Checken += c.Text + " ";
                }
            }
            else if( c is CheckBox & Uncheck == 0)
            {
                if (((CheckBox)c).Checked == true)
                {
                    ((CheckBox)c).Checked = false;
                }
            }

            else if(c is RadioButton & Uncheck == 0)
            {
                if (((RadioButton)c).Checked == true)
                {
                    ((RadioButton)c).Checked = false;
                }
            }

            return Checken;
        }


    }
}
