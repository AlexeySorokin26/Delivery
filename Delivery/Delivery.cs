using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    abstract class Delivery
    {
        private Address address;
        private Product product;
        public Delivery(Address address, Product product)
        {
            this.address = address;
            this.product = product;
        }
        public Address Address
        {
            get { return address; }
            set { this.address = value; }
        }
        public Product Product
        {
            get { return product; }
            set { this.product = value; }
        }
        public abstract void Describe();
    }
}
