namespace changethescore
{
    partial class frmscoredetail
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
            this.dgdvscore = new System.Windows.Forms.DataGridView();
            this.ope_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score_orig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score_inc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score_now = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.lblVip_no = new System.Windows.Forms.Label();
            this.txtVip_no = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgdvscore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdvscore
            // 
            this.dgdvscore.AllowUserToAddRows = false;
            this.dgdvscore.AllowUserToDeleteRows = false;
            this.dgdvscore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdvscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdvscore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ope_date,
            this.vip_no,
            this.op,
            this.score_orig,
            this.subject,
            this.score_inc,
            this.score_dec,
            this.score_now});
            this.dgdvscore.Location = new System.Drawing.Point(8, 36);
            this.dgdvscore.Name = "dgdvscore";
            this.dgdvscore.ReadOnly = true;
            this.dgdvscore.RowTemplate.Height = 23;
            this.dgdvscore.Size = new System.Drawing.Size(803, 149);
            this.dgdvscore.TabIndex = 0;
            // 
            // ope_date
            // 
            this.ope_date.DataPropertyName = "ope_date";
            this.ope_date.HeaderText = "时间";
            this.ope_date.Name = "ope_date";
            this.ope_date.ReadOnly = true;
            this.ope_date.Width = 54;
            // 
            // vip_no
            // 
            this.vip_no.DataPropertyName = "vip_no";
            this.vip_no.HeaderText = "会员号";
            this.vip_no.Name = "vip_no";
            this.vip_no.ReadOnly = true;
            this.vip_no.Width = 66;
            // 
            // op
            // 
            this.op.DataPropertyName = "operator";
            this.op.HeaderText = "操作员";
            this.op.Name = "op";
            this.op.ReadOnly = true;
            this.op.Width = 66;
            // 
            // score_orig
            // 
            this.score_orig.DataPropertyName = "score_orig";
            this.score_orig.HeaderText = "原积分";
            this.score_orig.Name = "score_orig";
            this.score_orig.ReadOnly = true;
            this.score_orig.Width = 66;
            // 
            // subject
            // 
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "摘要";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 54;
            // 
            // score_inc
            // 
            this.score_inc.DataPropertyName = "score_inc";
            this.score_inc.HeaderText = "积分增加";
            this.score_inc.Name = "score_inc";
            this.score_inc.ReadOnly = true;
            this.score_inc.Width = 78;
            // 
            // score_dec
            // 
            this.score_dec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.score_dec.DataPropertyName = "score_dec";
            this.score_dec.HeaderText = "积分减少";
            this.score_dec.Name = "score_dec";
            this.score_dec.ReadOnly = true;
            this.score_dec.Width = 78;
            // 
            // score_now
            // 
            this.score_now.DataPropertyName = "score_now";
            this.score_now.HeaderText = "现积分";
            this.score_now.Name = "score_now";
            this.score_now.ReadOnly = true;
            this.score_now.Width = 66;
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(36, 191);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnToExcel.TabIndex = 1;
            this.btnToExcel.Text = "导出excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // lblVip_no
            // 
            this.lblVip_no.AutoSize = true;
            this.lblVip_no.Location = new System.Drawing.Point(189, 196);
            this.lblVip_no.Name = "lblVip_no";
            this.lblVip_no.Size = new System.Drawing.Size(41, 12);
            this.lblVip_no.TabIndex = 2;
            this.lblVip_no.Text = "会员号";
            // 
            // txtVip_no
            // 
            this.txtVip_no.Location = new System.Drawing.Point(236, 193);
            this.txtVip_no.Name = "txtVip_no";
            this.txtVip_no.Size = new System.Drawing.Size(100, 21);
            this.txtVip_no.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(359, 191);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(62, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmscoredetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 306);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtVip_no);
            this.Controls.Add(this.lblVip_no);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.dgdvscore);
            this.Name = "frmscoredetail";
            this.Text = "积分明细查询";
            this.Load += new System.EventHandler(this.frmscoredetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdvscore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdvscore;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.Label lblVip_no;
        private System.Windows.Forms.TextBox txtVip_no;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ope_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn op;
        private System.Windows.Forms.DataGridViewTextBoxColumn score_orig;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn score_inc;
        private System.Windows.Forms.DataGridViewTextBoxColumn score_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn score_now;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}