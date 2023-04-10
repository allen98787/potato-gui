
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_plus10_button);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form2";
            this.Text = "form2 4_10 textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Button text_plus10_button;
    }
}