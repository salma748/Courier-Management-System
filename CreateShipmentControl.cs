using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class CreateShipmentControl : UserControl
    {
        string connStr = "Data Source=ORCL;User Id=scott;Password=tiger;";

        int userID;
        string senderName;

        public CreateShipmentControl(int id, string userName)
        {

            InitializeComponent();
            userID = id;
            senderName = userName;

        }

        public CreateShipmentControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        
    }

        private void CreateShipmentControl_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Clothes");
            comboBox1.Items.Add("Documents");
            comboBox1.Items.Add("Electronics");
            comboBox1.Items.Add("Food");
            comboBox1.Items.Add("Accessories");

            comboBox1.SelectedIndex = 0;
            LoadDiscounts();
        }

      
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                   
                    OracleCommand cmdId = new OracleCommand(
                        "SELECT NVL(MAX(SHIPMENTID),0)+1 FROM SHIPMENTS", conn);

                    int newId = Convert.ToInt32(cmdId.ExecuteScalar());

                    string status = "Pending";

                    
                    OracleCommand cmdCourier = new OracleCommand(
                        "SELECT USERID FROM (SELECT USERID FROM USERS WHERE ROLE='Courier' ORDER BY DBMS_RANDOM.VALUE) WHERE ROWNUM = 1",
                        conn);

                    int courierId = Convert.ToInt32(cmdCourier.ExecuteScalar());

                  
                    decimal price = Convert.ToDecimal(price_box.Text);
                    decimal finalPrice = Convert.ToDecimal(final_price_box.Text);

                   
                    string query = @"INSERT INTO SHIPMENTS 
            (SHIPMENTID, SENDERNAME, RECEIVERNAME, PACKAGEDETAILS, STATUS, CUSTOMERID, COURIERID, PRICE, FINALPRICE)
            VALUES (:id, :sender, :receiver, :details, :status, :cust, :courier, :price, :final)";

                    OracleCommand cmd = new OracleCommand(query, conn);

                    cmd.Parameters.Add(":id", newId);
                    cmd.Parameters.Add(":sender", senderName);
                    cmd.Parameters.Add(":receiver", Recievername.Text);
                    cmd.Parameters.Add(":details", comboBox1.Text);
                    cmd.Parameters.Add(":status", status);
                    cmd.Parameters.Add(":cust", userID);
                    cmd.Parameters.Add(":courier", courierId);
                    cmd.Parameters.Add(":price", price);
                    cmd.Parameters.Add(":final", finalPrice);

                    cmd.ExecuteNonQuery();

                    
                    OracleCommand cmdPayId = new OracleCommand(
                        "SELECT NVL(MAX(PAYMENTID),0)+1 FROM PAYMENTS", conn);

                    int payId = Convert.ToInt32(cmdPayId.ExecuteScalar());

                  
                    OracleCommand payCmd = new OracleCommand(
                        "INSERT INTO PAYMENTS (PAYMENTID, SHIPMENTID, AMOUNT, PAYMENTSTATUS) VALUES (:payId, :shipId, :amount, 'Paid')",
                        conn);

                    payCmd.Parameters.Add(":payId", payId);
                    payCmd.Parameters.Add(":shipId", newId);
                    payCmd.Parameters.Add(":amount", finalPrice);

                    payCmd.ExecuteNonQuery();

                    MessageBox.Show("Shipment created & paid successfully ✅");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Recievername_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal price = GetPrice(comboBox1.Text);
            price_box.Text = price.ToString();

           
            decimal finalPrice = price;

            if (!string.IsNullOrEmpty(discountcode_box.Text))
            {
                finalPrice = ApplyDiscount(price, discountcode_box.Text);
            }

            final_price_box.Text = finalPrice.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void price_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountcode_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void final_price_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_price_Click(object sender, EventArgs e)
        {
            decimal price = GetPrice(comboBox1.Text);

            decimal finalPrice = price;

           
            if (!string.IsNullOrEmpty(discountcode_box.Text))
            {
                finalPrice = ApplyDiscount(price, discountcode_box.Text);
            }

            
            price_box.Text = price.ToString();
            final_price_box.Text = finalPrice.ToString();

        }

        private decimal GetPrice(string package)
        {
            switch (package)
            {
                case "Clothes": return 100;
                case "Documents": return 50;
                case "Electronics": return 200;
                case "Food": return 80;
                case "Accessories": return 120;
                default: return 60;
            }
        }
        private decimal ApplyDiscount(decimal price, string discountCode)
        {
            decimal finalPrice = price;

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(
                    "SELECT PERCENTAGE, ISACTIVE FROM DISCOUNTS WHERE DISCOUNTCODE = :code",
                    conn);

                cmd.Parameters.Add(":code", discountCode);

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int isActive = Convert.ToInt32(reader["ISACTIVE"]);

                    if (isActive == 1)
                    {
                        decimal percentage = Convert.ToDecimal(reader["PERCENTAGE"]);
                        finalPrice = price - (price * percentage / 100);
                    }
                }
            }

            return finalPrice;
        }

        private void LoadDiscounts()
        {
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                OracleDataAdapter da = new OracleDataAdapter(
                    "SELECT DISCOUNTCODE FROM DISCOUNTS WHERE ISACTIVE = 1", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                discountcode_box.DataSource = dt;
                discountcode_box.DisplayMember = "DISCOUNTCODE";
            }
        }
    }
    }

