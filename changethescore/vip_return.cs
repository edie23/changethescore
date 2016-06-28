using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class vip_return : Form
    {
        public vip_return()
        {
            InitializeComponent();
        }


        public void vip_return_m()
        {
            int count = 0;
            int index = 0;
            string sqlstr = string.Empty;
            Db d = new Db();
            while (index < dataGridView1.Rows.Count - 1)
            {
                sqlstr = " insert into vip_returnAmount(monthNum,vip_no,return_amount,old_amount) select '" + dateTimePicker1.Text.Trim() + "','" + dataGridView1.Rows[index].Cells["会员号"].Value.ToString().Trim() + "'," + maskedTextBox1.Text + ",amount_remain from f_vip where vip_no='" + dataGridView1.Rows[index].Cells["会员号"].Value.ToString().Trim() + "'  update f_vip set amount_remain=amount_remain+" + maskedTextBox1.Text.Trim() + "where vip_no='" + dataGridView1.Rows[index].Cells["会员号"].Value.ToString().Trim() + "'";
                int suc=d.Nonquery(Login.score_2Constr, sqlstr);
                if (suc > 0)
                {
                    dataGridView1.Rows.RemoveAt(index);
                    count++;
                }
                
            }
            MessageBox.Show("共返利给"+count+"位会员");
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime time = DateTime.Parse(dateTimePicker1.Text);
            string sqlstr = "select vip_no as '会员号',count(*) as '刷卡消费次数' from w_retail_vip b where MONTH(sa_time)=" + dateTimePicker1.Text.Substring(4, 2) + " and year(sa_time)=" + dateTimePicker1.Text.Substring(0, 4) + " and vip_no not in (select vip_no from vip_returnAmount where vip_no=b.vip_no and monthNum=" + dateTimePicker1.Text + ") group by vip_no having count(*)>="+maskedTextBox2.Text.Trim();
            Db d = new Db();
            d.sdsBindTogdvMenthod(Login.score_2Constr, sqlstr, "filltodgdv", dataGridView1);
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowsDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            if (dataGridView1.Rows.Count > 1)
            {
                label2.Visible = true;
                maskedTextBox1.Visible = true;
                label3.Visible = true;
                button2.Visible = true;
              
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "合计";

                int sum = 0;
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[j].Cells[1].Value.ToString());
                }
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = sum.ToString();

            }
            else
            {
                label2.Visible = false;
                maskedTextBox1.Visible = false;
                label3.Visible = false;
                button2.Visible = false;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vip_return_m();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlstr = "select monthNum as 返利月份,vip_no as 会员号,return_amount as 返利金额,old_amount as 原额,operatrDate as 操作 from vip_returnAmount order by monthNum desc,vip_no ";
            Db d = new Db();
            d.sdsBindTogdvMenthod(Login.score_2Constr, sqlstr, "filltodgdv", dataGridView1);
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowsDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "合计";
                Login.sumColumnToFooterText(dataGridView1, 2);
                Login.sumColumnToFooterText(dataGridView1, 3);

            }
           
                label2.Visible = false;
                maskedTextBox1.Visible = false;
                label3.Visible = false;
                button2.Visible = false;
                

        }
    }
}
