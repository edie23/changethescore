namespace changethescore
{
    partial class frmInv
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
            this.cmbVno = new System.Windows.Forms.ComboBox();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_real_inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_inc_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_in_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVno = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVno = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnLead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVno
            // 
            this.cmbVno.FormattingEnabled = true;
            this.cmbVno.Location = new System.Drawing.Point(98, 40);
            this.cmbVno.Name = "cmbVno";
            this.cmbVno.Size = new System.Drawing.Size(121, 20);
            this.cmbVno.TabIndex = 0;
            // 
            // dgvInv
            // 
            this.dgvInv.AllowUserToAddRows = false;
            this.dgvInv.AllowUserToDeleteRows = false;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ano,
            this.article_name,
            this.specific,
            this.unit_st,
            this.qty,
            this.qty_real_inv,
            this.qty_inc_dec,
            this.price,
            this.amount,
            this.price_in,
            this.price_in_amount,
            this.amount_dec});
            this.dgvInv.Location = new System.Drawing.Point(2, 67);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.RowTemplate.Height = 23;
            this.dgvInv.Size = new System.Drawing.Size(998, 500);
            this.dgvInv.TabIndex = 1;
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
            this.qty.HeaderText = "账面数";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // qty_real_inv
            // 
            this.qty_real_inv.DataPropertyName = "qty_real_inv";
            this.qty_real_inv.HeaderText = "实盘数";
            this.qty_real_inv.Name = "qty_real_inv";
            this.qty_real_inv.ReadOnly = true;
            // 
            // qty_inc_dec
            // 
            this.qty_inc_dec.DataPropertyName = "qty_inc_dec";
            this.qty_inc_dec.HeaderText = "损益数";
            this.qty_inc_dec.Name = "qty_inc_dec";
            this.qty_inc_dec.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "单价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "实盘金额";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // price_in
            // 
            this.price_in.DataPropertyName = "price_in";
            this.price_in.HeaderText = "进价";
            this.price_in.Name = "price_in";
            this.price_in.ReadOnly = true;
            // 
            // price_in_amount
            // 
            this.price_in_amount.DataPropertyName = "price_in_amount";
            this.price_in_amount.HeaderText = "进价金额";
            this.price_in_amount.Name = "price_in_amount";
            this.price_in_amount.ReadOnly = true;
            // 
            // amount_dec
            // 
            this.amount_dec.DataPropertyName = "amount_dec";
            this.amount_dec.HeaderText = "进销差价";
            this.amount_dec.Name = "amount_dec";
            this.amount_dec.ReadOnly = true;
            // 
            // lblVno
            // 
            this.lblVno.AutoSize = true;
            this.lblVno.Location = new System.Drawing.Point(51, 43);
            this.lblVno.Name = "lblVno";
            this.lblVno.Size = new System.Drawing.Size(41, 12);
            this.lblVno.TabIndex = 2;
            this.lblVno.Text = "凭证号";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(236, 38);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "选择凭证号";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "凭证号";
            // 
            // txtVno
            // 
            this.txtVno.Location = new System.Drawing.Point(558, 38);
            this.txtVno.Name = "txtVno";
            this.txtVno.Size = new System.Drawing.Size(100, 21);
            this.txtVno.TabIndex = 5;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(675, 36);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(98, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "直接输入凭证号";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnLead
            // 
            this.btnLead.Location = new System.Drawing.Point(848, 12);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(120, 23);
            this.btnLead.TabIndex = 7;
            this.btnLead.Text = "导出到execl";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // frmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtVno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblVno);
            this.Controls.Add(this.dgvInv);
            this.Controls.Add(this.cmbVno);
            this.Name = "frmInv";
            this.Text = "盘点历史帐导出";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVno;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Label lblVno;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVno;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn article_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn specific;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_st;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_real_inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_inc_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_in_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_dec;
    }
}