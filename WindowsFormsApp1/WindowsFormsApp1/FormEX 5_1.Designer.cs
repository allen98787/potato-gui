
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
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(66, 56);
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
            this.count_label.Location = new System.Drawing.Point(60, 119);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(300, 34);
            this.count_label.TabIndex = 1;
            this.count_label.Text = "請輸入1~100的數字";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(66, 188);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 22);
            this.tb_type.TabIndex = 2;
            // 
            // guess_button
            // 
            this.guess_button.Location = new System.Drawing.Point(214, 186);
            this.guess_button.Name = "guess_button";
            this.guess_button.Size = new System.Drawing.Size(75, 23);
            this.guess_button.TabIndex = 3;
            this.guess_button.Text = "確認";
            this.guess_button.UseVisualStyleBackColor = true;
            this.guess_button.Click += new System.EventHandler(this.guess_button_Click);
            // 
            // FormEX_5_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guess_button);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.Start_button);
            this.Name = "FormEX_5_1";
            this.Text = "FormEX_5_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.TextBox tb_type;
        public System.Windows.Forms.Button guess_button;
    }
}