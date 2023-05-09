using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryProject2.Entities
{
    public class Address
    {
        #region Attributes

        private long _id;
        public long Id { get; set; }

        private string _street;
        public string Street { get; set; }

        private string _number;
        public string Number { get; set; }

        private string _details;
        public string Details { get; set; }

        #endregion


        public Address(long id, string street, string number, string extra)
        {
            Id = id;
            Street = street;
            Number = number;
            Details = extra;
        }

        public Address( string street, string number, string extra)
        {
            Street = street;
            Number = number;
            Details = extra;
        }
    }
}
