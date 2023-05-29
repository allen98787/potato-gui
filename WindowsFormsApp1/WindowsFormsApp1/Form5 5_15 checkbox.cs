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
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
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
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        Spicy += c.Text + " ";
                    }
                }
            }
        }
    }
}
