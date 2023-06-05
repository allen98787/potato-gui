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
            File.WriteAllText("Temp.txt","HI");  //.csv(逗點分隔值檔案)可用於
            File.AppendAllText("Temp.txt","IH"); // 不同程式之間的資料轉換
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            string mainFood = "";

            foreach(Control c in panel1.Controls)
            {
                if (c is CheckBox)
                { 
                    if(((CheckBox)c).Checked == true)
                    {
                        mainFood += c.Text + " ";
                    }
                }
            }
            string sideFood = "";

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
            MessageBox.Show("主食:" + mainFood+Environment.NewLine+"配菜:" + sideFood);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Spicy = "";
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckedListBox)
                {
                    if (((CheckedListBox)c).GetItemCheckState == CheckState.Checked)//https://stackoverflow.com/questions/24074470/c-sharp-checkedlistbox-if-checked
                    {
                        Spicy += c.Text + " ";
                    }
                }
            }
        }

    }
}
