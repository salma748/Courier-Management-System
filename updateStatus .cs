using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class updateStatus : UserControl
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        int courierID;

        public updateStatus(int id)
        {
            InitializeComponent();
            courierID = id;
        }

        private void updateStatus_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            conn = new OracleConnection(ordb);
            da = new OracleDataAdapter("SELECT * FROM Shipments WHERE CourierID = :cid AND Status NOT IN ('Delivered','Cancelled')", conn);
            da.SelectCommand.Parameters.Add(":cid", courierID);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            cmbShipmentID.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cmbShipmentID.Items.Add(row["ShipmentID"].ToString());
            }
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("In Transit");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (cmbShipmentID.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Select shipment and status");
                return;
            }

            int selectedID = Convert.ToInt32(cmbShipmentID.Text);
            bool found = false;
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["ShipmentID"]) == selectedID)
                {
                    if (row["Status"].ToString() == "Delivered")
                        return;

                    if (row["Status"].ToString() == "Cancelled")
                        return;

                    row["Status"] = cmbStatus.Text;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                da.Update(dt);
                MessageBox.Show("Status updated successfully");
                LoadData();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();   // LoginForm
            login.Show();
            this.Hide();
        }
    }
}