using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections;
namespace changethescore
{
    public partial class score_2_steup : Form
    {
        public score_2_steup()
        {
            InitializeComponent();
        }


        public  void GetFileName(string DirName, string FileName)//递归查找指定目录下的文件
        {
            //文件夹信息
            ArrayList arr = new ArrayList();
            DirectoryInfo dir = new DirectoryInfo(DirName);
            //如果非根路径且是系统文件夹则跳过
            if (null != dir.Parent && dir.Attributes.ToString().IndexOf("System") > -1)
            {
                return;
            }
            //取得所有文件
            FileInfo[] finfo = dir.GetFiles();
            string fname = string.Empty;
            for (int i = 0; i < finfo.Length; i++)
            {
                fname = finfo[i].Name;
                label3.Text = finfo[i].FullName;
                //判断文件是否包含查询名
                //string extendName = System.IO.Path.GetExtension(myFile.FileName).ToLower();
                if (fname.IndexOf(FileName) > -1)
                {
                    if ((finfo[i].DirectoryName.ToLower().IndexOf("data")>-1 || finfo[i].Name.ToLower().IndexOf("score") > -1)&&finfo[i].LastWriteTime.AddDays(7)>DateTime.Now)
                    {
                        listBox1.Items.Add(finfo[i].FullName);
                    }
                    else
                    {
                        listBox2.Items.Add(finfo[i].FullName);
                    } 
                    //arr.Add(finfo[i].FullName);
                    ////Console.WriteLine(finfo[i].FullName);

                }
            }
            //取得所有子文件夹
            DirectoryInfo[] dinfo = dir.GetDirectories();
            for (int i = 0; i < dinfo.Length; i++)
            {
                //查找子文件夹中是否有符合要求的文件
                GetFileName(dinfo[i].FullName, FileName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Process process = new Process();
            //process.StartInfo.FileName = "D:\\test.bat";
            //process.StartInfo.UseShellExecute = true;

            ////这里相当于传参数 
            //process.StartInfo.Arguments = "hello world";
            //process.Start();

            ////测试同步执行 
            //process.WaitForExit();

            ////测试第二次运行 
            //process.StartInfo.Arguments = "hello heqichang";
            //process.Start();
            //process.WaitForExit(); 
            DriveInfo[] d = DriveInfo.GetDrives();
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i].DriveType == DriveType.Fixed && d[i].Name.ToLower()!="c:\\")
                {
                    GetFileName(d[i].Name, ".mdf");
                }
            }
            
                //foreach (DriveInfo di in d)
                //{
                //    if (di.DriveType == DriveType.Fixed)
                //    {
                //        arr.Add(di.Name);
                //    }
                //}
            
        }
    }
}
