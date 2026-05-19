using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class confirmDelivery : UserControl
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleDataAdapter da;
        DataTable dt;
        int courierID;
        public confirmDelivery(int id)
        {
            InitializeComponent();
            courierID = id;
        }


        private void confirmDelivery_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            OracleConnection conn = new OracleConnection(ordb);
            da = new OracleDataAdapter("SELECT * FROM Shipments WHERE CourierID = :cid AND Status = 'In Transit'", conn);
            da.SelectCommand.Parameters.Add(":cid", courierID);
            OracleCommandBuilder cb = new OracleCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            cmbShipmentID.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cmbShipmentID.Items.Add(row["ShipmentID"].ToString());
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbShipmentID.SelectedIndex == -1)
            {
                MessageBox.Show("Select shipment");
                return;
            }

            int selectedID = Convert.ToInt32(cmbShipmentID.Text);
            bool found = false;

            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["ShipmentID"]) == selectedID)
                {
                    row["Status"] = "Delivered";
                    found = true;
                    break;
                }
            }

            if (found)
            {
                da.Update(dt);
                MessageBox.Show("Delivery confirmed");
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