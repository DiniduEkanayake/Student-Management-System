namespace Student_Manegement_System
{
    partial class frmRemoveStudent
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxStudentsRemove = new System.Windows.Forms.ListBox();
            this.tbxIDNumber = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblContactNumbers = new System.Windows.Forms.Label();
            this.tbxHome = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.cbxMobile = new System.Windows.Forms.CheckBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbxHome = new System.Windows.Forms.CheckBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cbxOffice = new System.Windows.Forms.CheckBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.cbbxIDType = new System.Windows.Forms.ComboBox();
            this.tbxOffice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(417, 616);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 46);
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxStudentsRemove
            // 
            this.lbxStudentsRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStudentsRemove.FormattingEnabled = true;
            this.lbxStudentsRemove.ItemHeight = 20;
            this.lbxStudentsRemove.Location = new System.Drawing.Point(11, 66);
            this.lbxStudentsRemove.Name = "lbxStudentsRemove";
            this.lbxStudentsRemove.Size = new System.Drawing.Size(284, 524);
            this.lbxStudentsRemove.TabIndex = 41;
            this.lbxStudentsRemove.SelectedIndexChanged += new System.EventHandler(this.lbxStudents_SelectedIndexChanged);
            // 
            // tbxIDNumber
            // 
            this.tbxIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIDNumber.Location = new System.Drawing.Point(553, 288);
            this.tbxIDNumber.Name = "tbxIDNumber";
            this.tbxIDNumber.Size = new System.Drawing.Size(236, 26);
            this.tbxIDNumber.TabIndex = 46;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(553, 185);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(236, 26);
            this.tbxPassword.TabIndex = 52;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMobile.Location = new System.Drawing.Point(553, 418);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(236, 26);
            this.tbxMobile.TabIndex = 47;
            // 
            // tbxFullName
            // 
            this.tbxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFullName.Location = new System.Drawing.Point(126, 77);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(663, 26);
            this.tbxFullName.TabIndex = 51;
            this.tbxFullName.TextChanged += new System.EventHandler(this.tbxFullName_TextChanged);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(553, 134);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(236, 26);
            this.tbxUsername.TabIndex = 48;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(517, 25);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(272, 26);
            this.tbxLastName.TabIndex = 50;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(648, 616);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 46);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblContactNumbers
            // 
            this.lblContactNumbers.AutoSize = true;
            this.lblContactNumbers.BackColor = System.Drawing.Color.White;
            this.lblContactNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumbers.ForeColor = System.Drawing.Color.Black;
            this.lblContactNumbers.Location = new System.Drawing.Point(406, 375);
            this.lblContactNumbers.Name = "lblContactNumbers";
            this.lblContactNumbers.Size = new System.Drawing.Size(140, 20);
            this.lblContactNumbers.TabIndex = 42;
            this.lblContactNumbers.Text = "Contact Numbers";
            // 
            // tbxHome
            // 
            this.tbxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHome.Location = new System.Drawing.Point(553, 478);
            this.tbxHome.Name = "tbxHome";
            this.tbxHome.Size = new System.Drawing.Size(236, 26);
            this.tbxHome.TabIndex = 55;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
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
            this.lbldob.ForeColor = System.Drawing.Color.Black;
            this.lbldob.Location = new System.Drawing.Point(16, 375);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(102, 20);
            this.lbldob.TabIndex = 44;
            this.lbldob.Text = "Date of birth";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(126, 22);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(242, 26);
            this.tbxFirstName.TabIndex = 53;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(11, 23);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(284, 31);
            this.tbxSearch.TabIndex = 42;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(16, 137);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpdob);
            this.panel1.Controls.Add(this.tbxAddress);
            this.panel1.Controls.Add(this.cbxMobile);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.cbxHome);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.cbxOffice);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.rdbMale);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.rdbFemale);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblIDNumber);
            this.panel1.Controls.Add(this.cbbxIDType);
            this.panel1.Controls.Add(this.lblContactNumbers);
            this.panel1.Controls.Add(this.tbxHome);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.tbxOffice);
            this.panel1.Controls.Add(this.lbldob);
            this.panel1.Controls.Add(this.tbxFirstName);
            this.panel1.Controls.Add(this.tbxIDNumber);
            this.panel1.Controls.Add(this.tbxPassword);
            this.panel1.Controls.Add(this.tbxMobile);
            this.panel1.Controls.Add(this.tbxFullName);
            this.panel1.Controls.Add(this.tbxUsername);
            this.panel1.Controls.Add(this.tbxLastName);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(317, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 592);
            this.panel1.TabIndex = 38;
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Location = new System.Drawing.Point(19, 416);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(349, 26);
            this.dtpdob.TabIndex = 62;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(126, 134);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(242, 135);
            this.tbxAddress.TabIndex = 49;
            // 
            // cbxMobile
            // 
            this.cbxMobile.AutoSize = true;
            this.cbxMobile.BackColor = System.Drawing.Color.White;
            this.cbxMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMobile.ForeColor = System.Drawing.Color.Black;
            this.cbxMobile.Location = new System.Drawing.Point(409, 420);
            this.cbxMobile.Name = "cbxMobile";
            this.cbxMobile.Size = new System.Drawing.Size(80, 24);
            this.cbxMobile.TabIndex = 61;
            this.cbxMobile.Text = "Mobile";
            this.cbxMobile.UseVisualStyleBackColor = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(16, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "First Name";
            // 
            // cbxHome
            // 
            this.cbxHome.AutoSize = true;
            this.cbxHome.BackColor = System.Drawing.Color.White;
            this.cbxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHome.ForeColor = System.Drawing.Color.Black;
            this.cbxHome.Location = new System.Drawing.Point(409, 478);
            this.cbxHome.Name = "cbxHome";
            this.cbxHome.Size = new System.Drawing.Size(76, 24);
            this.cbxHome.TabIndex = 60;
            this.cbxHome.Text = "Home";
            this.cbxHome.UseVisualStyleBackColor = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(406, 28);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name";
            // 
            // cbxOffice
            // 
            this.cbxOffice.AutoSize = true;
            this.cbxOffice.BackColor = System.Drawing.Color.White;
            this.cbxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOffice.ForeColor = System.Drawing.Color.Black;
            this.cbxOffice.Location = new System.Drawing.Point(409, 539);
            this.cbxOffice.Name = "cbxOffice";
            this.cbxOffice.Size = new System.Drawing.Size(76, 24);
            this.cbxOffice.TabIndex = 59;
            this.cbxOffice.Text = "Office";
            this.cbxOffice.UseVisualStyleBackColor = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.White;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(16, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(85, 20);
            this.lblFullName.TabIndex = 36;
            this.lblFullName.Text = "Full Name";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.BackColor = System.Drawing.Color.White;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.ForeColor = System.Drawing.Color.Black;
            this.rdbMale.Location = new System.Drawing.Point(19, 519);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(66, 24);
            this.rdbMale.TabIndex = 58;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = false;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.BackColor = System.Drawing.Color.White;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.ForeColor = System.Drawing.Color.Black;
            this.rdbFemale.Location = new System.Drawing.Point(139, 519);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(85, 24);
            this.rdbFemale.TabIndex = 57;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(405, 137);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 20);
            this.lblUsername.TabIndex = 38;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(405, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Password";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.BackColor = System.Drawing.Color.White;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.ForeColor = System.Drawing.Color.Black;
            this.lblIDNumber.Location = new System.Drawing.Point(405, 291);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(90, 20);
            this.lblIDNumber.TabIndex = 40;
            this.lblIDNumber.Text = "ID Number";
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
            this.cbbxIDType.Location = new System.Drawing.Point(126, 291);
            this.cbbxIDType.Name = "cbbxIDType";
            this.cbbxIDType.Size = new System.Drawing.Size(242, 28);
            this.cbbxIDType.TabIndex = 56;
            this.cbbxIDType.Text = "Select ID Type";
            // 
            // tbxOffice
            // 
            this.tbxOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOffice.Location = new System.Drawing.Point(553, 537);
            this.tbxOffice.Name = "tbxOffice";
            this.tbxOffice.Size = new System.Drawing.Size(236, 26);
            this.tbxOffice.TabIndex = 54;
            // 
            // frmRemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 674);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbxStudentsRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.panel1);
            this.Name = "frmRemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Student";
            this.Load += new System.EventHandler(this.frmRemoveStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbxStudentsRemove;
        private System.Windows.Forms.TextBox tbxIDNumber;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblContactNumbers;
        private System.Windows.Forms.TextBox tbxHome;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.CheckBox cbxMobile;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.CheckBox cbxHome;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.CheckBox cbxOffice;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.ComboBox cbbxIDType;
        private System.Windows.Forms.TextBox tbxOffice;
    }
}