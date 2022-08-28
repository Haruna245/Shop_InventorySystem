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
    public partial class TillingSc : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public TillingSc()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            string sText = searchText.Text;

            connection = new MySqlConnection(connectionString);

            string query = "SELECT ProductName,Amount from `product` WHERE `product`.`ProductName` = '" + sText + "';";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("item Added to carts");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            string sText = searchText.Text;

            connection = new MySqlConnection(connectionString);

            string query = "SELECT ProductName,Amount from `product`;";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            string sText = searchText.Text;

            connection = new MySqlConnection(connectionString);

            string query = "SELECT sum(Amount) as Total from `product`;";
            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            amtView.DataSource = dt; 
        }

        private void TillingSc_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transactions Completed");
        }
    }
}
