using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class frmInv : Form
    {
        public frmInv()
        {
            InitializeComponent();
            string sql = @"select vno from w_inventory";
            Db db = new Db();
            DataSet ds = db.readbyad(Login.score_2Constr, sql, "old_vno");
            cmbVno.DataSource = ds.Tables[0];
            cmbVno.DisplayMember = "vno";
            cmbVno.ValueMember = "vno";
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string constr = Login.score_2Constr;
            string sqlInv = "  SELECT  w_inventory_detail.ano as ano ,f_article.article_name as article_name,specific,unit_st ,convert(decimal(18,2),w_inventory_detail.qty) as qty,convert(decimal(18,2),qty_real_inv) as qty_real_inv ,convert(decimal(18,2),w_inventory_detail.price) as price ,convert(decimal(18,2),qty_real_inv - qty) as qty_inc_dec,convert(decimal(18,2),qty_real_inv * price) as amount,convert(decimal(18,2),f_article.price_in) as price_in,convert(decimal(18,2),f_article.price_in*qty) as price_in_amount,convert(decimal(18,2),qty_real_inv*price-f_article.price_in*qty_real_inv) as amount_dec FROM w_inventory_detail ,f_article     WHERE ( f_article.ano = w_inventory_detail.ano ) and ( ( w_inventory_detail.vno = '" + txtVno.Text.Trim() + "' ) ) ORDER BY w_inventory_detail.ano ASC";
            Db d = new Db();
            d.sdsBindTogdvMenthod(constr, sqlInv, "filltodgvInv", dgvInv);
            dgvInv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string constr = Login.score_2Constr;
            string sqlInv = "  SELECT  w_inventory_detail.ano as ano ,f_article.article_name as article_name,specific,unit_st ,convert(decimal(18,2),w_inventory_detail.qty) as qty,convert(decimal(18,2),qty_real_inv) as qty_real_inv ,convert(decimal(18,2),w_inventory_detail.price) as price ,convert(decimal(18,2),qty_real_inv - qty) as qty_inc_dec,convert(decimal(18,2),qty_real_inv * price) as amount,convert(decimal(18,2),f_article.price_in) as price_in,convert(decimal(18,2),f_article.price_in*qty) as price_in_amount,convert(decimal(18,2),qty_real_inv*price-f_article.price_in*qty_real_inv) as amount_dec FROM w_inventory_detail ,f_article     WHERE ( f_article.ano = w_inventory_detail.ano ) and ( ( w_inventory_detail.vno = '" + cmbVno.SelectedValue.ToString().Trim() + "' ) ) ORDER BY w_inventory_detail.ano ASC";
            Db d = new Db();
            d.sdsBindTogdvMenthod(constr, sqlInv, "filltodgvInv", dgvInv);
            dgvInv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            Login.saveToExcel(dgvInv);
        }

        private void frmInv_Load(object sender, EventArgs e)
        {

        }
    }
}
