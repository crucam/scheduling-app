using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace SchedulingApplication_RevA
{
    class DataHelper
    {
        //Connection string
        
        public static string connectionString = @"server=localhost;user id=sqlUser;database=client_schedule;password=Passw0rd!";
        public static MySqlConnection conn;
        public static MySqlCommand command;
        public static MySqlDataReader dataReader;
        public static string sql = "";
        
        //////////////////////////////////////////////////////////CREATE CUSTOMER//////////////////////////////////////////////////////////////////////////
        

        /////////////////////////////////////////Get Section////////////////////////////////////////////
        public static void GetAppointment()
        {

            
            string Output = "";
            conn = new MySqlConnection(connectionString);
            conn.Open();

            sql="Select * from appointment";
            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(4) + "\n";
                
            }

            MessageBox.Show(Output);
            conn.Close();
        }
        public static int GetUserID(string userName)
        {
            
            //Instantiate the object then establsih and open a connection
            conn = new MySqlConnection(connectionString);
            conn.Open();

            //Declare a variable to the MySQL command
            string sql = $"select userId from user where userName = '{userName}'";
            int output;

            //Create and convert the command then execute it
            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            
            dataReader.Read();
            output = (int)dataReader.GetValue(0);
            dataReader.Close();
            conn.Close();
            return output;
            
        }

        public static int UserIDVal()
        {
            int nextId = 0;
            sql = "select customerId from customer";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                nextId = (int)dataReader.GetValue(0);
            }

            dataReader.Close();
            conn.Close();

            return nextId+1;
        }

        //Return the next customerId sequentially
        public static int NextCustId()
        {
            int nextId = 0;
            sql = "select customerId from customer order by customerId";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                nextId = (int)dataReader.GetValue(0);
            }

            dataReader.Close();
            conn.Close();

            return nextId + 1;
            
        }

        //Return the next cityId sequentially
        public static int NextCityId()
        {
            int nextId = 0;
            sql = "select cityId from city order by cityId";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                nextId = (int)dataReader.GetValue(0);
            }

            dataReader.Close();
            conn.Close();

            return nextId + 1;
        }
        public static int NextCountryId()
        {
            int nextId = 0;
            sql = "select countryId from country order by countryId";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                nextId = (int)dataReader.GetValue(0);
            }

            dataReader.Close();
            conn.Close();

            return nextId + 1;
        }

        public static int CheckCity(string city, string country, string user)
        {
            int cityId;
            sql = $"select cityId from city where city = '{city}'";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            if (!dataReader.Read())
            {
                //Increment cityId and create the new city correllating to the new cityId
                int nextCityId = NextCityId();
                int countryId = CheckCountry(country, user);
                CreateCity(nextCityId, "test", countryId, user);

                dataReader.Close();
                conn.Close();

                return nextCityId;
            }

            else
            {
                //If there was a match in city check, return it's city Id
                dataReader.Read();
                cityId = (int)dataReader.GetValue(0);

                dataReader.Close();
                conn.Close();
            }
            return cityId;
        }
        public static string GetCity(int cityId)
        {
            sql = $"select city from city where cityId = '{cityId}'";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            dataReader.Read();
            string city = (string)dataReader.GetValue(0);

            dataReader.Close();
            conn.Close();

            return city;
        }

        public static int CheckCountry(string country, string user)
        {
            int countryId;
            sql = $"select countryId from country where country = '{country}'";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            if (!dataReader.Read())
            {
                //Increment cityId and create the new country correllating to the new countryId
                int nextCountryId = NextCountryId();
                CreateCountry(nextCountryId, country, user);

                dataReader.Close();
                conn.Close();

                return nextCountryId;
            }

            else
            {
                //If there was a match in country check, return it's country Id
                dataReader.Read();
                countryId = (int)dataReader.GetValue(0);

                dataReader.Close();
                conn.Close();
            }
            return countryId;
        }
        public static string GetCountry(int countryId)
        {
            sql = $"select country from country where countryId = '{countryId}'";
            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            dataReader.Read();
            string country = (string)dataReader.GetValue(0);

            dataReader.Close();
            conn.Close();

            return country;
        }

        /////////////////////////////////////////Create Section//////////////////////////////////////////////
        public static void CreateCustomer(string fName, string address, string city, string country, string phone, string user)
        {
            //The check methods will verify if the entity exists, if it does not, it will be created
            //Must be sequential due to the foreign key restraints put on each respective tables
            int countryId = CheckCountry(country, user);
            country = GetCountry(countryId);
            int cityId = CheckCity(city, country, user);
            city = GetCity(cityId);
            int custId = NextCustId();
            int addressId = custId;

            sql = $"insert into address(addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) values({addressId}, '{address}', '', {cityId}, '', {phone}, now(),'{user}', now(), '{user}'); " +
            $"insert into customer(customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) values({custId}, '{fName}', {addressId}, 1, now(), '{user}', now(), '{user}');";

            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            conn.Close();

        }
        //CheckCity found no matches, so a new one must be made
        public static void CreateCity(int cityId, string city, int countryId, string user)
        {
            //Add city, cityId, countryId in mySql command
            sql = $"insert into city(cityId, city, countryId, createDate, createdBy, lastUpdateBy) values({cityId}, '{city}', {countryId}, Now(), '{user}', '{user}')";

            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            conn.Close();

        }
        public static void CreateCountry(int countryId, string country, string user)
        {
            //Add city, cityId, countryId in mySql command
            sql = $"insert into country (countryId, country, createdBy, createDate, lastUpdateBy) values ({countryId}, '{country}', '{user}', Now(), Now())";

            conn = new MySqlConnection(connectionString);

            conn.Open();

            command = new MySqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            conn.Close();

        }
    }
    
    ////////////////////////////////////////////////////////////////////CREATE APPOINTMENT/////////////////////////////////////////////////////////////////
}
