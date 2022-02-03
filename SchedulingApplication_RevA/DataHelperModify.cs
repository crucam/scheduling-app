using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Globalization;


namespace SchedulingApplication_RevA
{
    class DataHelperModify
    {
        //Connection string

        public static string connectionString = DataHelperCreate.ConnMaster;
        public static MySqlConnection conn;
        public static MySqlCommand command;
        public static MySqlDataReader dataReader;
        public static string sql = "";


        //////////////////////////////////////////////////////////MODIFY CUSTOMER//////////////////////////////////////////////////////////////////////////
        ////////////////////////Get Section//////////////////////////
        public static int GetCustomerId(string customer)
        {


            int custId = 0;
            conn = new MySqlConnection(connectionString);
            conn.Open();

            sql = $"Select customerId from customer where customerName = '{customer}'";
            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                custId = (int)dataReader.GetValue(0);
            }

            conn.Close();

            return custId;
        }



        ////////////////////////Modify Section//////////////////////////

        public static void ModifyCustomer(int custId, string fName, string address, string city, string country, string phone, string user)
        {
            //The check methods will verify if the entity exists, if it does not, it will be created
            //Must be sequential due to the foreign key restraints put on each respective tables
            int countryId = DataHelperCreate.CheckCountry(country, user);
            country = DataHelperCreate.GetCountry(countryId);
            int cityId = DataHelperCreate.CheckCity(city, country, user);
            city = DataHelperCreate.GetCity(cityId);



            sql = "update customer " +
                    "inner join address on customer.addressId = address.addressId " +
                    "inner join city on address.cityId = city.cityId " +
                    "inner join country on city.countryId = country.countryId " +
                    $"set customerName = '{fName}', address = '{address}', city = '{city}', country = '{country}', phone = '{phone}' " +
                    $"where customerId = {custId};";

            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            conn.Close();

        }


        /////////////////////////////////////////////////////////DELETE CUSTOMER/////////////////////////////////////////////
        public static void DeleteCustomer(int custId, string customerName)
        {


            sql = $"delete from appointment where customerId = {custId}; " +
                  $"delete from customer where addressId = {custId}; " +
                  $"delete from address where addressId = {custId};";


            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            conn.Close();

            MessageBox.Show($"{customerName} record successfully deleted.");
        }

        //////////////////////////////////////////////////////////MODIFY APPOINTMENT//////////////////////////////////////////////////////////////////////////
        //////////Get Section/////////////////
        public static int GetAppointmentId(string aptDate, string time)
        {
            int aptId = 0;

            sql = $"select appointmentId from appointment where date(start) = date('{aptDate}') and time(start) = time('{time}')";

            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                aptId = (int)dataReader.GetValue(0);
            }

            conn.Close();

            return aptId;
        }
        //////////Delete Appointment//////////
        public static void DeleteAppointment(string custName, string date, string time, string user)
        {
            int custId = GetCustomerId(custName);
            //test
            int aptId = GetAppointmentId(date, time);
            //

            //return
            //sql = $"delete from appointment where customerId = {custId} " +
            //      $"and Date(start) = Date('{date}') and Time(start) = Time('{time}');";
            //

            sql = $"delete from appointment where appointmentId = {aptId}";

            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            conn.Close();

            MessageBox.Show($"{custName}'s appointment for {date} at {time} successfully deleted.");
        }

        //////////////////Modify Appointment///////////////////////

        public static void ModifyAppointment(string custName, string type, string aptDate, string time, string user, int aptId)
        {
            int custId = GetCustomerId(custName);

            DateTime end = DateTime.ParseExact(time, "HH:mm", CultureInfo.InvariantCulture);
            string endTime = end.AddMinutes(15).ToString("HH:mm");

            sql = "update appointment " +
                    $"set type = '{type}', start = '{aptDate} {time}', end = '{aptDate} {endTime}' " +
                    $"where appointmentId = {aptId};";

            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                command.ExecuteNonQuery();
            }

            conn.Close();

        }
    }
}
