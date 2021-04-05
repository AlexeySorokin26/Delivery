using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class ShopAddress : Address
    {
        private string shopName;
        private byte shopFloor;
        private bool mollTrick; // easier to find a shop location; maybe some north, east... 
        public ShopAddress(string country, string city,
            string street, ushort house,
            string shopName, byte shopFloor, bool mollTrick) :
            base(country, city, street, house)
        {
            this.shopName = shopName;
            this.shopFloor = shopFloor;
            this.mollTrick = mollTrick;
        }
        public string ShopName
        {
            get { return shopName; }
            set { this.shopName = value; }
        }
        public byte ShopFloor
        {
            get { return shopFloor; }
            set { this.shopFloor = value; }
        }
        public bool MollTrick
        {
            get { return mollTrick; }
            set { this.mollTrick = value; }
        }
    }
}
