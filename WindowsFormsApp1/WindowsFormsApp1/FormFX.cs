using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormFX : Form
    {
        //int slot = 1;
        public FormFX()
        {
            InitializeComponent();
        }

        private void ShowOrder_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("OrderData.csv"))
            {
                string order = File.ReadAllText("OrderData.csv");
                string[] meal = order.Split('\n');//字串.Split('分割線')
                foreach (var word in meal)
                {
                    checkedListBox1.Items.Add($"{word}");
                    //System.Console.WriteLine($"<{word}>");
                }

            }
            else
            {
               MessageBox.Show("菜單不存在");  
            }

        }

       
            private void DeleteBT_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("確定刪除點單列表?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    MessageBox.Show("點單列表已刪除");
                    File.Delete("OrderData.csv");
                }
                else
                {
                   
                }
            
            }
        
    }
}
