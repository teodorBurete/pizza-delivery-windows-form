using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryProject2.Entities
{
    public class Pizza
    {

        #region Attributes
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private string _description;
        public string Description { get { return _description; } set { _description = value; } }
        private double _price;
        public double Price { get { return _price; } set { _price = value; } }
        #endregion

        public Pizza(long id, string name, string description,double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public Pizza(string name, string description,double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
