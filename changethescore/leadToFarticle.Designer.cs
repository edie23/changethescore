namespace changethescore
{
    partial class leadToFarticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leadToFarticle));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.dgvExeclData = new System.Windows.Forms.DataGridView();
            this.cboExcelNames = new System.Windows.Forms.ComboBox();
            this.btnLead = new System.Windows.Forms.Button();
            this.lblExcelNames = new System.Windows.Forms.Label();
            this.btnGdvTodb = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.convertBarcode = new System.Windows.Forms.Button();
            this.btnSaveAsExcel = new System.Windows.Forms.Button();
            this.cbClass_3 = new System.Windows.Forms.CheckBox();
            this.cmbClass_3 = new System.Windows.Forms.ComboBox();
            this.btnLeadToB_in_store = new System.Windows.Forms.Button();
            this.btnCreateAno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExeclData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(75, 25);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(116, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "选择要导入的文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(208, 27);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(190, 21);
            this.txtFilename.TabIndex = 1;
            // 
            // dgvExeclData
            // 
            this.dgvExeclData.AllowUserToAddRows = false;
            this.dgvExeclData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExeclData.Location = new System.Drawing.Point(4, 65);
            this.dgvExeclData.Name = "dgvExeclData";
            this.dgvExeclData.RowTemplate.Height = 23;
            this.dgvExeclData.Size = new System.Drawing.Size(1002, 521);
            this.dgvExeclData.TabIndex = 2;
            // 
            // cboExcelNames
            // 
            this.cboExcelNames.FormattingEnabled = true;
            this.cboExcelNames.Location = new System.Drawing.Point(565, 28);
            this.cboExcelNames.Name = "cboExcelNames";
            this.cboExcelNames.Size = new System.Drawing.Size(121, 20);
            this.cboExcelNames.TabIndex = 3;
            this.cboExcelNames.SelectedIndexChanged += new System.EventHandler(this.cboExcelNames_SelectedIndexChanged);
            this.cboExcelNames.SelectionChangeCommitted += new System.EventHandler(this.cboExcelNames_SelectionChangeCommitted);
            // 
            // btnLead
            // 
            this.btnLead.Location = new System.Drawing.Point(695, 25);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(75, 23);
            this.btnLead.TabIndex = 4;
            this.btnLead.Text = "载入";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // lblExcelNames
            // 
            this.lblExcelNames.AutoSize = true;
            this.lblExcelNames.Location = new System.Drawing.Point(455, 31);
            this.lblExcelNames.Name = "lblExcelNames";
            this.lblExcelNames.Size = new System.Drawing.Size(95, 12);
            this.lblExcelNames.TabIndex = 5;
            this.lblExcelNames.Text = "文件中包含的表:";
            // 
            // btnGdvTodb
            // 
            this.btnGdvTodb.Location = new System.Drawing.Point(488, 614);
            this.btnGdvTodb.Name = "btnGdvTodb";
            this.btnGdvTodb.Size = new System.Drawing.Size(112, 33);
            this.btnGdvTodb.TabIndex = 6;
            this.btnGdvTodb.Text = "增加到商品档案";
            this.btnGdvTodb.UseVisualStyleBackColor = true;
            this.btnGdvTodb.Click += new System.EventHandler(this.btnGdvTodb_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(23, 314);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 12);
            this.lblWarning.TabIndex = 7;
            // 
            // convertBarcode
            // 
            this.convertBarcode.Location = new System.Drawing.Point(843, 25);
            this.convertBarcode.Name = "convertBarcode";
            this.convertBarcode.Size = new System.Drawing.Size(75, 23);
            this.convertBarcode.TabIndex = 9;
            this.convertBarcode.Text = "去掉科学计数法";
            this.convertBarcode.UseVisualStyleBackColor = true;
            this.convertBarcode.Visible = false;
            this.convertBarcode.Click += new System.EventHandler(this.convertBarcode_Click);
            // 
            // btnSaveAsExcel
            // 
            this.btnSaveAsExcel.Location = new System.Drawing.Point(796, 619);
            this.btnSaveAsExcel.Name = "btnSaveAsExcel";
            this.btnSaveAsExcel.Size = new System.Drawing.Size(122, 23);
            this.btnSaveAsExcel.TabIndex = 10;
            this.btnSaveAsExcel.Text = "导出到EXCEL";
            this.btnSaveAsExcel.UseVisualStyleBackColor = true;
            this.btnSaveAsExcel.Click += new System.EventHandler(this.btnSaveAsExcel_Click);
            // 
            // cbClass_3
            // 
            this.cbClass_3.AutoSize = true;
            this.cbClass_3.Location = new System.Drawing.Point(5, 623);
            this.cbClass_3.Name = "cbClass_3";
            this.cbClass_3.Size = new System.Drawing.Size(108, 16);
            this.cbClass_3.TabIndex = 11;
            this.cbClass_3.Text = "导入指定小类中";
            this.cbClass_3.UseVisualStyleBackColor = true;
            this.cbClass_3.Visible = false;
            this.cbClass_3.CheckedChanged += new System.EventHandler(this.cbClass_3_CheckedChanged);
            // 
            // cmbClass_3
            // 
            this.cmbClass_3.FormattingEnabled = true;
            this.cmbClass_3.Location = new System.Drawing.Point(119, 621);
            this.cmbClass_3.Name = "cmbClass_3";
            this.cmbClass_3.Size = new System.Drawing.Size(108, 20);
            this.cmbClass_3.TabIndex = 12;
            this.cmbClass_3.Visible = false;
            this.cmbClass_3.SelectedIndexChanged += new System.EventHandler(this.cmbClass_3_SelectedIndexChanged);
            this.cmbClass_3.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_3_SelectionChangeCommitted);
            // 
            // btnLeadToB_in_store
            // 
            this.btnLeadToB_in_store.Location = new System.Drawing.Point(715, 619);
            this.btnLeadToB_in_store.Name = "btnLeadToB_in_store";
            this.btnLeadToB_in_store.Size = new System.Drawing.Size(75, 23);
            this.btnLeadToB_in_store.TabIndex = 13;
            this.btnLeadToB_in_store.Text = "导入到库存";
            this.btnLeadToB_in_store.UseVisualStyleBackColor = true;
            this.btnLeadToB_in_store.Visible = false;
            this.btnLeadToB_in_store.Click += new System.EventHandler(this.btnLeadToB_in_store_Click);
            // 
            // btnCreateAno
            // 
            this.btnCreateAno.Location = new System.Drawing.Point(233, 619);
            this.btnCreateAno.Name = "btnCreateAno";
            this.btnCreateAno.Size = new System.Drawing.Size(145, 23);
            this.btnCreateAno.TabIndex = 14;
            this.btnCreateAno.Text = "根据所选分类产生编号";
            this.btnCreateAno.UseVisualStyleBackColor = true;
            this.btnCreateAno.Visible = false;
            this.btnCreateAno.Click += new System.EventHandler(this.btnCreateAno_Click);
            // 
            // leadToFarticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.btnCreateAno);
            this.Controls.Add(this.btnLeadToB_in_store);
            this.Controls.Add(this.cmbClass_3);
            this.Controls.Add(this.cbClass_3);
            this.Controls.Add(this.btnSaveAsExcel);
            this.Controls.Add(this.convertBarcode);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnGdvTodb);
            this.Controls.Add(this.lblExcelNames);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.cboExcelNames);
            this.Controls.Add(this.dgvExeclData);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnSelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "leadToFarticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据导入";
            this.Load += new System.EventHandler(this.leadToFarticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExeclData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.DataGridView dgvExeclData;
        private System.Windows.Forms.ComboBox cboExcelNames;
        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.Label lblExcelNames;
        private System.Windows.Forms.Button btnGdvTodb;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button convertBarcode;
        private System.Windows.Forms.Button btnSaveAsExcel;
        private System.Windows.Forms.CheckBox cbClass_3;
        private System.Windows.Forms.ComboBox cmbClass_3;
        private System.Windows.Forms.Button btnLeadToB_in_store;
        private System.Windows.Forms.Button btnCreateAno;

    }
}