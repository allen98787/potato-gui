
namespace WindowsFormsApp1
{
    partial class Form4_5_8
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
            this.components = new System.ComponentModel.Container();
            this.timer_label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_label1
            // 
            this.timer_label1.AutoSize = true;
            this.timer_label1.Font = new System.Drawing.Font("新細明體", 24F);
            this.timer_label1.Location = new System.Drawing.Point(224, 117);
            this.timer_label1.Name = "timer_label1";
            this.timer_label1.Size = new System.Drawing.Size(62, 32);
            this.timer_label1.TabIndex = 0;
            this.timer_label1.Text = "0秒";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // Form4_5_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timer_label1);
            this.Name = "Form4_5_8";
            this.Text = "Form4_5_8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timer_label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}