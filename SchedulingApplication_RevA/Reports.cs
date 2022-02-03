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
    public partial class Reports : Form
    {
        public string User { get; set; }
        public string AptType { get; set; }
        public string UserName { get; set; }
        public static int AptMonth { get; set; }
        public static int AptYear { get; set; }
        public static string City { get; set; }
        public DataGridView AptTypesDGV { get; set; }
        public DataGridView UserDGV { get; set; }
        public DataGridView ScheduleDGV { get; set; }
        public DataGridView CityClientDGV { get; set; }
        public DataGridView CityDGV { get; set; }


        public BindingList<string> StickItToTheMan = new BindingList<string>();
        public BindingList<string> FightThePower = new BindingList<string>();
        public BindingList<string> ProjectFreedom = new BindingList<string>();
        public BindingList<string> JudgementFree = new BindingList<string>();
        public BindingList<string> LetsGo = new BindingList<string>();

        public Reports()
        {
            InitializeComponent();
        }
        public Reports(string user)
        {
            InitializeComponent();

            User = user;

            //AptTypes
            var bs = new BindingSource();
            bs.DataSource = StickItToTheMan;

            var pt = new BindingSource();
            pt.DataSource = FightThePower;

            //UserSchedule
            var xp = new BindingSource();
            xp.DataSource = ProjectFreedom;

            //CityClient
            var dv = new BindingSource();
            dv.DataSource = JudgementFree;

            //CityChoser
            var ui = new BindingSource();
            ui.DataSource = LetsGo;

            aptTypesDGV.DataSource = bs;
            userDGV.DataSource = pt;
            userScheduleDGV.DataSource = xp;
            cityClientDGV.DataSource = dv;
            cityDGV.DataSource = ui;

            AptTypesDGV = aptTypesDGV;
            UserDGV = userDGV;
            ScheduleDGV = userScheduleDGV;
            CityClientDGV = cityClientDGV;
            CityDGV = cityDGV;

            AptMonth = DateTime.Now.Month;
            AptYear = DateTime.Now.Year;

            PopulateAptTypesDGV();
            PopulateUserDGV();
            PopulateCityDGV();

            aptTypesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            aptTypesDGV.MultiSelect = false;

            userScheduleDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userScheduleDGV.MultiSelect = false;

            //Change date/time picker formats
            monthDateTimePicker.Format = DateTimePickerFormat.Custom;
            monthDateTimePicker.CustomFormat = " MMMM yyyy";
            monthDateTimePicker.ShowUpDown = true;
            
        }

        //////////////////////////////////////////AptTypeReport//////////////////////////////////////////
        public void PopulateAptTypesDGV()
        {
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string aptCmd = "select customerName as 'Customer', start as 'Date/Time', type as 'Type' from appointment " +
                            "inner join customer on appointment.customerId = customer.customerId " +
                            $"where type = '{AptType}' and month(start) = {AptMonth} and year(start) = {AptYear}";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            AptTypesDGV.DataSource = table;

            this.aptTypesDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptTypesDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptTypesDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            int total = aptTypesDGV.Rows.Count - 1;
            totalBox.Text = total.ToString();
            
        }
        public int TotalAptsByType()
        {



            return 0; //temp
        }

        private void aptTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AptType = aptTypeListBox.Text;
            PopulateAptTypesDGV();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hub rtn = new Hub(User);
            rtn.ShowDialog();
            this.Close();
        }

        private void monthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int month = monthDateTimePicker.Value.Month;
            AptMonth = month;
            
            int year = monthDateTimePicker.Value.Year;
            AptYear = year;
            PopulateAptTypesDGV();
        }

        //////////////////////////////////////////UserScheduleReport//////////////////////////////////////////
        public void PopulateUserDGV()
        {
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string aptCmd = "select userName as User from user";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            UserDGV.DataSource = table;

            this.userDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

        }

        public void PopulateScheduleDGV()
        {
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string aptCmd = "select customer.customerName as 'Customer', appointment.type as 'Appointment Type',  date_format(appointment.start, '%m/%d/%Y %H:%i:%S') as 'Start', appointment.createdBy " +
                            "from customer " +
                            "inner join appointment on customer.customerId = appointment.customerId " +
                           "inner join user on appointment.userId = user.userId " +
                           $"where userName = '{UserName}' order by Date(start), Time(start)";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            ScheduleDGV.DataSource = table;

            this.userScheduleDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.userScheduleDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.userScheduleDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.userScheduleDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            int index = userDGV.CurrentCell.RowIndex;
            UserName = userDGV.Rows[index].Cells[0].Value.ToString();
            
            PopulateScheduleDGV();
            scheduleLabel.Text = $"{UserName}'s Schedule";
        }


        //////////////////////////////////////////Clients per City//////////////////////////////////////////

        public void PopulateCityDGV()
        {
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string aptCmd = "select city as 'City' from city";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            CityDGV.DataSource = table;

           this.cityDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void PopulateClientDGV()
        {
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string aptCmd = "select customerName as 'Customer', address as 'Address' , phone as 'Phone' from customer " +
                            "inner join address on customer.addressId = address.addressid " +
                            "inner join city on address.cityid = city.cityId " +
                            $"where city = '{City}'";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            CityClientDGV.DataSource = table;

            this.cityClientDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.cityClientDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.cityClientDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            try
            {
                var reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show($"There are currently no customer's in {City}");
                }
                reader.Close();
            }
            catch
            {

            }


        }
        private void clientBtn_Click(object sender, EventArgs e)
        {
            int index = cityDGV.CurrentCell.RowIndex;
            City = cityDGV.Rows[index].Cells[0].Value.ToString();

            PopulateClientDGV();
            clientCityLabel.Text = $"Clients in {City}";
        }


    }


}
