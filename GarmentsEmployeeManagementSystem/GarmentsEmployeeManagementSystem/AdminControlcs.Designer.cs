namespace GarmentsEmployeeManagementSystem
{
    partial class AdminControlcs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAdmins = new System.Windows.Forms.TabPage();
            this.tbAddAdmin = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbAdminPhone = new System.Windows.Forms.TextBox();
            this.tbAdminGender = new System.Windows.Forms.TextBox();
            this.tbAdminEmail = new System.Windows.Forms.TextBox();
            this.tbAdminPassword = new System.Windows.Forms.TextBox();
            this.tbAdminName = new System.Windows.Forms.TextBox();
            this.lvlAdminPhone = new System.Windows.Forms.Label();
            this.lvlAdminGender = new System.Windows.Forms.Label();
            this.lvlAdminEmail = new System.Windows.Forms.Label();
            this.lvlAdminPassword = new System.Windows.Forms.Label();
            this.lvlAdminName = new System.Windows.Forms.Label();
            this.lvlAddAdminMsg = new System.Windows.Forms.Label();
            this.tpAdminUpdate = new System.Windows.Forms.TabPage();
            this.tpAdminDelete = new System.Windows.Forms.TabPage();
            this.tbHome = new System.Windows.Forms.TabPage();
            this.tbadminLogout = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbAddAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAdmins);
            this.tabControl1.Controls.Add(this.tbAddAdmin);
            this.tabControl1.Controls.Add(this.tpAdminUpdate);
            this.tabControl1.Controls.Add(this.tpAdminDelete);
            this.tabControl1.Controls.Add(this.tbHome);
            this.tabControl1.Controls.Add(this.tbadminLogout);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAdmins
            // 
            this.tpAdmins.Location = new System.Drawing.Point(4, 28);
            this.tpAdmins.Name = "tpAdmins";
            this.tpAdmins.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmins.Size = new System.Drawing.Size(569, 328);
            this.tpAdmins.TabIndex = 0;
            this.tpAdmins.Text = "Admins";
            this.tpAdmins.UseVisualStyleBackColor = true;
            // 
            // tbAddAdmin
            // 
            this.tbAddAdmin.Controls.Add(this.btnSubmit);
            this.tbAddAdmin.Controls.Add(this.tbAdminPhone);
            this.tbAddAdmin.Controls.Add(this.tbAdminGender);
            this.tbAddAdmin.Controls.Add(this.tbAdminEmail);
            this.tbAddAdmin.Controls.Add(this.tbAdminPassword);
            this.tbAddAdmin.Controls.Add(this.tbAdminName);
            this.tbAddAdmin.Controls.Add(this.lvlAdminPhone);
            this.tbAddAdmin.Controls.Add(this.lvlAdminGender);
            this.tbAddAdmin.Controls.Add(this.lvlAdminEmail);
            this.tbAddAdmin.Controls.Add(this.lvlAdminPassword);
            this.tbAddAdmin.Controls.Add(this.lvlAdminName);
            this.tbAddAdmin.Controls.Add(this.lvlAddAdminMsg);
            this.tbAddAdmin.Location = new System.Drawing.Point(4, 28);
            this.tbAddAdmin.Name = "tbAddAdmin";
            this.tbAddAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddAdmin.Size = new System.Drawing.Size(569, 328);
            this.tbAddAdmin.TabIndex = 1;
            this.tbAddAdmin.Text = "Add Admin";
            this.tbAddAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(340, 268);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbAdminPhone
            // 
            this.tbAdminPhone.Location = new System.Drawing.Point(185, 223);
            this.tbAdminPhone.Name = "tbAdminPhone";
            this.tbAdminPhone.Size = new System.Drawing.Size(230, 20);
            this.tbAdminPhone.TabIndex = 10;
            // 
            // tbAdminGender
            // 
            this.tbAdminGender.Location = new System.Drawing.Point(185, 180);
            this.tbAdminGender.Name = "tbAdminGender";
            this.tbAdminGender.Size = new System.Drawing.Size(230, 20);
            this.tbAdminGender.TabIndex = 9;
            // 
            // tbAdminEmail
            // 
            this.tbAdminEmail.Location = new System.Drawing.Point(185, 139);
            this.tbAdminEmail.Name = "tbAdminEmail";
            this.tbAdminEmail.Size = new System.Drawing.Size(230, 20);
            this.tbAdminEmail.TabIndex = 8;
            // 
            // tbAdminPassword
            // 
            this.tbAdminPassword.Location = new System.Drawing.Point(185, 98);
            this.tbAdminPassword.Name = "tbAdminPassword";
            this.tbAdminPassword.Size = new System.Drawing.Size(230, 20);
            this.tbAdminPassword.TabIndex = 7;
            // 
            // tbAdminName
            // 
            this.tbAdminName.Location = new System.Drawing.Point(185, 58);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(230, 20);
            this.tbAdminName.TabIndex = 6;
            // 
            // lvlAdminPhone
            // 
            this.lvlAdminPhone.AutoSize = true;
            this.lvlAdminPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAdminPhone.Location = new System.Drawing.Point(52, 223);
            this.lvlAdminPhone.Name = "lvlAdminPhone";
            this.lvlAdminPhone.Size = new System.Drawing.Size(56, 16);
            this.lvlAdminPhone.TabIndex = 5;
            this.lvlAdminPhone.Text = "Phone:";
            // 
            // lvlAdminGender
            // 
            this.lvlAdminGender.AutoSize = true;
            this.lvlAdminGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAdminGender.Location = new System.Drawing.Point(52, 180);
            this.lvlAdminGender.Name = "lvlAdminGender";
            this.lvlAdminGender.Size = new System.Drawing.Size(63, 16);
            this.lvlAdminGender.TabIndex = 4;
            this.lvlAdminGender.Text = "Gender:";
            // 
            // lvlAdminEmail
            // 
            this.lvlAdminEmail.AutoSize = true;
            this.lvlAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAdminEmail.Location = new System.Drawing.Point(52, 139);
            this.lvlAdminEmail.Name = "lvlAdminEmail";
            this.lvlAdminEmail.Size = new System.Drawing.Size(51, 16);
            this.lvlAdminEmail.TabIndex = 3;
            this.lvlAdminEmail.Text = "Email:";
            // 
            // lvlAdminPassword
            // 
            this.lvlAdminPassword.AutoSize = true;
            this.lvlAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAdminPassword.Location = new System.Drawing.Point(52, 98);
            this.lvlAdminPassword.Name = "lvlAdminPassword";
            this.lvlAdminPassword.Size = new System.Drawing.Size(80, 16);
            this.lvlAdminPassword.TabIndex = 2;
            this.lvlAdminPassword.Text = "Password:";
            // 
            // lvlAdminName
            // 
            this.lvlAdminName.AutoSize = true;
            this.lvlAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAdminName.Location = new System.Drawing.Point(55, 62);
            this.lvlAdminName.Name = "lvlAdminName";
            this.lvlAdminName.Size = new System.Drawing.Size(53, 16);
            this.lvlAdminName.TabIndex = 1;
            this.lvlAdminName.Text = "Name:";
            // 
            // lvlAddAdminMsg
            // 
            this.lvlAddAdminMsg.AutoSize = true;
            this.lvlAddAdminMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAddAdminMsg.Location = new System.Drawing.Point(182, 3);
            this.lvlAddAdminMsg.Name = "lvlAddAdminMsg";
            this.lvlAddAdminMsg.Size = new System.Drawing.Size(197, 16);
            this.lvlAddAdminMsg.TabIndex = 0;
            this.lvlAddAdminMsg.Text = "Add New Admin Information";
            // 
            // tpAdminUpdate
            // 
            this.tpAdminUpdate.Location = new System.Drawing.Point(4, 28);
            this.tpAdminUpdate.Name = "tpAdminUpdate";
            this.tpAdminUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminUpdate.Size = new System.Drawing.Size(569, 328);
            this.tpAdminUpdate.TabIndex = 2;
            this.tpAdminUpdate.Text = "Update Admin";
            this.tpAdminUpdate.UseVisualStyleBackColor = true;
            // 
            // tpAdminDelete
            // 
            this.tpAdminDelete.Location = new System.Drawing.Point(4, 28);
            this.tpAdminDelete.Name = "tpAdminDelete";
            this.tpAdminDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminDelete.Size = new System.Drawing.Size(569, 328);
            this.tpAdminDelete.TabIndex = 3;
            this.tpAdminDelete.Text = "Delete Admin";
            this.tpAdminDelete.UseVisualStyleBackColor = true;
            // 
            // tbHome
            // 
            this.tbHome.Location = new System.Drawing.Point(4, 28);
            this.tbHome.Name = "tbHome";
            this.tbHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbHome.Size = new System.Drawing.Size(569, 328);
            this.tbHome.TabIndex = 4;
            this.tbHome.Text = "Home";
            this.tbHome.UseVisualStyleBackColor = true;
            this.tbHome.Enter += new System.EventHandler(this.tbHome_Enter);
            // 
            // tbadminLogout
            // 
            this.tbadminLogout.Location = new System.Drawing.Point(4, 28);
            this.tbadminLogout.Name = "tbadminLogout";
            this.tbadminLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tbadminLogout.Size = new System.Drawing.Size(569, 328);
            this.tbadminLogout.TabIndex = 5;
            this.tbadminLogout.Text = "Logout";
            this.tbadminLogout.UseVisualStyleBackColor = true;
            this.tbadminLogout.Enter += new System.EventHandler(this.tbadminLogout_Enter);
            // 
            // AdminControlcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 357);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "AdminControlcs";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Controlcs";
            this.tabControl1.ResumeLayout(false);
            this.tbAddAdmin.ResumeLayout(false);
            this.tbAddAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdmins;
        private System.Windows.Forms.TabPage tbAddAdmin;
        private System.Windows.Forms.TabPage tpAdminUpdate;
        private System.Windows.Forms.TabPage tpAdminDelete;
        private System.Windows.Forms.TabPage tbHome;
        private System.Windows.Forms.TabPage tbadminLogout;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbAdminPhone;
        private System.Windows.Forms.TextBox tbAdminGender;
        private System.Windows.Forms.TextBox tbAdminEmail;
        private System.Windows.Forms.TextBox tbAdminPassword;
        private System.Windows.Forms.TextBox tbAdminName;
        private System.Windows.Forms.Label lvlAdminPhone;
        private System.Windows.Forms.Label lvlAdminGender;
        private System.Windows.Forms.Label lvlAdminEmail;
        private System.Windows.Forms.Label lvlAdminPassword;
        private System.Windows.Forms.Label lvlAdminName;
        private System.Windows.Forms.Label lvlAddAdminMsg;
    }
}