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
    public partial class EmployeeControl : Form
    {
        public EmployeeControl()
        {
            InitializeComponent();
        }

        private void tpAdminHome_Enter(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel AP = new AdminPanel();
            AP.Closed += (s, args) => this.Close();
            AP.Show();
        }

        private void tpLogout_Enter(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom LF = new LoginFrom();
            LF.Closed += (s, args) => this.Close();
            LF.Show();
        }
    }
}
