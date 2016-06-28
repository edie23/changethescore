namespace changethescore
{
    partial class score_front
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmp_noText = new System.Windows.Forms.Label();
            this.lblEmp_no = new System.Windows.Forms.Label();
            this.lblPos_notext = new System.Windows.Forms.Label();
            this.lblDept_noText = new System.Windows.Forms.Label();
            this.lblCashier_noText = new System.Windows.Forms.Label();
            this.lblPos_no = new System.Windows.Forms.Label();
            this.lblDept_no = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_retail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashier_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sa_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblsumCost = new System.Windows.Forms.Label();
            this.lblSumQty = new System.Windows.Forms.Label();
            this.lblSumText = new System.Windows.Forms.Label();
            this.lblWrite = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmp_noText
            // 
            this.lblEmp_noText.AutoSize = true;
            this.lblEmp_noText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmp_noText.Location = new System.Drawing.Point(27, 24);
            this.lblEmp_noText.Name = "lblEmp_noText";
            this.lblEmp_noText.Size = new System.Drawing.Size(53, 12);
            this.lblEmp_noText.TabIndex = 0;
            this.lblEmp_noText.Text = "收款员：";
            // 
            // lblEmp_no
            // 
            this.lblEmp_no.AutoSize = true;
            this.lblEmp_no.Location = new System.Drawing.Point(86, 24);
            this.lblEmp_no.Name = "lblEmp_no";
            this.lblEmp_no.Size = new System.Drawing.Size(0, 12);
            this.lblEmp_no.TabIndex = 1;
            // 
            // lblPos_notext
            // 
            this.lblPos_notext.AutoSize = true;
            this.lblPos_notext.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPos_notext.Location = new System.Drawing.Point(228, 24);
            this.lblPos_notext.Name = "lblPos_notext";
            this.lblPos_notext.Size = new System.Drawing.Size(53, 12);
            this.lblPos_notext.TabIndex = 2;
            this.lblPos_notext.Text = "收款机：";
            // 
            // lblDept_noText
            // 
            this.lblDept_noText.AutoSize = true;
            this.lblDept_noText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDept_noText.Location = new System.Drawing.Point(429, 24);
            this.lblDept_noText.Name = "lblDept_noText";
            this.lblDept_noText.Size = new System.Drawing.Size(41, 12);
            this.lblDept_noText.TabIndex = 3;
            this.lblDept_noText.Text = "部门：";
            // 
            // lblCashier_noText
            // 
            this.lblCashier_noText.AutoSize = true;
            this.lblCashier_noText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCashier_noText.Location = new System.Drawing.Point(596, 24);
            this.lblCashier_noText.Name = "lblCashier_noText";
            this.lblCashier_noText.Size = new System.Drawing.Size(53, 12);
            this.lblCashier_noText.TabIndex = 4;
            this.lblCashier_noText.Text = "营业员：";
            // 
            // lblPos_no
            // 
            this.lblPos_no.AutoSize = true;
            this.lblPos_no.Location = new System.Drawing.Point(287, 24);
            this.lblPos_no.Name = "lblPos_no";
            this.lblPos_no.Size = new System.Drawing.Size(0, 12);
            this.lblPos_no.TabIndex = 5;
            // 
            // lblDept_no
            // 
            this.lblDept_no.AutoSize = true;
            this.lblDept_no.Location = new System.Drawing.Point(491, 24);
            this.lblDept_no.Name = "lblDept_no";
            this.lblDept_no.Size = new System.Drawing.Size(0, 12);
            this.lblDept_no.TabIndex = 6;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Location = new System.Drawing.Point(656, 24);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(0, 12);
            this.lblCashier.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvArticle);
            this.panel1.Location = new System.Drawing.Point(-2, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 331);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 35);
            this.panel2.TabIndex = 9;
            // 
            // dgvArticle
            // 
            this.dgvArticle.AllowUserToAddRows = false;
            this.dgvArticle.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ano,
            this.article_name,
            this.specific,
            this.unit_st,
            this.qty,
            this.price_retail,
            this.amount,
            this.disc,
            this.disc_rate,
            this.dept_no,
            this.cashier_no,
            this.sa_type});
            this.dgvArticle.Location = new System.Drawing.Point(0, -3);
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.ReadOnly = true;
            this.dgvArticle.RowTemplate.Height = 23;
            this.dgvArticle.Size = new System.Drawing.Size(1240, 340);
            this.dgvArticle.TabIndex = 0;
            this.dgvArticle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticle_CellContentClick);
            // 
            // ano
            // 
            this.ano.DataPropertyName = "ano";
            this.ano.HeaderText = "商品编号";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            // 
            // article_name
            // 
            this.article_name.DataPropertyName = "article_name";
            this.article_name.HeaderText = "名称";
            this.article_name.Name = "article_name";
            this.article_name.ReadOnly = true;
            // 
            // specific
            // 
            this.specific.DataPropertyName = "specific";
            this.specific.HeaderText = "规格";
            this.specific.Name = "specific";
            this.specific.ReadOnly = true;
            // 
            // unit_st
            // 
            this.unit_st.DataPropertyName = "unit_st";
            this.unit_st.HeaderText = "单位";
            this.unit_st.Name = "unit_st";
            this.unit_st.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "数量";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // price_retail
            // 
            this.price_retail.DataPropertyName = "price_retail";
            this.price_retail.HeaderText = "单价";
            this.price_retail.Name = "price_retail";
            this.price_retail.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "金额";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // disc
            // 
            this.disc.DataPropertyName = "disc";
            this.disc.HeaderText = "折扣";
            this.disc.Name = "disc";
            this.disc.ReadOnly = true;
            // 
            // disc_rate
            // 
            this.disc_rate.DataPropertyName = "disc_rate";
            this.disc_rate.HeaderText = "折扣率";
            this.disc_rate.Name = "disc_rate";
            this.disc_rate.ReadOnly = true;
            // 
            // dept_no
            // 
            this.dept_no.DataPropertyName = "dept_no";
            this.dept_no.HeaderText = "部门";
            this.dept_no.Name = "dept_no";
            this.dept_no.ReadOnly = true;
            // 
            // cashier_no
            // 
            this.cashier_no.DataPropertyName = "cashier_no";
            this.cashier_no.HeaderText = "营业员";
            this.cashier_no.Name = "cashier_no";
            this.cashier_no.ReadOnly = true;
            // 
            // sa_type
            // 
            this.sa_type.DataPropertyName = "sa_type";
            this.sa_type.HeaderText = "销售类型";
            this.sa_type.Name = "sa_type";
            this.sa_type.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblsumCost);
            this.panel3.Controls.Add(this.lblSumQty);
            this.panel3.Controls.Add(this.lblSumText);
            this.panel3.Controls.Add(this.lblWrite);
            this.panel3.Controls.Add(this.txtWrite);
            this.panel3.Location = new System.Drawing.Point(1, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 46);
            this.panel3.TabIndex = 9;
            // 
            // lblsumCost
            // 
            this.lblsumCost.AutoSize = true;
            this.lblsumCost.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblsumCost.Location = new System.Drawing.Point(690, 3);
            this.lblsumCost.Name = "lblsumCost";
            this.lblsumCost.Size = new System.Drawing.Size(73, 29);
            this.lblsumCost.TabIndex = 4;
            this.lblsumCost.Text = "0.00";
            // 
            // lblSumQty
            // 
            this.lblSumQty.AutoSize = true;
            this.lblSumQty.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumQty.Location = new System.Drawing.Point(563, 3);
            this.lblSumQty.Name = "lblSumQty";
            this.lblSumQty.Size = new System.Drawing.Size(73, 29);
            this.lblSumQty.TabIndex = 3;
            this.lblSumQty.Text = "0.00";
            // 
            // lblSumText
            // 
            this.lblSumText.AutoSize = true;
            this.lblSumText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSumText.Location = new System.Drawing.Point(479, 12);
            this.lblSumText.Name = "lblSumText";
            this.lblSumText.Size = new System.Drawing.Size(66, 19);
            this.lblSumText.TabIndex = 2;
            this.lblSumText.Text = "小计：";
            // 
            // lblWrite
            // 
            this.lblWrite.AutoSize = true;
            this.lblWrite.Location = new System.Drawing.Point(11, 12);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(41, 12);
            this.lblWrite.TabIndex = 1;
            this.lblWrite.Text = "输入：";
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(58, 9);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(238, 21);
            this.txtWrite.TabIndex = 0;
            this.txtWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWrite_KeyDown);
            // 
            // score_front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.lblDept_no);
            this.Controls.Add(this.lblPos_no);
            this.Controls.Add(this.lblCashier_noText);
            this.Controls.Add(this.lblDept_noText);
            this.Controls.Add(this.lblPos_notext);
            this.Controls.Add(this.lblEmp_no);
            this.Controls.Add(this.lblEmp_noText);
            this.Name = "score_front";
            this.Text = "score_front";
            this.Load += new System.EventHandler(this.score_front_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmp_noText;
        private System.Windows.Forms.Label lblEmp_no;
        private System.Windows.Forms.Label lblPos_notext;
        private System.Windows.Forms.Label lblDept_noText;
        private System.Windows.Forms.Label lblCashier_noText;
        private System.Windows.Forms.Label lblPos_no;
        private System.Windows.Forms.Label lblDept_no;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvArticle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblsumCost;
        private System.Windows.Forms.Label lblSumQty;
        private System.Windows.Forms.Label lblSumText;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn article_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn specific;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_retail;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashier_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn sa_type;
    }
}