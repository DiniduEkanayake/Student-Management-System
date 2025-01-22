namespace Student_Manegement_System
{
    partial class frmEditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.cbxMobile = new System.Windows.Forms.CheckBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbxHome = new System.Windows.Forms.CheckBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cbxOffice = new System.Windows.Forms.CheckBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.cbbxIDType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblContactNumbers = new System.Windows.Forms.Label();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxIDNumber = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.tbxOffice = new System.Windows.Forms.TextBox();
            this.pnlEditStudent = new System.Windows.Forms.Panel();
            this.pnlEditStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(333, 620);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 46);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Location = new System.Drawing.Point(16, 418);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(365, 26);
            this.dtpdob.TabIndex = 62;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(139, 134);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(242, 127);
            this.tbxAddress.TabIndex = 49;
            // 
            // cbxMobile
            // 
            this.cbxMobile.AutoSize = true;
            this.cbxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMobile.ForeColor = System.Drawing.Color.White;
            this.cbxMobile.Location = new System.Drawing.Point(408, 418);
            this.cbxMobile.Name = "cbxMobile";
            this.cbxMobile.Size = new System.Drawing.Size(80, 24);
            this.cbxMobile.TabIndex = 61;
            this.cbxMobile.Text = "Mobile";
            this.cbxMobile.UseVisualStyleBackColor = true;
            this.cbxMobile.CheckedChanged += new System.EventHandler(this.cbxMobile_CheckedChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(16, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "First Name";
            // 
            // cbxHome
            // 
            this.cbxHome.AutoSize = true;
            this.cbxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHome.ForeColor = System.Drawing.Color.White;
            this.cbxHome.Location = new System.Drawing.Point(408, 477);
            this.cbxHome.Name = "cbxHome";
            this.cbxHome.Size = new System.Drawing.Size(76, 24);
            this.cbxHome.TabIndex = 60;
            this.cbxHome.Text = "Home";
            this.cbxHome.UseVisualStyleBackColor = true;
            this.cbxHome.CheckedChanged += new System.EventHandler(this.cbxHome_CheckedChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(404, 25);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // cbxOffice
            // 
            this.cbxOffice.AutoSize = true;
            this.cbxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOffice.ForeColor = System.Drawing.Color.White;
            this.cbxOffice.Location = new System.Drawing.Point(408, 537);
            this.cbxOffice.Name = "cbxOffice";
            this.cbxOffice.Size = new System.Drawing.Size(76, 24);
            this.cbxOffice.TabIndex = 59;
            this.cbxOffice.Text = "Office";
            this.cbxOffice.UseVisualStyleBackColor = true;
            this.cbxOffice.CheckedChanged += new System.EventHandler(this.cbxOffice_CheckedChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.White;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(16, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(85, 20);
            this.lblFullName.TabIndex = 36;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(708, 620);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 46);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.ForeColor = System.Drawing.Color.White;
            this.rdbMale.Location = new System.Drawing.Point(19, 519);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(66, 24);
            this.rdbMale.TabIndex = 58;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.ForeColor = System.Drawing.Color.White;
            this.rdbFemale.Location = new System.Drawing.Point(139, 519);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(85, 24);
            this.rdbFemale.TabIndex = 57;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(404, 137);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 20);
            this.lblUsername.TabIndex = 38;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(404, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.BackColor = System.Drawing.Color.White;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(404, 289);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(90, 20);
            this.lblIDNumber.TabIndex = 40;
            this.lblIDNumber.Text = "ID Number";
            this.lblIDNumber.Click += new System.EventHandler(this.lblIDNumber_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(404, 241);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(147, 20);
            this.lblConfirmPassword.TabIndex = 41;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // cbbxIDType
            // 
            this.cbbxIDType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxIDType.FormattingEnabled = true;
            this.cbbxIDType.Items.AddRange(new object[] {
            "National ID",
            "Passport",
            "Driving License",
            "Postal ID"});
            this.cbbxIDType.Location = new System.Drawing.Point(139, 289);
            this.cbbxIDType.Name = "cbbxIDType";
            this.cbbxIDType.Size = new System.Drawing.Size(242, 28);
            this.cbbxIDType.TabIndex = 56;
            this.cbbxIDType.Text = "Select ID Type";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(521, 620);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 46);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(16, 137);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(13, 23);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(300, 31);
            this.tbxSearch.TabIndex = 37;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblContactNumbers
            // 
            this.lblContactNumbers.AutoSize = true;
            this.lblContactNumbers.BackColor = System.Drawing.Color.White;
            this.lblContactNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumbers.Location = new System.Drawing.Point(404, 375);
            this.lblContactNumbers.Name = "lblContactNumbers";
            this.lblContactNumbers.Size = new System.Drawing.Size(140, 20);
            this.lblContactNumbers.TabIndex = 42;
            this.lblContactNumbers.Text = "Contact Numbers";
            // 
            // tbxHome
            // 
            this.tbxHome.Enabled = false;
            this.tbxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHome.Location = new System.Drawing.Point(581, 476);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(236, 26);
            this.tbxHome.TabIndex = 55;
            this.tbxHome.TextChanged += new System.EventHandler(this.tbxHome_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(16, 481);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 43;
            this.lblGender.Text = "Gender";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.White;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(16, 375);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(102, 20);
            this.lbldob.TabIndex = 44;
            this.lbldob.Text = "Date of birth";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPassword.Location = new System.Drawing.Point(581, 241);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(236, 26);
            this.tbxConfirmPassword.TabIndex = 45;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(139, 23);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(242, 26);
            this.tbxFirstName.TabIndex = 53;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // tbxIDNumber
            // 
            this.tbxIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIDNumber.Location = new System.Drawing.Point(581, 289);
            this.tbxIDNumber.Name = "tbxIDNumber";
            this.tbxIDNumber.Size = new System.Drawing.Size(236, 26);
            this.tbxIDNumber.TabIndex = 46;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(581, 186);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(236, 26);
            this.tbxPassword.TabIndex = 52;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Enabled = false;
            this.tbxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMobile.Location = new System.Drawing.Point(581, 418);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(236, 26);
            this.tbxMobile.TabIndex = 47;
            this.tbxMobile.TextChanged += new System.EventHandler(this.tbxMobile_TextChanged);
            // 
            // tbxFullName
            // 
            this.tbxFullName.Enabled = false;
            this.tbxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFullName.Location = new System.Drawing.Point(139, 78);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(678, 26);
            this.tbxFullName.TabIndex = 51;
            this.tbxFullName.TextChanged += new System.EventHandler(this.tbxFullName_TextChanged);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(581, 134);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(236, 26);
            this.tbxUsername.TabIndex = 48;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(545, 25);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(272, 26);
            this.tbxLastName.TabIndex = 50;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // lbxStudents
            // 
            this.lbxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 20;
            this.lbxStudents.Location = new System.Drawing.Point(13, 66);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(300, 524);
            this.lbxStudents.TabIndex = 36;
            this.lbxStudents.SelectedIndexChanged += new System.EventHandler(this.lbxStudents_SelectedIndexChanged);
            // 
            // tbxOffice
            // 
            this.tbxOffice.Enabled = false;
            this.tbxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOffice.Location = new System.Drawing.Point(581, 537);
            this.tbxOffice.Name = "tbxOffice";
            this.tbxOffice.Size = new System.Drawing.Size(236, 26);
            this.tbxOffice.TabIndex = 54;
            // 
            // pnlEditStudent
            // 
            this.pnlEditStudent.Controls.Add(this.dtpdob);
            this.pnlEditStudent.Controls.Add(this.tbxAddress);
            this.pnlEditStudent.Controls.Add(this.cbxMobile);
            this.pnlEditStudent.Controls.Add(this.lblFirstName);
            this.pnlEditStudent.Controls.Add(this.cbxHome);
            this.pnlEditStudent.Controls.Add(this.lblLastName);
            this.pnlEditStudent.Controls.Add(this.cbxOffice);
            this.pnlEditStudent.Controls.Add(this.lblFullName);
            this.pnlEditStudent.Controls.Add(this.rdbMale);
            this.pnlEditStudent.Controls.Add(this.lblAddress);
            this.pnlEditStudent.Controls.Add(this.rdbFemale);
            this.pnlEditStudent.Controls.Add(this.lblUsername);
            this.pnlEditStudent.Controls.Add(this.lblPassword);
            this.pnlEditStudent.Controls.Add(this.lblIDNumber);
            this.pnlEditStudent.Controls.Add(this.lblConfirmPassword);
            this.pnlEditStudent.Controls.Add(this.cbbxIDType);
            this.pnlEditStudent.Controls.Add(this.lblContactNumbers);
            this.pnlEditStudent.Controls.Add(this.tbxHome);
            this.pnlEditStudent.Controls.Add(this.lblGender);
            this.pnlEditStudent.Controls.Add(this.tbxOffice);
            this.pnlEditStudent.Controls.Add(this.lbldob);
            this.pnlEditStudent.Controls.Add(this.tbxConfirmPassword);
            this.pnlEditStudent.Controls.Add(this.tbxFirstName);
            this.pnlEditStudent.Controls.Add(this.tbxIDNumber);
            this.pnlEditStudent.Controls.Add(this.tbxPassword);
            this.pnlEditStudent.Controls.Add(this.tbxMobile);
            this.pnlEditStudent.Controls.Add(this.tbxFullName);
            this.pnlEditStudent.Controls.Add(this.tbxUsername);
            this.pnlEditStudent.Controls.Add(this.tbxLastName);
            this.pnlEditStudent.Enabled = false;
            this.pnlEditStudent.Location = new System.Drawing.Point(319, 12);
            this.pnlEditStudent.Name = "pnlEditStudent";
            this.pnlEditStudent.Size = new System.Drawing.Size(833, 592);
            this.pnlEditStudent.TabIndex = 32;
            this.pnlEditStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditStudent_Paint);
            // 
            // frmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1159, 688);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.pnlEditStudent);
            this.Name = "frmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.frmEditStudent_Load);
            this.pnlEditStudent.ResumeLayout(false);
            this.pnlEditStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.CheckBox cbxMobile;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.CheckBox cbxHome;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.CheckBox cbxOffice;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ComboBox cbbxIDType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblContactNumbers;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxIDNumber;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.TextBox tbxOffice;
        private System.Windows.Forms.Panel pnlEditStudent;
    }
}