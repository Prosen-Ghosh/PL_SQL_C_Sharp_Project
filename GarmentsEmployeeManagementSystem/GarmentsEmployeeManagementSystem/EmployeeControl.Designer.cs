namespace GarmentsEmployeeManagementSystem
{
    partial class EmployeeControl
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
            this.tcEmployeeControl = new System.Windows.Forms.TabControl();
            this.tpEmployeeSearch = new System.Windows.Forms.TabPage();
            this.tpEmployeeAdd = new System.Windows.Forms.TabPage();
            this.tpEmployeeUpdate = new System.Windows.Forms.TabPage();
            this.tpEmployeeDelete = new System.Windows.Forms.TabPage();
            this.tpAdminHome = new System.Windows.Forms.TabPage();
            this.tpLogout = new System.Windows.Forms.TabPage();
            this.tcEmployeeControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEmployeeControl
            // 
            this.tcEmployeeControl.Controls.Add(this.tpEmployeeSearch);
            this.tcEmployeeControl.Controls.Add(this.tpEmployeeAdd);
            this.tcEmployeeControl.Controls.Add(this.tpEmployeeUpdate);
            this.tcEmployeeControl.Controls.Add(this.tpEmployeeDelete);
            this.tcEmployeeControl.Controls.Add(this.tpAdminHome);
            this.tcEmployeeControl.Controls.Add(this.tpLogout);
            this.tcEmployeeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEmployeeControl.Location = new System.Drawing.Point(1, 1);
            this.tcEmployeeControl.Name = "tcEmployeeControl";
            this.tcEmployeeControl.Padding = new System.Drawing.Point(8, 6);
            this.tcEmployeeControl.SelectedIndex = 0;
            this.tcEmployeeControl.Size = new System.Drawing.Size(650, 395);
            this.tcEmployeeControl.TabIndex = 0;
            // 
            // tpEmployeeSearch
            // 
            this.tpEmployeeSearch.Location = new System.Drawing.Point(4, 28);
            this.tpEmployeeSearch.Name = "tpEmployeeSearch";
            this.tpEmployeeSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeSearch.Size = new System.Drawing.Size(642, 363);
            this.tpEmployeeSearch.TabIndex = 0;
            this.tpEmployeeSearch.Text = "Search";
            this.tpEmployeeSearch.UseVisualStyleBackColor = true;
            // 
            // tpEmployeeAdd
            // 
            this.tpEmployeeAdd.Location = new System.Drawing.Point(4, 28);
            this.tpEmployeeAdd.Name = "tpEmployeeAdd";
            this.tpEmployeeAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeAdd.Size = new System.Drawing.Size(642, 363);
            this.tpEmployeeAdd.TabIndex = 1;
            this.tpEmployeeAdd.Text = "Add Employee";
            this.tpEmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // tpEmployeeUpdate
            // 
            this.tpEmployeeUpdate.Location = new System.Drawing.Point(4, 28);
            this.tpEmployeeUpdate.Name = "tpEmployeeUpdate";
            this.tpEmployeeUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeUpdate.Size = new System.Drawing.Size(642, 363);
            this.tpEmployeeUpdate.TabIndex = 2;
            this.tpEmployeeUpdate.Text = "Update Employee";
            this.tpEmployeeUpdate.UseVisualStyleBackColor = true;
            // 
            // tpEmployeeDelete
            // 
            this.tpEmployeeDelete.Location = new System.Drawing.Point(4, 28);
            this.tpEmployeeDelete.Name = "tpEmployeeDelete";
            this.tpEmployeeDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeDelete.Size = new System.Drawing.Size(642, 363);
            this.tpEmployeeDelete.TabIndex = 3;
            this.tpEmployeeDelete.Text = "Delete Employee";
            this.tpEmployeeDelete.UseVisualStyleBackColor = true;
            // 
            // tpAdminHome
            // 
            this.tpAdminHome.Location = new System.Drawing.Point(4, 28);
            this.tpAdminHome.Name = "tpAdminHome";
            this.tpAdminHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminHome.Size = new System.Drawing.Size(642, 363);
            this.tpAdminHome.TabIndex = 4;
            this.tpAdminHome.Text = "Admin Home";
            this.tpAdminHome.UseVisualStyleBackColor = true;
            this.tpAdminHome.Enter += new System.EventHandler(this.tpAdminHome_Enter);
            // 
            // tpLogout
            // 
            this.tpLogout.Location = new System.Drawing.Point(4, 28);
            this.tpLogout.Name = "tpLogout";
            this.tpLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogout.Size = new System.Drawing.Size(642, 363);
            this.tpLogout.TabIndex = 5;
            this.tpLogout.Text = "Logout";
            this.tpLogout.UseVisualStyleBackColor = true;
            this.tpLogout.Enter += new System.EventHandler(this.tpLogout_Enter);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 398);
            this.Controls.Add(this.tcEmployeeControl);
            this.MaximizeBox = false;
            this.Name = "EmployeeControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Control";
            this.tcEmployeeControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEmployeeControl;
        private System.Windows.Forms.TabPage tpEmployeeSearch;
        private System.Windows.Forms.TabPage tpEmployeeAdd;
        private System.Windows.Forms.TabPage tpEmployeeUpdate;
        private System.Windows.Forms.TabPage tpEmployeeDelete;
        private System.Windows.Forms.TabPage tpAdminHome;
        private System.Windows.Forms.TabPage tpLogout;
    }
}