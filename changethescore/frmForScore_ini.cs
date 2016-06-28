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
    public partial class frmForScore_ini : Form
    {
        public frmForScore_ini()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(@"c:\Program Files\杭州思科电子有限公司\Score_2\score.ini");
            FileStream afile = new FileStream(@"c:\Program Files\杭州思科电子有限公司\Score_2\score.ini", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(afile);
            sw.WriteLine("[Database]");
            sw.WriteLine("DBMS = MSS Microsoft SQL Server 6.x");
            sw.WriteLine("Database=" + textBox1.Text.Trim());
            Login.score_2Constr = "server=.;uid=sa;pwd=88808172;database="+ textBox1.Text.Trim();
            sw.WriteLine("ServerName =" + textBox2.Text.Trim());
            sw.WriteLine("LogId =" + textBox3.Text.Trim());
            sw.WriteLine("Logpass =" + textBox4.Text.Trim());
            sw.Close();
            //File.Move(@"E:\Score_2\score.txt",@"E:\Score_2\score.ini");
            MessageBox.Show("修改成功");
            formdiv fd = new formdiv();
            fd.Show();
        }

        private void frmForScore_ini_Load(object sender, EventArgs e)
        {

        }
    }

}
