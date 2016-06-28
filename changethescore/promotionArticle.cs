using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class promotionArticle : Form
    {
        public promotionArticle()
        {
            InitializeComponent();
            Db db = new Db();

            db.bindDrop(Login.score_2Constr, "select distinct rtrim(pro_name) as pro_name, rtrim(pro_name) as pro_name from b_promotion_article", cmbPro_name, "选择特价活动.....");
            cmbPro_name.SelectedIndex = 0;
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

        protected void gridbing()
        {
            string proname = cmbPro_name.SelectedValue.ToString().Trim();

            string sqlstr = string.Empty;
            Db d = new Db();
            DataTable dt = new DataTable();
            //proname = " and sa_article.ano in(select ano from b_promotion_article where pro_name='" + proname + "')";
            sqlstr = "  SELECT '大类编号'='','中类编号'='','小类编号'='',  f_article.ano as '商品编号',f_article.article_name as '商品名称',  '规格' =specific,'单位' = unit_st,'产地' =manu_no,'进价' =f_article.price_in,'零售价'= f_article.price_retail,'会员价'=price_vip,'条形码'=barcode FROM f_article,b_promotion_article  WHERE   b_promotion_article.pro_name='" + proname + "' and (  b_promotion_article.ano = f_article.ano )   ORDER BY f_article.ano";
            d.sdsBindTogdvMenthod(Login.score_2Constr, sqlstr, "filltodgdv", dataGridView1);
            //dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowsDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //if (dataGridView1.Rows.Count > 0)
            //{

               
            //    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "合计";
            //    for (int i = 4; i < 7; i++)
            //    {
            //        Login.sumColumnToFooterText(dataGridView1, i);
            //    }

            //}
            //else
            //{
               
            //}

        }

        private void cmbPro_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gridbing();
        }
    }

}
