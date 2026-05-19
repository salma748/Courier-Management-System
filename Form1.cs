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
    public partial class Form1 : Form
    {
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        public Form1()
        {
            InitializeComponent();
        }


        private void reg_btn_Click(object sender, EventArgs e)
        {
            string name = username_txt.Text;
            string email = email_txt.Text;
            string password = password_txt.Text;
            string role = "";


            if (customer.Checked) role = "Customer";
            else if (admin.Checked) role = "Admin";
            else if (courier.Checked) role = "Courier";
            if (name == "" || email == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();
            string getId = "SELECT NVL(MAX(UserID),0) + 1 FROM Users";
            OracleCommand cmdId = new OracleCommand(getId, conn);
            int newId = Convert.ToInt32(cmdId.ExecuteScalar());
            string query = "INSERT INTO Users VALUES (:id, :name, :email, :pass, :role)";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":id", newId);
            cmd.Parameters.Add(":name", name);
            cmd.Parameters.Add(":email", email);
            cmd.Parameters.Add(":pass", password);
            cmd.Parameters.Add(":role", role);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered successfully!");
                username_txt.Text = "";
                email_txt.Text = "";
                password_txt.Text = "";
                customer.Checked = false;
                admin.Checked = false;
                courier.Checked = false;
                Form dashboard = null;
                if (role == "Customer")
                    dashboard = new Admin_Form();  // da esm el customer form 3ady
                else if (role == "Admin")
                    dashboard = new AdminForm();
                else if (role == "Courier")
                    dashboard = new CourierForm(newId);

                if (dashboard != null)
                {
                    dashboard.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Email already exists!");
            }

            conn.Close();
        }


        private void username_txt_TextChanged(object sender, EventArgs e) { }
        private void email_txt_TextChanged(object sender, EventArgs e) { }
        private void password_txt_TextChanged(object sender, EventArgs e) { }
        private void admin_CheckedChanged(object sender, EventArgs e) { }
        private void courier_CheckedChanged(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}