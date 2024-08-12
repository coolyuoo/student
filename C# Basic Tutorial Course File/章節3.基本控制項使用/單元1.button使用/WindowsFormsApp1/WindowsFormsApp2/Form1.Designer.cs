namespace WindowsFormsApp2
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 63);
            this.button3.TabIndex = 7;
            this.button3.Text = "奇怪的滑鼠點擊事件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(63, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 63);
            this.button4.TabIndex = 6;
            this.button4.Text = "滑動事件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "點擊事件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "鍵盤事件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(318, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 64);
            this.button5.TabIndex = 10;
            this.button5.Text = "鍵盤事件2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button5_KeyDown);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(318, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 64);
            this.button6.TabIndex = 11;
            this.button6.Text = "Tab 可切換控制項";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "只會用到Click";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}

