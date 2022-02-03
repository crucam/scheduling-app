using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulingApplication_RevA
{
    public partial class CreateAppointment : Form
    {
        public DataGridView ClientDGV { get; set; }
        public DataGridView AptDGV { get; set; }
        
        public static BindingList<string> StickItToTheMan = new BindingList<string>();
        public static BindingList<string> TestApt = new BindingList<string>();

        public string AptDate { get; set; }
        public string AptTime { get; set; }
        public string Type { get; set; }
        public string User { get; set; }
        public string Customer { get; set; }
        public string Initial { get; set; }


        public static string connectionString = DataHelperCreate.ConnMaster;
        public CreateAppointment()
        {
            InitializeComponent();
           
        }

        public CreateAppointment(string user)
        {
            InitializeComponent();

            AptDate = DateTime.Now.ToString("yyyy-MM-dd");

            var bsPart = new BindingSource();
            bsPart.DataSource = StickItToTheMan;

            clientDGV.DataSource = bsPart;

            var bsApt = new BindingSource();
            bsApt.DataSource = TestApt;

            allApts.DataSource = bsApt;

            ClientDGV = clientDGV;
            AptDGV = allApts;

            User = user;

            PopulateCustDGV();
            PopulateAptDGV();

           
        }

        private void createAptBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = clientDGV.CurrentCell.RowIndex;

            Customer = clientDGV.Rows[rowIndex].Cells["Customer"].Value.ToString();

            if (Customer == null)
            {
                MessageBox.Show("Please select a client.");
                return;
            }
            if (Type == null)
            {
                MessageBox.Show("Please select an Appointment Type.");
                return;
            }
            if (AptTime == null)
            {
                MessageBox.Show("Please select a time.");
                return;
            }
            if (AptDate == null)
            {
                MessageBox.Show("Please selecte a date.");
                return;
            }

            

            DataHelperCreate.CreateAppointment(Customer, User, Type, AptTime, AptDate);
            this.Hide();
            AppointmentsForm rtn = new AppointmentsForm(User);
            rtn.ShowDialog();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsForm returnApt = new AppointmentsForm(User);
            returnApt.ShowDialog();
            this.Close();
        }

        void PopulateCustDGV()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            string clientCmd = "select customerName as 'Customer' from customer";

            MySqlCommand cmd = new MySqlCommand(clientCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            ClientDGV.DataSource = table;

            this.clientDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        void PopulateAptDGV()
        {
            //On calendar click, run this method to populate appointments booked for all users

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            string sql = "select customerName, phone, type, start, end, appointment.createdBy from appointment " +
                         "inner join customer on appointment.customerId = customer.customerId " +
                         "inner join address on customer.addressId = address.addressId " +
                         $"where Date(start) = Date('{AptDate}') order by Time(start)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            AptDGV.DataSource = table;

            this.allApts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.allApts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.allApts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.allApts.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.allApts.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.allApts.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void aptTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type = aptTypeListBox.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                string aptDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                DateTime temp = DateTime.ParseExact(aptDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                AptDate = temp.ToString("yyyy-MM-dd");
                PopulateAptDGV();
            }
            catch { }

            try
            {
                //Parses if day is single digits
                string aptDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                DateTime temp = DateTime.Parse(aptDate);
                AptDate = temp.ToString("yyyy-MM-dd");
                PopulateAptDGV();
            }
            catch { }

        }

        private void aptTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (DataHelperCreate.CheckAptTime(aptTimeBox.Text, AptDate) == 1)
            {
                aptTimeBox.Text = null;
            }

            AptTime = aptTimeBox.Text;
            try
            {
                DateTime dt = DateTime.ParseExact(AptTime, "HH:mm", CultureInfo.CurrentCulture);
                dt = dt.ToUniversalTime();

                string utc = dt.ToString("HH:mm");

                AptTime = utc;

            }
            catch (Exception) 
            {
                AptTime = null;
            }
        }
        private void clientDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Customer = clientDGV.Rows[e.RowIndex].Cells["Customer"].Value.ToString();
        }
    }
}
