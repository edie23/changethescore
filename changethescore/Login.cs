using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web;
using System.Collections;

namespace changethescore
{
    public static class Login
    {

        public static bool IsNumeric(string str)
        {
            System.Text.RegularExpressions.Regex reg1
            = new System.Text.RegularExpressions.Regex(@"^[-]?\d+[.]?\d*$");
            return reg1.IsMatch(str);
        } //是否位数字

        //public static string headDb= ConfigurationManager.ConnectionStrings["headDb"].ConnectionString;//20151119检测漏传并传输
        
        public static string uid = ConfigurationManager.ConnectionStrings["uid"].ConnectionString;
        public static string serverName = ConfigurationManager.ConnectionStrings["serverName"].ConnectionString;
        public static string conPwd = ConfigurationManager.ConnectionStrings["pwd"].ConnectionString;
        public static string dataname = ConfigurationManager.ConnectionStrings["dataname"].ConnectionString;
        public static string score_2Constr = "server="+Login.serverName+";uid="+Login.uid+";pwd="+Login.conPwd+";database="+Login.dataname+";";
        public static string asstConstr = ConfigurationManager.ConnectionStrings["asst"].ConnectionString;
        //public static string sqlOldVno = @"";

        //管理平台数据库用
        public static string managerServer = ConfigurationManager.ConnectionStrings["managerServer"].ConnectionString;
        public static string managerPwd = ConfigurationManager.ConnectionStrings["managerPwd"].ConnectionString;
        public static string managerUid = ConfigurationManager.ConnectionStrings["managerUid"].ConnectionString;
        public static string managerDb = ConfigurationManager.ConnectionStrings["managerDb"].ConnectionString;
        public static string managerConstr = "server=" + Login.managerServer + ";uid=" + Login.managerUid + ";pwd=" + Login.managerPwd + ";database=" + Login.managerDb + ";";
        public static string sqlarticle = @"SELECT f_article.ano as ano,f_article.article_name as article_name,f_article.specific as specific,f_article.unit_st as unit_st,f_article.manu_no as manu_no,manu_name=(select manu_name from f_manufacture where manu_no=f_article.manu_no),f_article.mark_no as mark_no,mark_name=(select mark_name from f_mark where mark_no=f_article.mark_no), f_article.dealer_no as dealer_no,f_article.price_in as price_in,f_article.price_retail as price_retail,f_article.price_vip as price_vip,f_article.feature1 as feature1,f_article.feature2 as feature2,f_article.bk_field1 as bk_field1,f_article.bk_field2 as bk_field2,f_article.barcode as barcode,dealer_name = ( select simple_name from f_dealer where dealer_no = f_article.dealer_no) FROM f_article WHERE in_use = 1  order by ano ";
        public static void saveToExcel(DataGridView dgdvscore)
        {
            SaveFileDialog kk = new SaveFileDialog();
            kk.Title = "保存EXECL文件";
            kk.Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*";
            kk.FilterIndex = 1;
            if (kk.ShowDialog() == DialogResult.OK)
            {
                string FileName = kk.FileName;
                if (File.Exists(FileName))
                    File.Delete(FileName);
                FileStream objFileStream;
                StreamWriter objStreamWriter;
                string strLine = "";
                objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);
                for (int i = 0; i < dgdvscore.Columns.Count; i++)
                {
                    if (dgdvscore.Columns[i].Visible == true)
                    { strLine = strLine + dgdvscore.Columns[i].HeaderText.ToString() + Convert.ToChar(9); }
                }
                objStreamWriter.WriteLine(strLine);
                strLine = "";

                for (int i = 0; i < dgdvscore.Rows.Count; i++)
                {
                    if (dgdvscore.Columns[0].Visible == true)
                    {
                        if (dgdvscore.Rows[i].Cells[0].Value == null)
                            strLine = strLine + " " + Convert.ToChar(9);
                        else
                            strLine = strLine + dgdvscore.Rows[i].Cells[0].Value.ToString() + Convert.ToChar(9);
                    }
                    for (int j = 1; j < dgdvscore.Columns.Count; j++)
                    {
                        if (dgdvscore.Columns[j].Visible == true)
                        {
                            if (dgdvscore.Rows[i].Cells[j].Value == null)
                                strLine = strLine + " " + Convert.ToChar(9);
                            else
                            {
                                string rowstr = "";
                                rowstr = dgdvscore.Rows[i].Cells[j].Value.ToString();
                                if (rowstr.IndexOf("\r\n") > 0)
                                    rowstr = rowstr.Replace("\r\n", " ");
                                if (rowstr.IndexOf("\t") > 0)
                                    rowstr = rowstr.Replace("\t", " ");
                                strLine = strLine + rowstr + Convert.ToChar(9);
                            }
                        }
                    }
                    objStreamWriter.WriteLine(strLine);
                    strLine = "";
                }
                objStreamWriter.Close();
                objFileStream.Close();
                MessageBox.Show("保存EXCEL成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        

        public static int isUnqOfTheBarcode(string barcode)
        {
            Db db = new Db();
            string sqlCheckBarcode= "select 1 from f_article where barcode='" + barcode+"'";
            object o =db.readGetFrist(score_2Constr, sqlCheckBarcode);
            if (o == null)
            {
                return 0;
            }
            else
            {
                return int.Parse(o.ToString());
            }
        }

        public static void execlToDataGridview(DataGridView gdv,string fileName,string tableName)//从execl中导入数据导gridview里
        {
            //int barcodeCl=-1;
            string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;Hdr=NO;IMEX=1'";
            //连接execl
            OleDbConnection con=new OleDbConnection(strCon);
            con.Open();
            string strExecl = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            tableName=tableName.Replace("'","");
            strExecl = "select * from [" + tableName+"]";
            myCommand = new OleDbDataAdapter(strExecl, strCon);
            ds = new DataSet();
            myCommand.Fill(ds,tableName);
 
            //根据datagridview的列构造一个新的datatable
            System.Data.DataTable tb = new System.Data.DataTable();
            //以下根据excel列生成datagridview列
            string dsCellValue;//此为ececl相应单元格的值
            for (int i = 0; i < ds.Tables[tableName].Columns.Count; i++)
            {
                dsCellValue = ds.Tables[tableName].Rows[0][i].ToString();
                gdv.Columns.Add(dsCellValue, dsCellValue);
                switch (dsCellValue)
                {
                    case "大类编号":
                        gdv.Columns[i].DataPropertyName = "class_1_no";
                        gdv.Columns[i].Name = "class_1_no";
                        break;
                    case "中类编号":
                        gdv.Columns[i].DataPropertyName = "class_2_no";
                        gdv.Columns[i].Name = "class_2_no";
                        break;
                    case "小类编号":
                        gdv.Columns[i].DataPropertyName = "class_3_no";
                        gdv.Columns[i].Name = "class_3_no";
                        break;
                    case "商品编号":
                        gdv.Columns[i].DataPropertyName = "ano";
                        gdv.Columns[i].Name = "ano";
                        break;
                    case "商品名称":
                        gdv.Columns[i].DataPropertyName = "article_name";
                        gdv.Columns[i].Name = "article_name";
                        break;
                    case "名称":
                        gdv.Columns[i].DataPropertyName = "article_name";
                        gdv.Columns[i].Name = "article_name";
                        break;
                    case "单位":
                        gdv.Columns[i].DataPropertyName = "unit_st";
                        gdv.Columns[i].Name = "unit_st";
                        break;
                    case "产地":
                        gdv.Columns[i].DataPropertyName = "manu_no";
                        gdv.Columns[i].Name = "manu_no";
                        break;
                    case "进价":
                        gdv.Columns[i].DataPropertyName = "price_in";
                        gdv.Columns[i].Name = "price_in";
                        break;
                    case "零售价":
                        gdv.Columns[i].DataPropertyName = "price_retail";
                        gdv.Columns[i].Name = "price_retail";
                        break;
                    case "会员价":
                        gdv.Columns[i].DataPropertyName = "price_vip";
                        gdv.Columns[i].Name = "price_vip";
                        break;
                    case "条形码":
                        gdv.Columns[i].DataPropertyName = "barcode";
                        gdv.Columns[i].Name = "barcode";
                        //barcodeCl = i;
                        break;
                    case "规格":
                        gdv.Columns[i].DataPropertyName = "specific";
                        gdv.Columns[i].Name = "specific";
                        break;
                    case "供货商":
                         gdv.Columns[i].DataPropertyName = "dealer_no";
                        gdv.Columns[i].Name = "dealer_no";
                        break;
                    default:
                        break;
                }       
            }
            ds.Tables[tableName].Rows.RemoveAt(0);//移除每列第一行
            foreach (DataGridViewColumn gdvtemp in gdv.Columns)
            {
                if (gdvtemp.Visible && gdvtemp.CellType != typeof(DataGridViewCheckBoxCell))
                {
                    DataColumn dc = new DataColumn();
                    dc.ColumnName = gdvtemp.DataPropertyName;
                    //dc.DataType = gdvtemp.ValueType;
                    //if (dc.ColumnName != "")//此处设置条件避免因为空数据加了一列空值
                    tb.Columns.Add(dc);  
                }

            }
                foreach (DataRow excelrow in ds.Tables[tableName].Rows)//给作为数据源的临时表赋值
                {
                    int i = 0;
                    DataRow dr = tb.NewRow();
                    foreach (DataColumn dc in tb.Columns)
                    {
                        dr[dc] = excelrow[i];
                        i++;
                    }
                    tb.Rows.Add(dr);
                    //pb.Value++;
                }
           
                //在datagridview中显示导入的数据
            gdv.DataSource = tb.DefaultView;
            //gdv.DataSource = ds.Tables[tableName].DefaultView;





        }

        public static System.Data.DataTable getExeclTableALL(string execlName)//获取excel里的表信息
        {
            try
            {
                if (System.IO.File.Exists(execlName))
                {
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=\"Excel 8.0\";Data Source=" + execlName);
                    con.Open();
                    System.Data.DataTable table = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "TABLE" }); 
                    con.Close();
                    return table;
                }
                return null;

            }
            catch
            {
                return null;
            }
        }

        public static void insertToDbByGdv(DataGridView gdv, string constr)
        {
            string sqlend = "";
            string sqlstart = "";
            string sql = "";
            int suc = 0;
            int fal = 0;
            if (gdv.Columns[0].Name != "errMes")
            {
                DataGridViewColumn dgvc = new DataGridViewColumn();//以下增加一列现实出错信息的单元格
                dgvc.Name = "errMes";
                dgvc.HeaderText = "错误信息";
                dgvc.CellTemplate = new DataGridViewTextBoxCell();
                gdv.Columns.Insert(0, dgvc);
            }
            else 
            {
                for(int i=0;i<gdv.Rows.Count;i++)
                {
                    gdv.Rows[i].Cells[0].Value = "";
                }
            }
            int index = 0;
           while( index < gdv.Rows.Count)
            {
                if (gdv.Rows[index].Cells["barcode"].Value==null)
                {
                    index = index + 1;
                    continue;
                }
                int o = (Login.isUnqOfTheBarcode(gdv.Rows[index].Cells["barcode"].Value.ToString()));
                //if (o>0)
                //{
                //    gdv.Rows[index].Cells["errMes"].Value = "(条形码重复了)";//首先判断条码唯一性
                //    index = index + 1;
                //    continue;
                //}
                //else if (o == -1)
                //{
                //    gdv.Rows[index].Cells["errMes"].Value = "未能验证条码唯一性";
                //    index = index + 1;
                //}
                for (int j = 0; j < gdv.Columns.Count; j++)
                {
                    //根据datagridview里的各列绑定源来生成插入语句
                    switch (gdv.Columns[j].DataPropertyName)
                    {
                        case "class_1_no":               
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "class_2_no":                          
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "class_3_no":                        
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "ano":
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "article_name":                            
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "price_in":                           
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            if (IsNumeric(gdv.Rows[index].Cells[j].Value.ToString().Trim()))
                            {
                                sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            }
                            else
                            {
                                sqlend = sqlend + "'',";
                            }
                            break;
                        case "price_retail":                            
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            if (IsNumeric(gdv.Rows[index].Cells[j].Value.ToString().Trim()))
                            {
                                sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            }
                            else
                            {
                                sqlend = sqlend + "'',";
                            }
                            break;
                        case "price_vip":                            
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            if (IsNumeric(gdv.Rows[index].Cells[j].Value.ToString().Trim()))
                            {
                                sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            }
                            else
                            {
                                sqlend = sqlend + "'',";
                            }
                            break;
                        case "barcode":                           
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "specific":                          
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "unit_st":
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "manu_no":
                             sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        case "dealer_no":
                            sqlstart = sqlstart + gdv.Columns[j].DataPropertyName + ",";
                            sqlend = sqlend + "'" + gdv.Rows[index].Cells[j].Value.ToString() + "',";
                            break;
                        default:
                            break;
                    }
                }
                sqlstart = sqlstart.TrimEnd(',');
                sqlend = sqlend.TrimEnd(',');
                sql = "insert into f_article(" + sqlstart + ")values(" + sqlend+")";
                Db db = new Db();
                string dbRusult = db.nonquery(Login.score_2Constr, sql);
                if (Login.IsNumeric(dbRusult)&&Convert.ToInt32(dbRusult)>0)
                {
                    suc = suc + 1;
                    gdv.Rows.RemoveAt(index);
                    //index=index-1;
                }
                else
                {
                    
                  
                    //gdv.Rows[i].Selected = true;
                    //if (dbRusult == -1)
                    //{
                    //    //MessageBox.Show("商品编号重复");
                    //    //return;
                    //    gdv.Rows[index].Cells["errMes"].Value += "(商品编号重复)";
                    //}
                    //else if (dbRusult == -2)
                    //{
                    //    //MessageBox.Show("商品分类里没有该小类所对应的编号");
                    //    gdv.Rows[index].Cells["errMes"].Value += "(商品分类里没有该小类所对应的编号)";
                    //}
                    //else if (dbRusult == -3)
                    //{
                    //    MessageBox.Show("无法连接指定数据库，请检查数据库名称是否正确");
                    //    return;
                        
                    //}
                    //else if (dbRusult == -4)
                    //{
                    //    MessageBox.Show("有数据超过长度范围");
                    //}
                    //else if (dbRusult==-5)
                    //{
                    //    MessageBox.Show("将数据类型varchar转换为numeric时出错");
                    //}
                    //else
                    //{
                    //    gdv.Rows[index].Cells["errMes"].Value += "(未知错误)";
                    //}
                    gdv.Rows[index].Cells["errMes"].Value += dbRusult;
                    fal = fal + 1;
                    index=index+1;
                }
                //给语句恢复初始值
                sqlstart="";
                sqlend="";
                sql="";
            }
            MessageBox.Show("已成功导入" + suc.ToString() + "行数据，剩下" + fal.ToString() + "行数据导入数据失败");
        }

        public static System.Data.DataTable GetExcelSheetNames(string excelFileFullPath)
        {
            var fileType = Path.GetExtension(excelFileFullPath.ToLower()).Trim();
            var excelVersionNumber = fileType == ".xlsx" ? "12.0" : "8.0";

            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;
            try
            {
                var connString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0} ;Extended Properties=\"Excel {1};HDR=Yes;IMEX=2;\"", excelFileFullPath, excelVersionNumber);

                objConn = new OleDbConnection(connString);
                objConn.Open();
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                return dt;
            }
            finally
            {
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

        public static void printDataGridView(DataGridView dataGridView1, string title, string docName)//打印执行类，打印datagridview里的内容
        {
            System.Drawing.Printing.PrintDocument printDocument1 = new System.Drawing.Printing.PrintDocument();//创建打印文档

            if (InitializePrinting(printDocument1, dataGridView1, title, docName))
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument1;
                printPreviewDialog.ShowDialog();
            }
        }

        private static bool InitializePrinting(System.Drawing.Printing.PrintDocument printDocument1, DataGridView dataGridView1, string title, string docName)
        {

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() != DialogResult.OK)
                return false;

            printDocument1.DocumentName = docName;
            printDocument1.PrinterSettings = printDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
            //printDocument1.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);  

            GridPrinter gridPrinter = new GridPrinter(dataGridView1, printDocument1, true, true, title, new System.Drawing.Font("黑体", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Blue, true);
            //if(printDocument1.DocumentName== "document")
            //{
            //以下匿名方法委托，难点
            printDocument1.PrintPage += (s, e) =>
            {
                bool more = gridPrinter.DrawDataGridView(e.Graphics);
                if (more == true)
                    e.HasMorePages = true;

            };
            //}
            return true;
        }



        public static void sumColumnToFooterText(DataGridView gdv, int i)//设置gridview的页脚和，i为设置哪列的和
        {
            decimal sum = 0.00m;
            for (int j = 0; j < gdv.Rows.Count-1; j++)
            {
                sum += Convert.ToDecimal(gdv.Rows[j].Cells[i].Value.ToString());
            }
            Math.Round(sum, 2);
            gdv.Rows[gdv.Rows.Count-1].Cells[i].Value = sum.ToString();

        }


     


        //public static string UpLoadImage(string ano, FileUpload upImage, string sSavePath, string sThumbExtension, int intThumbWidth, int intThumbHeight)
        //{
        //    string sThumbFile = "";
        //    string sFilename = "";
        //    if (upImage.PostedFile != null)
        //    {
        //        HttpPostedFile myFile = upImage.PostedFile;
        //        int nFileLen = myFile.ContentLength;
        //        if (nFileLen == 0)
        //            return "没有选择上传图片";
        //        //获取upImage选择文件的扩展名 
        //        string extendName = System.IO.Path.GetExtension(myFile.FileName).ToLower();
        //        //判断是否为图片格式 
        //        if (extendName != ".jpg" && extendName != ".jpge" && extendName != ".gif" && extendName != ".bmp" && extendName != ".png")
        //            return "图片格式不正确";

        //        byte[] myData = new Byte[nFileLen];
        //        myFile.InputStream.Read(myData, 0, nFileLen);
        //        sFilename = ano + extendName;
        //        //int file_append = 0; 
        //        //检查当前文件夹下是否有该客户文件夹
        //        if (!System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(sSavePath)))
        //        {
        //            System.IO.Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath(sSavePath));
        //        }
        //        //检查当前文件夹下是否有同名图片,有则在文件名+ 
        //        while (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(sSavePath + "//" + sFilename)))
        //        {
        //            //file_append++; 
        //            //sFilename = System.IO.Path.GetFileNameWithoutExtension(myFile.FileName) 
        //            //    + file_append.ToString() + extendName; 
        //            System.IO.File.Delete(System.Web.HttpContext.Current.Server.MapPath(sSavePath + "//" + sFilename));
        //        }
        //        System.IO.FileStream newFile
        //            = new System.IO.FileStream(System.Web.HttpContext.Current.Server.MapPath(sSavePath + "//" + sFilename),
        //            System.IO.FileMode.Create, System.IO.FileAccess.Write);
        //        newFile.Write(myData, 0, myData.Length);
        //        newFile.Close();
        //        //以上为上传原图
        //        try
        //        {
        //            //原图加载 
        //            using (System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(System.Web.HttpContext.Current.Server.MapPath(sSavePath + "//" + sFilename)))
        //            {
        //                //原图宽度和高度 
        //                int width = sourceImage.Width;
        //                int height = sourceImage.Height;
        //                int smallWidth;
        //                int smallHeight;
        //                //获取第一张绘制图的大小,(比较 原图的宽/缩略图的宽 和 原图的高/缩略图的高) 
        //                if (((decimal)width) / height <= ((decimal)intThumbWidth) / intThumbHeight)
        //                {
        //                    smallWidth = intThumbWidth;
        //                    smallHeight = intThumbWidth * height / width;
        //                }
        //                else
        //                {
        //                    smallWidth = intThumbHeight * width / height;
        //                    smallHeight = intThumbHeight;
        //                }
        //                //判断缩略图在当前文件夹下是否同名称文件存在 
        //                //file_append =0 ; 
        //                sThumbFile = ano + extendName;
        //                if (!System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(sThumbExtension)))
        //                {
        //                    System.IO.Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath(sThumbExtension));
        //                }
        //                while (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath(sThumbExtension + "//" + sThumbFile)))
        //                {
        //                    //file_append++; 
        //                    //sThumbFile = sThumbExtension + System.IO.Path.GetFileNameWithoutExtension(myFile.FileName) + 
        //                    //    file_append.ToString() + extendName; 
        //                    System.IO.File.Delete(System.Web.HttpContext.Current.Server.MapPath(sThumbExtension + "//" + sThumbFile));
        //                }
        //                //缩略图保存的绝对路径 
        //                string smallImagePath = System.Web.HttpContext.Current.Server.MapPath(sThumbExtension) + "//" + sThumbFile;
        //                //新建一个图板,以最小等比例压缩大小绘制原图 
        //                using (System.Drawing.Image bitmap = new System.Drawing.Bitmap(smallWidth, smallHeight))
        //                {
        //                    //绘制中间图 
        //                    using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap))
        //                    {
        //                        //高清,平滑 
        //                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
        //                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //                        g.Clear(System.Drawing.Color.Black);
        //                        g.DrawImage(
        //                        sourceImage,
        //                        new System.Drawing.Rectangle(0, 0, smallWidth, smallHeight),
        //                        new System.Drawing.Rectangle(0, 0, width, height),
        //                        System.Drawing.GraphicsUnit.Pixel
        //                        );
        //                    }
        //                    //新建一个图板,以缩略图大小绘制中间图 
        //                    using (System.Drawing.Image bitmap1 = new System.Drawing.Bitmap(intThumbWidth, intThumbHeight))
        //                    {
        //                        //绘制缩略图 
        //                        using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap1))
        //                        {
        //                            //高清,平滑
        //                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
        //                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //                            g.Clear(System.Drawing.Color.Black);
        //                            int lwidth = (smallWidth - intThumbWidth) / 2;
        //                            int bheight = (smallHeight - intThumbHeight) / 2;
        //                            g.DrawImage(bitmap, new Rectangle(0, 0, intThumbWidth, intThumbHeight), lwidth, bheight, intThumbWidth, intThumbHeight, GraphicsUnit.Pixel);
        //                            g.Dispose();
        //                            bitmap.Save(smallImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            //出错则删除 
        //            System.IO.File.Delete(System.Web.HttpContext.Current.Server.MapPath(sSavePath + "//" + sFilename));
        //            return "上传图片失败";
        //        }
        //        //返回缩略图名称 

        //        return "上传图片成功";
        //    }
        //    return "没有选择图片";
        //}
    }
}
