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

namespace InventorySystem
{
    public partial class SignUp : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public SignUp()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void Registerbtn_Click(object sender, EventArgs e)
        {
            string Fname = fname.Text;
            string lname = Lname.Text;
            string email = Email.Text;
            string password1 = Password.Text;
            string confpassword = confPassword.Text;
            string admin = Admin.Text;
            string attendant = Attendant.Text;
            string phnum = PhoneNum.Text;
            
            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            string query = "INSERT INTO `user` (ID,`Fname`, `Lname`, `Password`, `ConfPassword`, `Email`, `PhoneNumber`, `userType`) VALUES(6,'" + Fname + "','" + lname + "','" + password1 + "','" + confpassword + "','" + email + "','" + phnum + "', 'admin')";

            //open connection
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            connection.Close();

            MessageBox.Show("Data Inserted");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
