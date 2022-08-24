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
    public partial class AddProduct : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pname = Pname.Text;
            int price = Convert.ToInt32(Price.Value);
            //string manuDate = ManuDate.Text;
            //string manuDate = ManuDate.Value.ToShortDateString();
            string manuDate = ManuDate.Value.ToString("yyyy-MM-dd");
            string expiryDate = ExpiryDate.Value.ToString("yyyy-MM-dd");
            //string expiryDate = ExpiryDate.Text;
            int qnty = Convert.ToInt32(Qnty.Value);
            

            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            string query = "INSERT INTO `product` (`ProductName`, `Amount`, `ManuDate`, `Exp.Date`, `Quantity`) VALUES('" + pname + "','" + price + "','" + manuDate + "' ,'" + expiryDate + "','" + qnty + "')";

            connection.Open();
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            connection.Close();

            MessageBox.Show("New Product Added");

        }

        //delete button
        private void button2_Click(object sender, EventArgs e)
        {
            string pname = Pname.Text;
            int price = Convert.ToInt32(Price.Value);
            server = "localhost";
            database = "inventorysystem";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "Port=" + 3307 + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            string query = "DELETE FROM `product` WHERE  ProductName='" + pname + "'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            //Execute command
            cmd.ExecuteNonQuery();

            //close connection
            connection.Close();

            MessageBox.Show("Product Deleted");
        }
    }
}
