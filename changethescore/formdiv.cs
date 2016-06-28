using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace changethescore
{
    public partial class formdiv : Form
    {
        public formdiv()
        {
            InitializeComponent();
        }

        private void formdiv_Load(object sender, EventArgs e)
        {
            string sql=@"select vno from w_in_store";
            Db db = new Db();
            DataSet ds = db.readbyad(Login.score_2Constr, sql, "old_vno");
            cmbOldVno.DataSource = ds.Tables[0];
            cmbOldVno.DisplayMember = "vno";
            cmbOldVno.ValueMember="vno";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string sqlstoredprocetureText = "createNewvnobillByOldvno";
            Db db = new Db();
            db.Constr = Login.score_2Constr;
            int i=db.execStoredProcedure(sqlstoredprocetureText, "@old_vno", "@new_vno", cmbOldVno.SelectedValue.ToString(), txtNewVno.Text.Trim());
            if (i == 0)
            {
                MessageBox.Show("生成单据成功");
            }
            else
            {
                MessageBox.Show("生成单据失败");
            }
        }

        private void cmbOldVno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
