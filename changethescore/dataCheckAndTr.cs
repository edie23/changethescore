using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace changethescore
{
    public partial class dataCheckAndTr : Form
    {
        public dataCheckAndTr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string checkStr = "select sa_date, shift_no, dept_no, pos_no, cashier_no, salesman_no, retail_no, vip_no, amount_total, amount_get, amount_chg, amount_diff, credit_no, credit_amount, invoice_no, invoice_amount, bk_field1, bk_field2, get_1, get_2, get_3, get_4, get_5, get_6, get_7, get_8, sa_time from w_retail where retail_no not in (select retail_no from openrowset('sqloledb', '220.189.236.54'; 'sa'; '88808172',score_2.dbo.w_retail) where dept_no = 1 and sa_date = 13076) and dept_no = 1 and sa_date = 13076";



           //     insert into openrowset('sqloledb', '220.189.236.54'; 'sa'; '88808172',score_2.dbo.b_retail1) select sa_date, shift_no, dept_no, pos_no, cashier_no, salesman_no, retail_no, vip_no, amount_total, amount_get, amount_chg, amount_diff, credit_no, credit_amount, invoice_no, invoice_amount, bk_field1, bk_field2, get_1, get_2, get_3, get_4, get_5, get_6, get_7, get_8, sa_time from w_retail where retail_no not in (select retail_no from openrowset('sqloledb', '220.189.236.54'; 'sa'; '88808172',score_2.dbo.w_retail) where dept_no = 1 and sa_date = 13076) and dept_no = 1 and sa_date = 13076
           //                           --插入单据明细
           //                           insert into openrowset('sqloledb', '220.189.236.54'; 'sa'; '88808172',score_2.dbo.b_retail1_detail) select retail_no, ano, qty, price, amount, disc_amount, sa_type, ano_type, disc_type, creater, dept_no, salesman_no from w_retail_detail where retail_no in (select retail_no from w_retail where retail_no not in (select retail_no from openrowset('sqloledb', '220.189.236.54'; 'sa'; '88808172',score_2.dbo.w_retail) where dept_no = 1 and sa_date = 13076) and dept_no = 1 and sa_date = 13076)
           //select sa_date, shift_no, dept_no, pos_no, cashier_no, salesman_no, retail_no, vip_no, amount_total, amount_get, amount_chg, amount_diff, credit_no, credit_amount, invoice_no, invoice_amount, bk_field1, bk_field2, get_1, get_2, get_3, get_4, get_5, get_6, get_7, get_8, sa_time from w_retail where retail_no not in (select retail_no from openrowset('sqloledb', '220.189.236.54'; 'sa'; '88808172',score_2.dbo.w_retail) where dept_no = 1 and sa_date = 13076) and dept_no = 1 and sa_date = 13076
           //                        --插入单据信息



        }
    }
}
