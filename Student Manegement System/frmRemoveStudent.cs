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
    public partial class frmRemoveStudent : Form
    {
        public static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
        public static System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        public static DataSet ds = new DataSet();

        public frmRemoveStudent()
        {
            InitializeComponent();
        }

        private void frmRemoveStudent_Load(object sender, EventArgs e)
        {
            if (ds.Tables["tblStudentDetials"] != null)
            {
                ds.Tables["tblStudentDetials"].Clear();
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
                lbxStudentsRemove.Items.Add(ds.Tables["tblStudentDetails"].Rows[currentrow].ItemArray[3].ToString());
                currentrow++;
            }
        }

        private void lbxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnClose.Enabled = true;

            ds.Tables["tblStudentDetails"].Clear();
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStudentDetails WHERE FullName= '" + lbxStudentsRemove.SelectedItem.ToString() + "' ", con);
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
            if (ds.Tables["tblStudentDetails"].Rows[0].ItemArray[10].ToString() == "male")
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }

            tbxMobile.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[11].ToString();
            if (ds.Tables["tblStudentDetails"].Rows[0].ItemArray[11].ToString() != null)
            {
                cbxMobile.Checked = true;
            }
            tbxHome.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[12].ToString();
            if (ds.Tables["tblStudentDetails"].Rows[0].ItemArray[12].ToString() != null)
            {
                cbxHome.Checked = true;
            }
            tbxOffice.Text = ds.Tables["tblStudentDetails"].Rows[0].ItemArray[13].ToString();
            if (ds.Tables["tblStudentDetails"].Rows[0].ItemArray[13].ToString() != null)
            {
                cbxOffice.Checked = true;
            }
        }

        private void tbxFullName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Text = tbxFirstName.Text + " " + tbxLastName.Text;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=DESKTOP-4R7P5UD\SQLEXPRESS;Initial Catalog=name1;Persist Security Info=True;User ID=sa;Password=123";
            con.Open();
            cmd  = new System.Data.SqlClient.SqlCommand( "DELETE FROM tblStudentDetails WHERE IDNumber = '" + tbxIDNumber.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You have been deleted Successfully.");



            if (ds.Tables["tblStudentDetails"] != null)
            {
                ds.Tables["tblStudentDetails"].Clear();
                lbxStudentsRemove.Items.Clear();
                lbxStudentsRemove.Refresh();
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
                lbxStudentsRemove.Items.Add(ds.Tables["tblStudentDetails"].Rows[currentrow].ItemArray[3].ToString());
                currentrow++;
            }
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxFullName.Clear();
            tbxAddress.Clear();
            tbxUsername.Clear();
            tbxPassword.Clear();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (ds.Tables["tblStudentDetails"] != null)
            {
                ds.Tables["tblStudentDetails"].Clear();
                lbxStudentsRemove.Items.Clear();
                lbxStudentsRemove.Refresh();
            }
            con.Open();
            da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblStudentDetails WHERE FullName like '%" + tbxSearch.Text + "%' ", con);
            da.Fill(ds, "tblStudentDetails");
            con.Close();


            int currentRow = 0;
            int rowcount = ds.Tables["tblStudentDetails"].Rows.Count;

            while(currentRow < rowcount)
            {
                lbxStudentsRemove.Items.Add(ds.Tables["tblStudentDetails"].Rows[currentRow].ItemArray[3].ToString());
                currentRow++;
            }


        }   
    }
}
