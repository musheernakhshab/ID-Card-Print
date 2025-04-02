using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;

namespace GlobalSoft
{
    public partial class FrmAddCollege : Form
    {
        Image ImageLogo;
        Image ImageSign;
        String ImgName;
        String ImgSign;
        public FrmAddCollege()
        {
            InitializeComponent();
        }

        private void bttn_SelectLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(open.FileName);
                ImgName = open.SafeFileName;
                lbl_Logo.Text = ImgName;
                ImageLogo = resizeImage(img, new Size(100, 100));
                pictureBox_Logo.Image = ImageLogo; //*.GetThumbnailImage(150, 150, null, new IntPtr());
                open.RestoreDirectory = true;
                //ImageLogo.Save("c:\\button.gif", System.Drawing.Imaging.ImageFormat.Gif);
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void bttn_Sign_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(open.FileName);
                ImgSign = open.SafeFileName;
                lbl_Signiture.Text = ImgSign;
                ImageSign = resizeImage(img, new Size(123, 36));
                pictureBox_Sign.Image = ImageSign; //*.GetThumbnailImage(150, 150, null, new IntPtr());
                open.RestoreDirectory = true;
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            String ImgPath = System.Windows.Forms.Application.StartupPath;
            ImgName = GenerateFileName(ImgName);
            ImgSign = GenerateFileName(ImgSign);
            ImgPath += @"\College\";
            try
            {
                if (ValidateInput())
                {
                    DataManager.DBReturnCode rCode = DataManager.AddCollege(txtBox_CollegeName.Text, txtBox_SansthaName.Text, txtBox_CAddress.Text, txtBox_Zip.Text, txtBox_Contact.Text, txtBox_Email.Text, txtBox_Website.Text, ImgName, ImgSign);
                    if (rCode == DataManager.DBReturnCode.SUCCESS)
                    {
                        ImageLogo.Save(ImgPath + ImgName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        ImageSign.Save(ImgPath + ImgSign, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("College Inserted succesfully.");
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string GenerateFileName(string context)
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + Guid.NewGuid().ToString() + context;
        }
        public void Clear()
        {
            txtBox_CollegeName.Text = "";
            txtBox_SansthaName.Text = "";
            txtBox_CAddress.Text = "";
            txtBox_Zip.Text = "";
            txtBox_Contact.Text = "";
            txtBox_Email.Text = "";
            txtBox_Website.Text = "";
            pictureBox_Logo = null;
            pictureBox_Sign = null;
            pictureBox_Logo.Image = null;
            pictureBox_Sign.Image = null;
        }
        bool ValidateInput()
        {
            bool result = false;
            if (txtBox_CollegeName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter college name.");
                txtBox_CollegeName.Focus();
            }
            else if (txtBox_SansthaName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter name of sanstha.");
                txtBox_SansthaName.Focus();
            }
            else if (txtBox_CAddress.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter address.");
                txtBox_CAddress.Focus();
            }
            else if (txtBox_Zip.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter zip / picode.");
                txtBox_Zip.Focus();
            }
            else if (txtBox_Contact.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter contact no.");
                txtBox_Contact.Focus();
            }
            else if (txtBox_Email.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter email.");
                txtBox_Email.Focus();
            }
            else
            {
                return true;
            }
            return result;
        }

        private void FrmAddCollege_Load(object sender, EventArgs e)
        {

        }

        
    }
}