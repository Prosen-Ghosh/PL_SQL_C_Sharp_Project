using Oracle.ManagedDataAccess.Client;
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
    public partial class ManagerControl : Form
    {
        public ManagerControl()
        {
            InitializeComponent();
        }
        OracleConnection _con = new OracleConnection("DATA SOURCE=Last1:1521/XE;USER ID=PRO; Password=aiub");
        
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

        private void tpManagerSearch_Enter(object sender, EventArgs e)
        {
            _con.Open();
            string sql = "SELECT * FROM MANAGER ORDER BY MANAGERID";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewManagers.DataSource = dt;
            _con.Close();
        }
    }
}
