using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class HomeAddress : Address
    {
        private byte floor;
        private ushort doorNumber;
        private bool coronaSpeciality;
        public  HomeAddress(string country, string city,
            string street, ushort house,
            byte floor, ushort doorNumber, bool coronaSpeciality) : 
            base( country, city, street, house) 
        {
            this.floor = floor;
            this.doorNumber = doorNumber;
            this.coronaSpeciality = coronaSpeciality;
        }
        public byte Floor
        {
            get { return floor; }
            set { this.floor = value; }
        }
        public ushort DoorNumber
        {
            get { return doorNumber; }
            set { this.doorNumber = value; }
        }
        public bool CoronaSpeciality
        {
            get { return coronaSpeciality; }
            set { this.coronaSpeciality = value; }
        }


    }
}
