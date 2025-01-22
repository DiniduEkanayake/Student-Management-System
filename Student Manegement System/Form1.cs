using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Manegement_System
{
    public partial class mnuMain : Form
    {   
        
        public mnuMain()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            if(login.ShowDialog() == DialogResult.OK)
            {
                mnuitmAddStudent.Enabled = true;
                mnuitmEditStudent.Enabled = true;
                mnuitmRemoveStudent.Enabled = true;
                mnuitmLogout.Enabled = true;
                mnuitmLogin.Enabled = false;
            }
            else
            {
                mnuitmAddStudent.Enabled = false;
                mnuitmEditStudent.Enabled = false;
                mnuitmRemoveStudent.Enabled = false;
                mnuitmLogout.Enabled = false;
                mnuitmLogin.Enabled = false;

            }
        }  
        

        private void mnuMain_Load(object sender, EventArgs e)
        {
             
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent add = new frmAddStudent();
            add.ShowDialog();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditStudent add = new frmEditStudent();
            add.ShowDialog();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveStudent add = new frmRemoveStudent();
            add.ShowDialog();


        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuitmAddStudent.Enabled = false;
            mnuitmEditStudent.Enabled = false;
            mnuitmRemoveStudent.Enabled = false;
            mnuitmLogout.Enabled = false;
            mnuitmLogin.Enabled = true;
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
