using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class getAbb : Form
    {
        public getAbb()
        {
            InitializeComponent();
        }

        private void getAbb_Load(object sender, EventArgs e)
        {
            string sqlstr = @"select ano,article_name, abbr_name from f_article where abbr_name=''" ;
            string constr = Login.score_2Constr;
            Db d = new Db();
            d.sdsBindTogdvMenthod(constr, sqlstr, "filltodgdv", gdvArticle);
            gdvArticle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getZjc gz=new getZjc();
            for (int i = 0; i <gdvArticle.Rows.Count; i++)
            {
                try
                {
                    gdvArticle.Rows[i].Cells[2].Value = gz.GetPYString(gdvArticle.Rows[i].Cells[1].Value.ToString().Trim()).Replace("*","");
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlstr="";
            Db d=new Db();
            for(int i=0;i<gdvArticle.Rows.Count-1;i++)
            {
                sqlstr="update f_article set abbr_name='"+gdvArticle.Rows[i].Cells[2].Value.ToString()+"' where ano='"+gdvArticle.Rows[i].Cells[0].Value.ToString().Trim()+"'";
             
                    int suc = d.Nonquery(Login.score_2Constr, sqlstr);
                   

            }
            sqlstr = @"select ano,article_name, abbr_name from f_article where abbr_name=''";
            string constr = Login.score_2Constr;
            d.sdsBindTogdvMenthod(constr, sqlstr, "filltodgdv", gdvArticle);
            gdvArticle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            MessageBox.Show("结束，剩下未更新");
        }
    }
}
