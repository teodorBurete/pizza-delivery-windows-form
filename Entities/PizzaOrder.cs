using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryProject2.Entities
{
    public class PizzaOrder
    {
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private Pizza _pizza;
        public Pizza Pizza { get { return _pizza; } set { _pizza = value; } }

        private long _pizzaId;
        public long PizzaId { get { return _pizzaId; } set { _pizzaId = value; } }

        private Order _order;
        public Order Order { get { return _order; } set { _order = value; } }

        private long _orderId;
        public long OrderId { get { return _orderId; } set { _orderId = value; } }
        private int _amount;
        public int Amount { get { return _amount; } set { _amount = value; } }

        public PizzaOrder(Pizza pizza, int amount)
        {
            Pizza = pizza;
            Amount = amount;
            PizzaId = pizza.Id;
        }

    }
}
