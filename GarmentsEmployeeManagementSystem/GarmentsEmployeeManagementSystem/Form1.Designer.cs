namespace GarmentsEmployeeManagementSystem
{
    partial class LoginFrom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.lvlUserPassword = new System.Windows.Forms.Label();
            this.lvlUserId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.tbUserPassword);
            this.panel1.Controls.Add(this.tbUserId);
            this.panel1.Controls.Add(this.lvlUserPassword);
            this.panel1.Controls.Add(this.lvlUserId);
            this.panel1.Location = new System.Drawing.Point(69, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 213);
            this.panel1.TabIndex = 0;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(342, 149);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(81, 30);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(199, 94);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(224, 20);
            this.tbUserPassword.TabIndex = 3;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(199, 42);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(224, 20);
            this.tbUserId.TabIndex = 2;
            // 
            // lvlUserPassword
            // 
            this.lvlUserPassword.AutoSize = true;
            this.lvlUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUserPassword.Location = new System.Drawing.Point(38, 94);
            this.lvlUserPassword.Name = "lvlUserPassword";
            this.lvlUserPassword.Size = new System.Drawing.Size(139, 20);
            this.lvlUserPassword.TabIndex = 1;
            this.lvlUserPassword.Text = "User Password: ";
            // 
            // lvlUserId
            // 
            this.lvlUserId.AutoSize = true;
            this.lvlUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUserId.Location = new System.Drawing.Point(38, 43);
            this.lvlUserId.Name = "lvlUserId";
            this.lvlUserId.Size = new System.Drawing.Size(78, 20);
            this.lvlUserId.TabIndex = 0;
            this.lvlUserId.Text = "User Id: ";
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 292);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LoginFrom";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label lvlUserPassword;
        private System.Windows.Forms.Label lvlUserId;
    }
}

