
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
            this.timer_label2 = new System.Windows.Forms.Label();
            this.timer2_start_bt = new System.Windows.Forms.Button();
            this.timer2_pause_button = new System.Windows.Forms.Button();
            this.timer2_zero_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_label1
            // 
            this.timer_label1.AutoSize = true;
            this.timer_label1.Font = new System.Drawing.Font("新細明體", 24F);
            this.timer_label1.Location = new System.Drawing.Point(86, 60);
            this.timer_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer_label1.Name = "timer_label1";
            this.timer_label1.Size = new System.Drawing.Size(76, 40);
            this.timer_label1.TabIndex = 0;
            this.timer_label1.Text = "0秒";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer_label2
            // 
            this.timer_label2.AutoSize = true;
            this.timer_label2.Font = new System.Drawing.Font("新細明體", 25F);
            this.timer_label2.Location = new System.Drawing.Point(495, 60);
            this.timer_label2.Name = "timer_label2";
            this.timer_label2.Size = new System.Drawing.Size(80, 42);
            this.timer_label2.TabIndex = 1;
            this.timer_label2.Text = "0秒";
            // 
            // timer2_start_bt
            // 
            this.timer2_start_bt.Location = new System.Drawing.Point(382, 142);
            this.timer2_start_bt.Name = "timer2_start_bt";
            this.timer2_start_bt.Size = new System.Drawing.Size(96, 49);
            this.timer2_start_bt.TabIndex = 2;
            this.timer2_start_bt.Text = "開始";
            this.timer2_start_bt.UseVisualStyleBackColor = true;
            this.timer2_start_bt.Click += new System.EventHandler(this.timer2_start_bt_Click);
            // 
            // timer2_pause_button
            // 
            this.timer2_pause_button.Location = new System.Drawing.Point(515, 142);
            this.timer2_pause_button.Name = "timer2_pause_button";
            this.timer2_pause_button.Size = new System.Drawing.Size(86, 49);
            this.timer2_pause_button.TabIndex = 3;
            this.timer2_pause_button.Text = "暫停";
            this.timer2_pause_button.UseVisualStyleBackColor = true;
            this.timer2_pause_button.Click += new System.EventHandler(this.timer2_pause_button_Click);
            // 
            // timer2_zero_button
            // 
            this.timer2_zero_button.Location = new System.Drawing.Point(636, 142);
            this.timer2_zero_button.Name = "timer2_zero_button";
            this.timer2_zero_button.Size = new System.Drawing.Size(99, 48);
            this.timer2_zero_button.TabIndex = 4;
            this.timer2_zero_button.Text = "歸零";
            this.timer2_zero_button.UseVisualStyleBackColor = true;
            this.timer2_zero_button.Click += new System.EventHandler(this.timer2_zero_button_Click);
            // 
            // Form4_5_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 263);
            this.Controls.Add(this.timer2_zero_button);
            this.Controls.Add(this.timer2_pause_button);
            this.Controls.Add(this.timer2_start_bt);
            this.Controls.Add(this.timer_label2);
            this.Controls.Add(this.timer_label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4_5_8";
            this.Text = "Form4_5_8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timer_label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label timer_label2;
        private System.Windows.Forms.Button timer2_start_bt;
        private System.Windows.Forms.Button timer2_pause_button;
        private System.Windows.Forms.Button timer2_zero_button;
    }
}