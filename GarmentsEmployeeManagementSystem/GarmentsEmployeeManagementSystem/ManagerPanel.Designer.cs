namespace GarmentsEmployeeManagementSystem
{
    partial class ManagerPanel
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
            this.tcManagerControl = new System.Windows.Forms.TabControl();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tpEmployeeAttendance = new System.Windows.Forms.TabPage();
            this.tpAddCommission = new System.Windows.Forms.TabPage();
            this.tpLogout = new System.Windows.Forms.TabPage();
            this.tcManagerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManagerControl
            // 
            this.tcManagerControl.Controls.Add(this.tpSearch);
            this.tcManagerControl.Controls.Add(this.tpEmployeeAttendance);
            this.tcManagerControl.Controls.Add(this.tpAddCommission);
            this.tcManagerControl.Controls.Add(this.tpLogout);
            this.tcManagerControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManagerControl.Location = new System.Drawing.Point(3, 0);
            this.tcManagerControl.Name = "tcManagerControl";
            this.tcManagerControl.Padding = new System.Drawing.Point(8, 6);
            this.tcManagerControl.SelectedIndex = 0;
            this.tcManagerControl.Size = new System.Drawing.Size(778, 403);
            this.tcManagerControl.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.Location = new System.Drawing.Point(4, 28);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(770, 371);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "Search";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // tpEmployeeAttendance
            // 
            this.tpEmployeeAttendance.Location = new System.Drawing.Point(4, 28);
            this.tpEmployeeAttendance.Name = "tpEmployeeAttendance";
            this.tpEmployeeAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeAttendance.Size = new System.Drawing.Size(770, 371);
            this.tpEmployeeAttendance.TabIndex = 1;
            this.tpEmployeeAttendance.Text = "Employee Attendance";
            this.tpEmployeeAttendance.UseVisualStyleBackColor = true;
            // 
            // tpAddCommission
            // 
            this.tpAddCommission.Location = new System.Drawing.Point(4, 28);
            this.tpAddCommission.Name = "tpAddCommission";
            this.tpAddCommission.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddCommission.Size = new System.Drawing.Size(770, 371);
            this.tpAddCommission.TabIndex = 2;
            this.tpAddCommission.Text = "Add Commission";
            this.tpAddCommission.UseVisualStyleBackColor = true;
            // 
            // tpLogout
            // 
            this.tpLogout.Location = new System.Drawing.Point(4, 28);
            this.tpLogout.Name = "tpLogout";
            this.tpLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogout.Size = new System.Drawing.Size(770, 371);
            this.tpLogout.TabIndex = 3;
            this.tpLogout.Text = "Logout";
            this.tpLogout.UseVisualStyleBackColor = true;
            this.tpLogout.Enter += new System.EventHandler(this.tpLogout_Enter);
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 401);
            this.Controls.Add(this.tcManagerControl);
            this.MaximizeBox = false;
            this.Name = "ManagerPanel";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Panel";
            this.Load += new System.EventHandler(this.ManagerPanel_Load);
            this.tcManagerControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManagerControl;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpEmployeeAttendance;
        private System.Windows.Forms.TabPage tpAddCommission;
        private System.Windows.Forms.TabPage tpLogout;
    }
}