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
    public partial class frmSa_article : Form
    {
        public frmSa_article()
        {
            InitializeComponent();
            bindC();
            Db db = new Db();
            db.bindDrop(Login.score_2Constr, "select dept_name,dept_no from f_dept", comboBox1, "所有部门");
            db.bindDrop(Login.score_2Constr, "select class_3_name,class_3_no from f_class_3", comboBox3, "所有分类");
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
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
            string class_3_no=comboBox3.SelectedValue.ToString().Trim();
            string str = textBox1.Text.Trim();
            string conStr = comboBox2.SelectedValue.ToString().Trim();
            if (dept == "所有部门")
            {
                dept = "";
            }
            else
            {
                dept = " and sa_article.dept_no='" + dept + "'";
            }
            if (class_3_no == "所有分类")
            {
                class_3_no = "";
            }
            else
            {
                class_3_no=" and class_3_no='"+class_3_no+"'";
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
            sqlstr = "   SELECT sa_article.ano as '商品编号',f_article.article_name as '商品名称',f_article.specific as '规格',  f_article.unit_st as '单位',price_retail as '零售价','总销售数量'= Convert(decimal(18,2), sum(qty)) ,'总成本' = sum(cost), '总销售额' = sum(amount) ,'总折扣额'= sum(disc) ,'毛利'= sum(gain),'毛利率' =Convert(decimal(18,2),case when sum(amount) + sum(disc) = 0 then 0	 when (sum(amount)) <> 0 then sum(gain) / (sum(amount) ) end),  f_article.barcode as 条形码   FROM f_article,  sa_article WHERE ( sa_article.ano = f_article.ano )   and	  ( sa_date between " + DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString() + " and " + DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString() + " ) " + dept + str +class_3_no+ " 	   GROUP BY sa_article.ano,  f_article.article_name,  f_article.specific,  f_article.unit_st,price_retail,f_article.tax_rate,f_article.unit_rate,f_article.barcode   ORDER BY sa_article.ano ASC";
            d.sdsBindTogdvMenthod(Login.score_2Constr, sqlstr, "filltodgdv", dataGridView1);
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
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "合计";
                for (int i = 5; i < 10; i++)
                {
                    Login.sumColumnToFooterText(dataGridView1, i);
                }

            }
            else
            {
                button1.Visible = false;
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
                dataGridView1.Columns.RemoveAt(0);
                Login.saveToExcel(dataGridView1);
            }
            else
            {
                MessageBox.Show("没有任何数据");
            }
        }
    }
}
