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

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // 🔐 OPEN LOGIN FORM
        private void login_btn_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();   // LoginForm
            login.Show();
            this.Hide();
        }

      
        private void reg_btn_Click(object sender, EventArgs e)
        {
            Form1 register = new Form1(); 
            register.Show();
            this.Hide();
        }
    }
}