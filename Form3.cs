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
    public partial class Form3 : Form
    {
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";
        public Form3()
        {
            InitializeComponent();
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text;
            string password = password_txt.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password");
                return;
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    string query = @"SELECT UserID, Role,Name
                             FROM Users 
                             WHERE Email = :email 
                             AND Password = :pass";

                    OracleCommand cmd = new OracleCommand(query, conn);

                    cmd.Parameters.Add(":email", email);
                    cmd.Parameters.Add(":pass", password);

                    OracleDataReader dr = cmd.ExecuteReader();

                    if (!dr.Read())
                    {
                        MessageBox.Show("Invalid email or password");
                        dr.Close();
                        email_txt.Text = "";
                        password_txt.Text = "";
                        return;
                    }
                    int userID = Convert.ToInt32(dr["UserID"]);
                    string userName = dr["Name"].ToString();
                    string role = dr["Role"].ToString();
                    dr.Close();
                    MessageBox.Show("Login successful as " + role);
                    email_txt.Text = "";
                    password_txt.Text = "";
                    if (role == "Admin")
                    {
                        AdminForm admin = new AdminForm();
                        admin.Show();
                    }
                    else if (role == "Customer")
                    {
                        Admin_Form customer = new Admin_Form(userID, userName);
                        customer.Show();
                    }

                    else if (role == "Courier")
                    {
                        CourierForm courier = new CourierForm(userID);
                        courier.Show();
                    }

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}