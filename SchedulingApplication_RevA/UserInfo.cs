using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SchedulingApplication_RevA
{
    class UserInfo
    {
        //public string UserName { get; set; }
        //public string UPassword { get; set; }

        public static DateTime now = DateTime.Now.ToLocalTime();
        public static string path = "LoginLogs.txt";
        public static string connectionString;
        public static MySqlConnection cnn;

        //Lambda Expression: 
        Action welcome = () => { MessageBox.Show("Welcome to CC Scheduler."); };

        public UserInfo(string full)
        {
            var info = full.Split(',');
            string userName = info[0];
            string password = info[1];

            //UserName = userName;
            //UPassword = password;

        }

        public static void FailedLogin(string user)
        {
            var info = new FileInfo(path);
            if (info.Length == 0)
            {
                using (StreamWriter file = new StreamWriter(path))
                {
                    file.WriteLine($"{user} FAILED attempted login at: {now}");
                }
                return;
            }
            else
            {
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine($"{user} FAILED attempted login at: {now}");
                }
                return;
            }
        }
        public static void LoggedIn(string user)
        {
            var info = new FileInfo(path);
            if (info.Length == 0)
            {
                using (StreamWriter file = new StreamWriter(path))
                {
                    file.WriteLine($"{user} Logged in at: {now}");
                }
                return;
            }
            else
            {
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine($"{user} Logged in at: {now}");
                }
                return;
            }
        }
        public static string UserLogin(string userName, string password)
        {
            connectionString = DataHelperCreate.ConnMaster;

            cnn = new MySqlConnection(connectionString);
            cnn.Open();


            MySqlCommand command;
            MySqlDataReader dataReader;
            string sql, OutputUser = "";
            string OutputPass = "";



            sql = "Select userName, password from user";
            command = new MySqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                OutputUser = dataReader.GetValue(0).ToString();
                OutputPass = dataReader.GetValue(1).ToString();

                if ((userName == OutputUser) && (password == OutputPass))
                {
                    ////////////////MessageBox.Show($"Welcome {userName}.");
                    string full = userName + "," + password;
                    cnn.Close();


                    return full;
                }
            }
            return null;
        }
    }
}
