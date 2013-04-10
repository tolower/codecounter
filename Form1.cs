using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CodeCounter
{
    public partial class Form1 : Form
    {
        string select_path = "";//项目位置
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开按钮、选择项目位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.ShowDialog();
            
            select_path = folderBrowserDialog1.SelectedPath;
            textBox1.Text = select_path;
        }
        /// <summary>
        /// 开始统计代码行数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConuter_Click(object sender, EventArgs e)
        {
            //string[] str_array = Directory.GetFileSystemEntries(select_path);//.Length.ToString();
            ////textBox2.Text = str;
            //foreach (string str in str_array)
            //{
            //    textBox2.Text += str+"          ";
            //}
            Counter c = new Counter();
            c.GetProjectResult(select_path);
            int codenumber = c.CodeLines;
            int filenumber = c.FileNumber;
            textBox2.Text = "项目中共有cs代码文件"+filenumber+"个。";
            textBox2.Text += "\r\n" + "代码一共有" + codenumber + "行";
        }
    }
}
