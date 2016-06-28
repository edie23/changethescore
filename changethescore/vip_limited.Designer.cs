namespace changethescore
{
    partial class vip_limited
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
            this.dgVip_limited = new System.Windows.Forms.DataGridView();
            this.vip_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnLead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVip_limited)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVip_limited
            // 
            this.dgVip_limited.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVip_limited.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vip_no,
            this.limited});
            this.dgVip_limited.Location = new System.Drawing.Point(175, 101);
            this.dgVip_limited.Name = "dgVip_limited";
            this.dgVip_limited.RowTemplate.Height = 23;
            this.dgVip_limited.Size = new System.Drawing.Size(403, 454);
            this.dgVip_limited.TabIndex = 0;
            // 
            // vip_no
            // 
            this.vip_no.DataPropertyName = "vip_no";
            this.vip_no.HeaderText = "会员号";
            this.vip_no.Name = "vip_no";
            // 
            // limited
            // 
            this.limited.DataPropertyName = "limited";
            this.limited.HeaderText = "会员使用次数";
            this.limited.MinimumWidth = 20;
            this.limited.Name = "limited";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(462, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始时间";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "结束时间";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(352, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "查找";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLead
            // 
            this.btnLead.Location = new System.Drawing.Point(487, 72);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(75, 23);
            this.btnLead.TabIndex = 5;
            this.btnLead.Text = "导出excel";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // vip_limited
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgVip_limited);
            this.Name = "vip_limited";
            this.Text = "vip_limited";
            this.Load += new System.EventHandler(this.vip_limited_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVip_limited)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVip_limited;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn limited;
        private System.Windows.Forms.Button btnLead;
    }
}