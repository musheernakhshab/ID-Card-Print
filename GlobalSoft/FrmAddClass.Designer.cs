namespace GlobalSoft
{
    partial class FrmAddClass
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttn_Close = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.txtBox_ClassName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Class_Name = new System.Windows.Forms.DataGridView();
            this.nID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Class_Name)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1087, 46);
            this.panel1.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkGreen;
            this.label22.Location = new System.Drawing.Point(150, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 29);
            this.label22.TabIndex = 2;
            this.label22.Text = "Add Classes";
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
            this.panel2.Controls.Add(this.bttn_Close);
            this.panel2.Controls.Add(this.bttn_Add);
            this.panel2.Controls.Add(this.txtBox_ClassName);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 104);
            this.panel2.TabIndex = 33;
            // 
            // bttn_Close
            // 
            this.bttn_Close.Location = new System.Drawing.Point(101, 68);
            this.bttn_Close.Name = "bttn_Close";
            this.bttn_Close.Size = new System.Drawing.Size(75, 23);
            this.bttn_Close.TabIndex = 11;
            this.bttn_Close.Text = "Close";
            this.bttn_Close.UseVisualStyleBackColor = true;
            this.bttn_Close.Click += new System.EventHandler(this.bttn_Close_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(184, 68);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(75, 23);
            this.bttn_Add.TabIndex = 10;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // txtBox_ClassName
            // 
            this.txtBox_ClassName.Location = new System.Drawing.Point(132, 42);
            this.txtBox_ClassName.Name = "txtBox_ClassName";
            this.txtBox_ClassName.Size = new System.Drawing.Size(127, 20);
            this.txtBox_ClassName.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(17, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 18);
            this.label19.TabIndex = 39;
            this.label19.Text = "Add Classes Below :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Enter Class Name";
            // 
            // dgv_Class_Name
            // 
            this.dgv_Class_Name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Class_Name.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nID,
            this.sClass});
            this.dgv_Class_Name.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Class_Name.Location = new System.Drawing.Point(69, 162);
            this.dgv_Class_Name.Name = "dgv_Class_Name";
            this.dgv_Class_Name.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Class_Name.Size = new System.Drawing.Size(194, 150);
            this.dgv_Class_Name.TabIndex = 34;
            // 
            // nID
            // 
            this.nID.DataPropertyName = "nID";
            this.nID.HeaderText = "ID";
            this.nID.Name = "nID";
            this.nID.Width = 50;
            // 
            // sClass
            // 
            this.sClass.DataPropertyName = "sClass";
            this.sClass.HeaderText = "Class Name";
            this.sClass.Name = "sClass";
            // 
            // FrmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1087, 722);
            this.Controls.Add(this.dgv_Class_Name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddClass";
            this.Text = "Classes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAddClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Class_Name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttn_Close;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.TextBox txtBox_ClassName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn nID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sClass;
    }
}