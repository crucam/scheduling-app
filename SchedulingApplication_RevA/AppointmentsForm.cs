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
    public partial class AppointmentsForm : Form
    {
        public DataGridView AptDGV { get; set; }
        public DataGridView WeekAptDGV { get; set; }

        public BindingList<string> StickItToTheMan = new BindingList<string>();

        public BindingList<string> YupYup = new BindingList<string>();

        public int Month { get; set; }
        public int Year { get; set; }
        public int WeekOf { get; set; }

        public string User { get; set; }
        public AppointmentsForm()
        {
            InitializeComponent();
        }
        public AppointmentsForm(string user)
        {
            InitializeComponent();
            User = user;
            //Data source binding for the respective DGVs
            var bsPart = new BindingSource();
            bsPart.DataSource = StickItToTheMan;

            var baPart = new BindingSource();
            baPart.DataSource = YupYup;

            aptDGV.DataSource = bsPart;
            aptWeekDGV.DataSource = baPart;
            
            //DGV Mode select
            aptDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            aptDGV.MultiSelect = false;
            
            aptWeekDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            aptWeekDGV.MultiSelect = false;
            
            //Getter setters
            AptDGV = aptDGV;
            WeekAptDGV = aptWeekDGV;

            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
            WeekOf = DataHelperCreate.GetWeekNumber(DateTime.Now);

            //Populate DGVs
            PopulateAptDGV();
            PopulateWeekAptDGV();
            
            //Change date/time picker formats
            monthDateTimePicker.Format = DateTimePickerFormat.Custom;
            monthDateTimePicker.CustomFormat = " MMMM yyyy";
            monthDateTimePicker.ShowUpDown = true;
        }

        private void addAptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAppointment newApt = new CreateAppointment(User);
            newApt.ShowDialog();
            this.Close();
        }

        private void modAptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyAptMain mod = new ModifyAptMain(User);
            mod.ShowDialog();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hub returnHub = new Hub(User);
            returnHub.ShowDialog();
            this.Close();
        }

        void PopulateAptDGV()
        {
            var offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow);

            var sqlOffset = offset.ToString().Substring(0, offset.ToString().Length - 3);

            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            string aptCmd = $"select customer.customerName, appointment.type, convert_tz(appointment.start, '-00:00', '{sqlOffset}') as 'Start', convert_tz(appointment.end, '-00:00', '{sqlOffset}') as 'End', appointment.createdBy " +
                            "from customer " +
                            "inner join appointment on customer.customerId = appointment.customerId " +
                           "inner join user on appointment.userId = user.userId " +
                           $"where userName = '{User}' and Month(start) = {Month} order by Date(start), Time(start)";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            AptDGV.DataSource = table;

            //this.aptDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }
        void PopulateWeekAptDGV()
        {

            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            var offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow);

            var sqlOffset = offset.ToString().Substring(0, offset.ToString().Length - 3);

            string aptCmd = $"select customerName, phone, type, convert_tz(appointment.start, '-00:00', '{sqlOffset}') as 'Start', convert_tz(appointment.end, '-00:00', '{sqlOffset}') as 'End', appointment.createdBy from appointment " +
                         "inner join customer on appointment.customerId = customer.customerId " +
                         "inner join address on customer.addressId = address.addressId " +
                         $"where weekofyear(start) = {WeekOf} order by Date(start), Time(start)";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            WeekAptDGV.DataSource = table;

            //this.aptDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.aptDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        private void weekDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            DateTime week = weekDateTimePicker.Value;
            WeekOf = DataHelperCreate.GetWeekNumber(week);

            PopulateWeekAptDGV();
        }

        private void monthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        
            int month = monthDateTimePicker.Value.Month;
            int year = monthDateTimePicker.Value.Year;

            Month = month;
            Year = year;

            PopulateAptDGV();
                
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAppointment del = new DeleteAppointment(User);
            del.ShowDialog();
            this.Close();
        }
    }
}
 