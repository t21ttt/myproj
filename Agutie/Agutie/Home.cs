using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agutie
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Parent newMDIChil = new Parent();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }
        Student newMDIChild;
        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild == null)
            {

                Student newMDIChild = new Student();
                // Set the Parent Form of the Child window.
                newMDIChild.FormClosed += new FormClosedEventHandler(newMDIChild_formClosed);
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();
            }
            else
                newMDIChild.Activate();

        }

        private void newMDIChild_formClosed(object sender, FormClosedEventArgs e)
        {
            newMDIChild = null;
           // throw new NotImplementedException();
        }

        private void subgradeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Teacher newMDIChil = new Teacher();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }

        private void parentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            subgrade newMDIChil = new subgrade();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void teacherPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subgrade newMDIChil = new subgrade();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }

        private void parentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Parent newMDIChil = new Parent();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }

        private void studentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild == null)
            {

                Student newMDIChild = new Student();
                // Set the Parent Form of the Child window.
                newMDIChild.FormClosed += new FormClosedEventHandler(newMDIChild_formClosed);
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Show();
            }
            else
                newMDIChild.Activate();
        }

        private void subGradePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher newMDIChil = new Teacher();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SUBJECT newMDIChil = new SUBJECT();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SUBJECT newMDIChil = new SUBJECT();
            // Set the Parent Form of the Child window.
            newMDIChil.MdiParent = this;
            // Display the new form.
            newMDIChil.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            studsection sc = new studsection();
            sc.MdiParent = this;
            sc.Show();
        }
    }
}
