namespace changethescore
{
    partial class formdiv
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
            this.lblOldVno = new System.Windows.Forms.Label();
            this.lblNewVno = new System.Windows.Forms.Label();
            this.txtNewVno = new System.Windows.Forms.TextBox();
            this.cmbOldVno = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldVno
            // 
            this.lblOldVno.AutoSize = true;
            this.lblOldVno.Location = new System.Drawing.Point(37, 9);
            this.lblOldVno.Name = "lblOldVno";
            this.lblOldVno.Size = new System.Drawing.Size(65, 12);
            this.lblOldVno.TabIndex = 0;
            this.lblOldVno.Text = "已审核单据";
            // 
            // lblNewVno
            // 
            this.lblNewVno.AutoSize = true;
            this.lblNewVno.Location = new System.Drawing.Point(37, 44);
            this.lblNewVno.Name = "lblNewVno";
            this.lblNewVno.Size = new System.Drawing.Size(65, 12);
            this.lblNewVno.TabIndex = 2;
            this.lblNewVno.Text = "反审核单据";
            // 
            // txtNewVno
            // 
            this.txtNewVno.Location = new System.Drawing.Point(127, 41);
            this.txtNewVno.Name = "txtNewVno";
            this.txtNewVno.Size = new System.Drawing.Size(100, 21);
            this.txtNewVno.TabIndex = 3;
            // 
            // cmbOldVno
            // 
            this.cmbOldVno.FormattingEnabled = true;
            this.cmbOldVno.Location = new System.Drawing.Point(127, 6);
            this.cmbOldVno.Name = "cmbOldVno";
            this.cmbOldVno.Size = new System.Drawing.Size(121, 20);
            this.cmbOldVno.TabIndex = 4;
            this.cmbOldVno.SelectedIndexChanged += new System.EventHandler(this.cmbOldVno_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(127, 81);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确定\r\n";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // formdiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 266);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbOldVno);
            this.Controls.Add(this.txtNewVno);
            this.Controls.Add(this.lblNewVno);
            this.Controls.Add(this.lblOldVno);
            this.Name = "formdiv";
            this.Text = "formdiv";
            this.Load += new System.EventHandler(this.formdiv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldVno;
        private System.Windows.Forms.Label lblNewVno;
        private System.Windows.Forms.TextBox txtNewVno;
        private System.Windows.Forms.ComboBox cmbOldVno;
        private System.Windows.Forms.Button btnOk;
    }
}