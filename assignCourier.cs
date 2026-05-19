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

namespace WindowsFormsApp1
{
    public partial class assignCourier : UserControl
    {
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";

        public assignCourier()
        {
            InitializeComponent();
            LoadShipments();
            LoadCouriers();
        }

        private void LoadShipments()
        {
            try
            {
                string query = @"SELECT ShipmentID 
                                 FROM Shipments 
                                 WHERE Status = 'Pending'";

                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        shipments_cmb.Items.Clear();
                        while (reader.Read())
                        {
                            shipments_cmb.Items.Add(reader["ShipmentID"].ToString());
                        }
                    }
                }

             
                shipments_cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shipments: " + ex.Message);
            }
        }

        private void LoadCouriers()
        {
            try
            {
                string query = @"SELECT UserID, Name 
                                 FROM Users 
                                 WHERE Role = 'Courier'";

                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        courier_cmb.DataSource = null;
                        courier_cmb.DisplayMember = "Name";
                        courier_cmb.ValueMember = "UserID";
                        courier_cmb.DataSource = dt;  
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading couriers: " + ex.Message);
            }
        }

        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (shipments_cmb.SelectedItem == null)
                {
                    MessageBox.Show("Please select a shipment.");
                    return;
                }

                if (courier_cmb.SelectedValue == null || courier_cmb.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Please select a courier.");
                    return;
                }

                int shipmentID = int.Parse(shipments_cmb.SelectedItem.ToString());
                int courierID = Convert.ToInt32(courier_cmb.SelectedValue);

                string query = @"UPDATE Shipments 
                                 SET CourierID = :courierID, Status = 'In Transit' 
                                 WHERE ShipmentID = :shipmentID";

                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        
                        cmd.Parameters.Add(new OracleParameter("courierID", OracleDbType.Int32) { Value = courierID });
                        cmd.Parameters.Add(new OracleParameter("shipmentID", OracleDbType.Int32) { Value = shipmentID });

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Courier assigned successfully!");
                            LoadShipments();
                            LoadCouriers();
                            shipments_cmb.SelectedIndex = -1;
                            courier_cmb.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Assignment failed. Shipment ID may not exist or is no longer pending.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during assignment: " + ex.Message);
            }
        
    }
    }
}