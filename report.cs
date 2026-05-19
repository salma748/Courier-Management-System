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
    public partial class report : UserControl
    {
        CrystalReport2 CR;
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        int userID;
        public report()
        {
            InitializeComponent();
        }
        public report(int id)
        {
            InitializeComponent();
            userID = id;
           
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Loading report for User ID: " + userID);
            CR = new CrystalReport2();

            CR.SetDatabaseLogon("scott", "tiger");
            CR.SetParameterValue("LoggedUserID", userID);

           
            crystalReportViewer1.ReportSource = CR;
            crystalReportViewer1.Refresh();

        }
       

    }
}
