using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.saveToExcel(dgv);
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            mtxtTime1.Text = DateTime.Now.ToShortDateString();
            mtxtTime2.Text = DateTime.Now.ToShortDateString();
            TreeNode trDept = new TreeNode();
            //trvDept.SelectedNode.
            
               
        }
    }
}
