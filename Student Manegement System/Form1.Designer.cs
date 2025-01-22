namespace Student_Manegement_System
{
    partial class mnuMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnuMain));
            this.munMain = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitmAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitmEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitmRemoveStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.munMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // munMain
            // 
            this.munMain.BackColor = System.Drawing.Color.Transparent;
            this.munMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.munMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.studentDetailsToolStripMenuItem});
            this.munMain.Location = new System.Drawing.Point(0, 0);
            this.munMain.Name = "munMain";
            this.munMain.Size = new System.Drawing.Size(1240, 36);
            this.munMain.TabIndex = 0;
            this.munMain.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitmLogin,
            this.mnuitmLogout,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.systemToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.systemToolStripMenuItem.Text = "System";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            // 
            // mnuitmLogin
            // 
            this.mnuitmLogin.BackColor = System.Drawing.Color.Transparent;
            this.mnuitmLogin.Name = "mnuitmLogin";
            this.mnuitmLogin.Size = new System.Drawing.Size(181, 32);
            this.mnuitmLogin.Text = "Log In ";
            this.mnuitmLogin.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // mnuitmLogout
            // 
            this.mnuitmLogout.BackColor = System.Drawing.Color.Transparent;
            this.mnuitmLogout.Enabled = false;
            this.mnuitmLogout.Name = "mnuitmLogout";
            this.mnuitmLogout.Size = new System.Drawing.Size(181, 32);
            this.mnuitmLogout.Text = "Log Out";
            this.mnuitmLogout.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitmAddStudent,
            this.mnuitmEditStudent,
            this.mnuitmRemoveStudent});
            this.studentDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.studentDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // mnuitmAddStudent
            // 
            this.mnuitmAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.mnuitmAddStudent.Name = "mnuitmAddStudent";
            this.mnuitmAddStudent.Size = new System.Drawing.Size(233, 32);
            this.mnuitmAddStudent.Text = "Add Student";
            this.mnuitmAddStudent.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // mnuitmEditStudent
            // 
            this.mnuitmEditStudent.BackColor = System.Drawing.Color.Transparent;
            this.mnuitmEditStudent.Name = "mnuitmEditStudent";
            this.mnuitmEditStudent.Size = new System.Drawing.Size(233, 32);
            this.mnuitmEditStudent.Text = "Edit Student";
            this.mnuitmEditStudent.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // mnuitmRemoveStudent
            // 
            this.mnuitmRemoveStudent.BackColor = System.Drawing.Color.Transparent;
            this.mnuitmRemoveStudent.Name = "mnuitmRemoveStudent";
            this.mnuitmRemoveStudent.Size = new System.Drawing.Size(233, 32);
            this.mnuitmRemoveStudent.Text = "Remove Student";
            this.mnuitmRemoveStudent.Click += new System.EventHandler(this.removeStudentToolStripMenuItem_Click);
            // 
            // mnuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Student_Manegement_System.Properties.Resources.peter_thomas_w_OD0b4CfeU_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 645);
            this.Controls.Add(this.munMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mnuMain";
            this.Text = "Student Manegemnt System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mnuMain_Load);
            this.munMain.ResumeLayout(false);
            this.munMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip munMain;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuitmLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuitmLogout;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuitmAddStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuitmEditStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuitmRemoveStudent;



    }
}

