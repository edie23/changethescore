using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{

    public partial class score_front : Form
    {
        System.Data.DataTable dsReal = new System.Data.DataTable("articleTotal");

        public score_front()
        {
            InitializeComponent();
        }

        private void txtWrite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                Db db = new Db();
                string sqlArticle=@"select ltrim(rtrim(ano)) as ano,article_name,specific,unit_st,qty=1,price_retail,amout=price_retail,disc=0,disc_rate=1,cashier_no='',sa_type='1' from f_article where ( ano ='"+txtWrite.Text.Trim()+"' ) or ( abbr_name ='"+txtWrite.Text.Trim()+"' ) or ( barcode ='"+txtWrite.Text.Trim()+"' ) or ( ano_old ='"+txtWrite.Text.Trim()+"' ) ";
                DataSet ds = db.readbyad(Login.score_2Constr, sqlArticle, "articledetail");
                ds.Tables[0].Columns[9].DefaultValue = "";
                if (dsReal.Rows.Count > 0)
                {
                    object o = ds.Tables[0].Rows[0]["ano"];
                    //Login.dsReal.Tables["articleTotal"].DefaultView.ApplyDefaultSort = true;
                    dsReal.DefaultView.Sort = "ano";
                    //DataView custView = new DataView(dsReal, "", "ano", DataViewRowState.CurrentRows);
                    int i =dsReal.DefaultView.Find(o);
                    if (i == -1)
                    {
                       dsReal.Merge(ds.Tables[0]);
                        //Login.dsReal.Tables["articleTotal"].Load(ds.Tables[0].CreateDataReader());
                    }
                    else
                    {
                        int oldI = Int32.Parse(dsReal.Rows[i][6].ToString());
                        int tempI = Int32.Parse(ds.Tables[0].Rows[i][6].ToString());
                       dsReal.Rows[i][6] = (oldI + tempI).ToString();
                        oldI = Int32.Parse(dsReal.Rows[i][7].ToString());
                        tempI = Int32.Parse(ds.Tables[0].Rows[i][7].ToString());
                       dsReal.Rows[i][7] = (oldI + tempI).ToString();

                    }
                    dgvArticle.DataSource =dsReal.DefaultView;
                    txtWrite.Text = "";
                }
                else if (dsReal.Rows.Count == 0)
                {
                    dgvArticle.DataSource = ds.Tables[0].DefaultView;
                    dsReal.Merge(ds.Tables[0]);
                    txtWrite.Text = "";
                }
                
            }
        }

        private void score_front_Load(object sender, EventArgs e)
        {
            txtWrite.Focus();
            
        }

        private void dgvArticle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
