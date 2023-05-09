using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryProject2.Entities
{
    public class Order
    {
        #region Attributes
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private string _customerId;
        public string CustomerId { get { return _customerId; } set { _customerId = value; } }
        #endregion
        private double _totalPrice;
        public double TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }
        private string _paymentMethod;
        public string PaymentMethod { get { return _paymentMethod; }set { _paymentMethod = value; } }

        public Order(string customerId,double totalPrice, string paymentMethod )
        {
            CustomerId = customerId;
            TotalPrice = totalPrice;
            PaymentMethod = paymentMethod;
        }
    }

    
}
