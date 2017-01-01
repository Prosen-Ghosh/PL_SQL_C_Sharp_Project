using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GarmentsEmployeeManagementSystem
{
    public partial class AdminControlcs : Form
    {
        public AdminControlcs()
        {
            InitializeComponent();
        }

        private void tbadminLogout_Enter(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom LF = new LoginFrom();
            LF.Closed += (s, args) => this.Close();
            LF.Show();
        }

        private void tbHome_Enter(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel AP = new AdminPanel();
            AP.Closed += (s, args) => this.Close();
            AP.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection _con = new OracleConnection("DATA SOURCE=Last1:1521/XE;USER ID=PRO; Password=aiub");
                _con.Open();
                OracleCommand command = new OracleCommand("ADD_ADMIN", _con);
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter val1 = new OracleParameter("val1", OracleDbType.Varchar2);
                val1.Direction = ParameterDirection.Input;
                val1.Value = tbAdminName.Text.ToString();
                command.Parameters.Add(val1);

                OracleParameter val2 = new OracleParameter("val2", OracleDbType.Varchar2);
                val2.Direction = ParameterDirection.Input;
                val2.Value = tbAdminPassword.Text.ToString();
                command.Parameters.Add(val2);

                OracleParameter val3 = new OracleParameter("val3", OracleDbType.Varchar2);
                val3.Direction = ParameterDirection.Input;
                val3.Value = tbAdminEmail.Text.ToString();
                command.Parameters.Add(val3);

                OracleParameter val4 = new OracleParameter("val4", OracleDbType.Varchar2);
                val4.Direction = ParameterDirection.Input;
                val4.Value = tbAdminGender.Text.ToString();
                command.Parameters.Add(val4);

                OracleParameter val5 = new OracleParameter("val5", OracleDbType.Varchar2);
                val5.Direction = ParameterDirection.Input;
                val5.Value = tbAdminPhone.Text.ToString();
                command.Parameters.Add(val5);

                command.ExecuteNonQuery();

                MessageBox.Show("Admin Insert Successfull.");
                tbAdminName.Text = string.Empty;
                tbAdminPassword.Text = string.Empty;
                tbAdminEmail.Text = string.Empty;
                tbAdminGender.Text = string.Empty;
                tbAdminPhone.Text = string.Empty;
            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
