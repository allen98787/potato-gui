
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.text_plus10_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_add1 = new System.Windows.Forms.TextBox();
            this.TB_add2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_add_result = new System.Windows.Forms.Label();
            this.BT_result = new System.Windows.Forms.Button();
            this.BT_reduce = new System.Windows.Forms.Button();
            this.LB_reduce_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_reduce2 = new System.Windows.Forms.TextBox();
            this.TB_reduce1 = new System.Windows.Forms.TextBox();
            this.BT_multi = new System.Windows.Forms.Button();
            this.LB_multi_result = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_multi2 = new System.Windows.Forms.TextBox();
            this.TB_multi1 = new System.Windows.Forms.TextBox();
            this.BT_divide = new System.Windows.Forms.Button();
            this.LB_divide_result = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_divide2 = new System.Windows.Forms.TextBox();
            this.TB_divide1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(95, 88);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(132, 25);
            this.textBox_input.TabIndex = 0;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(92, 49);
            this.label_output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(37, 15);
            this.label_output.TabIndex = 1;
            this.label_output.Text = "結果";
            // 
            // text_plus10_button
            // 
            this.text_plus10_button.Location = new System.Drawing.Point(95, 144);
            this.text_plus10_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_plus10_button.Name = "text_plus10_button";
            this.text_plus10_button.Size = new System.Drawing.Size(100, 29);
            this.text_plus10_button.TabIndex = 2;
            this.text_plus10_button.Text = "+10";
            this.text_plus10_button.UseVisualStyleBackColor = true;
            this.text_plus10_button.Click += new System.EventHandler(this.text_plus10_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "計算機";
            // 
            // TB_add1
            // 
            this.TB_add1.Location = new System.Drawing.Point(55, 261);
            this.TB_add1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_add1.Name = "TB_add1";
            this.TB_add1.Size = new System.Drawing.Size(132, 25);
            this.TB_add1.TabIndex = 4;
            // 
            // TB_add2
            // 
            this.TB_add2.Location = new System.Drawing.Point(220, 261);
            this.TB_add2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_add2.Name = "TB_add2";
            this.TB_add2.Size = new System.Drawing.Size(132, 25);
            this.TB_add2.TabIndex = 5;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(197, 265);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(15, 15);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // LB_add_result
            // 
            this.LB_add_result.AutoSize = true;
            this.LB_add_result.Location = new System.Drawing.Point(397, 265);
            this.LB_add_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_add_result.Name = "LB_add_result";
            this.LB_add_result.Size = new System.Drawing.Size(14, 15);
            this.LB_add_result.TabIndex = 8;
            this.LB_add_result.Text = "0";
            // 
            // BT_result
            // 
            this.BT_result.Location = new System.Drawing.Point(472, 259);
            this.BT_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_result.Name = "BT_result";
            this.BT_result.Size = new System.Drawing.Size(100, 29);
            this.BT_result.TabIndex = 9;
            this.BT_result.Text = "計算";
            this.BT_result.UseVisualStyleBackColor = true;
            this.BT_result.Click += new System.EventHandler(this.result_Click);
            // 
            // BT_reduce
            // 
            this.BT_reduce.Location = new System.Drawing.Point(472, 296);
            this.BT_reduce.Margin = new System.Windows.Forms.Padding(4);
            this.BT_reduce.Name = "BT_reduce";
            this.BT_reduce.Size = new System.Drawing.Size(100, 29);
            this.BT_reduce.TabIndex = 15;
            this.BT_reduce.Text = "計算";
            this.BT_reduce.UseVisualStyleBackColor = true;
            this.BT_reduce.Click += new System.EventHandler(this.BT_reduce_Click);
            // 
            // LB_reduce_result
            // 
            this.LB_reduce_result.AutoSize = true;
            this.LB_reduce_result.Location = new System.Drawing.Point(397, 302);
            this.LB_reduce_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_reduce_result.Name = "LB_reduce_result";
            this.LB_reduce_result.Size = new System.Drawing.Size(14, 15);
            this.LB_reduce_result.TabIndex = 14;
            this.LB_reduce_result.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // TB_reduce2
            // 
            this.TB_reduce2.Location = new System.Drawing.Point(220, 298);
            this.TB_reduce2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_reduce2.Name = "TB_reduce2";
            this.TB_reduce2.Size = new System.Drawing.Size(132, 25);
            this.TB_reduce2.TabIndex = 11;
            // 
            // TB_reduce1
            // 
            this.TB_reduce1.Location = new System.Drawing.Point(55, 298);
            this.TB_reduce1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_reduce1.Name = "TB_reduce1";
            this.TB_reduce1.Size = new System.Drawing.Size(132, 25);
            this.TB_reduce1.TabIndex = 10;
            // 
            // BT_multi
            // 
            this.BT_multi.Location = new System.Drawing.Point(472, 333);
            this.BT_multi.Margin = new System.Windows.Forms.Padding(4);
            this.BT_multi.Name = "BT_multi";
            this.BT_multi.Size = new System.Drawing.Size(100, 29);
            this.BT_multi.TabIndex = 21;
            this.BT_multi.Text = "計算";
            this.BT_multi.UseVisualStyleBackColor = true;
            this.BT_multi.Click += new System.EventHandler(this.BT_multi_Click);
            // 
            // LB_multi_result
            // 
            this.LB_multi_result.AutoSize = true;
            this.LB_multi_result.Location = new System.Drawing.Point(397, 339);
            this.LB_multi_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_multi_result.Name = "LB_multi_result";
            this.LB_multi_result.Size = new System.Drawing.Size(14, 15);
            this.LB_multi_result.TabIndex = 20;
            this.LB_multi_result.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 339);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // TB_multi2
            // 
            this.TB_multi2.Location = new System.Drawing.Point(220, 335);
            this.TB_multi2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_multi2.Name = "TB_multi2";
            this.TB_multi2.Size = new System.Drawing.Size(132, 25);
            this.TB_multi2.TabIndex = 17;
            // 
            // TB_multi1
            // 
            this.TB_multi1.Location = new System.Drawing.Point(55, 335);
            this.TB_multi1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_multi1.Name = "TB_multi1";
            this.TB_multi1.Size = new System.Drawing.Size(132, 25);
            this.TB_multi1.TabIndex = 16;
            // 
            // BT_divide
            // 
            this.BT_divide.Location = new System.Drawing.Point(472, 370);
            this.BT_divide.Margin = new System.Windows.Forms.Padding(4);
            this.BT_divide.Name = "BT_divide";
            this.BT_divide.Size = new System.Drawing.Size(100, 29);
            this.BT_divide.TabIndex = 27;
            this.BT_divide.Text = "計算";
            this.BT_divide.UseVisualStyleBackColor = true;
            this.BT_divide.Click += new System.EventHandler(this.BT_divide_Click);
            // 
            // LB_divide_result
            // 
            this.LB_divide_result.AutoSize = true;
            this.LB_divide_result.Location = new System.Drawing.Point(397, 376);
            this.LB_divide_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_divide_result.Name = "LB_divide_result";
            this.LB_divide_result.Size = new System.Drawing.Size(14, 15);
            this.LB_divide_result.TabIndex = 26;
            this.LB_divide_result.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 376);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 376);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "/";
            // 
            // TB_divide2
            // 
            this.TB_divide2.Location = new System.Drawing.Point(220, 372);
            this.TB_divide2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_divide2.Name = "TB_divide2";
            this.TB_divide2.Size = new System.Drawing.Size(132, 25);
            this.TB_divide2.TabIndex = 23;
            // 
            // TB_divide1
            // 
            this.TB_divide1.Location = new System.Drawing.Point(55, 372);
            this.TB_divide1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_divide1.Name = "TB_divide1";
            this.TB_divide1.Size = new System.Drawing.Size(132, 25);
            this.TB_divide1.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.BT_divide);
            this.Controls.Add(this.LB_divide_result);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_divide2);
            this.Controls.Add(this.TB_divide1);
            this.Controls.Add(this.BT_multi);
            this.Controls.Add(this.LB_multi_result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_multi2);
            this.Controls.Add(this.TB_multi1);
            this.Controls.Add(this.BT_reduce);
            this.Controls.Add(this.LB_reduce_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_reduce2);
            this.Controls.Add(this.TB_reduce1);
            this.Controls.Add(this.BT_result);
            this.Controls.Add(this.LB_add_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.TB_add2);
            this.Controls.Add(this.TB_add1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_plus10_button);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.textBox_input);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "form2 4_10 textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Button text_plus10_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_add1;
        private System.Windows.Forms.TextBox TB_add2;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_add_result;
        private System.Windows.Forms.Button BT_result;
        private System.Windows.Forms.Button BT_reduce;
        private System.Windows.Forms.Label LB_reduce_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_reduce2;
        private System.Windows.Forms.TextBox TB_reduce1;
        private System.Windows.Forms.Button BT_multi;
        private System.Windows.Forms.Label LB_multi_result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_multi2;
        private System.Windows.Forms.TextBox TB_multi1;
        private System.Windows.Forms.Button BT_divide;
        private System.Windows.Forms.Label LB_divide_result;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_divide2;
        private System.Windows.Forms.TextBox TB_divide1;
    }
}