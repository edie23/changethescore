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
    public partial class frmPromotionReport : Form
    {
        GridPrinter gridPrinter;
        public frmPromotionReport()
        {
            InitializeComponent();
            //string sql = @"select distinct rtrim(pro_name) as pro_name from b_promotion_article";
            Db db = new Db();
            //DataSet ds = db.readbyad(Login.score_2Constr, sql, "pro_name");
            //cmbPro_name.DataSource = ds.Tables[0];
            //cmbPro_name.DisplayMember = "pro_name";
            //cmbPro_name.ValueMember = "pro_name";
            bindC();
            db.bindDrop(Login.score_2Constr, "select distinct rtrim(pro_name) as pro_name, rtrim(pro_name) as pro_name from b_promotion_article",cmbPro_name, "选择特价活动.....");
            db.bindDrop(Login.score_2Constr, "select dept_name,dept_no from f_dept", comboBox1,"所有部门");
            comboBox1.SelectedValue = "所有部门";
            //comboBox1.Items.Insert(0, "所有部门");
            
        }


      

        protected void gridbing()
        {
            string proname = cmbPro_name.SelectedValue.ToString().Trim();
            string dept = comboBox1.SelectedValue.ToString().Trim();
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
            if (conStr != "" && str != "")//得到查询方式的选择
            {
               
                    str = " and f_article." +conStr + " like '%" + str+ "%'";
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
           sqlstr = "  SELECT   sa_article.ano as '商品编号',f_article.article_name as '名称',  '总销售数量' = sum(sa_article.qty),'总销售成本' = sum(cost),'总销售金额' = sum(amount),'总折扣' = sum(disc),'进价成本差'= Convert(decimal(18,2),sum(sa_article.qty*f_article.price_in))-sum(cost) FROM f_article,  sa_article,b_promotion_article  WHERE sa_article.ano=b_promotion_article.ano and b_promotion_article.pro_name='"+proname+"' and ( sa_article.ano = f_article.ano )   and ( sa_date between " + DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString() + " and " + DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString() + " ) " + dept + str  + " GROUP BY sa_article.ano,  f_article.article_name,  f_article.specific,  f_article.unit_st, f_article.dealer_no ORDER BY f_article.dealer_no,sa_article.ano ASC";
            d.sdsBindTogdvMenthod(Login.score_2Constr, sqlstr, "filltodgdv",dataGridView1);
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
                btnPrint.Visible = true;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "合计";
                for (int i = 4; i < 7; i++)
                {
                    Login.sumColumnToFooterText(dataGridView1, i);
                }
                
            }
            else
            {
                button1.Visible = false;
                btnPrint.Visible = false;
            }
         
        }

       protected void bindC()
       {
           Db d = new Db();
            ArrayList arrValue = new ArrayList();
            arrValue.Add("dealer_no");
            arrValue.Add("article_name");
            arrValue.Add("ano");
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
            arrText.Add("供货商号");
            arrText.Add("商品名称");
            arrText.Add("商品编号");
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
            d.dropBind(arrText, arrValue,comboBox2);//绑定下拉菜单
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

       private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
       {
           bool more = gridPrinter.DrawDataGridView(e.Graphics);
           if (more == true)
               e.HasMorePages = true; 
       }

       private void btnPrint_Click(object sender, EventArgs e)
       {
           if (InitializePrinting())
           {
               PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
               printPreviewDialog.Document = printDocument1;
               printPreviewDialog.ShowDialog();
           }  
       }

       private bool InitializePrinting()
       {
           PrintDialog printDialog = new PrintDialog();
           if (printDialog.ShowDialog() != DialogResult.OK)
               return false;

           printDocument1.DocumentName = "供货商特价销售报表";
           printDocument1.PrinterSettings = printDialog.PrinterSettings;
           printDocument1.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
           //printDocument1.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);  

           gridPrinter = new GridPrinter(dataGridView1, printDocument1, true, true, "供货商特价销售报表\r\n"+dateTimePicker1.Text+"--"+dateTimePicker2.Text+"\r\n"+comboBox1.SelectedValue.ToString(), new Font("黑体", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Blue, true);
           return true;
       }  
    }
}
