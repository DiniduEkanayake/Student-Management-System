namespace Student_Manegement_System
{
    partial class frmAddStudent
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
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.cbxMobile = new System.Windows.Forms.CheckBox();
            this.pnlAddStudent = new System.Windows.Forms.Panel();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbxHome = new System.Windows.Forms.CheckBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cbxOffice = new System.Windows.Forms.CheckBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.cbbxIDType = new System.Windows.Forms.ComboBox();
            this.lblContactNumbers = new System.Windows.Forms.Label();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbxOffice = new System.Windows.Forms.TextBox();
            this.lbldob = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxIDNumber = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Location = new System.Drawing.Point(27, 414);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(347, 26);
            this.dtpdob.TabIndex = 33;
            // 
            // cbxMobile
            // 
            this.cbxMobile.AutoSize = true;
            this.cbxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMobile.Location = new System.Drawing.Point(409, 416);
            this.cbxMobile.Name = "cbxMobile";
            this.cbxMobile.Size = new System.Drawing.Size(80, 24);
            this.cbxMobile.TabIndex = 31;
            this.cbxMobile.Text = "Mobile";
            this.cbxMobile.UseVisualStyleBackColor = true;
            this.cbxMobile.CheckedChanged += new System.EventHandler(this.cbxMobile_CheckedChanged);
            // 
            // pnlAddStudent
            // 
            this.pnlAddStudent.Controls.Add(this.dtpdob);
            this.pnlAddStudent.Controls.Add(this.tbxAddress);
            this.pnlAddStudent.Controls.Add(this.cbxMobile);
            this.pnlAddStudent.Controls.Add(this.lblFirstName);
            this.pnlAddStudent.Controls.Add(this.cbxHome);
            this.pnlAddStudent.Controls.Add(this.lblLastName);
            this.pnlAddStudent.Controls.Add(this.cbxOffice);
            this.pnlAddStudent.Controls.Add(this.lblFullName);
            this.pnlAddStudent.Controls.Add(this.rdbMale);
            this.pnlAddStudent.Controls.Add(this.lblAddress);
            this.pnlAddStudent.Controls.Add(this.rdbFemale);
            this.pnlAddStudent.Controls.Add(this.lblUsername);
            this.pnlAddStudent.Controls.Add(this.lblPassword);
            this.pnlAddStudent.Controls.Add(this.lblIDNumber);
            this.pnlAddStudent.Controls.Add(this.lblConfirmPassword);
            this.pnlAddStudent.Controls.Add(this.cbbxIDType);
            this.pnlAddStudent.Controls.Add(this.lblContactNumbers);
            this.pnlAddStudent.Controls.Add(this.tbxHome);
            this.pnlAddStudent.Controls.Add(this.lblGender);
            this.pnlAddStudent.Controls.Add(this.tbxOffice);
            this.pnlAddStudent.Controls.Add(this.lbldob);
            this.pnlAddStudent.Controls.Add(this.tbxConfirmPassword);
            this.pnlAddStudent.Controls.Add(this.tbxFirstName);
            this.pnlAddStudent.Controls.Add(this.tbxIDNumber);
            this.pnlAddStudent.Controls.Add(this.tbxPassword);
            this.pnlAddStudent.Controls.Add(this.tbxMobile);
            this.pnlAddStudent.Controls.Add(this.tbxFullName);
            this.pnlAddStudent.Controls.Add(this.tbxUsername);
            this.pnlAddStudent.Controls.Add(this.tbxLastName);
            this.pnlAddStudent.Enabled = false;
            this.pnlAddStudent.ForeColor = System.Drawing.Color.White;
            this.pnlAddStudent.Location = new System.Drawing.Point(10, 29);
            this.pnlAddStudent.Name = "pnlAddStudent";
            this.pnlAddStudent.Size = new System.Drawing.Size(835, 607);
            this.pnlAddStudent.TabIndex = 36;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(132, 130);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(242, 130);
            this.tbxAddress.TabIndex = 15;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(24, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // cbxHome
            // 
            this.cbxHome.AutoSize = true;
            this.cbxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHome.Location = new System.Drawing.Point(409, 476);
            this.cbxHome.Name = "cbxHome";
            this.cbxHome.Size = new System.Drawing.Size(76, 24);
            this.cbxHome.TabIndex = 30;
            this.cbxHome.Text = "Home";
            this.cbxHome.UseVisualStyleBackColor = true;
            this.cbxHome.CheckedChanged += new System.EventHandler(this.cbxHome_CheckedChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(399, 24);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // cbxOffice
            // 
            this.cbxOffice.AutoSize = true;
            this.cbxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOffice.Location = new System.Drawing.Point(409, 535);
            this.cbxOffice.Name = "cbxOffice";
            this.cbxOffice.Size = new System.Drawing.Size(76, 24);
            this.cbxOffice.TabIndex = 29;
            this.cbxOffice.Text = "Office";
            this.cbxOffice.UseVisualStyleBackColor = true;
            this.cbxOffice.CheckedChanged += new System.EventHandler(this.cbxOffice_CheckedChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.White;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(24, 76);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(85, 20);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(27, 515);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(66, 24);
            this.rdbMale.TabIndex = 28;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(24, 133);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(147, 515);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(85, 24);
            this.rdbFemale.TabIndex = 27;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(399, 133);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(399, 184);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.BackColor = System.Drawing.Color.White;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.ForeColor = System.Drawing.Color.Black;
            this.lblIDNumber.Location = new System.Drawing.Point(399, 287);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(90, 20);
            this.lblIDNumber.TabIndex = 6;
            this.lblIDNumber.Text = "ID Number";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmPassword.Location = new System.Drawing.Point(399, 237);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(147, 20);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Confirm Password";
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
            this.cbbxIDType.Location = new System.Drawing.Point(132, 287);
            this.cbbxIDType.Name = "cbbxIDType";
            this.cbbxIDType.Size = new System.Drawing.Size(242, 28);
            this.cbbxIDType.TabIndex = 23;
            this.cbbxIDType.Text = "Select ID Type";
            // 
            // lblContactNumbers
            // 
            this.lblContactNumbers.AutoSize = true;
            this.lblContactNumbers.BackColor = System.Drawing.Color.White;
            this.lblContactNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumbers.ForeColor = System.Drawing.Color.Black;
            this.lblContactNumbers.Location = new System.Drawing.Point(399, 371);
            this.lblContactNumbers.Name = "lblContactNumbers";
            this.lblContactNumbers.Size = new System.Drawing.Size(140, 20);
            this.lblContactNumbers.TabIndex = 8;
            this.lblContactNumbers.Text = "Contact Numbers";
            // 
            // tbxHome
            // 
            this.tbxHome.Enabled = false;
            this.tbxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHome.Location = new System.Drawing.Point(552, 474);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(236, 26);
            this.tbxHome.TabIndex = 22;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(24, 477);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender";
            // 
            // tbxOffice
            // 
            this.tbxOffice.Enabled = false;
            this.tbxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOffice.Location = new System.Drawing.Point(552, 533);
            this.tbxOffice.Name = "tbxOffice";
            this.tbxOffice.Size = new System.Drawing.Size(236, 26);
            this.tbxOffice.TabIndex = 21;
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.White;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.Color.Black;
            this.lbldob.Location = new System.Drawing.Point(24, 371);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(102, 20);
            this.lbldob.TabIndex = 10;
            this.lbldob.Text = "Date of birth";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPassword.Location = new System.Drawing.Point(574, 234);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(236, 26);
            this.tbxConfirmPassword.TabIndex = 11;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(132, 21);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(242, 26);
            this.tbxFirstName.TabIndex = 19;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // tbxIDNumber
            // 
            this.tbxIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIDNumber.Location = new System.Drawing.Point(574, 284);
            this.tbxIDNumber.Name = "tbxIDNumber";
            this.tbxIDNumber.Size = new System.Drawing.Size(236, 26);
            this.tbxIDNumber.TabIndex = 12;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(574, 181);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(236, 26);
            this.tbxPassword.TabIndex = 18;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Enabled = false;
            this.tbxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMobile.Location = new System.Drawing.Point(552, 414);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(236, 26);
            this.tbxMobile.TabIndex = 13;
            this.tbxMobile.TextChanged += new System.EventHandler(this.tbxMobile_TextChanged);
            // 
            // tbxFullName
            // 
            this.tbxFullName.Enabled = false;
            this.tbxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFullName.Location = new System.Drawing.Point(132, 73);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(678, 26);
            this.tbxFullName.TabIndex = 17;
            this.tbxFullName.TextChanged += new System.EventHandler(this.tbxFullName_TextChanged);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(574, 130);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(236, 26);
            this.tbxUsername.TabIndex = 14;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(538, 21);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(272, 26);
            this.tbxLastName.TabIndex = 16;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(174, 652);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 46);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(364, 652);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 46);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(549, 652);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 46);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 714);
            this.Controls.Add(this.pnlAddStudent);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.pnlAddStudent.ResumeLayout(false);
            this.pnlAddStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.CheckBox cbxMobile;
        private System.Windows.Forms.Panel pnlAddStudent;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.CheckBox cbxHome;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.CheckBox cbxOffice;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ComboBox cbbxIDType;
        private System.Windows.Forms.Label lblContactNumbers;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbxOffice;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxIDNumber;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}