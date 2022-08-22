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
    public partial class LoginScreen : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string pass;
        public LoginScreen()
        {
            InitializeComponent();
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

            





            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
