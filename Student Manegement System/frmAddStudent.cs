using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Manegement_System
{
    public partial class frmAddStudent : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxFullName.Clear();
            tbxAddress.Clear();
            tbxUsername.Clear();
            tbxPassword.Clear();
            tbxConfirmPassword.Clear();
            cbbxIDType.Text = "Select ID Type";
            tbxIDNumber.Clear();
            dtpdob.Value = DateTime.Now;
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
            cbxHome.Checked = false;
            cbxMobile.Checked = false;
            cbxOffice.Checked = false;
            tbxMobile.Clear();
            tbxHome.Clear();
            tbxOffice.Clear();
        }

        private void cbxOffice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxOffice.Checked == true)
            {
                tbxOffice.Enabled = true;
            }
            else
            {
                tbxOffice.Enabled = false;
                tbxOffice.Clear();
            }
        }

        private void cbxHome_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHome.Checked == true)
            {
                tbxHome.Enabled = true;
            }
            else
            {
                tbxHome.Enabled = false;
                tbxHome.Clear();
            }
        }

        private void cbxMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMobile.Checked == true)
            {
                tbxMobile.Enabled = true;
            }
            else
            {
                tbxMobile.Enabled = false;
                tbxMobile.Clear();
            }
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlAddStudent.Enabled = true;
        }

        private void tbxFullName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbxFirstName.Text == null || tbxLastName.Text == null || tbxAddress.Text == null || tbxUsername.Text == null || tbxPassword.Text == null || tbxIDNumber.Text == null || cbbxIDType.Text == "Select ID Type" || dtpdob.Value == DateTime.Now)
            {
                MessageBox.Show("Please fill all fields !!");
            }
            else if(tbxPassword.Text != tbxConfirmPassword.Text)
            {
                MessageBox.Show("Check your Password again!");
            }
            else if (rdbMale.Checked == false && rdbFemale.Checked == false)
            {
                MessageBox.Show("Please select gender !!!");
            }
            else
            {


                string gender = "";
                if (rdbMale.Checked == true)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }

                con.ConnectionString = @"Data Source=DESKTOP-4R7P5UD\SQLEXPRESS;Initial Catalog=name1;Persist Security Info=True;User ID=sa;Password=123";
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO tblStudentDetails VALUES ('" + tbxFirstName.Text + "','" + tbxLastName.Text + "','" + tbxFullName.Text + "','" + tbxAddress.Text + "','" + tbxUsername.Text + "','" + tbxPassword.Text + "','" + tbxIDNumber.Text + "','" + cbbxIDType.Text + "','" + dtpdob.Value.ToShortDateString() + "','" + gender + "','" + tbxMobile.Text + "','" + tbxHome.Text + "','" + tbxOffice.Text + "')";
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has been saved successfully !");
                con.Close();

                tbxFirstName.Clear();
                tbxLastName.Clear();
                tbxFullName.Clear();
                tbxAddress.Clear();
                tbxUsername.Clear();
                tbxPassword.Clear();
                tbxConfirmPassword.Clear();
                cbbxIDType.Text = "Select ID Type";
                tbxIDNumber.Clear();
                dtpdob.Value = DateTime.Now;
                rdbFemale.Checked = false;
                rdbMale.Checked = false;
                cbxHome.Checked = false;
                cbxMobile.Checked = false;
                cbxOffice.Checked = false;
                tbxMobile.Clear();
                tbxHome.Clear();
                tbxOffice.Clear();
            }
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbxMobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
