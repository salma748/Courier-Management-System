using Oracle.DataAccess.Client;
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
    public partial class CancelControl : UserControl
    {
        int userID;
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";

       
        public CancelControl(int id)
        {
            InitializeComponent();
            userID = id;
            LoadShipments();
        }
        private void LoadShipments()
        {
            string query = @"SELECT ShipmentID 
                 FROM Shipments 
                 WHERE CustomerID = :userID 
                 AND Status NOT IN ('Delivered', 'Cancelled')";
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("userID", userID));

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        cmbShipments.Items.Clear();

                        while (reader.Read())
                        {
                            cmbShipments.Items.Add(reader["ShipmentID"].ToString());
                        }
                    }
                }
            }

            if (cmbShipments.Items.Count == 0)
            {
                MessageBox.Show("No shipments available to cancel.");
            }
        }
        public CancelControl()
        {
            InitializeComponent();
        }

        private void cmbShipments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cmbShipments.SelectedItem == null)
            {
                MessageBox.Show("Please select a shipment first.");
                return;
            }

            int shipmentID = int.Parse(cmbShipments.SelectedItem.ToString());

            string query = @"UPDATE Shipments 
                     SET Status = 'Cancelled' 
                     WHERE ShipmentID = :id 
                     AND CustomerID = :userID 
                     AND Status != 'Delivered'";

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(new OracleParameter("id", shipmentID));
                cmd.Parameters.Add(new OracleParameter("userID", userID));

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Shipment cancelled successfully.");

                    LoadShipments(); 
                }
                else
                {
                    MessageBox.Show("Cannot cancel this shipment.");
                }
            }
        }
    }
}
