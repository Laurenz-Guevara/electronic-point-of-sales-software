using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Electronic_Point_Of_Sales
{
    class mySQLClass
    {
        public bool isSuccessful = false;

        private string MySQLConnectionString = (@"Server = laurenzguevara.co.uk;port=3306;Database=eposdatabase;User Id=eposclient;password=PKzyE7AmUfDSPLFrlAmcgB4NFWk8w9Ac");

        public void RunSQL(string query)
        {
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            isSuccessful = false;

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    databaseConnection.Close();
                    isSuccessful = true;
                }
            }


            catch (Exception)
            {
                isSuccessful = false;

            }
        }

        public string id;
        public string firstName;
        public string lastName;
        public string clockType;
        public string permissionsLevel;

        public void LookupUser(string query)
        {
            isSuccessful = false;

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = reader.GetString("staffId");
                    firstName = reader.GetString("staffFirstName");
                    lastName = reader.GetString("staffLastName");
                    clockType = reader.GetString("clockType");
                    permissionsLevel = reader.GetString("permissionsLevel");

                    reader.Close();
                    databaseConnection.Close();
                    isSuccessful = true;
                }
            }


            catch (Exception)
            {
                isSuccessful = false;
            }
        }


    }
}
