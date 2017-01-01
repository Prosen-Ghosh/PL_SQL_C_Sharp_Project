namespace GarmentsEmployeeManagementSystem
{
    partial class DepartmentControl
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
            this.tcDepartmentControl = new System.Windows.Forms.TabControl();
            this.tpDepartmentSearch = new System.Windows.Forms.TabPage();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.tpAddDepartment = new System.Windows.Forms.TabPage();
            this.btnAddDepartmentSubmit = new System.Windows.Forms.Button();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.tbDepartmentId = new System.Windows.Forms.TextBox();
            this.lvlDepartmentName = new System.Windows.Forms.Label();
            this.lvlDepartmentId = new System.Windows.Forms.Label();
            this.lvlAddDepartmentMsg = new System.Windows.Forms.Label();
            this.tpDepartmentUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewUpdateDepartment = new System.Windows.Forms.DataGridView();
            this.CheckBoxUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lvlUpdateDepartmentMsg = new System.Windows.Forms.Label();
            this.tpDepartmentDelete = new System.Windows.Forms.TabPage();
            this.lvlDepartmentDeleteMsg = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewDeleteDepartment = new System.Windows.Forms.DataGridView();
            this.CheckBoxDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpAdminHome = new System.Windows.Forms.TabPage();
            this.tpLogout = new System.Windows.Forms.TabPage();
            this.tcDepartmentControl.SuspendLayout();
            this.tpDepartmentSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.tpAddDepartment.SuspendLayout();
            this.tpDepartmentUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateDepartment)).BeginInit();
            this.tpDepartmentDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDepartmentControl
            // 
            this.tcDepartmentControl.Controls.Add(this.tpDepartmentSearch);
            this.tcDepartmentControl.Controls.Add(this.tpAddDepartment);
            this.tcDepartmentControl.Controls.Add(this.tpDepartmentUpdate);
            this.tcDepartmentControl.Controls.Add(this.tpDepartmentDelete);
            this.tcDepartmentControl.Controls.Add(this.tpAdminHome);
            this.tcDepartmentControl.Controls.Add(this.tpLogout);
            this.tcDepartmentControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDepartmentControl.Location = new System.Drawing.Point(-1, 1);
            this.tcDepartmentControl.Name = "tcDepartmentControl";
            this.tcDepartmentControl.Padding = new System.Drawing.Point(8, 6);
            this.tcDepartmentControl.SelectedIndex = 0;
            this.tcDepartmentControl.Size = new System.Drawing.Size(786, 396);
            this.tcDepartmentControl.TabIndex = 0;
            // 
            // tpDepartmentSearch
            // 
            this.tpDepartmentSearch.Controls.Add(this.dataGridViewDepartment);
            this.tpDepartmentSearch.Location = new System.Drawing.Point(4, 28);
            this.tpDepartmentSearch.Name = "tpDepartmentSearch";
            this.tpDepartmentSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepartmentSearch.Size = new System.Drawing.Size(778, 364);
            this.tpDepartmentSearch.TabIndex = 0;
            this.tpDepartmentSearch.Text = "Departments";
            this.tpDepartmentSearch.UseVisualStyleBackColor = true;
            this.tpDepartmentSearch.Enter += new System.EventHandler(this.tpDepartmentSearch_Enter);
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(9, 44);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.Size = new System.Drawing.Size(762, 319);
            this.dataGridViewDepartment.TabIndex = 1;
            // 
            // tpAddDepartment
            // 
            this.tpAddDepartment.Controls.Add(this.btnAddDepartmentSubmit);
            this.tpAddDepartment.Controls.Add(this.tbDepartmentName);
            this.tpAddDepartment.Controls.Add(this.tbDepartmentId);
            this.tpAddDepartment.Controls.Add(this.lvlDepartmentName);
            this.tpAddDepartment.Controls.Add(this.lvlDepartmentId);
            this.tpAddDepartment.Controls.Add(this.lvlAddDepartmentMsg);
            this.tpAddDepartment.Location = new System.Drawing.Point(4, 28);
            this.tpAddDepartment.Name = "tpAddDepartment";
            this.tpAddDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddDepartment.Size = new System.Drawing.Size(778, 364);
            this.tpAddDepartment.TabIndex = 1;
            this.tpAddDepartment.Text = "Add Department";
            this.tpAddDepartment.UseVisualStyleBackColor = true;
            // 
            // btnAddDepartmentSubmit
            // 
            this.btnAddDepartmentSubmit.Location = new System.Drawing.Point(443, 180);
            this.btnAddDepartmentSubmit.Name = "btnAddDepartmentSubmit";
            this.btnAddDepartmentSubmit.Size = new System.Drawing.Size(75, 35);
            this.btnAddDepartmentSubmit.TabIndex = 5;
            this.btnAddDepartmentSubmit.Text = "Submit";
            this.btnAddDepartmentSubmit.UseVisualStyleBackColor = true;
            this.btnAddDepartmentSubmit.Click += new System.EventHandler(this.btnAddDepartmentSubmit_Click);
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(291, 131);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(228, 20);
            this.tbDepartmentName.TabIndex = 4;
            // 
            // tbDepartmentId
            // 
            this.tbDepartmentId.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDepartmentId.Location = new System.Drawing.Point(291, 80);
            this.tbDepartmentId.Name = "tbDepartmentId";
            this.tbDepartmentId.ReadOnly = true;
            this.tbDepartmentId.Size = new System.Drawing.Size(228, 20);
            this.tbDepartmentId.TabIndex = 3;
            // 
            // lvlDepartmentName
            // 
            this.lvlDepartmentName.AutoSize = true;
            this.lvlDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDepartmentName.Location = new System.Drawing.Point(85, 131);
            this.lvlDepartmentName.Name = "lvlDepartmentName";
            this.lvlDepartmentName.Size = new System.Drawing.Size(137, 16);
            this.lvlDepartmentName.TabIndex = 2;
            this.lvlDepartmentName.Text = "Department Name:";
            // 
            // lvlDepartmentId
            // 
            this.lvlDepartmentId.AutoSize = true;
            this.lvlDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDepartmentId.Location = new System.Drawing.Point(85, 85);
            this.lvlDepartmentId.Name = "lvlDepartmentId";
            this.lvlDepartmentId.Size = new System.Drawing.Size(109, 16);
            this.lvlDepartmentId.TabIndex = 1;
            this.lvlDepartmentId.Text = "Department Id:";
            // 
            // lvlAddDepartmentMsg
            // 
            this.lvlAddDepartmentMsg.AutoSize = true;
            this.lvlAddDepartmentMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAddDepartmentMsg.Location = new System.Drawing.Point(288, 14);
            this.lvlAddDepartmentMsg.Name = "lvlAddDepartmentMsg";
            this.lvlAddDepartmentMsg.Size = new System.Drawing.Size(154, 16);
            this.lvlAddDepartmentMsg.TabIndex = 0;
            this.lvlAddDepartmentMsg.Text = "Add New Department";
            // 
            // tpDepartmentUpdate
            // 
            this.tpDepartmentUpdate.Controls.Add(this.btnUpdate);
            this.tpDepartmentUpdate.Controls.Add(this.dataGridViewUpdateDepartment);
            this.tpDepartmentUpdate.Controls.Add(this.lvlUpdateDepartmentMsg);
            this.tpDepartmentUpdate.Location = new System.Drawing.Point(4, 28);
            this.tpDepartmentUpdate.Name = "tpDepartmentUpdate";
            this.tpDepartmentUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepartmentUpdate.Size = new System.Drawing.Size(778, 364);
            this.tpDepartmentUpdate.TabIndex = 2;
            this.tpDepartmentUpdate.Text = "Update Department";
            this.tpDepartmentUpdate.UseVisualStyleBackColor = true;
            this.tpDepartmentUpdate.Enter += new System.EventHandler(this.tpDepartmentUpdate_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(655, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewUpdateDepartment
            // 
            this.dataGridViewUpdateDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpdateDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdateDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxUpdate});
            this.dataGridViewUpdateDepartment.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewUpdateDepartment.Name = "dataGridViewUpdateDepartment";
            this.dataGridViewUpdateDepartment.Size = new System.Drawing.Size(765, 283);
            this.dataGridViewUpdateDepartment.TabIndex = 1;
            // 
            // CheckBoxUpdate
            // 
            this.CheckBoxUpdate.HeaderText = "Select For Update";
            this.CheckBoxUpdate.Name = "CheckBoxUpdate";
            // 
            // lvlUpdateDepartmentMsg
            // 
            this.lvlUpdateDepartmentMsg.AutoSize = true;
            this.lvlUpdateDepartmentMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUpdateDepartmentMsg.Location = new System.Drawing.Point(322, 9);
            this.lvlUpdateDepartmentMsg.Name = "lvlUpdateDepartmentMsg";
            this.lvlUpdateDepartmentMsg.Size = new System.Drawing.Size(143, 16);
            this.lvlUpdateDepartmentMsg.TabIndex = 0;
            this.lvlUpdateDepartmentMsg.Text = "Update Department";
            // 
            // tpDepartmentDelete
            // 
            this.tpDepartmentDelete.Controls.Add(this.lvlDepartmentDeleteMsg);
            this.tpDepartmentDelete.Controls.Add(this.btnDelete);
            this.tpDepartmentDelete.Controls.Add(this.dataGridViewDeleteDepartment);
            this.tpDepartmentDelete.Location = new System.Drawing.Point(4, 28);
            this.tpDepartmentDelete.Name = "tpDepartmentDelete";
            this.tpDepartmentDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpDepartmentDelete.Size = new System.Drawing.Size(778, 364);
            this.tpDepartmentDelete.TabIndex = 3;
            this.tpDepartmentDelete.Text = "Delete Department";
            this.tpDepartmentDelete.UseVisualStyleBackColor = true;
            this.tpDepartmentDelete.Enter += new System.EventHandler(this.tpDepartmentDelete_Enter);
            // 
            // lvlDepartmentDeleteMsg
            // 
            this.lvlDepartmentDeleteMsg.AutoSize = true;
            this.lvlDepartmentDeleteMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDepartmentDeleteMsg.Location = new System.Drawing.Point(318, 12);
            this.lvlDepartmentDeleteMsg.Name = "lvlDepartmentDeleteMsg";
            this.lvlDepartmentDeleteMsg.Size = new System.Drawing.Size(138, 16);
            this.lvlDepartmentDeleteMsg.TabIndex = 2;
            this.lvlDepartmentDeleteMsg.Text = "Delete Department";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(674, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewDeleteDepartment
            // 
            this.dataGridViewDeleteDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeleteDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxDelete});
            this.dataGridViewDeleteDepartment.Location = new System.Drawing.Point(6, 43);
            this.dataGridViewDeleteDepartment.Name = "dataGridViewDeleteDepartment";
            this.dataGridViewDeleteDepartment.Size = new System.Drawing.Size(766, 267);
            this.dataGridViewDeleteDepartment.TabIndex = 0;
            // 
            // CheckBoxDelete
            // 
            this.CheckBoxDelete.HeaderText = "Select For Delete";
            this.CheckBoxDelete.Name = "CheckBoxDelete";
            this.CheckBoxDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tpAdminHome
            // 
            this.tpAdminHome.Location = new System.Drawing.Point(4, 28);
            this.tpAdminHome.Name = "tpAdminHome";
            this.tpAdminHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminHome.Size = new System.Drawing.Size(778, 364);
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
            this.tpLogout.Size = new System.Drawing.Size(778, 364);
            this.tpLogout.TabIndex = 5;
            this.tpLogout.Text = "Logout";
            this.tpLogout.UseVisualStyleBackColor = true;
            this.tpLogout.Enter += new System.EventHandler(this.tpLogout_Enter);
            // 
            // DepartmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 398);
            this.Controls.Add(this.tcDepartmentControl);
            this.MaximizeBox = false;
            this.Name = "DepartmentControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department Control";
            this.tcDepartmentControl.ResumeLayout(false);
            this.tpDepartmentSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.tpAddDepartment.ResumeLayout(false);
            this.tpAddDepartment.PerformLayout();
            this.tpDepartmentUpdate.ResumeLayout(false);
            this.tpDepartmentUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateDepartment)).EndInit();
            this.tpDepartmentDelete.ResumeLayout(false);
            this.tpDepartmentDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDepartmentControl;
        private System.Windows.Forms.TabPage tpDepartmentSearch;
        private System.Windows.Forms.TabPage tpAddDepartment;
        private System.Windows.Forms.TabPage tpDepartmentUpdate;
        private System.Windows.Forms.TabPage tpDepartmentDelete;
        private System.Windows.Forms.TabPage tpAdminHome;
        private System.Windows.Forms.TabPage tpLogout;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Label lvlAddDepartmentMsg;
        private System.Windows.Forms.Button btnAddDepartmentSubmit;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.TextBox tbDepartmentId;
        private System.Windows.Forms.Label lvlDepartmentName;
        private System.Windows.Forms.Label lvlDepartmentId;
        private System.Windows.Forms.Label lvlUpdateDepartmentMsg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewUpdateDepartment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewDeleteDepartment;
        private System.Windows.Forms.Label lvlDepartmentDeleteMsg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxDelete;
    }
}