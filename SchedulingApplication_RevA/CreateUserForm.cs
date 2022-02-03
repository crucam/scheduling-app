using MySql.Data.MySqlClient;
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
    public partial class CreateUserForm : Form
    {
        public static string UserName { get; set; }
        public static string Password { get; set; }

        public static int UserId { get; set; }
        public CreateUserForm()
        {
            InitializeComponent();
            passBox.UseSystemPasswordChar = true;
            vPassBox.UseSystemPasswordChar = true;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (userBox.Text.Count() < 1)
            {
                MessageBox.Show("Enter a username.");
                return;
            }
            if (passBox.Text.Count() < 1 || vPassBox.Text.Count() < 1)
            {
                MessageBox.Show("Neither password boxes can be empty.");
                return;
            }
            if (passBox.Text == vPassBox.Text)
            {
                
                Password = passBox.Text;
                UserName = userBox.Text;
                if (CheckUser(UserName) == 1)
                {
                    MessageBox.Show("That user already exists.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Passwords must match.");
                return;
            }

            GetNextUserId();
            CreateUser(UserName, Password);
            MessageBox.Show($"Successfully created User: {UserName}");
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        public void CreateUser(string user, string password)
        {
            string sql = $"insert into user values({UserId}, '{UserName}', '{Password}', 1, now(), '{UserName}', now(), '{UserName}')";
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);

            conn.Open();

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();

            conn.Close();
        }
        public void GetNextUserId()
        {
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);
            conn.Open();

            //Declare a variable to the MySQL command
            string sql = $"select userId from user order by userId";
            int output;

            //Create and convert the command then execute it
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = (int)dataReader.GetValue(0);
                UserId = output + 1;
            }

            dataReader.Close();
            conn.Close();
        }
        public int CheckUser(string username)
        {
            int sentinel = 1;
            string sql = $"select userName from user where userName = '{username}'";
            MySqlConnection conn = new MySqlConnection(DataHelperCreate.connectionString);

            conn.Open();

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();

            if (!dataReader.Read())
            {
                //If no userName matches if will set sentinel to 0 = false
                sentinel = 0;
                dataReader.Close();
                conn.Close();

                return sentinel;
            }
            return sentinel;
        }
    }
}
