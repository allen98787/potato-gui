
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_to_text = new System.Windows.Forms.Button();
            this.exam1_button = new System.Windows.Forms.Button();
            this.Extra_button1 = new System.Windows.Forms.Button();
            this.Timer_button = new System.Windows.Forms.Button();
            this.checkbox_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button 3/13";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Call form 3/13";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_to_text
            // 
            this.button_to_text.Location = new System.Drawing.Point(175, 158);
            this.button_to_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_to_text.Name = "button_to_text";
            this.button_to_text.Size = new System.Drawing.Size(161, 56);
            this.button_to_text.TabIndex = 13;
            this.button_to_text.Text = "textbox  4/10  \r\n計算機5/12";
            this.button_to_text.UseVisualStyleBackColor = true;
            this.button_to_text.Click += new System.EventHandler(this.button_to_text_Click);
            // 
            // exam1_button
            // 
            this.exam1_button.Location = new System.Drawing.Point(193, 232);
            this.exam1_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exam1_button.Name = "exam1_button";
            this.exam1_button.Size = new System.Drawing.Size(163, 29);
            this.exam1_button.TabIndex = 14;
            this.exam1_button.Text = "期中考 4/17";
            this.exam1_button.UseVisualStyleBackColor = true;
            this.exam1_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Extra_button1
            // 
            this.Extra_button1.Location = new System.Drawing.Point(384, 172);
            this.Extra_button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Extra_button1.Name = "Extra_button1";
            this.Extra_button1.Size = new System.Drawing.Size(176, 29);
            this.Extra_button1.TabIndex = 15;
            this.Extra_button1.Text = "終極密碼 5/1";
            this.Extra_button1.UseVisualStyleBackColor = true;
            this.Extra_button1.Click += new System.EventHandler(this.Extra_button1_Click);
            // 
            // Timer_button
            // 
            this.Timer_button.Location = new System.Drawing.Point(27, 300);
            this.Timer_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Timer_button.Name = "Timer_button";
            this.Timer_button.Size = new System.Drawing.Size(152, 38);
            this.Timer_button.TabIndex = 16;
            this.Timer_button.Text = "計時器 5/8";
            this.Timer_button.UseVisualStyleBackColor = true;
            this.Timer_button.Click += new System.EventHandler(this.Timer_button_Click);
            // 
            // checkbox_button
            // 
            this.checkbox_button.Location = new System.Drawing.Point(217, 290);
            this.checkbox_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkbox_button.Name = "checkbox_button";
            this.checkbox_button.Size = new System.Drawing.Size(275, 48);
            this.checkbox_button.TabIndex = 17;
            this.checkbox_button.Text = "期末專案 6/12       checkbox   5/15 \r\n版面設計(panel dock ) 5/22   \r\n\r\n";
            this.checkbox_button.UseVisualStyleBackColor = true;
            this.checkbox_button.Click += new System.EventHandler(this.checkbox_button_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 125);
            this.panel1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 290);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 48);
            this.button3.TabIndex = 19;
            this.button3.Text = "期末專案Extra 菜單讀取";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 588);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkbox_button);
            this.Controls.Add(this.Timer_button);
            this.Controls.Add(this.Extra_button1);
            this.Controls.Add(this.exam1_button);
            this.Controls.Add(this.button_to_text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_to_text;
        private System.Windows.Forms.Button exam1_button;
        private System.Windows.Forms.Button Extra_button1;
        private System.Windows.Forms.Button Timer_button;
        private System.Windows.Forms.Button checkbox_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}

