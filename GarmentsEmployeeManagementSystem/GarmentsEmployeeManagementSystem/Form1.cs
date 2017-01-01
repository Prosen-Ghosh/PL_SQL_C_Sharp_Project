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
using System.Data.SqlClient;

namespace GarmentsEmployeeManagementSystem
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
            this.AcceptButton = btnLogIn;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text == string.Empty) {
                MessageBox.Show("Please Enter Id Number.");
                return;
            }
            if (tbUserPassword.Text == string.Empty) {
                MessageBox.Show("Please Enter Password.");
                return;
            }
            try {
                OracleConnection _con = new OracleConnection("DATA SOURCE=Last1:1521/XE;USER ID=PRO; Password=aiub");
                _con.Open();
                OracleCommand command = new OracleCommand("GET_LOGIN_INFO", _con);
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter retval = new OracleParameter("retval", OracleDbType.Varchar2, 10);
                retval.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(retval);

                OracleParameter val1 = new OracleParameter("val1", OracleDbType.Int32);
                val1.Direction = ParameterDirection.Input;
                val1.Value = Int32.Parse(tbUserId.Text.ToString());
                command.Parameters.Add(val1);

                OracleParameter val2 = new OracleParameter("val2", OracleDbType.Varchar2);
                val2.Direction = ParameterDirection.Input;
                val2.Value = tbUserPassword.Text.ToString();
                command.Parameters.Add(val2);

                command.ExecuteNonQuery();

                if (retval.Value.ToString().ToUpper() == "ADMIN")
                {
                    this.Hide();
                    AdminPanel AP = new AdminPanel();
                    AP.Closed += (s, args) => this.Close();
                    AP.Show();
                }
                else if (retval.Value.ToString().ToUpper() == "MANAGER")
                {
                    this.Hide();
                    ManagerPanel MP = new ManagerPanel();
                    MP.Closed += (s, args) => this.Close();
                    MP.Show();
                }
            }catch(Exception ex){
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
