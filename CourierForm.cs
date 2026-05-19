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
    public partial class CourierForm : Form
    {
        int courierID;
        public CourierForm(int id)
        {
            InitializeComponent();
            courierID = id;
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
        }
        private void SetActive(Button btn)
        {
            btn.BackColor = SystemColors.WindowFrame;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(button1);
            LoadControl(new myShipments(courierID));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(button2);
            LoadControl(new updateStatus(courierID));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();   // LoginForm
            login.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(button3);
            LoadControl(new confirmDelivery(courierID));
        }
    }
}
