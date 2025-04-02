namespace GlobalSoft
{
    partial class FrmViewColleges
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgv_AllColleges = new System.Windows.Forms.DataGridView();
            this.nID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllColleges)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 46);
            this.panel1.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkGreen;
            this.label22.Location = new System.Drawing.Point(150, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 29);
            this.label22.TabIndex = 2;
            this.label22.Text = "View All Colleges";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkRed;
            this.label21.Location = new System.Drawing.Point(21, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 29);
            this.label21.TabIndex = 1;
            this.label21.Text = "Global Soft";
            // 
            // dgv_AllColleges
            // 
            this.dgv_AllColleges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllColleges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nID,
            this.sCName,
            this.sSName,
            this.sAddress,
            this.sZip,
            this.sContactNo,
            this.sEmailId,
            this.sWebsite});
            this.dgv_AllColleges.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_AllColleges.Location = new System.Drawing.Point(26, 80);
            this.dgv_AllColleges.Name = "dgv_AllColleges";
            this.dgv_AllColleges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllColleges.Size = new System.Drawing.Size(938, 402);
            this.dgv_AllColleges.TabIndex = 4;
            // 
            // nID
            // 
            this.nID.DataPropertyName = "nID";
            this.nID.HeaderText = "ID";
            this.nID.Name = "nID";
            this.nID.Width = 50;
            // 
            // sCName
            // 
            this.sCName.DataPropertyName = "sCName";
            this.sCName.HeaderText = "College Name";
            this.sCName.Name = "sCName";
            this.sCName.Width = 200;
            // 
            // sSName
            // 
            this.sSName.DataPropertyName = "sSName";
            this.sSName.HeaderText = "Sanstha Name";
            this.sSName.Name = "sSName";
            this.sSName.Width = 200;
            // 
            // sAddress
            // 
            this.sAddress.DataPropertyName = "sAddress";
            this.sAddress.HeaderText = "Address";
            this.sAddress.Name = "sAddress";
            this.sAddress.Width = 200;
            // 
            // sZip
            // 
            this.sZip.DataPropertyName = "sZip";
            this.sZip.HeaderText = "Zip / Pincode";
            this.sZip.Name = "sZip";
            // 
            // sContactNo
            // 
            this.sContactNo.DataPropertyName = "sContactNo";
            this.sContactNo.HeaderText = "Contact No";
            this.sContactNo.Name = "sContactNo";
            // 
            // sEmailId
            // 
            this.sEmailId.DataPropertyName = "sEmailId";
            this.sEmailId.HeaderText = "Email ID";
            this.sEmailId.Name = "sEmailId";
            // 
            // sWebsite
            // 
            this.sWebsite.DataPropertyName = "sWebsite";
            this.sWebsite.HeaderText = "Website";
            this.sWebsite.Name = "sWebsite";
            this.sWebsite.ReadOnly = true;
            // 
            // FrmViewColleges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(976, 722);
            this.Controls.Add(this.dgv_AllColleges);
            this.Controls.Add(this.panel1);
            this.Name = "FrmViewColleges";
            this.Text = "View Colleges";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmViewColleges_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllColleges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgv_AllColleges;
        private System.Windows.Forms.DataGridViewTextBoxColumn nID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sWebsite;
    }
}