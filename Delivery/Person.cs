using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    abstract class Person
    {
        private Cellar cellar;
        private HomePhone homePhone;
        private HomeAddress homeAddress;
        private string name;
        private int age;
        public Person(string name, int age, 
            string? codeCellar = null, string? subscriberCellar = null, 
            string? codeHomePhone = null, string? subscriberHomePhone = null,
            string? addressCountry = null, string? addressCity = null,
            string? addressStreet = null, ushort addressHouse = 0,
            byte floor = 0, ushort doorNumber = 0, bool coronaSpeciality = false)
        {
            this.name = name;
            this.age = age;
            this.cellar = new Cellar(codeCellar, subscriberCellar);
            this.homePhone = new HomePhone(codeHomePhone, subscriberHomePhone);
            this.homeAddress = new HomeAddress(
                addressCountry, addressCity, addressStreet, addressHouse,
                floor, doorNumber, coronaSpeciality);
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        public string GetCellarNumber()
        {
            if(cellar.Number != null)
            {
                return cellar.Number;
            }
            return null;
        }
        public string GetHomePhoneNumber()
        {
            if (homePhone.Number != null)
            {
                return homePhone.Number;
            }
            return null;
        }
        public HomeAddress GetHomeAddress()
        {
            if (homeAddress != null)
            {
                return homeAddress;
            }
            return null;
        }
    }
}
