
namespace WindowsFormsApp1
{
    partial class button_call
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
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.minus_one = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.plusone_button = new System.Windows.Forms.Button();
            this.plusone_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "還沒按過";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 179);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(164, 18);
            this.progressBar1.TabIndex = 17;
            // 
            // minus_one
            // 
            this.minus_one.Location = new System.Drawing.Point(128, 203);
            this.minus_one.Margin = new System.Windows.Forms.Padding(2);
            this.minus_one.Name = "minus_one";
            this.minus_one.Size = new System.Drawing.Size(74, 23);
            this.minus_one.TabIndex = 16;
            this.minus_one.Text = "-1";
            this.minus_one.UseVisualStyleBackColor = true;
            this.minus_one.Click += new System.EventHandler(this.minus_one_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "bigger and bigger";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // plusone_button
            // 
            this.plusone_button.Location = new System.Drawing.Point(38, 203);
            this.plusone_button.Name = "plusone_button";
            this.plusone_button.Size = new System.Drawing.Size(75, 23);
            this.plusone_button.TabIndex = 14;
            this.plusone_button.Text = "+1";
            this.plusone_button.UseVisualStyleBackColor = true;
            this.plusone_button.Click += new System.EventHandler(this.plusone_button_Click);
            // 
            // plusone_label
            // 
            this.plusone_label.AutoSize = true;
            this.plusone_label.Location = new System.Drawing.Point(103, 146);
            this.plusone_label.Name = "plusone_label";
            this.plusone_label.Size = new System.Drawing.Size(37, 12);
            this.plusone_label.TabIndex = 13;
            this.plusone_label.Text = "will +1";
            // 
            // button_call
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.minus_one);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.plusone_button);
            this.Controls.Add(this.plusone_label);
            this.Controls.Add(this.button1);
            this.Name = "button_call";
            this.Text = "button_call";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button minus_one;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button plusone_button;
        private System.Windows.Forms.Label plusone_label;
    }
}