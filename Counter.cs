using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeCounter
{
    
    /// <summary>
    /// 统计代码的类，从一个文件夹里面。统计出所有代码文件中代码的行数
    /// </summary>
    class Counter
    {
        private int _code_lines;
        //代码行数
        public int CodeLines
        {
            get { return _code_lines; }
        }
        private int _comment_lines;
        //注释行数
        public int CommentLines
        {
            get { return _comment_lines; }
        }
        private int _file_number;
        //代码文件个数
        public int FileNumber
        {
            get { return _file_number; }
        }
        public Counter()
        {
            _code_lines = 0;
            _comment_lines = 0;
        }
        /// <summary>
        /// 获取项目的全部代码统计情况,
        /// 先获取项目下的子目录集合，遍历当前子目录，用递归的方法，遍历完子目录下面的子目录。
        /// 然后获取后缀名为cs的代码文件集合，读取文件的行数
        /// </summary>
        /// <param name="folderpath"></param>
        public void GetProjectResult(string folderpath)
        {
            DirectoryInfo folder = new DirectoryInfo(folderpath);
            //string str = folder.ToString();
            try
            {
                //当前子目录集合
                DirectoryInfo[] folders = folder.GetDirectories();
                for (int i = 0; i < folders.Length; i++)
                {
                    //递归调用，遍历所有的子目录下的子目录，有的文件夹会有权限限制，会出现读取权限异常
                    GetProjectResult(folders[i].FullName);
                }
                //获取当前文件夹下的后缀名为.cs的文件集合
                FileInfo[] files = folder.GetFiles("*.cs");
                for (int i = 0; i < files.Length; i++)
                {
                    _file_number++;
                    string file_name = folderpath + "\\" + files[i].Name;
                    GetCodeFileResult(file_name);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        /// <summary>
        /// 获取单个代码文件的代码统计情况
        /// </summary>
        /// <param name="filename"></param>
        public void GetCodeFileResult(string filename)
        {
            string line="";//每次从文件中读取一行数据
            StreamReader sr=new StreamReader(filename);
            //读完文件中行，计数增加1、暂时未区分代码和注释。
            //如果要区分代码和注释，读入一行内容后，需要进行判断，用正则表达式来验证估计不错
            while ((line=sr.ReadLine())!=null)
            {
                _code_lines++;
            }
        }
    }
}
