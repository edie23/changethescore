using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using System.Collections;
namespace changethescore
{
    public class Db
    {
        string str;
        string constr;
        public  Db()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            
        }

        public string Constr
        {
            get
            {
                return constr;
            }
            set
            {
                constr = value;
            }
        }

         public void setstr(string str)
        {
            this.str = str;
        }

        public void constrset(string constrset)
        {
            this.constr = constrset;
        }

        public string nonquery(string constr, string str)
        {
             SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(str, con);
            try
            {
                con.Open();
                return cmd.ExecuteNonQuery().ToString();

            }
            catch (Exception e)//新建一个类型包含int 和 exception返回以表示错误信息，待完善
            {
                return e.Message;
            }
            finally
            {
                con.Close();
            }
        }

        public int Nonquery(string constr, string str)    //插入，更新
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(str, con);
            try
            {
                con.Open();
                return cmd.ExecuteNonQuery();
                    
            }
            catch (Exception e)//新建一个类型包含int 和 exception返回以表示错误信息，待完善
            {

                if (e.Message == "违反了 PRIMARY KEY 约束 'pk_article'。不能在对象 'f_article' 中插入重复键。\r\n语句已终止。")
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
                else if (e.Message == "INSERT 语句与 COLUMN FOREIGN KEY 约束 'fk_f_article_class' 冲突。该冲突发生于数据库 '" + Login.dataname + "'，表 'f_class_3', column 'class_3_no'。\r\n语句已终止。")
                {
                    return -2;
                }
                else if (e.Message == "无法打开登录 '" + Login.dataname + "' 中请求的数据库。登录失败。\r\n用户 'sa' 登录失败。")
                {
                    return -3;
                }
                else if (e.Message == "将截断字符串或二进制数据。\r\n语句已终止。")
                {
                    return -4;
                }
                else if (e.Message == "将数据类型varchar转换为numeric时出错。")
                {
                    return -5;
                }
                else
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }
                
            }
            finally
            {
                con.Close();
            }
        }

        public SqlDataReader read(string constr, string str)  //查询用直连
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(str, con);
            try
            {
                con.Open();
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("数据查询失败");

                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void dropBind(ArrayList arrText, ArrayList arrValue, ComboBox drop)  //用数组绑定下拉菜单
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("text");
            dt.Columns.Add("value");
            for (int i = 0; i < arrText.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["text"] = arrText[i].ToString().Trim();
                dr["value"]=arrValue[i].ToString().Trim();
                dt.Rows.Add(dr);
            }
            drop.DataSource = dt;
            drop.DisplayMember = "text";
            drop.ValueMember = "value";
        }

        public void bindDrop(string constr, string str, ComboBox drop,string first)//用数据源绑定下拉框
        {
            DataTable db = readbyad(constr, str,"tb").Tables[0];
            //drop.DataSource = ;
            drop.DataSource = db;
            DataRow dr = db.NewRow();
            dr[0] = first;
            dr[1] = first;
            db.Rows.InsertAt(dr, 0);
            drop.DisplayMember = db.Columns[0].ColumnName;
            drop.ValueMember = db.Columns[1].ColumnName;
          
        }

        //public int selectGetRowCount(string constr, string str)  //查询用直连
        //{
        //    SqlConnection con = new SqlConnection(constr);
        //    SqlCommand cmd = new SqlCommand(str, con);
        //    try
        //    {
        //        con.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        return cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("数据查询失败");

        //        return 0;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        public object readGetFrist(string constr, string str)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(str, con);
            try
            {
                con.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show("数据查询失败");
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        //public int selectByProcOne(string str, string str1, string str2)//查询用存储过程
        //{

        //    SqlConnection con = new SqlConnection(constr);
        //    SqlCommand cmd = new SqlCommand(str, con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@emp_no", str1);
        //    cmd.Parameters.AddWithValue("@pass", str2);
        //    try
        //    {
        //        con.Open();
        //        object o = cmd.ExecuteScalar();
        //        if (o != null)
        //        {
        //            return 1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("数据查询失败");
        //        return 0;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        public DataSet readbyad(string constr, string str, string fillstring)  //查询用数据集
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter dap = new SqlDataAdapter(str, con);
            try
            {
                con.Open();
                dap.Fill(ds, fillstring);
                return ds; 
            }
            catch (Exception e)
            {
                MessageBox.Show("数据查询失败");
                return null;
            }
            finally
            {
                con.Close();
            }
        }

      
        public int execStoredProcedure(string sqlstr,string inputstr1,string inputstr2,string inputvalue1,string inputvalue2)//执行审核入库单转反审核入库单
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue( inputstr1,inputvalue1);
            cmd.Parameters.AddWithValue( inputstr2,inputvalue2);
            try
            {
                con.Open();
                int o = cmd.ExecuteNonQuery();
                if(o==0)
                {
                    MessageBox.Show("执行不成功");
                    return 0;  
                }
                else
                {
                    return o;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("查询失败");
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public void sdsBindTogdvMenthod(string constr, string str, string fillstring, DataGridView dgdv)//数据源绑定数据控件的方法，用到db类
        {
            dgdv.DataSource = readbyad(constr, str);
            //dgdv.DataBind();
        }
        //绑定下拉框
        public void sdsBindTogdvMenthod(string constr, string str, string fillstring, ComboBox cmb,string displayMember,string valueMember)//数据源绑定数据控件的方法，用到db类
        {
            DataTable db = readbyad(constr, str, fillstring).Tables[0];
            //drop.DataSource = ;
            if (db.Columns.Count < 3)
            {
                if (db.Columns.Count == 0)
                {
                    MessageBox.Show("没有数据可以绑定到下拉框");
                }
                if (db.Columns.Count == 1)
                {
                    for (int i = 0; i < db.Rows.Count; i++)
                    {
                        cmb.DataSource=db;
                        cmb.DisplayMember = displayMember;
                        cmb.ValueMember = valueMember;
                        cmb.SelectedIndex = 0;
                    }
                }
                if (db.Columns.Count == 2)
                {
                    for (int i = 0; i < db.Rows.Count; i++)
                    {
                        cmb.DataSource = db;
                        cmb.DisplayMember = displayMember;
                        cmb.ValueMember =valueMember;
                        cmb.SelectedIndex = 0;
                    }
                }
            }
           

            //drop.DataBind();
        }


        public DataTable readbyad(string constr, string str)//20140630用read直接读取得到datatable
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(str, con);
            try
            {
                con.Open();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("查询数据失败"); 
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //public void gdvBindAliveNoButton(DataGridView gdv, string sqlstr)
        //{
        //    gdv.Columns.Clear();
        //    DataSet ds = readbyad(constr, sqlstr, "gdv");
        //    gdv.DataSource = ds.Tables[0];

        //    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)//动态增加列
        //    {
        //        BoundField bf = new BoundField();
        //        bf.DataField = ds.Tables[0].Columns[i].ColumnName;
        //        bf.HeaderText = ds.Tables[0].Columns[i].ColumnName;
        //        gdv.Columns.Add(bf);
        //        gdv.DataBind();
        //        gdv.GridLines = GridLines.Both;
        //    }

        //}
    }
}
