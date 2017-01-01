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
    public partial class DepartmentControl : Form
    {
        public DepartmentControl()
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

        private void tpDepartmentSearch_Enter(object sender, EventArgs e)
        {
            loadDepartments();
        }

        private void loadDepartments(){
            
            _con.Open();
            string sql = "SELECT * FROM DEPARTMENT ORDER BY DEPARTMENTID";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewDepartment.DataSource = dt;
            OracleDataAdapter adapterDeptId = new OracleDataAdapter("select max(DEPARTMENTID)+1 from department", _con);
            DataTable dtDeptID = new DataTable();
            adapterDeptId.Fill(dtDeptID);
            tbDepartmentId.Text = dtDeptID.Rows[0][0].ToString();
            _con.Close();
        }

        private void btnAddDepartmentSubmit_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = _con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PRO.CHECK_DEPT_NAME";
            cmd.BindByName = true;
            cmd.Parameters.Add("NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = tbDepartmentName.Text;
            cmd.Parameters.Add("VAL", OracleDbType.Int32, ParameterDirection.ReturnValue);
            _con.Open();
            cmd.ExecuteNonQuery();
            string VALSTR = cmd.Parameters["VAL"].Value.ToString();
            int val = Int32.Parse(VALSTR);
            
            _con.Close();
            if (val > 0)
            {
                MessageBox.Show("Department alreay exist...");
            }
            else
            {
                MessageBox.Show("New Department added Successfully...");
                tbDepartmentName.Text = "";
                this.loadDepartments();
            }
                      
        }

        private void tpDepartmentUpdate_Enter(object sender, EventArgs e)
        {
            _con.Open();
            string sql = "SELECT * FROM DEPARTMENT ORDER BY DEPARTMENTID";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewUpdateDepartment.DataSource = dt;
            _con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _con.Open();
                string sql = "SELECT * FROM DEPARTMENT ORDER BY DEPARTMENTID";
                OracleDataAdapter adapter = new OracleDataAdapter(sql, _con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                _con.Close();
                int i = 0;
                bool isChecked = false;
                foreach (DataGridViewRow row in dataGridViewUpdateDepartment.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {

                        dt.Rows[i][0] = row.Cells[1].Value.ToString();
                        dt.Rows[i][1] = row.Cells[2].Value.ToString();
                        isChecked = true;
                    }
                    if (isChecked)
                    {
                        _con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = _con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "PRO.UPDATE_DEPARTMENT";
                        cmd.BindByName = true;
                        cmd.Parameters.Add("ID", OracleDbType.Int32,ParameterDirection.Input).Value = Int32.Parse(dt.Rows[i][0].ToString());
                        cmd.Parameters.Add("NAME", OracleDbType.Varchar2, ParameterDirection.Input).Value = dt.Rows[i][1].ToString();

                        cmd.ExecuteNonQuery();
                        isChecked = false;
                        i++;
                        _con.Close();
                    }
                }
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _con.Open();
                string sql = "SELECT * FROM DEPARTMENT ORDER BY DEPARTMENTID";
                OracleDataAdapter adapter = new OracleDataAdapter(sql, _con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                _con.Close();
                int i = 0;
                bool isChecked = false;
                foreach (DataGridViewRow row in dataGridViewDeleteDepartment.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {

                        dt.Rows[i][0] = row.Cells[1].Value.ToString();
                        //dt.Rows[i][1] = row.Cells[2].Value.ToString();
                        isChecked = true;
                    }
                    if (isChecked)
                    {
                        _con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = _con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "PRO.DELETE_DEPARTMENT";
                        cmd.BindByName = true;
                        cmd.Parameters.Add("ID", OracleDbType.Int32, ParameterDirection.Input).Value = Int32.Parse(dt.Rows[i][0].ToString());
                        cmd.ExecuteNonQuery();
                        isChecked = false;
                        i++;
                        _con.Close();
                    }
                }
                MessageBox.Show("Deleted Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tpDepartmentDelete_Enter(object sender, EventArgs e)
        {
            _con.Open();
            string sql = "SELECT * FROM DEPARTMENT ORDER BY DEPARTMENTID";
            OracleDataAdapter adapter = new OracleDataAdapter(sql, _con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewDeleteDepartment.DataSource = dt;
            _con.Close();
        }
    }
}
