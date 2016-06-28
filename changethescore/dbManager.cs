using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class dbManager : Form
    {
        public dbManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sucsum=0;
            string sqlstr = "select name from sysdatabases where name <>'master' and name<>'tempdb' and name<>'model' and name<>'msdb' and name<>'Northwind' and name <>'pubs' and name<>'score_2_customers' and name like '"+txtDbName.Text.Trim()+"%'";
            string sqlProStr = txtSql.Text.Trim();
            sqlProStr = sqlProStr.Replace("\r", " ").Replace("\n"," ");
            Db d=new Db();
            DataSet ds=d.readbyad(Login.managerConstr,sqlstr,"dbArray");
            if (ds.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string sqlcon = "server=" + txtServerName.Text.Trim() + ";uid=" + txtUid.Text.Trim() + ";pwd=" + txtPwd.Text.Trim() + ";database=" + ds.Tables[0].Rows[i][0].ToString().Trim() + ";";
                    int suc=d.Nonquery(sqlcon, sqlProStr);
                    if (suc != 0)
                    { sucsum++; }
                    else
                    {
                        MessageBox.Show("在更新"+ds.Tables[0].Rows[i][0].ToString()+"出错了");
                        return;
                    }
                }
            }
            MessageBox.Show("已成功更新"+sucsum.ToString()+"个数据库");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Db d = new Db();
            d.Constr = Login.score_2Constr;
            int suc = d.Nonquery(d.Constr, txtSql.Text.Trim());
            if (suc > 0)
            {
                MessageBox.Show("成功");
            }
            else
            {
 
            }

        }

        private void dbManager_Load(object sender, EventArgs e)
        {

        }
    }
}
