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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)  //只有勾選才會觸發
            
       
            MessageBox.Show(checkBox1.Text+ "已被按下");
            CheckedListBox1.Items.Add("Sunday", CheckState.Checked);
            CheckedListBox1.Items.Add("Monday", CheckState.Unchecked);
            CheckedListBox1.Items.Add("Tuesday", CheckState.Indeterminate);
            //http://csharp.net-informations.com/gui/cs-checkedlistbox.htm

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        
    }
}
