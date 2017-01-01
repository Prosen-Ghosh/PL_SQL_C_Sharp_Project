using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarmentsEmployeeManagementSystem
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnManagerControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerControl MC = new ManagerControl();
            MC.Closed += (s, args) => this.Close();
            MC.Show();
        }

        private void btnDepartmentControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentControl DC = new DepartmentControl();
            DC.Closed += (s, args) => this.Close();
            DC.Show();
        }

        private void btnEmployeeControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeControl EC = new EmployeeControl();
            EC.Closed += (s, args) => this.Close();
            EC.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom LF = new LoginFrom();
            LF.Closed += (s, args) => this.Close();
            LF.Show();
        }

        private void btnAdminControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminControlcs AC = new AdminControlcs();
            AC.Closed += (s, args) => this.Close();
            AC.Show();
        }
    }
}
