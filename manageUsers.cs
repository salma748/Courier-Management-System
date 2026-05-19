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
    public partial class manageUsers : UserControl
    {
        public manageUsers()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl control)
        {
            panelManagerUsersContent.Controls.Clear();   
            control.Dock = DockStyle.Fill;
            panelManagerUsersContent.Controls.Add(control);
        }
        private void ResetButtons()
        {
            btnView.BackColor = SystemColors.ActiveBorder;
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnDelete.BackColor = SystemColors.ActiveBorder;
        }
        private void SetActive(Button btn)
        {
            btn.BackColor = SystemColors.ActiveCaption;
        }
     
        
        
        private void button3_Click(object sender, EventArgs e)
        {

            ResetButtons();
            SetActive(btnAdd);

            LoadControl(new AddUserControl());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(btnDelete);

            LoadControl(new DeleteUserControl());
        }

        private void panelManagerUsersContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            ResetButtons();
            SetActive(btnView);

            LoadControl(new ViewUsersControl());
        }
    }
}
