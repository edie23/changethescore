using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class vip_retail : Form
    {
        public vip_retail()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //string vip_limit="";
            string sqlstr=string.Empty;
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                sqlstr = "select vip_no as '会员',sum(amount_total) as '消费总额' from w_retail where (vip_no between '" + textBox1.Text.Trim() + "' and '" + textBox2.Text.Trim() + "') and (sa_time between '" + DateTime.Parse(dateTimePicker1.Text).Date.AddDays(1).ToShortDateString() + "' and '" + DateTime.Parse(dateTimePicker2.Text).Date.AddDays(1).ToShortDateString() + "') group by vip_no order by vip_no";
            }
            else
            {
                sqlstr = "select vip_no as '会员',sum(amount_total) as '消费总额' from w_retail where vip_no<>'' and (sa_time between '" + DateTime.Parse(dateTimePicker1.Text).Date.ToShortDateString() + "' and '" + DateTime.Parse(dateTimePicker2.Text).Date.AddDays(1).ToShortDateString() + "') group by vip_no order by vip_no";
            }
            Db d = new Db();
            d.sdsBindTogdvMenthod(Login.score_2Constr,sqlstr, "filltodgdv", dgdv);
            //dgdv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            if (dgdv.Rows.Count> 1)
            {
                dgdv.Rows[dgdv.Rows.Count - 1].Cells[0].Value = "合计";
                Login.sumColumnToFooterText(dgdv, 1);
            }
           
        }
    }
}
