using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class asstChangeClass : Form
    {
        public asstChangeClass()
        {
            InitializeComponent();
        }

        private void asstChangeClass_Load(object sender, EventArgs e)
        {
            string sqlstr = "select name from sysdatabases where name <>'master' and name<>'tempdb' and name<>'model' and name<>'msdb' and name<>'Northwind' and name <>'pubs' and  name like 'asst%'";
            Db d = new Db();
            DataSet ds = d.readbyad("server=.;uid=sa;pwd=88808172;database=master;", sqlstr, "dbasst");
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (ds.Tables[0].Rows.Count == 1)
                {

                    label1.Text = "数据库已加载，可以操作了";

                    d.sdsBindTogdvMenthod("server=.;uid=sa;pwd=88808172;database=master;", sqlstr, "asstItem", comboBox1,"name","name");
                    
                    
                }
                else
                {
                    label1.Text = "找到多个小食神数据库，请选择再操作";
                    d.sdsBindTogdvMenthod("server=.;uid=sa;pwd=88808172;database=master;", sqlstr, "asstItem", comboBox1,"name","name");
                    
                }

            }
            else 
            {
                label1.Text = "未找到小食神数据库，或数据库名不规范";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sqlstr = "select class_3_no,class_3_name from f_class_3";
            Db d = new Db();
            if (comboBox1.SelectedValue!=null)
            {
                d.sdsBindTogdvMenthod("server=.;uid=sa;pwd=88808172;database=" + comboBox1.SelectedValue.ToString().Trim() + ";", sqlstr, "asst_class", comboBox2, "class_3_name", "class_3_no");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Db d = new Db();
            string selectvalue=comboBox2.SelectedValue.ToString().Trim();
            string sqlstr = "update f_article set class_no='" + selectvalue + "' where ano='"+ textBox1.Text.Trim() +"'";
            int suc=d.Nonquery("server=.;uid=sa;pwd=88808172;database=" + comboBox1.SelectedValue.ToString().Trim() + ";", sqlstr);
            if (suc == 1)
            {
                MessageBox.Show("更改分类成功");
            }
            else
            {
                MessageBox.Show("更改分类失败");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
