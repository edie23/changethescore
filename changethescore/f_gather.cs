using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class f_gather : Form
    {
        GridPrinter gridPrinter;
        public f_gather()
        {
            InitializeComponent();
            Db db = new Db();
            //DataSet ds = db.readbyad(Login.score_2Constr, sql, "pro_name");
            //cmbPro_name.DataSource = ds.Tables[0];
            //cmbPro_name.DisplayMember = "pro_name";
            //cmbPro_name.ValueMember = "pro_name";
            db.bindDrop(Login.score_2Constr, "select rtrim(class_no)+'-'+class_name,class_no from f_dealer_class where class_no in (select distinct class_no from f_customer) order by class_no", cmbCst_class, "所有客户类型");
            
            cmbCst_class.SelectedValue = "所有客户类型";
            db.bindDrop(Login.score_2Constr, "select rtrim(cust_no)+'-'+cust_name,cust_no from f_customer ",cmbCust,"所有客户");
            cmbCust.SelectedValue = "所有客户";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            gridbing();
        }

        protected void gridbing()
        {
             string cust_class = cmbCst_class.SelectedValue.ToString().Trim();
            
             string cust = cmbCust.SelectedValue.ToString().Trim(); 

           
            if (cust_class == "所有客户类型")
            {
                cust_class = "";
            }
            else
            {
               cust_class ="and ( f_customer.class_no like '%" + cmbCst_class.SelectedValue.ToString().Trim() + "%' ) ";
            }
            if (cust== "所有客户"||string.IsNullOrEmpty(cust))//得到查询方式的选择
            {
                cust = "";
                
            }
            else
            {
                cust = "and ( f_customer.cust_no like '%" + cmbCust.SelectedValue.ToString().Trim() + "%')";
                
            }
            DateTime time = new DateTime(1980, 1, 1);

            //string sqlstr = "SELECT f_dealer_class.class_name as '客户分类',f_customer.cust_no as '客户编号',f_customer.cust_name as '客户名称',上期欠款金额 = isnull(( select sum(amount_total) from w_ws where w_ws.cust_no = f_customer.cust_no and ws_date < "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" ),0) - isnull((select sum(amount_paied) from w_gather where w_gather.cust_no = f_customer.cust_no and gather_date < "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+"),0)-isnull(( select sum(amount_disc ) from w_gather  where w_gather.cust_no = f_customer.cust_no and gather_date < "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+"),0),本期销售金额 = isnull(( select sum(amount_total ) from w_ws where w_ws.cust_no = f_customer.cust_no and ws_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" ),0) ,本期收款金额 = isnull(( select sum(amount_paied ) from w_gather where gather_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" and w_gather.cust_no = f_customer.cust_no ),0) ,本期收款折扣额=isnull(( select sum(amount_disc ) from w_gather where gather_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" and w_gather.cust_no = f_customer.cust_no ),0) ,本期欠款金额 = isnull(( select sum(amount_total) from w_ws where w_ws.cust_no = f_customer.cust_no and ws_date <= "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" ),0) - isnull(( select sum(amount_disc ) from w_gather where gather_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" and w_gather.cust_no = f_customer.cust_no ),0) - isnull(( select sum(amount_paied) from w_gather where w_gather.cust_no = f_customer.cust_no and gather_date <= "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" ),0) - f_customer.amount_remaining ,f_customer.amount_remaining as '预付款金额' FROM f_customer, f_dealer_class where ( f_customer.class_no = f_dealer_class.class_no )" + cust_class + cust;
            string sqlstr = "SELECT f_dealer_class.class_name as '客户分类',f_customer.cust_no as '客户编号',f_customer.cust_name as '客户名称',上期欠款金额 = isnull(( select sum(amount_total) from w_ws where w_ws.cust_no = f_customer.cust_no and ws_date < "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" ),0) - isnull((select sum(amount_paied) from w_gather where w_gather.cust_no = f_customer.cust_no and gather_date < "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+"),0)-isnull(( select sum(amount_disc ) from w_gather  where w_gather.cust_no = f_customer.cust_no and gather_date < "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+"),0),本期销售金额 = isnull(( select sum(amount_total ) from w_ws where w_ws.cust_no = f_customer.cust_no and ws_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" ),0) ,本期收款金额 = isnull(( select sum(amount_paied ) from w_gather where gather_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" and w_gather.cust_no = f_customer.cust_no ),0) ,本期收款折扣额=isnull(( select sum(amount_disc ) from w_gather where gather_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" and w_gather.cust_no = f_customer.cust_no ),0) ,本期欠款金额 = isnull(( select sum(amount_total) from w_ws where w_ws.cust_no = f_customer.cust_no and ws_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" ),0) - isnull(( select sum(amount_disc ) from w_gather where gather_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" and w_gather.cust_no = f_customer.cust_no ),0) - isnull(( select sum(amount_paied) from w_gather where w_gather.cust_no = f_customer.cust_no and gather_date between "+DateTime.Parse(dateTimePicker1.Text).Subtract(time).Days.ToString()+" and "+DateTime.Parse(dateTimePicker2.Text).Subtract(time).Days.ToString()+" ),0) - f_customer.amount_remaining ,f_customer.amount_remaining as '预付款金额' FROM f_customer, f_dealer_class where ( f_customer.class_no = f_dealer_class.class_no )"+ cust_class + cust;
            Db d = new Db();
            DataTable dt = new DataTable();
            //proname = " and sa_article.ano in(select ano from b_promotion_article where pro_name='" + proname + "')";
           
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

                button2.Visible = true;
                //btnPrint.Visible = true;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "合计";
                for (int i = 3; i <= 8; i++)
                {
                    Login.sumColumnToFooterText(dataGridView1, i);
                }

            }
            else
            {
                button2.Visible = false;
                //btnPrint.Visible = false;
            }

        }

        private void cmbCst_class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Db db = new Db();
            db.bindDrop(Login.score_2Constr, "select rtrim(cust_no)+'-'+cust_name,cust_no from f_customer where class_no='" + cmbCst_class.SelectedValue.ToString().Trim() + "'", cmbCust, "所有客户");
            cmbCust.SelectedValue = "所有客户";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

            gridPrinter = new GridPrinter(dataGridView1, printDocument1, true, true, "供货商特价销售报表\r\n" + dateTimePicker1.Text + "--" + dateTimePicker2.Text + "\r\n" , new Font("黑体", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Blue, true);
            return true;
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (InitializePrinting())
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument1;
                printPreviewDialog.ShowDialog();
            }
        }  
    }
}
