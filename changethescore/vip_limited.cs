using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class vip_limited : Form
    {
        public vip_limited()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string sqlstr = "select vip_no,count(*) as limited from w_retail where vip_no <>'' and sa_time between '" + textBox1.Text.Trim() + "' and '" + textBox2.Text.Trim() + "' group by vip_no ";
            string constr = Login.score_2Constr;
            Db d = new Db();
            d.sdsBindTogdvMenthod(constr, sqlstr, "vip_limited", dgVip_limited);
            dgVip_limited.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void vip_limited_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToShortDateString();
            
        }

        private void btnLead_Click(object sender, EventArgs e)
        {

            if (dgVip_limited.Rows.Count > 0)
            {
                
                Login.saveToExcel(dgVip_limited);
            }
            else
            {
                MessageBox.Show("没有任何数据");
            }
        }
    }
}
