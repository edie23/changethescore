using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Db db = new Db();
            //string sqlstr = @"select name from sysdatabases where name <>'master' and name<>'tempdb' and name<>'model' and name<>'msdb' and name<>'Northwind' and name <>'pubs' and name<>'score_2_customers' and name like '%score%'";
            //db.sdsBindTogdvMenthod(Login.managerConstr,sqlstr, "class_3", cmbDb, "name", "name");
            txtEmp_no.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtEmp_no.Text.Trim() == "system")
            {
                string sqlLogin = "select 1 from f_sysparm where sys_pass='" + txtPass.Text.Trim() + "'";
                Db d = new Db();
                object o = d.readGetFrist(Login.score_2Constr, sqlLogin);
                if (Convert.ToInt32(o) == 1)
                {
                    //frmMain fm = new frmMain();
                    frmMain frmmain = new frmMain();
                    frmmain.Show();
                    this.Hide();
                    //fm.Show();
                }
                else
                {
                    MessageBox.Show("密码错误");
                    txtEmp_no.Focus();
                }
            }
            else 
            {
                MessageBox.Show("该工号没用进入权限");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Login.dataname = cmbDb.SelectedValue.ToString().Trim();
        }
    }
}
