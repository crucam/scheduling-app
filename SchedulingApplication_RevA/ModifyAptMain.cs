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
    public partial class ModifyAptMain : Form
    {
        public static string User { get; set; }
        public static int AptID { get; set; }
        public static string CustomerName { get; set; }
        public static string StartDate { get; set; }
        public static string StartTime { get; set; }
        public DataGridView AptDGV { get; set; }
        public BindingList<string> StickItToTheMan = new BindingList<string>();

        public ModifyAptMain()
        {
            InitializeComponent();
        }

        public ModifyAptMain(string user)
        {
            InitializeComponent();
            User = user;

            var bs = new BindingSource();
            bs.DataSource = StickItToTheMan;

            aptDGV.DataSource = bs;

            AptDGV = aptDGV;

            PopulateAptDGV();

            aptDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            aptDGV.MultiSelect = false;
        }

        private void modAptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyAptData modData = new ModifyAptData(User, GetAptData_AptDGV());
            modData.ShowDialog();
            this.Close();
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

            string aptCmd = "select customer.customerName as 'Customer Name', appointment.type as 'Type', Date(start) as 'Date', time_format(appointment.start, '%H:%i:%S') as 'Time', appointment.createdBy " +
                            "from customer " +
                            "inner join appointment on customer.customerId = appointment.customerId " +
                           "inner join user on appointment.userId = user.userId " +
                           $"where userName = '{User}' order by Date(start), time(start)";

            MySqlCommand cmd = new MySqlCommand(aptCmd, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);
            AptDGV.DataSource = table;

            this.aptDGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptDGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptDGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.aptDGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            conn.Close();
        }

        public string[] GetAptData_AptDGV()
        {
            string[] aptData = new string[5];
            foreach (DataGridViewRow row in aptDGV.SelectedRows)
            {
                aptData[0] = row.Cells[0].Value.ToString();
                aptData[1] = row.Cells[1].Value.ToString();
                aptData[2] = row.Cells[2].Value.ToString();
                aptData[3] = row.Cells[3].Value.ToString();
                aptData[4] = row.Cells[4].Value.ToString();

            }
            //0 = custName ; 1 = type ; 2 = startDate ; 3 startTime ; 4 createdBy

            return aptData;
        }
    }
}
