using PizzaDeliveryProject2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDeliveryProject2.Forms
{
    public partial class ConfirmationForm : Form
    {
        private string connectionString = Util.DBConnectionString;
        private Customer _customer;
        private ListView _mainFormLv;
        private MainForm _mainForm;
        private double _total;
        private List<PizzaOrder> _pizzaOrders;
        public MainForm MainForm { get; set; }
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        public ConfirmationForm(Form form, ListView lv)
        {
            InitializeComponent();

            _mainForm = (MainForm)form;
            _mainFormLv = lv;
            _customer = _mainForm.Customer;
            _pizzaOrders = _mainForm.PizzaOrders;
            _total = _mainForm.Total;


        }

        private void displayAddress()
        {
            Address customerAddress = _customer.Address;
            this.lbStreet.Text = "Street: " + _mainForm.Customer.Address.Street;
            this.lbStreetNo.Text = "Number: " + _mainForm.Customer.Address.Number;
            this.lbAddressDetails.Text = "Details: " + _mainForm.Customer.Address.Details;

        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            this.lvConfirmation.Items.AddRange((from ListViewItem item in _mainFormLv.Items select (ListViewItem)item.Clone()).ToArray());
            this.lbTotal.Text = "Total: " + _total;
            rbCash.Checked = true;
            displayAddress();
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            Address newAddress;
            ChangeAddressForm form = new ChangeAddressForm(_customer.Address);
            var result = form.ShowDialog();
            if (result == DialogResult.Yes && form.Address != null)
            {
                newAddress = form.Address;
                long newAddressId = AddAddressToDB(newAddress);
                _customer.AddressId = newAddressId;
                _customer.Address = newAddress;
                displayAddress();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string paymentMethod;
            try { paymentMethod = getPaymentMethod(); }
            catch { MessageBox.Show("Please select payment method!"); return; }

            Order order = new Order(_customer.Id, _total, paymentMethod);

            try
            {
                long id = AddOrderToDB(order);
                AddPizzaOrderToDB(id);
                order.Id = id;
                MessageBox.Show("Order sent, Thank you!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error processing your order. Please try again!");
                Console.WriteLine(ex.ToString());
                this.DialogResult = DialogResult.Retry;
                return;
            }
        }

        private long AddOrderToDB(Order order)
        {
            string query = "INSERT INTO Orders (customer_id, total_price, payment_method) VALUES (@customer_id, @total_price, @payment_method)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@customer_id", order.CustomerId);
                command.Parameters.AddWithValue("@total_price", order.TotalPrice);
                command.Parameters.AddWithValue("@payment_method", order.PaymentMethod);

                command.ExecuteNonQuery();
                return connection.LastInsertRowId;
            }
        }
        private string getPaymentMethod()
        {
            if (rbCard.Checked)
                return "Card";
            if (rbCash.Checked)
                return "Cash";
            else throw new Exception("Error, no radio button checked");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private long AddAddressToDB(Address address)
        {
            string query = "INSERT INTO Addresses (street, number, details) VALUES (@street, @number, @details)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@street", address.Street);
                command.Parameters.AddWithValue("@number", address.Number);
                command.Parameters.AddWithValue("@details", address.Details);

                connection.Open();
                command.ExecuteNonQuery();
                return connection.LastInsertRowId;
            }
        }

        private void AddPizzaOrderToDB(long orderId)
        {
            string query = "INSERT INTO PizzaOrder VALUES (@order_id, @pizza_id, @amount)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                foreach (PizzaOrder pizzaOrder in _pizzaOrders)
                {
                    pizzaOrder.OrderId = orderId;

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@order_id", orderId);
                    command.Parameters.AddWithValue("@pizza_id", pizzaOrder.PizzaId);
                    command.Parameters.AddWithValue("@amount", pizzaOrder.Amount);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Pizza,Pizza Description,Amount,Unit Price,Total Price");//fields

                    foreach (PizzaOrder pizzaOrder in _pizzaOrders)
                    {
                        string pizzaName = pizzaOrder.Pizza.Name;
                        string pizzaDescription = pizzaOrder.Pizza.Description;
                        string amount = pizzaOrder.Amount + "";
                        string unitPrice = pizzaOrder.Pizza.Price+"";
                        string totalPrice =(pizzaOrder.Pizza.Price*pizzaOrder.Amount)+"";
                          sw.WriteLine("\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\""
                                     ,pizzaName
                                     ,pizzaDescription
                                     ,amount
                                     ,unitPrice
                                     ,totalPrice);
                    }
                }

            }
        }
    }
}
