using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class leadToFarticle : Form
    {
        public leadToFarticle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Excel文件";
            ofd.FileName = "";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//获取打开特定文件目录，此处为桌面
            ofd.Filter = "Excel文件(*.xls)|*.xls";//制定选择的文件类型
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;          
            ofd.ValidateNames = true;//验证文件名有效性
            ofd.CheckFileExists = true;//验证文件有效性
            ofd.CheckPathExists = true;//验证路径有效性
            string strName = string.Empty;
            //ProgressBar pb = new ProgressBar();
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                strName = ofd.FileName;
                txtFilename.Text = ofd.FileName;
                DataTable tb = Login.getExeclTableALL(strName);
                //DataTable tb = Login.GetExcelSheetNames(strName);
                //string tablena = tb.Rows[0]["Table_Name"].ToString();
                //pb.Minimum = 0;
                //pb.Maximum = tb.Rows.Count;
                cboExcelNames.Items.Clear();
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    cboExcelNames.Items.Add(tb.Rows[i]["Table_Name"].ToString());//.TrimEnd('$')
                    //pb.Value++;
                }
                cboExcelNames.SelectedIndex = 0;
                
            }
            if (strName == "")
            { MessageBox.Show("没有选择文件");
            return;
            }
            
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            dgvExeclData.Columns.Clear();
            //按下载入时开始绑定datagridview从选中的表格中
            Login.execlToDataGridview(dgvExeclData, txtFilename.Text, cboExcelNames.SelectedItem.ToString());
            cbClass_3.Visible = true;
          

        }

        private void btnGdvTodb_Click(object sender, EventArgs e)
        {
            
            Login.insertToDbByGdv(dgvExeclData, Login.score_2Constr);
            
        }

        private void convertBarcode_Click(object sender, EventArgs e)
        {
            int j=-1;
            foreach (DataGridViewColumn cl in dgvExeclData.Columns)
            {
                
                string s;
                if (cl.DataPropertyName == "barcode")
                {
                    j=cl.Index;         
                    for (int i = 0; i <= dgvExeclData.Rows.Count; i++)
                    {
                        s=dgvExeclData.Rows[i].Cells[j].Value.ToString();

                       
                        
                        //dgvExeclData.Rows[i].Cells[j].Value=
                        //d = Convert.ToDecimal();
                    }
                }
            }
        }

        private void btnSaveAsExcel_Click(object sender, EventArgs e)
        {
            if (dgvExeclData.Rows.Count > 0)
            {
                dgvExeclData.Columns.RemoveAt(0);
                Login.saveToExcel(dgvExeclData);
            }
            else
            {
                MessageBox.Show("没有任何数据");
            }
        }

        private void cmbClass_3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbClass_3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClass_3.Checked == true)
            {
                cmbClass_3.Visible = true;
                Db db = new Db();
                string sqlClass_3 = "select class_3_no,class_3_name from f_class_3";
                //string sqlClass_3="select f_class_1.class_1_no,f_class_1.class_1_name,f_class_2.class_2_no,f_class_2.class_2_name,f_class_3.class_3_no,f_class_3.class_3_name from f_class_1,f_class_2,f_class_3 where f_class_1.class_1_no=f_class_2.class_1_no and f_class_2.class_2_no=f_class_3.class_2_no";
                DataSet ds= db.readbyad(Login.score_2Constr, sqlClass_3, "class");
                //for (int i = 0; i<ds.Tables["class"].Rows.Count; i++)
                //{
                //    cmbClass_3.Items.Add(ds.Tables["class"].Rows[i]);
                //    cmbClass_3.
                //}
                db.sdsBindTogdvMenthod(Login.score_2Constr, sqlClass_3, "class_3", cmbClass_3, "class_3_name", "class_3_no");
                //cmbClass_3.DataSource=ds.Tables["class"].DefaultView;
                //for (int i = 0; i < cmbClass_3.Items.Count; i++)
                //{
                //    cmbClass_3.DataBindings.
                //}
                int suc = cmbIsHasValue(cmbClass_3, cboExcelNames.SelectedItem.ToString().Replace("$", ""));
                if (suc != -1)
                { 
                    cmbClass_3.SelectedIndex = suc;
                    string sqlClass = "select class_1_no,class_2_no from f_class_2 where class_2_no in(select class_2_no from f_class_3 where class_3_no='" + cmbClass_3.SelectedValue.ToString().Trim() + "')";
                    Db d = new Db();
                     ds = d.readbyad(Login.score_2Constr, sqlClass, "class_2_noAndClass_3_no");
                    for (int i = 0; i < dgvExeclData.Rows.Count; i++)
                    {
                        dgvExeclData.Rows[i].Cells["class_1_no"].Value = ds.Tables[0].Rows[0]["class_1_no"].ToString().Trim();
                        dgvExeclData.Rows[i].Cells["class_2_no"].Value = ds.Tables[0].Rows[0]["class_2_no"].ToString().Trim();
                        dgvExeclData.Rows[i].Cells["class_3_no"].Value = cmbClass_3.SelectedValue.ToString().Trim();
                    }
                    btnCreateAno.Visible = true;
                }
                else
                { cmbClass_3.SelectedIndex = 0; }
            }
            else
            {
                cmbClass_3.Visible = false;
            }
        }

        private int cmbIsHasValue(ComboBox cmb, string s)
        {
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                string tep =cmb.GetItemText(cmb.Items[i]);
                if (tep.Contains(s)|| s.Contains(tep))
                {
                    return i;
                }
            }
            return -1;
        }

        private void leadToFarticle_Load(object sender, EventArgs e)
        {

        }

        private void btnLeadToB_in_store_Click(object sender, EventArgs e)
        {

        }

        private void cmbClass_3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if(cmbClass_3.SelectedValue)
            string sqlClass = "select class_1_no,class_2_no from f_class_2 where class_2_no in(select class_2_no from f_class_3 where class_3_no='" + cmbClass_3.SelectedValue.ToString().Trim() + "')";
            Db d = new Db();
            DataSet ds = d.readbyad(Login.score_2Constr, sqlClass, "class_2_noAndClass_3_no");
            for (int i = 0; i < dgvExeclData.Rows.Count; i++)
            {
                dgvExeclData.Rows[i].Cells["class_1_no"].Value = ds.Tables[0].Rows[0]["class_1_no"].ToString().Trim();
                dgvExeclData.Rows[i].Cells["class_2_no"].Value = ds.Tables[0].Rows[0]["class_2_no"].ToString().Trim();
                dgvExeclData.Rows[i].Cells["class_3_no"].Value = cmbClass_3.SelectedValue.ToString().Trim();
            }
            btnCreateAno.Visible = true;
        }

        private void btnCreateAno_Click(object sender, EventArgs e)
        {
            string sqlAno = "select max(ano) from f_article where class_3_no='" + cmbClass_3.SelectedValue.ToString().Trim() + "' and ano like '" + cmbClass_3.SelectedValue.ToString().Trim() + "%'";
            Db d = new Db();
            
            object o = d.readGetFrist(Login.score_2Constr, sqlAno);
            string strclass = cmbClass_3.SelectedValue.ToString().Trim();
            string str = o.ToString().StartsWith(cmbClass_3.SelectedValue.ToString().Trim()) == true ? o.ToString().Remove(0, cmbClass_3.SelectedValue.ToString().Trim().Length) : o.ToString();
            if (o is DBNull)
            {

                if (Login.IsNumeric(strclass))
                {

                    //str = strclass + "001";
                    //maxAno = (Convert.ToInt32(str)) * 1000 + 1;
                    int i = 0;
                    for (int j = 0; j < dgvExeclData.Rows.Count && (i + 1 + j) < 999; j++)
                    {
                        if (i + 1 + j < 10)
                        {
                            dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() +"00"+ (i + 1 + j).ToString();
                        }
                        else if (i + 1 + j < 100)
                        {
                            dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() + "0" + (i + 1 + j).ToString();
                        }
                        else
                        {
                            dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() + (i + 1 + j).ToString();
                        }
                        
                    }
                }
                else
                {
                    str = "";

                }
            }
            else
            {
                
                int i = Convert.ToInt32(str);
                for (int j = 0; j < dgvExeclData.Rows.Count && (i + 1 + j) < 999; j++)
                {
                    if (i + 1 + j < 10)
                    {
                        dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() + "00" + (i + 1 + j).ToString();
                    }
                    else if (i + 1 + j < 100)
                    {
                        dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() + "0" + (i + 1 + j).ToString();
                    }
                    else
                    {
                        dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() + (i + 1 + j).ToString();
                    }

                }
            }
            //string sqlAno = "select max(ano) from f_article where class_3_no='"+cmbClass_3.SelectedValue.ToString().Trim()+"'";
            //Db d = new Db();
            //object o = d.readGetFrist(Login.score_2Constr, sqlAno);
            //string strclass = cmbClass_3.SelectedValue.ToString().Trim();
            //string str = o.ToString().Replace(cmbClass_3.SelectedValue.ToString().Trim(), "");
            //if (o is DBNull)
            //{

            //    if (Login.IsNumeric(strclass))
            //    {

            //        str = strclass + "001";
            //        //maxAno = (Convert.ToInt32(str)) * 1000 + 1;
            //        int i = Convert.ToInt32(str);
            //        for (int j = 0; j < dgvExeclData.Rows.Count && (i + 1 + j) < 999; j++)
            //        {
            //            dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() + (i + 1 + j).ToString();
            //        }
            //    }
            //    else
            //    {
            //        str = "";

            //    }
            //}
            //else
            //{
            //    int i = Convert.ToInt32(str);
            //    for (int j = 0; j < dgvExeclData.Rows.Count && (i + 1 + j) < 999; j++)
            //    {
            //        dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim() + (i + 1 + j).ToString();
            //    }
            //}
            
            //int i = Convert.ToInt32(str);
            //for (int j = 0; j < dgvExeclData.Rows.Count && (i  + 1 + j )<999; j++)
            //{
            //    dgvExeclData.Rows[j].Cells["ano"].Value = cmbClass_3.SelectedValue.ToString().Trim()+(i + 1 + j).ToString();
            //}
            //int i=
        }

        private void cboExcelNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbClass_3.Visible = false;
            cbClass_3.Checked = false;
            cmbClass_3.Visible = false;
            btnCreateAno.Visible = false;
        }

        private void cboExcelNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
