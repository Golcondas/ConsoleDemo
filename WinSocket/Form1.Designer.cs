namespace WinSocket
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Request = new System.Windows.Forms.Button();
            this.txt_Request = new System.Windows.Forms.TextBox();
            this.txt_Response = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Request
            // 
            this.btn_Request.Location = new System.Drawing.Point(12, 12);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(75, 23);
            this.btn_Request.TabIndex = 0;
            this.btn_Request.Text = "请求";
            this.btn_Request.UseVisualStyleBackColor = true;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // txt_Request
            // 
            this.txt_Request.Location = new System.Drawing.Point(12, 41);
            this.txt_Request.Multiline = true;
            this.txt_Request.Name = "txt_Request";
            this.txt_Request.Size = new System.Drawing.Size(216, 367);
            this.txt_Request.TabIndex = 1;
            // 
            // txt_Response
            // 
            this.txt_Response.Location = new System.Drawing.Point(257, 41);
            this.txt_Response.Multiline = true;
            this.txt_Response.Name = "txt_Response";
            this.txt_Response.Size = new System.Drawing.Size(216, 367);
            this.txt_Response.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 420);
            this.Controls.Add(this.txt_Response);
            this.Controls.Add(this.txt_Request);
            this.Controls.Add(this.btn_Request);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Request;
        private System.Windows.Forms.TextBox txt_Request;
        private System.Windows.Forms.TextBox txt_Response;
    }
}

