using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulingApplication_RevA
{
    public partial class CustomerRecordsForm : Form
    {

        public DataGridView CustDGV { get; set; }
        public BindingList<string> StickItToTheMan = new BindingList<string>();
        public BindingList<object> CustomerData = new BindingList<object>();
        public string User { get; set; }
        public CustomerRecordsForm()
        {
            InitializeComponent();

        }
        public CustomerRecordsForm(string user)
        {
            InitializeComponent();


            var bsPart = new BindingSource();
            bsPart.DataSource = StickItToTheMan;

            customerDGV.DataSource = bsPart;

            CustDGV = customerDGV;

            User = user;

            PopulateCustomer();

            customerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCustomer addCust = new CreateCustomer(User);
            addCust.ShowDialog();
            this.Close();
        }

        private void modCustomerBtn_Click(object sender, EventArgs e)
        {
            int custId = DataHelperModify.GetCustomerId(GetCustName_DGV());

            this.Hide();
            ModifyCustomerForm modCust = new ModifyCustomerForm(custId, User);
            modCust.ShowDialog();
            this.Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hub returnHub = new Hub(User);
            returnHub.ShowDialog();
            this.Close();
        }

        private void PopulateCustomer()
        {
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string clientCmd = "select customerName, address, city, country, phone from customer " +
                "inner join address on address.addressId = customer.addressId " +
                "inner join city on city.cityId = address.cityId " +
                "inner join country on city.countryId = country.countryId ";

            MySqlCommand cmd = new MySqlCommand(clientCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            customerDGV.DataSource = table;
            this.customerDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.customerDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.customerDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.customerDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.customerDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            conn.Close();
        }

        public string GetCustName_DGV()
        {
            string custName = "";
            foreach (DataGridViewRow row in customerDGV.SelectedRows)
            {
                custName = row.Cells[0].Value.ToString();
            }
            
            return custName;   
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {

            if (srchBox.Text.ToString().Length == 0)
            {
                MessageBox.Show("Please enter a customer to search.");
                return;
            }

            var searchCust = srchBox.Text;

            for (int i = 0; i < CustDGV.Rows.Count -1 ; i++)
            {
                
                if (CustDGV.Rows[i].Cells[0].Value.ToString() == searchCust)
                {
                    CustDGV.ClearSelection();
                    CustDGV.Rows[i].Selected = true;
                    return;
                }
                else if (i + 2 == CustDGV.Rows.Count) 
                {
                    MessageBox.Show("No Customer Found.");
                }
            }
        }
    }
}
