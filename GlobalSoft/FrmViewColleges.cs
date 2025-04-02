using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobalSoft
{
    public partial class FrmViewColleges : Form
    {
        public FrmViewColleges()
        {
            InitializeComponent();
        }

        private void FrmViewColleges_Load(object sender, EventArgs e)
        {
            LoadAllColleges();
        }
        public void LoadAllColleges()
        {
            try
            {
                DataTable dtResult;
                DataManager.DBReturnCode retCode = DataManager.ViewAllColleges(out dtResult);
                if (retCode == DataManager.DBReturnCode.SUCCESS)
                {
                    dgv_AllColleges.DataSource = dtResult;
                    dtResult.Dispose();
                }
                else if (retCode == DataManager.DBReturnCode.SUCCESSNORESULT)
                {
                    MessageBox.Show("no college present in database. please add any college name.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}