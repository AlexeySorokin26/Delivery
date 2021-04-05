using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    enum CustomerStatus : byte
    {
        ordered,
        notOrdered,
        lookingOnWebSite,
    }
    class Customer : Person
    {
        private CustomerStatus customerStatus = CustomerStatus.notOrdered;
        private Busket busket;
        private int amountOfItemsInBusket = 0;
        private int reservedSizeOfBusket = 10000;
        public Customer(string name, int age,
            string? codeCellar, string? subscriberCellar,
            string? codeHomePhone, string? subscriberHomePhone,
            string? addressCountry, string addressCity,
            string? addressStreet, ushort addressHouse,
            byte floor, ushort doorNumber, bool coronaSpeciality,
            Busket busket) : 
            base(name, age, codeCellar, subscriberCellar, codeHomePhone, subscriberHomePhone,
                addressCountry, addressCity, addressStreet, addressHouse,
                floor, doorNumber, coronaSpeciality)
        {
            this.busket = busket;
            this.amountOfItemsInBusket = busket.GetAmountOfRealProducts();
        }
        public CustomerStatus CustomerStatus
        {
            get { return customerStatus; }
            set { this.customerStatus = value; }
        }

        public Busket Busket
        {
            get { return busket; }
            set { this.busket = value; }
        }

        public void AddItemToBusket(Product product)
        {
            // we have a reserved number of items to put in a busket
            if(amountOfItemsInBusket < reservedSizeOfBusket)
            {
                busket[amountOfItemsInBusket] = product;
                amountOfItemsInBusket++;
            }
            else
            {
                busket.AddProduct(product);
                amountOfItemsInBusket++;
            }
            
        }
    }
}
