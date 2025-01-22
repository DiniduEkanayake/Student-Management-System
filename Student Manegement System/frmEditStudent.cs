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
    public partial class frmEditStudent : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();
        
        public frmEditStudent()
        {
            InitializeComponent();
        }

        

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            if(ds.Tables["tblStudentDetials"] != null)
            {
                ds.Tables["tblStudentDetials"].Clear();
            }
            con.ConnectionString = @"Data Source=DESKTOP-4R7P5UD\SQLEXPRESS;Initial Catalog=name1;Persist Security Info=True;User ID=sa;Password=123";
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStudentDetails",con);
            da.Fill(ds, "tblStudentDetails");
            con.Close();

            int currentrow = 0;
            int rowcount = ds.Tables["tblStudentDetails"].Rows.Count;

            while(currentrow < rowcount)
            {
                lbxStudents.Items.Add(ds.Tables["tblStudentDetails"].Rows[currentrow].ItemArray[3].ToString());
                currentrow++;
            }
        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables["tblStudentDetails"].Clear();
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStudentDetails WHERE FullName= '"+lbxStudents.SelectedItem.ToString()+"' ", con);
            da.Fill(ds, "tblStudentDetails");
            con.Close();

            tbxFirstName.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[1].ToString();
            tbxLastName.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[2].ToString();
            tbxFullName.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[3].ToString();
            tbxAddress.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[4].ToString();
            tbxUsername.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[5].ToString();
            tbxPassword.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[6].ToString();
            tbxIDNumber.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[7].ToString();
            cbbxIDType.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[8].ToString();
            dtpdob.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[9].ToString();
            
            if(ds.Tables["tblStudentDetails"].Rows[0].ItemArray[10].ToString() == "female")
            {
                rdbFemale.Checked = true;
            }
            else
            {
                rdbMale.Checked = true;
            }

            tbxMobile.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[11].ToString();
            if (ds.Tables["tblStudentDetails"].Rows[0].ItemArray[11].ToString() != null)
            {
                cbxMobile.Checked = true;
            }
            else
            {
                cbxMobile.Checked = false;
            }
            tbxHome.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[12].ToString();
            if (ds.Tables["tblStudentDetails"].Rows[0].ItemArray[12].ToString() != null)
            {
                cbxHome.Checked = true;
            }
            else
            {
                cbxHome.Checked = false;
            }
            tbxOffice.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[13].ToString();
            if (ds.Tables["tblStudentDetails"].Rows[0].ItemArray[13].ToString() != null)
            {
                cbxOffice.Checked = true;
            }
            else
            {
                cbxOffice.Checked = false;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxFirstName.Text == null || tbxLastName.Text == null || tbxAddress.Text == null || tbxUsername.Text == null || tbxPassword.Text == null || tbxIDNumber.Text == null || cbbxIDType.Text == "Select ID Type" || dtpdob.Value == DateTime.Now)
            {
                MessageBox.Show("Please fill all fields !!");
            }
            else
            {
                string gender1 = "";
                if (rdbMale.Checked == true)
                {
                    gender1 = "male";
                }
                else
                {
                    gender1 = "female";
                }
                con.ConnectionString = @"Data Source=DESKTOP-4R7P5UD\SQLEXPRESS;Initial Catalog=name1;Persist Security Info=True;User ID=sa;Password=123";
                cmd.Connection = con;

                cmd.CommandText = "UPDATE tblStudentDetails SET FirstName = '" + tbxFirstName.Text + "', LastName = '" + tbxLastName.Text + "', FullName = '" + tbxFullName.Text + "', Address = '" + tbxAddress.Text + "', Username = '" + tbxUsername.Text + "', Password = '" + tbxPassword.Text + "', IDNumber = '" + tbxIDNumber.Text + "', IDType = '" + cbbxIDType.Text + "', dob = '" + dtpdob.Value.ToShortDateString() + "', gender = '" + gender1 + "', mobile = '" + tbxMobile.Text + "', home = '" + tbxHome.Text + "', office = '" + tbxOffice.Text + "' WHERE FullName = '" + tbxFullName.Text + "' ";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You have been updated successfully.");




                if (ds.Tables["tblStudentDetails"] != null)
                {
                    ds.Tables["tblStudentDetails"].Clear();
                    lbxStudents.Items.Clear();
                    lbxStudents.Refresh();
                }

                con.ConnectionString = @"Data Source=DESKTOP-4R7P5UD\SQLEXPRESS;Initial Catalog=name1;Persist Security Info=True;User ID=sa;Password=123";
                con.Open();
                da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStudentDetails", con);
                da.Fill(ds, "tblStudentDetails");
                con.Close();

                int currentrow = 0;
                int rowcount = ds.Tables["tblStudentDetails"].Rows.Count;

                while (currentrow < rowcount)
                {
                    lbxStudents.Items.Add(ds.Tables["tblStudentDetails"].Rows[currentrow].ItemArray[3].ToString());
                    currentrow++;
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlEditStudent.Enabled = true;
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
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
        private void tbxFullName_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + tbxLastName.Text;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + tbxLastName.Text;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (ds.Tables["tblStudentDetails"] != null)
            {
                ds.Tables["tblStudentDetails"].Clear();
                lbxStudents.Items.Clear();
                lbxStudents.Refresh();
            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStudentDetails WHERE FullName like '%" + tbxSearch.Text + "%' ", con);
            da.Fill(ds, "tblStudentDetails");
            con.Close();


            int currentRow = 0;
            int rowcount = ds.Tables["tblStudentDetails"].Rows.Count;

            while (currentRow < rowcount)
            {
                lbxStudents.Items.Add(ds.Tables["tblStudentDetails"].Rows[currentRow].ItemArray[3].ToString());
                currentRow++;
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

        private void tbxHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void pnlEditStudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblIDNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbxMobile_TextChanged(object sender, EventArgs e)
        {

        }
  
    }
}
