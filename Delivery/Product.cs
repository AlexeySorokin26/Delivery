using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    abstract class Product
    {
        string name;
        float price;
        public Product(string name = "noname", float price = 0.0f)
        {
            this.name = name;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public float Price
        {
            get { return price; }
            set { this.price = value; }
        }
    }
}
