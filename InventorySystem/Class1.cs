using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    internal class Class1
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Class1()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";"+"Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            
            Console.WriteLine("Connection Opened");

            
        }

        

        public void Insert()
        {
            string query = "INSERT INTO `user` (`Fname`, `Lname`, `Password`, `ConfPassword`, `Email`, `PhoneNumber`, `userType`) VALUES ('Seidu', 'Haruna', 'seidu', 'seidu', 'haruna@gmail.com', 0551763022, 'Admin')";

            //open connection
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);
           
            //Execute command
            cmd.ExecuteNonQuery();

                //close connection
                connection.Close();
            
        }

    }
}
