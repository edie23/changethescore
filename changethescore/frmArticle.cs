using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class frmArticle : Form
    {
        public frmArticle()
        {
            
            InitializeComponent();
            string constr = Login.score_2Constr;
            Db d = new Db();
            d.sdsBindTogdvMenthod(constr, Login.sqlarticle, "filltodgdv", dgv);
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void btnSaveToExcel_Click(object sender, EventArgs e)
        {
            Login.saveToExcel(dgv);
        }
    }
}
