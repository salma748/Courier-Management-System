using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class TrackControl : UserControl
    {
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        int userID;
       
        public TrackControl(int id)
        {
            InitializeComponent();
            userID = id;
            LoadShipments();
        }
        public TrackControl()
        {
            InitializeComponent();
        }

        private void LoadShipments()
        {
            string query = "SELECT ShipmentID FROM Shipments WHERE CustomerID = :userID";

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("userID", userID));

                OracleDataReader reader = cmd.ExecuteReader();

                ship_Ids_cmbox.Items.Clear();

                while (reader.Read())
                {
                    ship_Ids_cmbox.Items.Add(reader["ShipmentID"].ToString());
                }
            }

            if (ship_Ids_cmbox.Items.Count == 0)
            {
                MessageBox.Show("No shipments found.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ship_Ids_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ship_Ids_cmbox.SelectedItem == null) return;

            int shipmentID = int.Parse(ship_Ids_cmbox.SelectedItem.ToString());

            string query = @"SELECT ShipmentID, Status 
                     FROM Shipments 
                     WHERE ShipmentID = :id 
                     AND CustomerID = :userID";

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id", shipmentID));
                    cmd.Parameters.Add(new OracleParameter("userID", userID));

                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
    }
}
