
namespace WindowsFormsApp1
{
    partial class FormEX_5_1
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
            this.Start_button = new System.Windows.Forms.Button();
            this.count_label = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.guess_button = new System.Windows.Forms.Button();
            this.PB_point1 = new System.Windows.Forms.PictureBox();
            this.PB_point2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_point1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_point2)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(328, 123);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(130, 23);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "開始終極密碼";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("新細明體", 25F);
            this.count_label.Location = new System.Drawing.Point(261, 305);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(253, 34);
            this.count_label.TabIndex = 1;
            this.count_label.Text = "請按下開始按鈕";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(247, 372);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 22);
            this.tb_type.TabIndex = 2;
            // 
            // guess_button
            // 
            this.guess_button.Location = new System.Drawing.Point(353, 371);
            this.guess_button.Name = "guess_button";
            this.guess_button.Size = new System.Drawing.Size(75, 23);
            this.guess_button.TabIndex = 3;
            this.guess_button.Text = "確認";
            this.guess_button.UseVisualStyleBackColor = true;
            this.guess_button.Click += new System.EventHandler(this.guess_button_Click);
            // 
            // PB_point1
            // 
            this.PB_point1.Image = global::WindowsFormsApp1.Properties.Resources.leo_pointing;
            this.PB_point1.Location = new System.Drawing.Point(464, 90);
            this.PB_point1.Name = "PB_point1";
            this.PB_point1.Size = new System.Drawing.Size(228, 189);
            this.PB_point1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_point1.TabIndex = 5;
            this.PB_point1.TabStop = false;
            this.PB_point1.Visible = false;
            // 
            // PB_point2
            // 
            this.PB_point2.Image = global::WindowsFormsApp1.Properties.Resources.Spider_Man_meme;
            this.PB_point2.Location = new System.Drawing.Point(154, 71);
            this.PB_point2.Name = "PB_point2";
            this.PB_point2.Size = new System.Drawing.Size(157, 193);
            this.PB_point2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_point2.TabIndex = 4;
            this.PB_point2.TabStop = false;
            this.PB_point2.Visible = false;
            // 
            // FormEX_5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PB_point1);
            this.Controls.Add(this.PB_point2);
            this.Controls.Add(this.guess_button);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.Start_button);
            this.Name = "FormEX_5_1";
            this.Text = "FormEX_5_1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_point1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_point2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.TextBox tb_type;
        public System.Windows.Forms.Button guess_button;
        private System.Windows.Forms.PictureBox PB_point2;
        private System.Windows.Forms.PictureBox PB_point1;
    }
}