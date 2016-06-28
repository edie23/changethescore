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
    public partial class reportMain : Form
    {
        static string sqlstr = string.Empty;
        public reportMain()
        {
            InitializeComponent();
        }

        private void reportMain_Load(object sender, EventArgs e)
        {
            System.Drawing.Point pt = new Point(50, 30);
            int filenum = 0;
            DirectoryInfo dir  = new DirectoryInfo(Application.StartupPath.ToString());
            for (int i = 0; i < dir.GetFiles().Length; i++)
            {
                Button btn = new Button();
                if (dir.GetFiles()[i].Name.Contains("报表"))
                {
                    btn.Text = dir.GetFiles()[i].Name.ToString();
                    btn.Click += new EventHandler(reportClick);
                    btn.Location = new Point((filenum+1)*90, 30);
                    this.Controls.Add(btn);
                    filenum++;
                }
            }
        }
        private void reportClick(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath.ToString());
            foreach (FileInfo fl in dir.GetFiles())
            {
                if (fl.Name.Trim() == btn.Text.Trim())
                {
                    //FileStream fs = new FileStream(.ToString(), FileMode.Open);
                    StreamReader sr = new StreamReader(fl.FullName.ToString(),Encoding.Default);
                    //StreamReader sr = new StreamReader, Encoding.UTF8);
                     sr.BaseStream.Seek(0, SeekOrigin.Begin);
                     string line=sr.ReadLine();
                     while (line != null&&line!="")
                     {
                         Db d = new Db();
                         string constr = Login.score_2Constr;
                         frmReport frmr = new frmReport();
                         
                         DataGridView gdv = frmr.Controls.Find("dgv", true)[0] as DataGridView;
                         d.sdsBindTogdvMenthod(constr, line, "filltodgdv", gdv);
                         gdv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                         Label lblReport = frmr.Controls.Find("lblReport", true)[0] as Label;
                         lblReport.Text = btn.Text.Trim();
                         frmr.Show();
                         sr.Close();
                         break;
                         
                     }
                     
                }
            }
            
            
            
        }
    }
}
