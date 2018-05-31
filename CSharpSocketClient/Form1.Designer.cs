namespace CSharpSocketClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.TextBox_IPAddress = new System.Windows.Forms.TextBox();
            this.TextBox_PortNum = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_PortNum);
            this.groupBox1.Controls.Add(this.TextBox_IPAddress);
            this.groupBox1.Controls.Add(this.Btn_Connect);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器参数";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "IP地址";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(320, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 18);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "端口号";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(12, 150);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(750, 150);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = "";
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Location = new System.Drawing.Point(12, 350);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(750, 150);
            this.RichTextBox2.TabIndex = 2;
            this.RichTextBox2.Text = "";
            this.RichTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox2_KeyPress);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(604, 44);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(75, 25);
            this.Btn_Connect.TabIndex = 2;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // TextBox_IPAddress
            // 
            this.TextBox_IPAddress.Location = new System.Drawing.Point(88, 44);
            this.TextBox_IPAddress.Name = "TextBox_IPAddress";
            this.TextBox_IPAddress.Size = new System.Drawing.Size(152, 28);
            this.TextBox_IPAddress.TabIndex = 3;
            this.TextBox_IPAddress.Text = "127.0.0.1";
            // 
            // TextBox_PortNum
            // 
            this.TextBox_PortNum.Location = new System.Drawing.Point(388, 44);
            this.TextBox_PortNum.Name = "TextBox_PortNum";
            this.TextBox_PortNum.Size = new System.Drawing.Size(147, 28);
            this.TextBox_PortNum.TabIndex = 4;
            this.TextBox_PortNum.Text = "65535";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 129);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 18);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "聊天记录:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 329);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 18);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "输入框";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.RichTextBox2);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox_PortNum;
        private System.Windows.Forms.TextBox TextBox_IPAddress;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.RichTextBox RichTextBox2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
    }
}

