using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaDeliveryProject2.Entities;
using PizzaDeliveryProject2.Forms;


namespace PizzaDeliveryProject2.Forms
{
    public partial class LoginForm : Form
    {

        private string connectionString = Util.DBConnectionString;

        private Customer _customer;
        //    private Address _address;
        public Customer Customer { get { return _customer; } set { _customer = value; } }
        public LoginForm(Form form)
        {
            InitializeComponent();
        }

        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountForm newAccForm = new Forms.NewAccountForm();
            newAccForm.ShowDialog();

            if (newAccForm.DialogResult == DialogResult.OK)
            {
                _customer = newAccForm.Customer;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;
            if (id.Length < 3)
            {
                MessageBox.Show("Please enter a valid ID first!");
                return;
            }

            _customer = getCustomerFromDb(id);
            if (_customer != null)
            {
                this.DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                MessageBox.Show("ID not found! Try again or register!");
                return;
            }

        }

        private Customer getCustomerFromDb(string id)
        {
            string query = "SELECT id,name,address_id FROM Customers WHERE id = '" + id + "';";
            Customer customer = null;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        long addressId = (long)reader["address_id"];
                        customer = new Customer(id, name, addressId);
                    }
                }
            }
            if (customer != null)
            {
                Address customerAddress = getAddressFromDB(customer.AddressId);
                customer.Address = customerAddress;
            }
            return customer;
        }
        private Address getAddressFromDB(long id)
        {
            Address address = null;
            string query = "SELECT street,number,details FROM Addresses WHERE (id ='" + id + "')";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string street = (string)reader["street"];
                        string number = (string)reader["number"];
                        string details = (string)reader["details"];
                        address = new Address(id, street,number, details);
                    }
                }
            }
            return address;
        }
    }
}
