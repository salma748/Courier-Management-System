using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class AddUserControl : UserControl
    {
        string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleDataAdapter da;
        DataSet ds;
        public AddUserControl()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            da = new OracleDataAdapter("SELECT * FROM Users", conn);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            string role = "";
            if (customer.Checked)
                role = "Customer";
            else if (admin.Checked)
                role = "Admin";
            else if (courier.Checked)
                role = "Courier";
            else
            {
                MessageBox.Show("Please select a role");
                return;
            }

            try
            {
                DataRow newRow = ds.Tables[0].NewRow();
                int newID = 1;
                if (ds.Tables[0].Rows.Count > 0)
                    newID = Convert.ToInt32(ds.Tables[0].Compute("MAX(UserID)", "")) + 1;

                newRow["UserID"] = newID;
                newRow["Name"] = name_txt.Text;
                newRow["Email"] = email_txt.Text;
                newRow["Password"] = pass_txt.Text;
                newRow["Role"] = role;

                ds.Tables[0].Rows.Add(newRow);

                da.Update(ds.Tables[0]);

                MessageBox.Show("User added successfully!");

                name_txt.Clear();
                email_txt.Clear();
                pass_txt.Clear();
                customer.Checked = false;
                courier.Checked = false;
                admin.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
