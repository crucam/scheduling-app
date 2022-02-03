using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulingApplication_RevA
{
    public partial class ModifyCustomerForm : Form
    {
        public string User { get; set; }
        public static string connectionString = DataHelperCreate.ConnMaster;
        public static MySqlConnection conn;
        public static MySqlCommand command;
        public static MySqlDataReader dataReader;
        public static string sql = "";

        public static string CustomerName { get; set; }
        public static string Address { get; set; }
        public static string City { get; set; }
        public static string Country { get; set; }
        public static string Phone { get; set; }

        public static int CustomerId { get; set; }

        public ModifyCustomerForm()
        {
            InitializeComponent();
        }

        public ModifyCustomerForm(int custId, string user)
        {
            InitializeComponent();
            User = user;
            
            //Populate the text boxes with the bound data which will be used to alter the customer record
            GatherCustomerData(custId);

            fNameBox.Text = CustomerName;
            addressBox.Text = Address;
            cityBox.Text = City;
            countryBox.Text = Country;
            pNumberBox.Text = Phone.ToString();
            CustomerId = custId;

        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            string fName = fNameBox.Text;
            string address = addressBox.Text;
            string city = cityBox.Text;
            string country = countryBox.Text;
            string pNumber = pNumberBox.Text;
            

            if ((fName.Count() < 1) || (address.Count() < 1) || (city.Count() < 1) || (country.Count() < 1) || (pNumber.Count() < 1))
            {
                MessageBox.Show("Please fill in all of the fields.");
                return;
            }


            DataHelperModify.ModifyCustomer(CustomerId, fName, address, city, country, pNumber, User);

            MessageBox.Show($"Succesfully Modified {fName}'s record.");

            this.Hide();
            CustomerRecordsForm returnApt = new CustomerRecordsForm(User);
            returnApt.ShowDialog();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRecordsForm goBack = new CustomerRecordsForm(User);
            goBack.ShowDialog();
            this.Close();

        }

        static void GatherCustomerData(int custId)
        {
                string customerName = "";
                string address = "";
                string city = "";
                string country = "";
                string phone = "";

                conn = new MySqlConnection(connectionString);
                conn.Open();

                sql = $"select customerName, address, city, country, phone from customer " +
                        "inner join address on customer.addressId = address.addressId " +
                        "inner join city on city.cityId = address.cityId " +
                        "inner join country on city.countryId = country.countryId " +
                        $"where customerId = '{custId}';";

                command = new MySqlCommand(sql, conn);
                dataReader = command.ExecuteReader();
                


                while (dataReader.Read())
                {
                    customerName = (string)dataReader.GetValue(0);
                    address = (string)dataReader.GetValue(1);
                    city = (string)dataReader.GetValue(2);
                    country = (string)dataReader.GetValue(3);
                    phone = (string)dataReader.GetValue(4);
                }

                conn.Close();
                
                CustomerName = customerName;
                Address = address;
                City = city;
                Country = country;
                Phone = phone;
                
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteVerificationForm delVer = new DeleteVerificationForm(User, CustomerId, CustomerName);
            delVer.ShowDialog();
            this.Close();

        }
    }
}
