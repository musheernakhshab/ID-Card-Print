using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobalSoft
{
    public partial class MDIParent_Main : Form
    {
        private int childFormNumber = 0;

        public MDIParent_Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCollege objFrmAddCollege = new FrmAddCollege();
            objFrmAddCollege.MdiParent = this;
            objFrmAddCollege.Show();
        }

        private void bttn_add_Student_Click(object sender, EventArgs e)
        {
            FrmAddStudent objFrmAddStudent = new FrmAddStudent();
            objFrmAddStudent.MdiParent = this;
            objFrmAddStudent.Show();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent objFrmAddStudent = new FrmAddStudent();
            objFrmAddStudent.MdiParent = this;
            objFrmAddStudent.Show();
        }

        private void addClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddClass objFrmAddClass = new FrmAddClass();
            objFrmAddClass.MdiParent = this;
            objFrmAddClass.Show();
        }

        private void bttn_AddCollege_Click(object sender, EventArgs e)
        {
            FrmAddCollege objFrmAddCollege = new FrmAddCollege();
            objFrmAddCollege.MdiParent = this;
            objFrmAddCollege.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent objFrmAddStudent = new FrmAddStudent();
            objFrmAddStudent.MdiParent = this;
            objFrmAddStudent.Show();
        }

        private void collegeSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCollege objFrmAddCollege = new FrmAddCollege();
            objFrmAddCollege.MdiParent = this;
            objFrmAddCollege.Show();
        }

        private void bttn_ViewCollege_Click(object sender, EventArgs e)
        {
            FrmViewColleges objFrmViewColleges = new FrmViewColleges();
            objFrmViewColleges.MdiParent = this;
            objFrmViewColleges.Show();
        }

        private void bttn_ViewStudent_Click(object sender, EventArgs e)
        {
            FrmViewStudents objFrmViewStudents = new FrmViewStudents();
            objFrmViewStudents.MdiParent = this;
            objFrmViewStudents.Show();
        }

        private void bttn_PrintStudentCard_Click(object sender, EventArgs e)
        {
            FrmPrintStudentID objFrmPrintStudentID = new FrmPrintStudentID();
            objFrmPrintStudentID.MdiParent = this;
            objFrmPrintStudentID.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTest objFrmTest = new FrmTest();
            objFrmTest.MdiParent = this;
            objFrmTest.Show();
        }

    }
}
