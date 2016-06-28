using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class touchScore : Form
    {
        public touchScore()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.listView1.View = View.LargeIcon;
            ColumnHeader columnHeader0 = new ColumnHeader();
            columnHeader0.Text = "Title";
            //this.listView1.LargeImageList = this.imageList1;
            ListViewGroup group1 = new ListViewGroup("分类");
            group1.Name = "class_3_no";
            //ListViewGroup group2 = new ListViewGroup("商品");

            listView1.Groups.Add(group1);
            //listView1.Groups.Add(group2);


            Db d = new Db();
            DataTable dt = d.readbyad(Login.score_2Constr, "select class_3_no,class_3_name from f_class_3");
            //this.listView1.BeginUpdate();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(group1);

                //lvi.ImageIndex = i;

                lvi.Text = dt.Rows[i][1].ToString();
                
                lvi.Tag= dt.Rows[i][0].ToString();


                this.listView1.Items.Add(lvi);
            }
         

            //this.listView1.EndUpdate();


        }
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0&&listView1.SelectedItems[0].Group.Name=="class_3_no")
            {
                if (listView1.Groups.Count > 1)
                {
                    listView1.Groups[1].Items.Clear();
                    listView1.Groups.Remove(listView1.Groups[1]);

                }
                    ListViewGroup group2 = new ListViewGroup("商品");
                    listView1.Groups.Add(group2);
                    Db d = new Db();
                    string sqlstr = "select top 100 ano, article_name,price_retail,specific,unit_st from f_article where class_3_no='" + listView1.SelectedItems[0].Tag.ToString().Trim() + "'";
                    DataTable dt = d.readbyad(Login.score_2Constr, sqlstr);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem(group2);

                        //lvi.ImageIndex = i;

                        lvi.Text = dt.Rows[i][1].ToString();

                        lvi.Tag = dt.Rows[i][0].ToString();



                        this.listView1.Items.Add(lvi);



                    }
                
            }
        }
    }
}
