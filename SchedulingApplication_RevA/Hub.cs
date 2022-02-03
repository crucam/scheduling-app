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
    public partial class Hub : Form
    {
        public string UserName { get; set; }
        public DataGridView AptDGV { get; set; }
        public BindingList<string> StickItToTheMan = new BindingList<string>();

        public static string connectionString = DataHelperCreate.ConnMaster;

        
        public Hub()
        {
            InitializeComponent();

            var bsPart = new BindingSource();
            bsPart.DataSource = StickItToTheMan;

            apptDGV.DataSource = bsPart;

            AptDGV = apptDGV;

            PopulateHubDGV();

        }

        public Hub(string user)
        {
            InitializeComponent();
            UserName = user;

            this.Text = $"Hub - User: {UserName}";

            var bsPart = new BindingSource();
            bsPart.DataSource = StickItToTheMan;

            apptDGV.DataSource = bsPart;

            AptDGV = apptDGV;

            PopulateHubDGV();
            AptChecker();
        }

        
       
        
        private void customerRecordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRecordsForm cust = new CustomerRecordsForm(UserName);
            cust.ShowDialog();
            this.Close();
        }
        private void aptBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AppointmentsForm newApt = new AppointmentsForm(UserName);
            newApt.ShowDialog();
            this.Close();
        }
        private void reportsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports report = new Reports(UserName);
            report.ShowDialog();
            this.Close();
        }

        void PopulateHubDGV()
        {
            int userId;
            userId = DataHelperCreate.GetUserID(UserName);
            var offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow);

            var sqlOffset = offset.ToString().Substring(0, offset.ToString().Length-3);

            MySqlConnection conn = new MySqlConnection(connectionString);
            
            conn.Open();
            string aptCmd = $"select customerName as 'Name', convert_tz(start, '+00:00', '{sqlOffset}') as 'Start', convert_tz(end, '+00:00', '{sqlOffset}') as 'End', type from appointment left join customer using (customerId) where userId = {userId} order by Time(start)";
            

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            AptDGV.DataSource = table;

            this.apptDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.apptDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.apptDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.apptDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage rtn = new LoginPage();
            rtn.ShowDialog();
            this.Close();
        }

        private void AptChecker()
        {
            string customer = "";
            string aptTime = "";

            string tDate = DateTime.Now.ToString("yyyy-MM-dd");
            string tTime = DateTime.Now.ToString("HH:mm");
            string today = (tDate + " " + tTime);
            int userId = DataHelperCreate.GetUserID(UserName);

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Declare a variable to the MySQL command
            string sql = $"select customerName, appointment.start from customer " +
                           "inner join appointment on appointment.customerId = customer.customerId " +
                           $"where(date(start) = '{tDate}')  and (time(start) between '{tTime}' and addtime('{tTime}', '00:15:00') and userId = '{userId}');";

            //Create and convert the command then execute it
            MySqlCommand command = new MySqlCommand(sql, conn);
            
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                customer = dataReader.GetString(0);
                aptTime = dataReader.GetString(1);

                string[] newTime = aptTime.Split(' ');
                MessageBox.Show($"You have an appointment with {customer} at {newTime[1]}.");
            }
            
            dataReader.Close();

            conn.Close();

        }
    }
}
