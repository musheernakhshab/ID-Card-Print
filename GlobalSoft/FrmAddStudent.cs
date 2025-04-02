using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobalSoft
{
    public partial class FrmAddStudent : Form
    {
        Image PPhoto;
        String PhotoName;
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            LoadCollegeName();
            LoadClassName();
            //lbl_SID.Text = Guid.NewGuid().ToString();
            LoadSUID();
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
        public void LoadClassName()
        {
            try
            {
                comboBox_Class.Items.Clear();
                DataTable dtResult;
                DataManager.DBReturnCode rCode = DataManager.GetClassName(out dtResult);
                if (rCode == DataManager.DBReturnCode.SUCCESS)
                {
                    foreach (DataRow dr in dtResult.Rows)
                    {
                        ClassName objClassName = new ClassName();
                        objClassName.sClass = dr["sClass"].ToString();
                        objClassName.nID = Convert.ToInt64(dr["nID"]);
                        comboBox_Class.Items.Add(objClassName).ToString();
                        dtResult.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void bttn_SelectPPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(open.FileName);
                PhotoName = open.SafeFileName;
                lbl_PhotoName.Text = PhotoName;
                PPhoto = resizeImage(img, new Size(157, 155));
                pictureBox_PPhoto.Image = PPhoto; //*.GetThumbnailImage(150, 150, null, new IntPtr());
                open.RestoreDirectory = true;
                //ImageLogo.Save("c:\\button.gif", System.Drawing.Imaging.ImageFormat.Gif);
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public void LoadSUID()
        {
            lbl_SID.Text = "GSS" + DateTime.Now.ToString("yyMMddHHmmss");
        }
        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            String ImgPath = System.Windows.Forms.Application.StartupPath;
            PhotoName = GenerateFileName(PhotoName);
            ImgPath += @"\Student\";
            CollegeName objCollegeName = (CollegeName)comboBox_College.SelectedItem;
            ClassName objClassName = (ClassName)comboBox_Class.SelectedItem;
            try
            {
                if (ValidateInput())
                {
                    DataManager.DBReturnCode rCode = DataManager.AddStudent(Convert.ToInt64(objCollegeName.nID), txtBox_StudentName.Text, Convert.ToInt64(objClassName.nID), Convert.ToDateTime(dtp_dob.Value), comboBox_BloodGroup.SelectedItem.ToString(), comboBox_Session.SelectedItem.ToString(), textBox_Contact.Text, textBox_License.Text, textBox_Address.Text, lbl_SID.Text, PhotoName);
                    if (rCode == DataManager.DBReturnCode.SUCCESS)
                    {
                        PPhoto.Save(ImgPath + PhotoName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("student details Inserted succesfully.");
                        Clear();
                        LoadSUID();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string GenerateFileName(string context)
        {
            return Guid.NewGuid().ToString() + context;
        }
        bool ValidateInput()
        {
            bool result = false;
            if (comboBox_College.SelectedIndex == -1)
            {
                MessageBox.Show("Please select college.");
                comboBox_College.Focus();
            }
            if (txtBox_StudentName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter student name.");
                txtBox_StudentName.Focus();
            }
            else if (comboBox_Class.SelectedIndex ==- 1)
            {
                MessageBox.Show("Please select class.");
                comboBox_Class.Focus();
            }
            else if (comboBox_BloodGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please select blood group.");
                comboBox_BloodGroup.Focus();
            }
            else if (comboBox_Session.SelectedIndex == -1)
            {
                MessageBox.Show("Please select academic session.");
                comboBox_Session.Focus();
            }
            else if (textBox_Contact.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter contact no.");
                textBox_Contact.Focus();
            }
            else if (textBox_Address.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter address.");
                textBox_Address.Focus();
            }
            else if (pictureBox_PPhoto.Image==null)
            {
                MessageBox.Show("Please select passport size photo.");
                bttn_SelectPPhoto.Focus();
            }
            else
            {
                return true;
            }
            return result;
        }
        public void Clear()
        {
            txtBox_StudentName.Text = "";
            textBox_Contact.Text = "";
            textBox_License.Text = "";
            textBox_Address.Text = "";
            lbl_SID.Text="";
            pictureBox_PPhoto.Image=null;
        }
    }
}