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
    public partial class DeleteAppointment : Form
    {
        public static string User { get; set; }
        public static int AptID { get; set; }
        public static string CustomerName { get; set; }
        public static string StartDate { get; set; }
        public static string StartTime { get; set; }
        public static int AptMonth { get; set; }
        public int AptYear { get; set; }
        public DataGridView AptDGV { get; set; }

        public BindingList<string> StickItToTheMan = new BindingList<string>();


        public DeleteAppointment()
        {
            InitializeComponent();
        }
        public DeleteAppointment(string user)
        {
            InitializeComponent();
            User = user;

            var bs = new BindingSource();
            bs.DataSource = StickItToTheMan;

            aptDGV.DataSource = bs;

            AptDGV = aptDGV;

            AptMonth = DateTime.Now.Month;
            AptYear = DateTime.Now.Year;

            PopulateAptDGV();

            aptDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            aptDGV.MultiSelect = false;

            //Change date/time picker formats
            monthDateTimePicker.Format = DateTimePickerFormat.Custom;
            monthDateTimePicker.CustomFormat = " MMMM yyyy";
            monthDateTimePicker.ShowUpDown = true;
        }

        private void delAptBtn_Click(object sender, EventArgs e)
        {
            string name = GetCustName_AptDGV();
            DateTime tt = DateTime.ParseExact(GetStartDate_AptDGV(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            string date = tt.ToString("yyyy-MM-dd");
            string time = GetStartTime_AptDGV();

            DataHelperModify.DeleteAppointment(name, date, time, User);

            PopulateAptDGV();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsForm rtn = new AppointmentsForm(User);
            rtn.ShowDialog();
            this.Close();
        }
        void PopulateAptDGV()
        {

            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string aptCmd = "select customer.customerName, appointment.type,  date_format(appointment.start, '%m/%d/%Y %H:%i:%S') as 'Start', appointment.createdBy " +
                            "from customer " +
                            "inner join appointment on customer.customerId = appointment.customerId " +
                           "inner join user on appointment.userId = user.userId " +
                           $"where userName = '{User}' and Month(start) = {AptMonth} and Year(start) = {AptYear} order by Date(start), Time(start)";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            AptDGV.DataSource = table;

            this.aptDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            conn.Close();
        }

        private void aptDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerName = aptDGV.Rows[e.RowIndex].Cells["customerName"].Value.ToString();
            
            var startDate = Convert.ToDateTime(aptDGV.Rows[e.RowIndex].Cells["start"].Value);
            StartDate = startDate.ToShortDateString();

            var startTime = Convert.ToDateTime(aptDGV.Rows[e.RowIndex].Cells["start"].Value);
            StartTime = startTime.ToLongTimeString();

        }
        public string GetCustName_AptDGV()
        {
            string custName = "";
            foreach (DataGridViewRow row in aptDGV.SelectedRows)
            {
                custName = row.Cells[0].Value.ToString();
            }

            return custName;
        }
        public string GetStartTime_AptDGV()
        {
            string startTime = "";
            foreach (DataGridViewRow row in aptDGV.SelectedRows)
            {
                startTime = row.Cells[2].Value.ToString();
            }

            string[] time = startTime.Split(' ');
            return time[1];
        }
        public string GetStartDate_AptDGV()
        {
            
            string startDate = "";
            foreach (DataGridViewRow row in aptDGV.SelectedRows)
            {
                startDate = row.Cells[2].Value.ToString();
            }

            string[] date = startDate.Split(' ');
            return date[0];
        }

        private void monthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int month = monthDateTimePicker.Value.Month;
            AptMonth = month;

            int year = monthDateTimePicker.Value.Year;
            AptYear = year;

            PopulateAptDGV();
        }
    }
}
