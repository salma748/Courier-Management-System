using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class DeleteUserControl : UserControl
    {
        string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleDataAdapter da;
        DataTable dt;

        public DeleteUserControl()
        {
            InitializeComponent();
        }

        private void DeleteUserControl_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            da = new OracleDataAdapter("SELECT * FROM Users", conn);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            id_cmb.DataSource = dt;
            id_cmb.DisplayMember = "UserID";
            id_cmb.ValueMember = "UserID";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_cmb.SelectedValue == null)
                {
                    MessageBox.Show("Select a user");
                    return;
                }
                int id = Convert.ToInt32(id_cmb.SelectedValue);
                DataRow[] rows = dt.Select("UserID = " + id);
                if (rows.Length == 0)
                {
                    MessageBox.Show("User not found!");
                    return;
                }
                rows[0].Delete();
                da.Update(dt);
                MessageBox.Show("User deleted successfully!");
                dt.Clear();
                da.Fill(dt);
                id_cmb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}