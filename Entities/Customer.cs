using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryProject2.Entities
{
    public class Customer
    {

        #region Attributes
        private string _id;
        public string Id { get { return _id; } set { _id = value; } }
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Address _address;
        public Address Address { get { return _address; } set { _address = value; } }

        private long _addressId;
        public long AddressId { get { return _addressId; } set { _addressId = value; } }
        #endregion

        public Customer(string id, string name, Address address,long addressId)
        {
            Id = id;
            Name = name;
            Address = address;
            AddressId = addressId;
        }

        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public Customer(string id, string name, long addressId)
        {
            Id = id;
            Name = name;
            AddressId = addressId;
        }
    }
}
