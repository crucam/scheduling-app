using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication_RevA
{
    public partial class CreateCustomer : Form
    {
        public string User { get; set; }
        public CreateCustomer()
        {
            InitializeComponent();
        }

        public CreateCustomer(string user)
        {
            InitializeComponent();
            User = user;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string fName = fNameBox.Text;
            string address = addressBox.Text;
            string city = cityBox.Text;
            string country = countryBox.Text;
            string pNumber = pNumberBox.Text;
            int custId;

            if ((fName.Count() < 1) || (address.Count() < 1) || (city.Count() < 1) || (country.Count() < 1) || (pNumber.Count() < 1))
            {
                MessageBox.Show("Please fill in all of the fields.");
                return;
            }

            custId = DataHelperCreate.UserIDVal();

            DataHelperCreate.CreateCustomer(fName, address, city, country, pNumber, User);

            MessageBox.Show($"Succesfully Created {fName}'s record.");

            this.Hide();
            CustomerRecordsForm returnApt = new CustomerRecordsForm(User);
            returnApt.ShowDialog();
            this.Close();

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRecordsForm returnApt = new CustomerRecordsForm(User);
            returnApt.ShowDialog();
            this.Close();
        }
    }
}
