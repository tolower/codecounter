namespace CodeCounter
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConuter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "打开要统计代码的项目位置";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(359, 33);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "打开button1";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "项目位置：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 112);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(403, 129);
            this.textBox2.TabIndex = 3;
            // 
            // btnConuter
            // 
            this.btnConuter.Location = new System.Drawing.Point(31, 72);
            this.btnConuter.Name = "btnConuter";
            this.btnConuter.Size = new System.Drawing.Size(98, 23);
            this.btnConuter.TabIndex = 4;
            this.btnConuter.Text = "开始统计代码>>";
            this.btnConuter.UseVisualStyleBackColor = true;
            this.btnConuter.Click += new System.EventHandler(this.btnConuter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "注：功能比较单一，我不知道你具体要实现怎样的功能，\r\n这个程序只实现了统计后缀名为.cs文件的功能\r\n也没有实现分开统计代码和注释，如果要实现这个功能\r\n需要在读" +
                "取每行内容的时候，判断是代码或者注释。然后分别计数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConuter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.Text = "C#代码统计工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConuter;
        private System.Windows.Forms.Label label2;
    }
}

