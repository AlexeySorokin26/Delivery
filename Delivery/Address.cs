using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    abstract class Address
    {
        private string country;
        private string city;
        private string street;
        private ushort house;
        public Address(string country, string city, 
            string street, ushort house)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
        }
        public string Country
        {
            get { return country; }
            set { this.country = value; }
        }
        public string City
        {
            get { return city; }
            set { this.city = value; }
        }
        public string Street
        {
            get { return street; }
            set { this.street = value; }
        }
        public ushort House
        {
            get { return house; }
            set { this.house = value; }
        }

       
    }
}
