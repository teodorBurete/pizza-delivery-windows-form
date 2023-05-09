using PizzaDeliveryProject2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaDeliveryProject2.Forms;
using System.Data.SQLite;


namespace PizzaDeliveryProject2
{
    public partial class MainForm : Form
    {
        private string connectionString = Util.DBConnectionString;

        private Customer _customer;
        private List<Pizza> _pizzaList;
        private List<PizzaOrder> _pizzaOrders;
        private double _total;
        //private Address _address;

        public Customer Customer { get { return _customer; } set { _customer = value; } }
        public List<Pizza> PizzaList { get { return _pizzaList; } set { _pizzaList = value; } }
        public List<PizzaOrder> PizzaOrders { get { return _pizzaOrders; } set { _pizzaOrders = value; } }
        //  public Address Address { get; set; }
        public double Total { get { return _total; } set { _total = value; } }



        public MainForm()
        {
            InitializeComponent();
            _pizzaList = new List<Pizza>();
            _pizzaOrders = new List<PizzaOrder>();
            _total = 0;

        }

        #region Methods
        private void LoadItems()
        {
            /*  _pizzaList.Add(new Pizza(1, "Capriciosa", "Mushrooms, Cheese, Ham", 15));
              _pizzaList.Add(new Pizza(2, "Hawaii", "Pineapple, Cheese, Ham", 20));
              _pizzaList.Add(new Pizza(3, "Quatro Stagioni", "Mushrooms, Cheese, Ham, Pepperoni, Olives", 30));*/

            string query = "SELECT * FROM Pizzas";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id =(long) reader["id"];
                        string name = (string)reader["name"];
                        string description = (string)reader["description"];
                        double price = (double)reader["price"];

                        Pizza pizza = new Pizza(id,name, description, price);
                        _pizzaList.Add(pizza);
                    }
                }

            }
        }
        private void DisplayMenu()
        {
            cbPizza.DisplayMember = "Name";
            foreach (var pizza in _pizzaList)
            {
                cbPizza.Items.Add(pizza);
            }
        }
        private void DisplayPizzaOrder()
        {
            _total = 0;
            lvPizza.Items.Clear();
            foreach (PizzaOrder pizzaOrder in _pizzaOrders)
            {
                ListViewItem lvItem = new ListViewItem(pizzaOrder.Pizza.Name);
                lvItem.SubItems.Add(pizzaOrder.Amount.ToString());
                lvItem.SubItems.Add(pizzaOrder.Pizza.Price.ToString());

                double tPrice = pizzaOrder.Pizza.Price * pizzaOrder.Amount;
                lvItem.SubItems.Add(tPrice.ToString());

                lvItem.Tag = pizzaOrder;
                lvPizza.Items.Add(lvItem);

                _total += tPrice;
            }
            this.lbTotal.Text = "Total: " + _total;
        }
        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadItems();
                DisplayMenu();
                startLoginFormDialogue();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza selectedItem = (Pizza)cbPizza.SelectedItem;
            string description = selectedItem.Description.Replace(", ", "\n");
            lbIngredients.Text = "Ingredients:\n" + description;
        }
        #endregion

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            if (this.cbPizza.SelectedItem == null)
            {
                MessageBox.Show("Please select Pizza first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pizza selectedPizza = (Pizza)cbPizza.SelectedItem;
                int qty = (int)numQty.Value;
                PizzaOrder pizzaOrder = new PizzaOrder(selectedPizza, qty);
                _pizzaOrders.Add(pizzaOrder);
                DisplayPizzaOrder();
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPizza.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select the row you wish to delete!");
                return;
            }

            else
            {
                _pizzaOrders.Remove((PizzaOrder)lvPizza.SelectedItems[0].Tag);
                DisplayPizzaOrder();
            }
        }

        private void btnGoToOrderConfirmation_Click(object sender, EventArgs e)
        {
            if (_pizzaOrders.Count < 1)
            {
                MessageBox.Show("Please add at least on item to the order!");
                return;
            }

            if (_customer == null)
            {
                startLoginFormDialogue();
            }
            else
            {
                startConfirmationDialogue();
            }
        }

        private void startLoginFormDialogue()
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK)
            {
                _customer = loginForm.Customer;
            }
        }

        private void startConfirmationDialogue()
        {
            ConfirmationForm confirmationForm = new ConfirmationForm(this, this.lvPizza);
            confirmationForm.ShowDialog();
            if (confirmationForm.DialogResult == DialogResult.OK)
            {
                this.Controls.Clear();
                InitializeComponent();
                _pizzaOrders.Clear();
                _customer = null;
                DisplayMenu();
            }
        }
    }
}
