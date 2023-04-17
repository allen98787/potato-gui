
namespace WindowsFormsApp1
{
    partial class form3_4_17_exam1
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
            this.C_label1 = new System.Windows.Forms.Label();
            this.C_textBox = new System.Windows.Forms.TextBox();
            this.transform = new System.Windows.Forms.Button();
            this.F_label2 = new System.Windows.Forms.Label();
            this.F_label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // C_label1
            // 
            this.C_label1.AutoSize = true;
            this.C_label1.Font = new System.Drawing.Font("新細明體", 24F);
            this.C_label1.Location = new System.Drawing.Point(23, 60);
            this.C_label1.Name = "C_label1";
            this.C_label1.Size = new System.Drawing.Size(127, 32);
            this.C_label1.TabIndex = 0;
            this.C_label1.Text = "攝氏(C):";
            this.C_label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // C_textBox
            // 
            this.C_textBox.Font = new System.Drawing.Font("新細明體", 24F);
            this.C_textBox.Location = new System.Drawing.Point(156, 57);
            this.C_textBox.Name = "C_textBox";
            this.C_textBox.Size = new System.Drawing.Size(117, 46);
            this.C_textBox.TabIndex = 1;
            // 
            // transform
            // 
            this.transform.Font = new System.Drawing.Font("新細明體", 24F);
            this.transform.Location = new System.Drawing.Point(105, 122);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(113, 39);
            this.transform.TabIndex = 2;
            this.transform.Text = "轉換";
            this.transform.UseVisualStyleBackColor = true;
            this.transform.Click += new System.EventHandler(this.transform_Click);
            // 
            // F_label2
            // 
            this.F_label2.AutoSize = true;
            this.F_label2.Font = new System.Drawing.Font("新細明體", 24F);
            this.F_label2.Location = new System.Drawing.Point(12, 191);
            this.F_label2.Name = "F_label2";
            this.F_label2.Size = new System.Drawing.Size(124, 32);
            this.F_label2.TabIndex = 3;
            this.F_label2.Text = "華氏(F):";
            // 
            // F_label3
            // 
            this.F_label3.AutoSize = true;
            this.F_label3.Font = new System.Drawing.Font("新細明體", 24F);
            this.F_label3.Location = new System.Drawing.Point(156, 191);
            this.F_label3.Name = "F_label3";
            this.F_label3.Size = new System.Drawing.Size(175, 32);
            this.F_label3.TabIndex = 4;
            this.F_label3.Text = "請輸入攝氏";
            // 
            // form3_4_17_exam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_label3);
            this.Controls.Add(this.F_label2);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.C_textBox);
            this.Controls.Add(this.C_label1);
            this.Name = "form3_4_17_exam1";
            this.Text = "form3_4_17_exam1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C_label1;
        private System.Windows.Forms.TextBox C_textBox;
        private System.Windows.Forms.Button transform;
        private System.Windows.Forms.Label F_label2;
        private System.Windows.Forms.Label F_label3;
    }
}