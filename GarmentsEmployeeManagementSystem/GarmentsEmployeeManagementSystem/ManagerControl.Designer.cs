namespace GarmentsEmployeeManagementSystem
{
    partial class ManagerControl
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
            this.tpManagerSearch = new System.Windows.Forms.TabPage();
            this.tpAddManager = new System.Windows.Forms.TabPage();
            this.tpManagerUpdate = new System.Windows.Forms.TabPage();
            this.tpManagerDelete = new System.Windows.Forms.TabPage();
            this.tpAdminHome = new System.Windows.Forms.TabPage();
            this.tpLogout = new System.Windows.Forms.TabPage();
            this.dataGridViewManagers = new System.Windows.Forms.DataGridView();
            this.tcManagerControl.SuspendLayout();
            this.tpManagerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // tcManagerControl
            // 
            this.tcManagerControl.Controls.Add(this.tpManagerSearch);
            this.tcManagerControl.Controls.Add(this.tpAddManager);
            this.tcManagerControl.Controls.Add(this.tpManagerUpdate);
            this.tcManagerControl.Controls.Add(this.tpManagerDelete);
            this.tcManagerControl.Controls.Add(this.tpAdminHome);
            this.tcManagerControl.Controls.Add(this.tpLogout);
            this.tcManagerControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcManagerControl.Location = new System.Drawing.Point(0, 0);
            this.tcManagerControl.Name = "tcManagerControl";
            this.tcManagerControl.Padding = new System.Drawing.Point(8, 6);
            this.tcManagerControl.SelectedIndex = 0;
            this.tcManagerControl.Size = new System.Drawing.Size(787, 390);
            this.tcManagerControl.TabIndex = 0;
            // 
            // tpManagerSearch
            // 
            this.tpManagerSearch.Controls.Add(this.dataGridViewManagers);
            this.tpManagerSearch.Location = new System.Drawing.Point(4, 28);
            this.tpManagerSearch.Name = "tpManagerSearch";
            this.tpManagerSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagerSearch.Size = new System.Drawing.Size(779, 358);
            this.tpManagerSearch.TabIndex = 0;
            this.tpManagerSearch.Text = "Managers";
            this.tpManagerSearch.UseVisualStyleBackColor = true;
            this.tpManagerSearch.Enter += new System.EventHandler(this.tpManagerSearch_Enter);
            // 
            // tpAddManager
            // 
            this.tpAddManager.Location = new System.Drawing.Point(4, 28);
            this.tpAddManager.Name = "tpAddManager";
            this.tpAddManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddManager.Size = new System.Drawing.Size(779, 358);
            this.tpAddManager.TabIndex = 1;
            this.tpAddManager.Text = "Add manager";
            this.tpAddManager.UseVisualStyleBackColor = true;
            // 
            // tpManagerUpdate
            // 
            this.tpManagerUpdate.Location = new System.Drawing.Point(4, 28);
            this.tpManagerUpdate.Name = "tpManagerUpdate";
            this.tpManagerUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagerUpdate.Size = new System.Drawing.Size(779, 358);
            this.tpManagerUpdate.TabIndex = 2;
            this.tpManagerUpdate.Text = "Update Manager";
            this.tpManagerUpdate.UseVisualStyleBackColor = true;
            // 
            // tpManagerDelete
            // 
            this.tpManagerDelete.Location = new System.Drawing.Point(4, 28);
            this.tpManagerDelete.Name = "tpManagerDelete";
            this.tpManagerDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpManagerDelete.Size = new System.Drawing.Size(779, 358);
            this.tpManagerDelete.TabIndex = 3;
            this.tpManagerDelete.Text = "Delete Manager";
            this.tpManagerDelete.UseVisualStyleBackColor = true;
            // 
            // tpAdminHome
            // 
            this.tpAdminHome.Location = new System.Drawing.Point(4, 28);
            this.tpAdminHome.Name = "tpAdminHome";
            this.tpAdminHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminHome.Size = new System.Drawing.Size(779, 358);
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
            this.tpLogout.Size = new System.Drawing.Size(779, 358);
            this.tpLogout.TabIndex = 5;
            this.tpLogout.Text = "Logout";
            this.tpLogout.UseVisualStyleBackColor = true;
            this.tpLogout.Enter += new System.EventHandler(this.tpLogout_Enter);
            // 
            // dataGridViewManagers
            // 
            this.dataGridViewManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagers.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewManagers.Name = "dataGridViewManagers";
            this.dataGridViewManagers.Size = new System.Drawing.Size(765, 344);
            this.dataGridViewManagers.TabIndex = 0;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 390);
            this.Controls.Add(this.tcManagerControl);
            this.MaximizeBox = false;
            this.Name = "ManagerControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Control";
            this.tcManagerControl.ResumeLayout(false);
            this.tpManagerSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManagerControl;
        private System.Windows.Forms.TabPage tpManagerSearch;
        private System.Windows.Forms.TabPage tpAddManager;
        private System.Windows.Forms.TabPage tpManagerUpdate;
        private System.Windows.Forms.TabPage tpManagerDelete;
        private System.Windows.Forms.TabPage tpAdminHome;
        private System.Windows.Forms.TabPage tpLogout;
        private System.Windows.Forms.DataGridView dataGridViewManagers;
    }
}