using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void oldAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void oldAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees obj2 = new Fees();
            obj2.ShowDialog();
        }

        private void newAdmissionToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            NewAdmission obj1 = new NewAdmission();
            obj1.ShowDialog();
        }

        private void searchStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchStudent obj3 = new SearchStudent();
            obj3.ShowDialog();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualDetails obj4 = new IndividualDetails();
            obj4.ShowDialog();
        }

        private void aDDINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher obj5 = new teacher();
            obj5.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchTeacher obj6 = new SearchTeacher();
            obj6.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent obj7 = new DeleteStudent();
            obj7.ShowDialog();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCollege obj8 = new AboutCollege();
            obj8.ShowDialog();
        }

        private void oldAdmissionToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OldAdmission obj9 = new OldAdmission();
            obj9.ShowDialog();
        }
    }
}
