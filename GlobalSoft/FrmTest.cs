using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GlobalSoft
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            Int64 SID = 3;
            try
            {
                DataTable dtResult;
                DataManager.DBReturnCode retCode = DataManager.GetStudentToPrint(SID, out dtResult);
                if (retCode == DataManager.DBReturnCode.SUCCESS)
                {
                    String ImgPath = System.Windows.Forms.Application.StartupPath;
                    String LogoImgPath = ImgPath + @"\College\" + dtResult.Rows[0]["sLogoPath"].ToString();
                    pictureBox1.ImageLocation = LogoImgPath;
                    //LogoImgPath.Replace("\", "\/");
                    String slash = "/";
                    //String rchar = @"\";
                    //Regex.Replace(LogoImgPath, @"\", slash);
                    LogoImgPath = LogoImgPath.Replace(@"\", slash);
                    MessageBox.Show(LogoImgPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}