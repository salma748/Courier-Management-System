using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp1
{
    public partial class myShipments : UserControl
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int courierID;

        public myShipments(int id)
        {
            InitializeComponent();
            courierID = id;
        }

        private void myShipments_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            LoadShipments();
        }

        void LoadShipments()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetCourierShipments";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_courier_id", courierID);
            cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            myShipments_dgv.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadShipments();
        }

        private void myShipments_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();   // LoginForm
            login.Show();
            this.Hide();
        }
    }
}