using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Drawing.Imaging;

namespace GlobalSoft
{
    public partial class FrmPrintStudentID : Form
    {
        public FrmPrintStudentID()
        {
            InitializeComponent();
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

        private void FrmPrintStudentID_Load(object sender, EventArgs e)
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
        private void dgv_StudentByCID_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_StudentByCID.Columns[e.ColumnIndex].Name == "dDOB")
            {
                ShortFormDateFormat(e);
            }
        }

        private void dgv_StudentByCID_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (rBttn_Front.Checked || rBttn_Back.Checked)
                {
                    if (dgv_StudentByCID.SelectedRows != null && e.RowIndex != -1)
                    {
                        Int64 StudentID = Convert.ToInt64(dgv_StudentByCID.SelectedRows[0].Cells["nID"].Value);
                        String sCardSide = String.Empty;
                        if (rBttn_Back.Checked)
                        {
                            sCardSide = "Back";
                        }
                        else
                        {
                            sCardSide = "Front";
                        }
                        //MessageBox.Show(StudentID.ToString());
                        StudentID = StudentID - 1;
                        //MessageBox.Show(StudentID.ToString());
                        InsertFile(StudentID, sCardSide);
                        //InsertFile(@"c:\\Barcode.png", sSize, nMRP, sProductName, sStyle);
                    }
                }
                else
                {
                    MessageBox.Show("Please select print side of id card.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void InsertFile(Int64 SID, String CardSide)
        {
            try
            {
                DataTable dtResult;
                DataManager.DBReturnCode retCode = DataManager.GetStudentToPrint(SID,out dtResult);
                if (retCode == DataManager.DBReturnCode.SUCCESS)
                {
                    String ImgPath = System.Windows.Forms.Application.StartupPath;
                    String sHtml = String.Empty;
                    if (CardSide == "Front")
                    {
                        foreach (DataRow dr in dtResult.Rows)
                        {
                            String Lpath = ImgPath + @"\College\" + dr["sLogoPath"].ToString();
                            Lpath = Lpath.Replace(@"\", "/");
                            String Ppath = ImgPath + @"\Student\" + dr["sPassportPhoto"].ToString();
                            Ppath = Ppath.Replace(@"\", "/");
                            String Spath = ImgPath + @"\College\" + dr["sASign"].ToString();
                            Spath = Spath.Replace(@"\", "/");

                            sHtml += "<div style='float:left; padding:2px; margin:20px 10px 2px 5px; border:1px solid red; width:330px;'>";
                            sHtml += "<table width='100%' border='0' style='font-family:'Times New Roman'; font-weight:bold; font-size:11px; line-height:5px;'>";
                            sHtml += "<tr><td width='68px'><img src=" + Lpath.ToString() + " width='50'/></td>";
                            sHtml += "<td colspan='3' style='text-align:center; color:#FF6600; font-size:13px; font-weight:bold;'>" + dr["sSName"].ToString() + "<br />";
                            sHtml += "<span style='font-size:15px; color:#f90813'>" + dr["sCName"].ToString() + "</span><br />Address : " + dr["CAddress"].ToString() + "</td></tr>";
                            sHtml += "<tr><td colspan='4' style='border:1px solid #000000; text-align:center; font-size:12px;'>IDENTITY CARD</td></tr>";
                            sHtml += "<tr style='font-size:13px;'><td colspan='2' style='width:40px;'>Name</td><td style='color:#f90813'>: " + dr["sStudentName"].ToString() + "</td>";
                            sHtml += "<td rowspan='7' style='border:1px solid green; width:110px; text-align:center; font-size:11px;'><img src=" + Ppath.ToString() + " width='70' height='77'/><br />";
                            sHtml += "<img src=" + Spath.ToString() + " width='70' height='25'/><br>Signature of Authority</td></tr>";
                            sHtml += "<tr style='font-size:13px;'><td colspan='2'>Class </td><td>: " + dr["sClass"].ToString() + "</td></tr>";
                            sHtml += "<tr style='font-size:13px;'><td colspan='2'>DOB</td><td>: " + Convert.ToDateTime(dr["dDOB"]).ToShortDateString() + "</td></tr>";
                            sHtml += "<tr style='font-size:13px;'><td colspan='2'>Blood Group</td><td style='color:#f90813'>: " + dr["sBloodGroup"].ToString() + "</td></tr>";
                            sHtml += "<tr style='font-size:13px;'><td colspan='2'>Session</td><td>: " + dr["sSession"].ToString() + "</td></tr>";
                            sHtml += "<tr style='font-size:13px;'><td colspan='2'>Student Id</td><td>: " + dr["sSID"].ToString() + "</td></tr>";
                            sHtml += "<tr style='font-size:13px;'><td colspan='2'>Contact No.</td><td>: " + dr["sContactNo"].ToString() + "</td></tr>";
                            sHtml += "</table>";
                            sHtml += "</div>";
                        }
                        webBrowser1.DocumentText = sHtml;
                    }
                    else if (CardSide == "Back")
                    {
                        foreach (DataRow dr in dtResult.Rows)
                        {
                            sHtml += "<div style='float:right; padding:13px; margin:20px 5px 2px 10px; border:0px solid red; width:330px;'>";
                            sHtml += "<table width='100%' border='0' style='font-family:'Times New Roman'; font-weight:bold; font-size:11px; line-height:3px;'>";
                            sHtml += "<tr style='font-size:11px;'><td style='width:40px;'>DL.No</td><td>: " + dr["sDrivingLicence"].ToString() +" </td></tr>";
                            sHtml += "<tr style='font-size:11px;'><td style='width:40px;'>Address</td><td>: " + dr["sAddress"].ToString() + "</td></tr>";
                            sHtml += "<tr style='font-size:11px;'><td colspan='2'>";
                            sHtml += "<ul><span style='color:#FF6600'>INSRUCTION :- </span><li>This Card is not Transferable.</li>";
                            sHtml += "<li>Always Display This Card in college premises.</li>";
                            sHtml += "<li>Duplicate shall be issued at cost, if lost.</li>";
                            sHtml += "<li>If lost college office should be informed immediately. if found, please return to.</li></ul></td></tr>";
                            sHtml += "<tr><td colspan='2' style='padding:10px 20px 10px 20px;;'><div style='padding:5px 10px 5px 10px; border:1px solid #000000; font-size:11px;'>" + dr["sCName"].ToString() + "<br />";
                            sHtml += "" + dr["CAddress"].ToString() + "-" + dr["sZip"].ToString() +",  " + dr["CContact"].ToString() +"<br>";
                            sHtml += "E-mail Adderess:- <span style='color:#100599'>" + dr["sEmailId"].ToString() +"</span>";
                            sHtml += "</div></td></tr>";
                            sHtml += "</table>";
                            sHtml += "</div>";
                        }
                        webBrowser1.DocumentText = sHtml;
                    }
                    
                }
                else if (retCode == DataManager.DBReturnCode.SUCCESSNORESULT)
                {
                    MessageBox.Show("No data present in database.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }
        
    }
}