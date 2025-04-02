namespace GlobalSoft
{
    partial class FrmPrintStudentID
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_College = new System.Windows.Forms.ComboBox();
            this.bttn_View = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_StudentByCID = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.nID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDrivingLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.rBttn_Front = new System.Windows.Forms.RadioButton();
            this.rBttn_Back = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentByCID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(379, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "( To view Students List Please Select College Below )";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 46);
            this.panel1.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkGreen;
            this.label22.Location = new System.Drawing.Point(150, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(223, 29);
            this.label22.TabIndex = 2;
            this.label22.Text = "Print Student ID Card";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Controls.Add(this.rBttn_Back);
            this.panel2.Controls.Add(this.rBttn_Front);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_College);
            this.panel2.Controls.Add(this.bttn_View);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(309, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 110);
            this.panel2.TabIndex = 35;
            // 
            // comboBox_College
            // 
            this.comboBox_College.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_College.FormattingEnabled = true;
            this.comboBox_College.Location = new System.Drawing.Point(147, 42);
            this.comboBox_College.Name = "comboBox_College";
            this.comboBox_College.Size = new System.Drawing.Size(344, 21);
            this.comboBox_College.TabIndex = 40;
            // 
            // bttn_View
            // 
            this.bttn_View.Location = new System.Drawing.Point(497, 41);
            this.bttn_View.Name = "bttn_View";
            this.bttn_View.Size = new System.Drawing.Size(75, 23);
            this.bttn_View.TabIndex = 10;
            this.bttn_View.Text = "View";
            this.bttn_View.UseVisualStyleBackColor = true;
            this.bttn_View.Click += new System.EventHandler(this.bttn_View_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(17, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(282, 18);
            this.label19.TabIndex = 39;
            this.label19.Text = "To View Students List Please Select College :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Select College Name";
            // 
            // dgv_StudentByCID
            // 
            this.dgv_StudentByCID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentByCID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nID,
            this.sSID,
            this.sStudentName,
            this.sClass,
            this.dDOB,
            this.sBloodGroup,
            this.sSession,
            this.sContactNo,
            this.sDrivingLicense,
            this.sAddress});
            this.dgv_StudentByCID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_StudentByCID.Location = new System.Drawing.Point(43, 186);
            this.dgv_StudentByCID.Name = "dgv_StudentByCID";
            this.dgv_StudentByCID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_StudentByCID.Size = new System.Drawing.Size(1027, 508);
            this.dgv_StudentByCID.TabIndex = 36;
            this.dgv_StudentByCID.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentByCID_CellDoubleClick);
            this.dgv_StudentByCID.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_StudentByCID_CellFormatting);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(43, 64);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(245, 110);
            this.webBrowser1.TabIndex = 37;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // nID
            // 
            this.nID.DataPropertyName = "nID";
            this.nID.HeaderText = "ID";
            this.nID.Name = "nID";
            // 
            // sSID
            // 
            this.sSID.DataPropertyName = "sSID";
            this.sSID.HeaderText = "Student ID";
            this.sSID.Name = "sSID";
            this.sSID.ReadOnly = true;
            // 
            // sStudentName
            // 
            this.sStudentName.DataPropertyName = "sStudentName";
            this.sStudentName.HeaderText = "Student Name";
            this.sStudentName.Name = "sStudentName";
            // 
            // sClass
            // 
            this.sClass.DataPropertyName = "sClass";
            this.sClass.HeaderText = "Class";
            this.sClass.Name = "sClass";
            this.sClass.ReadOnly = true;
            // 
            // dDOB
            // 
            this.dDOB.DataPropertyName = "dDOB";
            this.dDOB.HeaderText = "Date Of Birth";
            this.dDOB.Name = "dDOB";
            this.dDOB.ReadOnly = true;
            // 
            // sBloodGroup
            // 
            this.sBloodGroup.DataPropertyName = "sBloodGroup";
            this.sBloodGroup.HeaderText = "Blood Group";
            this.sBloodGroup.Name = "sBloodGroup";
            this.sBloodGroup.ReadOnly = true;
            // 
            // sSession
            // 
            this.sSession.DataPropertyName = "sSession";
            this.sSession.HeaderText = "Session";
            this.sSession.Name = "sSession";
            this.sSession.ReadOnly = true;
            // 
            // sContactNo
            // 
            this.sContactNo.DataPropertyName = "sContactNo";
            this.sContactNo.HeaderText = "Contact No";
            this.sContactNo.Name = "sContactNo";
            this.sContactNo.ReadOnly = true;
            // 
            // sDrivingLicense
            // 
            this.sDrivingLicense.DataPropertyName = "sDrivingLicence";
            this.sDrivingLicense.HeaderText = "Driving License";
            this.sDrivingLicense.Name = "sDrivingLicense";
            this.sDrivingLicense.ReadOnly = true;
            this.sDrivingLicense.Width = 150;
            // 
            // sAddress
            // 
            this.sAddress.DataPropertyName = "sAddress";
            this.sAddress.HeaderText = "Address";
            this.sAddress.Name = "sAddress";
            this.sAddress.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Card side to print";
            // 
            // rBttn_Front
            // 
            this.rBttn_Front.AutoSize = true;
            this.rBttn_Front.Location = new System.Drawing.Point(149, 75);
            this.rBttn_Front.Name = "rBttn_Front";
            this.rBttn_Front.Size = new System.Drawing.Size(49, 17);
            this.rBttn_Front.TabIndex = 42;
            this.rBttn_Front.TabStop = true;
            this.rBttn_Front.Text = "Front";
            this.rBttn_Front.UseVisualStyleBackColor = true;
            // 
            // rBttn_Back
            // 
            this.rBttn_Back.AutoSize = true;
            this.rBttn_Back.Location = new System.Drawing.Point(204, 75);
            this.rBttn_Back.Name = "rBttn_Back";
            this.rBttn_Back.Size = new System.Drawing.Size(50, 17);
            this.rBttn_Back.TabIndex = 43;
            this.rBttn_Back.TabStop = true;
            this.rBttn_Back.Text = "Back";
            this.rBttn_Back.UseVisualStyleBackColor = true;
            // 
            // FrmPrintStudentID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1112, 794);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dgv_StudentByCID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrintStudentID";
            this.Text = "Print Student ID Cartd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrintStudentID_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentByCID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_College;
        private System.Windows.Forms.Button bttn_View;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_StudentByCID;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn sContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDrivingLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddress;
        private System.Windows.Forms.RadioButton rBttn_Back;
        private System.Windows.Forms.RadioButton rBttn_Front;
        private System.Windows.Forms.Label label2;
    }
}