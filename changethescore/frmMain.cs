using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class frmMain : Form
    {
        public static frmMain pCurrentWin = null;
        public static Form frmR = null;
        public static Form frmSql = null;
        public frmMain()
        {
            InitializeComponent();
            pCurrentWin = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnScore_in_Click(object sender, EventArgs e)
        {
            frmForScore_ini frmsi = new frmForScore_ini();
            frmsi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmArticle frmlhs = new frmArticle();
            frmlhs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formdiv frmdiv = new formdiv();
            frmdiv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmscoredetail frmsd = new frmscoredetail();
            frmsd.Show();
        }

        private void btnExeclToArticle_Click(object sender, EventArgs e)
        {
            leadToFarticle ltf = new leadToFarticle();
            ltf.Show();
        }

        private void idCreateReport_Click(object sender, EventArgs e)
        {
            reportMain repm = new reportMain();
            repm.Show();
            //Form sqlFrm = new Form();
            //sqlFrm.Name = "frmSql";
            //sqlFrm.Load += new EventHandler(sqlFrmSql_load);
            //sqlFrm.Show();
           
        }

        

        private void btnZjc_Click(object sender, EventArgs e)
        {
            getAbb frmGetAbb = new getAbb();
            frmGetAbb.Show();
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            frmArticle frmarticle = new frmArticle();
            frmarticle.Show();
        }

        private void btnInvO_Click(object sender, EventArgs e)
        {
            frmInv fi = new frmInv();
            fi.Show();
        }

        private void btnBpArticle_Click(object sender, EventArgs e)
        {
            frmPromotionReport fpr = new frmPromotionReport();
            fpr.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmSa_article fsa = new frmSa_article();
            fsa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            promotionArticle pa = new promotionArticle();
            pa.Show();
        }

       
//        FileStream fs = new FileStream("d:\\a.txt", FileMode.Open);
//StreamReader sr = new StreamReader(fs);
//string strLine = null;
//while((strLine = sr.ReadLine()) != null)
//{
//    //doSomething
//}
        //private void sqlFrmSql_load(object sender,EventArgs e)
        //{
           
        //    Form frm = sender as Form;

        //    frm.Width = 600;
        //    frm.Height = 420;
        //    TextBox txt=new TextBox();
        //    txt.Multiline=true;
        //    txt.Height = 80;
        //    txt.Width = 200;
        //    txt.Name = "txtsql";
        //    System.Drawing.Point pt = new Point(50, 30);
        //    System.Drawing.Point pb = new Point(50, 120);
        //    txt.Location=pt;
        //    Button btnCretaeReport = new Button();
            
        //    btnCretaeReport.Click += new EventHandler(btnAddCreateReport_Click);
        //    btnCretaeReport.Name = "btnCretaeReport";
        //    btnCretaeReport.Location = pb;
        //    frm.Controls.Add(txt);
            
        //    frm.Controls.Add(btnCretaeReport);
            
        //}
        //private void btnReport_click(object sender, EventArgs e)
        //{
        //    frmR.Show();
        //}
        //private void btnAddCreateReport_Click(object sender, EventArgs e)
        //{

        //    Button btn1 = sender as Button;
        //    Form frm =btn1.FindForm();

        //    TextBox txtSql = frm.Controls.Find("txtSql", false)[0] as TextBox;
        //    string constr = Login.score_2Constr;
        //    Db d = new Db();
        //    Form frmReport = new Form();
        //    frmReport.Height = 420;
        //    frmReport.Width = 500;
        //    DataGridView dg = new DataGridView();
        //    dg.Width = 400;
        //    dg.Height = 360;
        //    d.sdsBindTogdvMenthod(constr, txtSql.Text.Trim(), "filltodgdv", dg);
        //    dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        //    frmReport.Controls.Add(dg);
        //    frmR = frmReport;
        //    Button btnr1 = new Button();
        //    btnr1.Text = "自动报表";
        //    btnr1.Click += new EventHandler(btnReport_click);
        //    pCurrentWin.Controls.Add(btnr1);
        //    frm.Hide();
            
        //}
        
    

    }
}
