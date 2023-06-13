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
        int slot = 1;
        public FormFX()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("OrderData.csv"))
            {
                string order = File.ReadAllText("OrderData.csv");
                string[] meal = order.Split('\n');
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
    }
}
