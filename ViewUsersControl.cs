using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp1
{
    public partial class ViewUsersControl : UserControl
    {
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleDataAdapter da;
        DataTable dt;
        public ViewUsersControl()
        {
            InitializeComponent();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUsersControl_Load(object sender, EventArgs e)
        {
          
            OracleConnection conn = new OracleConnection(connStr);

            da = new OracleDataAdapter("SELECT * FROM Users", conn);

            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            cmbFilter.Items.Add("All");
            cmbFilter.Items.Add("Customer");
            cmbFilter.Items.Add("Admin");
            cmbFilter.Items.Add("Courier");
            cmbFilter.SelectedIndex = 0; // default = All
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        
            string selectedRole = cmbFilter.Text;

            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();

            string query;

            if (selectedRole == "All")
            {
                query = "SELECT * FROM Users";
            }
            else
            {
                query = "SELECT * FROM Users WHERE ROLE = :role";
            }

            OracleCommand cmd = new OracleCommand(query, conn);

            if (selectedRole != "All")
            {
                cmd.Parameters.Add("role", selectedRole);
            }

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        
        }
    }
}
