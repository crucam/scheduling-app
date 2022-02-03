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
    public partial class ModifyAptData : Form
    {
        public DataGridView ClientDGV { get; set; }
        public DataGridView AptDGV { get; set; }

        public static BindingList<string> StickItToTheMan = new BindingList<string>();
        public static BindingList<string> TestApt = new BindingList<string>();

        public string OldAptDate { get; set; }
        public string NewAptDate { get; set; }
        public string OldAptTime { get; set; }
        public string NewAptTime { get; set; }
        public string Type { get; set; }
        public string User { get; set; }
        public string Customer { get; set; }
        public string Initial { get; set; }
        public string[] AptData { get; set; }


        public static string connectionString = DataHelperCreate.ConnMaster;
        public ModifyAptData()
        {
            InitializeComponent();
        }
        public ModifyAptData(string user, string[] aptData)
        {
            InitializeComponent();

            AptData = aptData;

            var bsApt = new BindingSource();
            bsApt.DataSource = TestApt;

            allApts.DataSource = bsApt;

            AptDGV = allApts;

            User = user;

            string[] temp = aptData[2].Split(' ');
            OldAptDate = temp[0];

            OldAptTime = aptData[3];

            NewAptDate = OldAptDate;

            Customer = aptData[0];

            clientLabel.Text = Customer;
            dateLabel.Text = OldAptDate;
            timeLabel.Text = OldAptTime;

            //Pre populate the appointment data to be modified
            //Type
            for (int i = 0; i < aptTypeListBox.Items.Count; i++)
            {
                if (aptTypeListBox.Items[i].ToString() == aptData[1])
                {
                    aptTypeListBox.SelectedIndex = i;
                }
            }
            //Time
            for (int i = 0; i < aptTimeBox.Items.Count; i++)
            {
                DateTime tempTime = DateTime.Parse(aptTimeBox.Items[i].ToString() + ":00");

                if (tempTime.ToString("HH:mm:ss") == OldAptTime)
                {
                    aptTimeBox.SelectedIndex = i;

                }

            }
            //Date

            try
            {
                DateTime tempDate = DateTime.ParseExact(NewAptDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                NewAptDate = tempDate.ToString("yyyy-MM-dd");

                monthCalendar1.SetDate(tempDate);
            }
            catch
            {

            }
            try
            {
                DateTime shortDate = DateTime.Parse(NewAptDate);
                NewAptDate = shortDate.ToString("yyyy-MM-dd");

                monthCalendar1.SetDate(shortDate);
            }
            catch { }



            //CustomerName
            custNameBox.Text = aptData[0];
            custNameBox.Enabled = false;

            PopulateAptDGV();

            allApts.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            allApts.MultiSelect = false;
        }
        void PopulateAptDGV()
        {
            //On calendar click, run this method to populate appointments booked for all users

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            string sql = "select customerName as 'Customer', type as 'Type', date(start) as 'Date', time(start) as 'Start', time(end) as 'End', appointment.createdBy as 'By' from appointment " +
                         "inner join customer on appointment.customerId = customer.customerId " +
                         "inner join address on customer.addressId = address.addressId " +
                         $"where Date(start) = Date('{NewAptDate}') order by Time(start)";

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
                NewAptDate = temp.ToString("yyyy-MM-dd");
                PopulateAptDGV();
            }

            catch
            {
                
            }

            try
            {
                string aptDate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                DateTime temp = DateTime.Parse(aptDate);
                NewAptDate = temp.ToString("yyyy-MM-dd");
                PopulateAptDGV();
            }

            catch
            {

            }

        }

        private void aptTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aptTimeBox.Text.Count() <= 0)
            {
                return;
            }
            else
            {
                try
                {
                    NewAptTime = aptTimeBox.Text; //=HH:mm

                    DateTime tempTime = DateTime.ParseExact(NewAptTime, "HH:mm", CultureInfo.InvariantCulture);
                    tempTime = tempTime.AddSeconds(00);
                    string[] p = tempTime.ToString("dd/MM/yyyy HH:mm").Split(' '); //newApt date and Time split up


                    DateTime oldTemp = DateTime.ParseExact(OldAptTime, "HH:mm:ss", CultureInfo.InvariantCulture);
                    string[] t = oldTemp.ToString("dd/MM/yyyy HH:mm").Split(' '); //splitting up the old apt time

                    DateTime oldDate = DateTime.ParseExact(OldAptDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    string[] d = oldDate.ToString("yyyy-MM-dd").Split(' ');//splitting up the old apt date

                    if ((p[1] != t[1]) && ((OldAptDate != NewAptDate) || (d[0] != NewAptDate)))
                    {
                        if (DataHelperCreate.CheckAptTime(NewAptTime, NewAptDate) == 1)
                        {
                            aptTimeBox.Text = null;

                        }
                    }

                }
                catch
                {

                }
                try
                {
                    NewAptTime = aptTimeBox.Text; //=HH:mm

                    DateTime tempTime = DateTime.Parse(NewAptTime);
                    tempTime = tempTime.AddSeconds(00);
                    string[] p = tempTime.ToString("dd/MM/yyyy HH:mm").Split(' '); //newApt date and Time split up


                    DateTime oldTemp = DateTime.Parse(OldAptTime);
                    string[] t = oldTemp.ToString("dd/MM/yyyy HH:mm").Split(' '); //splitting up the old apt time

                    DateTime oldDate = DateTime.Parse(OldAptDate);
                    string[] d = oldDate.ToString("yyyy-MM-dd").Split(' ');//splitting up the old apt date

                    if ((p[1] != t[1]) && ((OldAptDate != NewAptDate) || (d[0] != NewAptDate)))
                    {
                        if (DataHelperCreate.CheckAptTime(NewAptTime, NewAptDate) == 1)
                        {
                            aptTimeBox.Text = null;

                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void saveAptBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //Parses date for double digit days
                DateTime tt = DateTime.ParseExact(OldAptDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                string date = tt.ToString("yyyy-MM-dd");

                int aptId = DataHelperModify.GetAppointmentId(date, OldAptTime);

                DataHelperModify.ModifyAppointment(Customer, Type, NewAptDate, NewAptTime, User, aptId);
                MessageBox.Show($"{Customer}'s {Type} appointment will be at {NewAptTime} on {NewAptDate}.");

                this.Hide();
                ModifyAptMain rtn = new ModifyAptMain(User);
                rtn.ShowDialog();
                this.Close();
            }
            catch
            {

            }
            try
            {
                //Parses date with single digit days
                MessageBox.Show(Type + " " + NewAptDate + " " + NewAptTime + " " + Customer + " " + User);
                DateTime tt = DateTime.Parse(OldAptDate);
                string date = tt.ToString("yyyy-MM-dd");

                int aptId = DataHelperModify.GetAppointmentId(date, OldAptTime);

                DataHelperModify.ModifyAppointment(Customer, Type, NewAptDate, NewAptTime, User, aptId);
                MessageBox.Show($"{Customer}'s {Type} appointment will be at {NewAptTime} on {NewAptDate}.");

                this.Hide();
                ModifyAptMain rtn = new ModifyAptMain(User);
                rtn.ShowDialog();
                this.Close();
            }
            catch
            {

            }
           
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyAptMain rtn = new ModifyAptMain(User);
            rtn.ShowDialog();
            this.Close();
        }
    }
}
