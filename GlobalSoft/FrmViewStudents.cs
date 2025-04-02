using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobalSoft
{
    public partial class FrmViewStudents : Form
    {
        public FrmViewStudents()
        {
            InitializeComponent();
        }

        private void FrmViewStudents_Load(object sender, EventArgs e)
        {
            LoadCollegeName();
        }
        public void LoadCollegeName()
        {
            try
            {
                comboBox_College.Items.Clear();
                DataTable dtResult;
                DataManager.DBReturnCode retCode = DataManager.GetCollegeName(out dtResult);
                if (retCode == DataManager.DBReturnCode.SUCCESS)
                {
                    foreach (DataRow dr in dtResult.Rows)
                    {
                        CollegeName objCollegeName = new CollegeName();
                        objCollegeName.sCName = dr["sCName"].ToString();
                        objCollegeName.nID = Convert.ToInt64(dr["nID"]);
                        comboBox_College.Items.Add(objCollegeName).ToString();
                        dtResult.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void bttn_View_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtResult;
                CollegeName objCollegeName = (CollegeName)comboBox_College.SelectedItem;
                DataManager.DBReturnCode retCode = DataManager.ViewStudentByCID(Convert.ToInt64(objCollegeName.nID), out dtResult);
                if (retCode == DataManager.DBReturnCode.SUCCESS)
                {
                    dgv_StudentByCID.DataSource = dtResult;
                    dtResult.Dispose();
                }
                else if (retCode == DataManager.DBReturnCode.SUCCESSNORESULT)
                {
                    MessageBox.Show("no Student present in database.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                    String dateString = theDate.ToString("dd-MM-yy");
                    formatting.Value = dateString;
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    // Set to false in case there are other handlers interested trying to
                    // format this DataGridViewCellFormattingEventArgs instance.
                    formatting.FormattingApplied = false;
                }
            }
        }

        private void dgv_StudentByCID_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_StudentByCID.Columns[e.ColumnIndex].Name == "dDOB")
            {
                ShortFormDateFormat(e);
            }
        }
    }
}