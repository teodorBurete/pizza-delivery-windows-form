using PizzaDeliveryProject2.Entities;
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

namespace PizzaDeliveryProject2.Forms
{
    public partial class NewAccountForm : Form
    {
        private string connectionString = Util.DBConnectionString;

        private Customer _customer;
        public Customer Customer { get { return _customer; } set { _customer = value; } }
        public NewAccountForm()
        {
            InitializeComponent();
            this.tbId.Select();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return;
            }
            string id = this.tbId.Text;
            string firstName = this.tbFirstName.Text;
            string lastName = this.tbLastName.Text;

            string street = this.tbStreet.Text;
            string streetNo = this.tbStreetNo.Text;
            string info = this.tbAdditionalInfo.Text;

            Address address = new Address(street, streetNo, info);
            long addressId = AddAddressToDb(address);
            address.Id = addressId;
            Customer customer;

            try
            {
                customer = new Customer(id, firstName + " " + lastName, address, addressId);
                AddCustomerToDb(customer);

                _customer = customer;

                this.DialogResult = DialogResult.OK;
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)// PK unique constraint 
                {
                    MessageBox.Show("User ID already taken! Please select another!");
                }
            }

        }

        private void AddCustomerToDb(Customer customer)
        {
            string query = "INSERT INTO Customers VALUES (@id,@name,@addressId)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", customer.Id);
                command.Parameters.AddWithValue("@name", customer.Name);
                command.Parameters.AddWithValue("@addressId", customer.AddressId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private long AddAddressToDb(Address address)
        {
            string query = "INSERT INTO Addresses (street, number, details) VALUES (@street, @number, @details)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@street", address.Street);
                command.Parameters.AddWithValue("@number", address.Number);
                command.Parameters.AddWithValue("@details", address.Details);

                command.ExecuteNonQuery();
                return connection.LastInsertRowId;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #region Data Validation Methods
        private bool isUserIdValid()
        {
            string userId = this.tbId.Text;
            if (String.IsNullOrWhiteSpace(userId.Trim()) ||
                userId.Length < 3)
                return false;

            return true;
        }

        private bool isFirstNameValid()
        {
            string firstName = this.tbFirstName.Text;
            if (String.IsNullOrWhiteSpace(firstName.Trim()) ||
                 firstName.Length < 3)
                return false;

            return true;
        }

        private bool isLastNameValid()
        {
            string lastName = this.tbLastName.Text;
            if (String.IsNullOrWhiteSpace(lastName.Trim()) ||
                 lastName.Length < 3)
                return false;

            return true;
        }
        private bool isStreetNameValid()
        {
            string streetName = this.tbStreet.Text;
            if (String.IsNullOrWhiteSpace(streetName.Trim()) ||
                streetName.Length < 3)
                return false;

            return true;
        }

        private bool isStreetNumberValid()
        {
            string streetNumber = this.tbStreetNo.Text;
            if (String.IsNullOrWhiteSpace(streetNumber.Trim()) ||
               streetNumber.Length < 1)
                return false;

            return true;
        }
        #endregion

        #region ValidatingEvents
        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (!isUserIdValid())
            {
                errorProvider1.SetError(tbId, "User ID should be at least 3 characters long!");
                e.Cancel = true;
            }
        }

        private void tbId_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbId, null);
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!isLastNameValid())
            {
                errorProvider1.SetError(tbLastName, "Last Name should be at least 3 characters long!");
                e.Cancel = true;


            }
        }
        private void tbLastName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbLastName, null);
        }
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!isFirstNameValid())
            {
                errorProvider1.SetError(tbFirstName, "First Name should be at least 3 characters long!");
                e.Cancel = true;
            }
        }
        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbFirstName, null);
        }

        private void tbStreetName_Validating(object sender, CancelEventArgs e)
        {
            if (!isStreetNameValid())
            {
                errorProvider1.SetError(tbStreet, "Street Name should be at least 3 characters long!");
                e.Cancel = true;
            }
        }

        private void tbStreetName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbStreet, null);
        }

        private void tbStreetNo_Validating(object sender, CancelEventArgs e)
        {
            if (!isStreetNumberValid())
            {
                errorProvider1.SetError(tbStreetNo, "Street Number should be at least 1 characters long!");
                e.Cancel = true;
            }

        }

        private void tbStreetNo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbStreetNo, null);
        }
        #endregion
    }

}

