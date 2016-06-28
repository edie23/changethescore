namespace changethescore
{
    partial class frmArticle
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealer_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_retail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_vip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feature1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feature2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bk_field1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bk_field2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ano,
            this.article_name,
            this.unit_st,
            this.specific,
            this.manu_name,
            this.mark_name,
            this.dealer_no,
            this.dealer_name,
            this.price_in,
            this.price_retail,
            this.price_vip,
            this.barcode,
            this.feature1,
            this.feature2,
            this.bk_field1,
            this.bk_field2});
            this.dgv.Location = new System.Drawing.Point(-1, 26);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(857, 287);
            this.dgv.TabIndex = 0;
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
            this.article_name.HeaderText = "商品名称";
            this.article_name.Name = "article_name";
            this.article_name.ReadOnly = true;
            // 
            // unit_st
            // 
            this.unit_st.DataPropertyName = "unit_st";
            this.unit_st.HeaderText = "单位";
            this.unit_st.Name = "unit_st";
            this.unit_st.ReadOnly = true;
            // 
            // specific
            // 
            this.specific.DataPropertyName = "specific";
            this.specific.HeaderText = "规格";
            this.specific.Name = "specific";
            this.specific.ReadOnly = true;
            // 
            // manu_name
            // 
            this.manu_name.DataPropertyName = "manu_name";
            this.manu_name.HeaderText = "产地";
            this.manu_name.Name = "manu_name";
            this.manu_name.ReadOnly = true;
            // 
            // mark_name
            // 
            this.mark_name.DataPropertyName = "mark_name";
            this.mark_name.HeaderText = "品牌";
            this.mark_name.Name = "mark_name";
            this.mark_name.ReadOnly = true;
            // 
            // dealer_no
            // 
            this.dealer_no.DataPropertyName = "dealer_no";
            this.dealer_no.HeaderText = "供货商编号";
            this.dealer_no.Name = "dealer_no";
            this.dealer_no.ReadOnly = true;
            // 
            // dealer_name
            // 
            this.dealer_name.DataPropertyName = "dealer_name";
            this.dealer_name.HeaderText = "供货商名称";
            this.dealer_name.Name = "dealer_name";
            this.dealer_name.ReadOnly = true;
            // 
            // price_in
            // 
            this.price_in.DataPropertyName = "price_in";
            this.price_in.HeaderText = "进价";
            this.price_in.Name = "price_in";
            this.price_in.ReadOnly = true;
            // 
            // price_retail
            // 
            this.price_retail.DataPropertyName = "price_retail";
            this.price_retail.HeaderText = "零售价";
            this.price_retail.Name = "price_retail";
            this.price_retail.ReadOnly = true;
            // 
            // price_vip
            // 
            this.price_vip.DataPropertyName = "price_vip";
            this.price_vip.HeaderText = "会员价";
            this.price_vip.Name = "price_vip";
            this.price_vip.ReadOnly = true;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "条形码";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // feature1
            // 
            this.feature1.DataPropertyName = "feature1";
            this.feature1.HeaderText = "特征1";
            this.feature1.Name = "feature1";
            this.feature1.ReadOnly = true;
            // 
            // feature2
            // 
            this.feature2.DataPropertyName = "feature2";
            this.feature2.HeaderText = "特征2";
            this.feature2.Name = "feature2";
            this.feature2.ReadOnly = true;
            // 
            // bk_field1
            // 
            this.bk_field1.DataPropertyName = "bk_field1";
            this.bk_field1.HeaderText = "备用1";
            this.bk_field1.Name = "bk_field1";
            this.bk_field1.ReadOnly = true;
            // 
            // bk_field2
            // 
            this.bk_field2.DataPropertyName = "bk_field2";
            this.bk_field2.HeaderText = "备用2";
            this.bk_field2.Name = "bk_field2";
            this.bk_field2.ReadOnly = true;
            // 
            // btnSaveToExcel
            // 
            this.btnSaveToExcel.Location = new System.Drawing.Point(63, 342);
            this.btnSaveToExcel.Name = "btnSaveToExcel";
            this.btnSaveToExcel.Size = new System.Drawing.Size(91, 23);
            this.btnSaveToExcel.TabIndex = 1;
            this.btnSaveToExcel.Text = "导出到EXCEL";
            this.btnSaveToExcel.UseVisualStyleBackColor = true;
            this.btnSaveToExcel.Click += new System.EventHandler(this.btnSaveToExcel_Click);
            // 
            // frmForLHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 427);
            this.Controls.Add(this.btnSaveToExcel);
            this.Controls.Add(this.dgv);
            this.Name = "frmForLHS";
            this.Text = "frmForLHS";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn article_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn specific;
        private System.Windows.Forms.DataGridViewTextBoxColumn manu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealer_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_retail;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_vip;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn feature1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feature2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bk_field1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bk_field2;
        private System.Windows.Forms.Button btnSaveToExcel;
    }
}