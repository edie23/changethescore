using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace changethescore
{
    public partial class asstInstore : Form
    {
        
        public asstInstore()
        {
            InitializeComponent();
            bindC();
            Db db = new Db();
            db.bindDrop(Login.asstConstr, "select dept_name,dept_no from f_dept", comboBox1, "所有部门");
            comboBox1.SelectedValue = "所有部门";
        }

        protected void bindC()
        {
            Db d = new Db();
            ArrayList arrValue = new ArrayList();
            arrValue.Add("ano");
            arrValue.Add("dealer_no");
            arrValue.Add("article_name");
          
            //arrValue.Add("%article_name%");
            arrValue.Add("abbr_name");
            arrValue.Add("specific");
            arrValue.Add("price_retail");
            arrValue.Add("price_in");
            arrValue.Add("barcode");
            //arrValue.Add("ano_old");
            //arrValue.Add("com_no");

            //arrValue.Add("contract_no");
            arrValue.Add("feature1");
            ArrayList arrText = new ArrayList();
            arrText.Add("商品编号");
            arrText.Add("供货商号");
            arrText.Add("商品名称");
            
            //arrText.Add("商品名称包含");
            arrText.Add("助记词");
            arrText.Add("规格");
            arrText.Add("零售价");
            arrText.Add("进价");
            arrText.Add("条形码");
            //arrText.Add("原编号");
            //arrText.Add("货号");

            //arrText.Add("合同号");
            arrText.Add("特征1");
            d.dropBind(arrText, arrValue, comboBox2);//绑定下拉菜单
        }

        protected void gridbing()
        {
           
            string dept = comboBox1.SelectedValue.ToString().Trim();
            string str = textBox1.Text.Trim();
            string conStr = comboBox2.SelectedValue.ToString().Trim();
            if (dept == "所有部门")
            {
                dept = "";
            }
            else
            {
                dept = " and dept_no='" + dept + "'";
            }
            if (conStr != "" && str != "")//得到查询方式的选择
            {

                str = " and f_article." + conStr + " like '%" + str + "%'";
            }
            else
            {
                str = "";
            }

            string sqlstr = string.Empty;
            DateTime time = new DateTime(1980, 1, 1);
            Db d = new Db();
            DataTable dt = new DataTable();
            //proname = " and sa_article.ano in(select ano from b_promotion_article where pro_name='" + proname + "')";
            //sqlstr = "  SELECT   sa_article.ano as '商品编号',f_article.article_name as '名称',  '总销售数量' = sum(sa_article.qty),'总销售成本' = sum(cost),'总销售金额' = sum(amount),'总折扣' = sum(disc),'进价成本差'= Convert(decimal(18,2),sum(sa_article.qty*f_article.price_in))-sum(cost) FROM f_article,  sa_article,b_promotion_article  WHERE sa_article.ano=b_promotion_article.ano and b_promotion_article.pro_name='" + proname + "' and ( sa_article.ano = f_article.ano )   and ( sa_date between " + DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString() + " and " + DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString() + " ) " + dept + str + " GROUP BY sa_article.ano,  f_article.article_name,  f_article.specific,  f_article.unit_st, f_article.dealer_no ORDER BY f_article.dealer_no,sa_article.ano ASC";
            sqlstr = "select a.ano as 商品编号,article_name as 商品名称,specific as 规格,unit_st as 单位, avg(price) as 平均进价,max(price) as 最高价,min(price) as 最低价 from (select vno,ano,price from w_in_store_detail where vno in (select vno from w_in_store where (in_date between  " + DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString() + " and " + DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString() +") "+dept+") group by vno,ano,price) a,f_article where a.ano=f_article.ano "+str+"  group by a.ano,article_name,unit_st,specific";
            d.sdsBindTogdvMenthod(Login.asstConstr, sqlstr, "filltodgdv", dataGridView1);
            //dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowsDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            if (dataGridView1.Rows.Count > 0)
            {
                button1.Visible = true;
                //btnOk.Visible = true;
                btnPrint.Visible = true;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "合计";
                //for (int i = 4; i < 7; i++)
                //{
                //    Login.sumColumnToFooterText(dataGridView1, i);
                //}

            }
            else
            {
                button1.Visible = false;
                //btnOk.Visible = false;
                btnPrint.Visible = false;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            gridbing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //dataGridView1.Columns.RemoveAt(0);
                Login.saveToExcel(dataGridView1);
            }
            else
            {
                MessageBox.Show("没有任何数据");
            }
        }

       

     

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
             Login.printDataGridView( dataGridView1, "入库分析","入库分析");
        }
    }
}

