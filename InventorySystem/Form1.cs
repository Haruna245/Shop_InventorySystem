using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            pass = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";

            connection = new MySqlConnection(connectionString);

            if (userText.Text != string.Empty || passText.Text != string.Empty)
            {

                string query = "select * from user where Fname='" + userText.Text + "' and Password='" + passText.Text + "'";
                connection.Open();
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }
    }
}
