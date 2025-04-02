using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobalSoft
{
    public partial class FrmAddClass : Form
    {
        public FrmAddClass()
        {
            InitializeComponent();
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    DataTable dtResult;
                    DataManager.DBReturnCode retCode = DataManager.ChkClassName(txtBox_ClassName.Text, out dtResult);
                    if (retCode == DataManager.DBReturnCode.SUCCESSNORESULT)
                    {
                        DataManager.DBReturnCode rCode = DataManager.AddClassName(txtBox_ClassName.Text);
                        if (rCode == DataManager.DBReturnCode.SUCCESS)
                        {
                            txtBox_ClassName.Text = "";
                            MessageBox.Show("Class add successfully.");
                            LoadClassName();
                        }
                        else
                        {
                            MessageBox.Show("Error to add class name.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Class name already present.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void LoadClassName()
        {
            try
            {
                DataTable dtResult;
                DataManager.DBReturnCode retCode = DataManager.GetClassName(out dtResult);
                if (retCode == DataManager.DBReturnCode.SUCCESS)
                {
                    dgv_Class_Name.DataSource = dtResult;
                    dtResult.Dispose();
                }
                else if (retCode == DataManager.DBReturnCode.SUCCESSNORESULT)
                {
                    MessageBox.Show("no class name present in database. please add any class name.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FrmAddClass_Load(object sender, EventArgs e)
        {
            LoadClassName();
        }
        bool ValidateInput()
        {
            bool result = false;
            if (txtBox_ClassName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter class name.");
                txtBox_ClassName.Focus();
            }
            else
            {
              return true;
            }
            return result;
        }
    }
}