
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
            this.TB_result = new System.Windows.Forms.Label();
            this.BT_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(71, 70);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(100, 22);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(69, 39);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(29, 12);
            this.label_output.TabIndex = 1;
            this.label_output.Text = "結果";
            // 
            // text_plus10_button
            // 
            this.text_plus10_button.Location = new System.Drawing.Point(71, 115);
            this.text_plus10_button.Name = "text_plus10_button";
            this.text_plus10_button.Size = new System.Drawing.Size(75, 23);
            this.text_plus10_button.TabIndex = 2;
            this.text_plus10_button.Text = "+10";
            this.text_plus10_button.UseVisualStyleBackColor = true;
            this.text_plus10_button.Click += new System.EventHandler(this.text_plus10_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "計算機";
            // 
            // TB_add1
            // 
            this.TB_add1.Location = new System.Drawing.Point(41, 209);
            this.TB_add1.Name = "TB_add1";
            this.TB_add1.Size = new System.Drawing.Size(100, 22);
            this.TB_add1.TabIndex = 4;
            // 
            // TB_add2
            // 
            this.TB_add2.Location = new System.Drawing.Point(165, 209);
            this.TB_add2.Name = "TB_add2";
            this.TB_add2.Size = new System.Drawing.Size(100, 22);
            this.TB_add2.TabIndex = 5;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(148, 212);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(11, 12);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // TB_result
            // 
            this.TB_result.AutoSize = true;
            this.TB_result.Location = new System.Drawing.Point(298, 212);
            this.TB_result.Name = "TB_result";
            this.TB_result.Size = new System.Drawing.Size(11, 12);
            this.TB_result.TabIndex = 8;
            this.TB_result.Text = "0";
            // 
            // BT_result
            // 
            this.BT_result.Location = new System.Drawing.Point(354, 207);
            this.BT_result.Name = "BT_result";
            this.BT_result.Size = new System.Drawing.Size(75, 23);
            this.BT_result.TabIndex = 9;
            this.BT_result.Text = "計算";
            this.BT_result.UseVisualStyleBackColor = true;
            this.BT_result.Click += new System.EventHandler(this.result_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_result);
            this.Controls.Add(this.TB_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.TB_add2);
            this.Controls.Add(this.TB_add1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_plus10_button);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form2";
            this.Text = "form2 4_10 textbox";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label TB_result;
        private System.Windows.Forms.Button BT_result;
    }
}