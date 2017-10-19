namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.lal_res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "龙珠直播间地址";
            // 
            // txt_url
            // 
            this.txt_url.Enabled = false;
            this.txt_url.Location = new System.Drawing.Point(107, 22);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(500, 21);
            this.txt_url.TabIndex = 1;
            this.txt_url.Text = "http://y.longzhu.com/y191527?style=v";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(1, 127);
            this.txt_res.Multiline = true;
            this.txt_res.Name = "txt_res";
            this.txt_res.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_res.Size = new System.Drawing.Size(619, 314);
            this.txt_res.TabIndex = 4;
            // 
            // lal_res
            // 
            this.lal_res.AutoSize = true;
            this.lal_res.Location = new System.Drawing.Point(12, 102);
            this.lal_res.Name = "lal_res";
            this.lal_res.Size = new System.Drawing.Size(83, 12);
            this.lal_res.TabIndex = 3;
            this.lal_res.Text = "最初在线人数:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.lal_res);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Label lal_res;
    }
}

