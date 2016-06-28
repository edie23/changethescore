using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace changethescore
{
    public partial class changeFileName : Form
    {
        public changeFileName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DirectoryInfo inf = new DirectoryInfo();
            
                    Db d = new Db();
                    d.Constr = "server=.;database=asst_mijia;uid=sa;pwd=88808172";
                    string sqlstr = "select ano from f_article order by ano";
                    DataTable dt = d.readbyad("server=.;database=asst_mijia;uid=sa;pwd=88808172", sqlstr);
            String[] files = Directory.GetFiles(txtPath.Text.Trim());
            for (int i=0;i<files.Length;i++)
            {
                // 最后一个"\" 
                int lastpath =files[i].LastIndexOf("\\");
                // 最后一个"." 
                int lastdot = files[i].LastIndexOf(".");
                // 纯文件名字长度 
                int length = lastdot - lastpath - 1;
                // 文件目录字符串 xx\xx\xx\ 
                String beginpart = files[i].Substring(0, lastpath + 1);
                // 纯文件名字 
                String namenoext = dt.Rows[i][0].ToString().Trim();
                // 扩展名 
                String ext = files[i].Substring(lastdot);


                String fullnewname = beginpart + namenoext+ext;

                    // 改名 
                    File.Move( files[i], fullnewname);

                }
                //try
                //{
                //    for (int i = 0; i < files.Length; i++)
                //    {
                //       files[i].MoveTo(dt.Rows[i][0].ToString().Trim());

                //    }
                //    MessageBox.Show("文件名修改结束", "友情提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //catch
                //{
                //}
            }

        private void changeFileName_Load(object sender, EventArgs e)
        {

        }
        
    }
}
