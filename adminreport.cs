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
    public partial class adminreport : UserControl
    {
        CrystalReport2 CR;
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";

        public adminreport()
        {
            InitializeComponent();
            FillUserComboBox();
        }

        private void FillUserComboBox()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    string sql = "SELECT USERID FROM USERS";
                    OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "USERID";
                    comboBox1.ValueMember = "USERID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int selectedID = Convert.ToInt32(comboBox1.SelectedValue);
                CR = new CrystalReport2();
                CR.SetDatabaseLogon("scott", "tiger");
                CR.SetParameterValue("LoggedUserID", selectedID);
                crystalReportViewer1.ReportSource = CR;
                crystalReportViewer1.Refresh();
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
    }
}
