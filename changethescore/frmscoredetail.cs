using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace changethescore
{
    public partial class frmscoredetail : Form
    {
        public frmscoredetail()
        {
            InitializeComponent();
        }
        private void btnToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog kk = new SaveFileDialog(); 
             kk.Title = "保存EXECL文件"; 
             kk.Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*"; 
            kk.FilterIndex = 1;
            if (kk.ShowDialog() == DialogResult.OK) 
           { 
              string FileName = kk.FileName + ".xls";
               if (File.Exists(FileName))
                   File.Delete(FileName);
               FileStream objFileStream; 
               StreamWriter objStreamWriter; 
               string strLine = ""; 
              objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write); 
              objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);
              for (int i = 0; i  < dgdvscore.Columns.Count; i++) 
              { 
                    if (dgdvscore.Columns[i].Visible == true) 
                   {                        strLine = strLine + dgdvscore.Columns[i].HeaderText.ToString() + Convert.ToChar(9);                   } 
               } 
               objStreamWriter.WriteLine(strLine); 
               strLine = ""; 

              for (int i = 0; i  < dgdvscore.Rows.Count; i++) 
              { 
                  if (dgdvscore.Columns[0].Visible == true) 
                  { 
                       if (dgdvscore.Rows[i].Cells[0].Value == null) 
                           strLine = strLine + " " + Convert.ToChar(9); 
                      else 
                          strLine = strLine + dgdvscore.Rows[i].Cells[0].Value.ToString() + Convert.ToChar(9); 
                  } 
                  for (int j = 1; j  < dgdvscore.Columns.Count; j++) 
                  { 
                      if (dgdvscore.Columns[j].Visible == true) 
                      { 
                          if (dgdvscore.Rows[i].Cells[j].Value == null) 
                              strLine = strLine + " " + Convert.ToChar(9); 
                          else 
                          { 
                              string rowstr = ""; 
                              rowstr = dgdvscore.Rows[i].Cells[j].Value.ToString(); 
                              if (rowstr.IndexOf("\r\n") >  0) 
                                  rowstr = rowstr.Replace("\r\n", " "); 
                              if (rowstr.IndexOf("\t") >  0) 
                                  rowstr = rowstr.Replace("\t", " "); 
                              strLine = strLine + rowstr + Convert.ToChar(9);                            } 
                       } 
                   } 
                   objStreamWriter.WriteLine(strLine); 
                   strLine = ""; 
               } 
              objStreamWriter.Close(); 
              objFileStream.Close();
                MessageBox.Show(this,"保存EXCEL成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string sqlstr = @"select ope_date,vip_no,operator,subject,score_orig,score_inc,score_dec,score_now from w_vip_score where vip_no='" + txtVip_no.Text.Trim()+"'"; ;
            string constr = Login.asstConstr;
            Db d = new Db();
            d.sdsBindTogdvMenthod(constr, sqlstr, "filltodgdv", dgdvscore);
            dgdvscore.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void frmscoredetail_Load(object sender, EventArgs e)
        {

        }
    }
}
