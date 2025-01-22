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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void blLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "admin" && tbxPassword.Text == "123")
            {
                DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                MessageBox.Show("Invalid Username / Password", "Login Faild !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
