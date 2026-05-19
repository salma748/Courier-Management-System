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
    public partial class Admin_Form : Form
    {
        string senderName;

        public Admin_Form(int id, string userName)
        {
            InitializeComponent();
            LoggedInUserID = id;
            senderName = userName;

        }
        int LoggedInUserID;

        public Admin_Form()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            LoadControl(new CreateShipmentControl(LoggedInUserID, senderName));
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
         
            LoadControl(new CancelControl(LoggedInUserID));
        }
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
         

        private void track_btn_Click(object sender, EventArgs e)
        {
            LoadControl(new TrackControl(LoggedInUserID));


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadControl(new report(LoggedInUserID));
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();   // LoginForm
            login.Show();
            this.Hide();
        }
    }
}
