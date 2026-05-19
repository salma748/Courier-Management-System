using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class manageShipments : UserControl
    {
        OracleDataAdapter daSelect;
        OracleDataAdapter daUpdate;
        DataSet ds;
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        public manageShipments()
        {
            InitializeComponent();
        }

        private void manageShipments_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            OracleCommand cmd = new OracleCommand("GetAllShipments", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            daSelect = new OracleDataAdapter(cmd);
            ds = new DataSet();
            daSelect.Fill(ds);
            ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["SHIPMENTID"] };
            dataGridShipments.DataSource = ds.Tables[0];
            dataGridShipments.Columns["SHIPMENTID"].ReadOnly = true;
            daUpdate = new OracleDataAdapter("SELECT * FROM Shipments", conn);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder cb = new OracleCommandBuilder(daUpdate);
            daUpdate.Update(ds.Tables[0]);
            MessageBox.Show("Updated successfully");
        }
    }
}