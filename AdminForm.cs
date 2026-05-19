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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();   
            uc.Dock = DockStyle.Fill;        
            panelContent.Controls.Add(uc);   
        }
        private void ResetButtons()
        {
            button1.BackColor = SystemColors.ActiveCaption;
            button2.BackColor = SystemColors.ActiveCaption;
            button3.BackColor = SystemColors.ActiveCaption;
            button4.BackColor = SystemColors.ActiveCaption;
        }
        private void SetActive(Button btn)
        {
            btn.BackColor = SystemColors.WindowFrame;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(button1);
            LoadControl(new manageUsers());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(button2);
            LoadControl(new manageShipments());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(button3);
            LoadControl(new assignCourier());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(button4);
            LoadControl(new adminreport());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();   // LoginForm
            login.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
