using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class Busket
    {
        private int reservedSizeOfBusket = 10000;
        private Product[] busket;
        public Busket()
        {
            this.busket = null;
        }
        public Busket(Product[] busket)
        {
            if(busket.Length < reservedSizeOfBusket && busket.Length > 0)
            {
                this.busket = new Product[reservedSizeOfBusket];
                for (int i = 0; i < busket.Length; ++i)
                {
                    this.busket[i] = busket[i];
                }
            }
            else if(busket.Length > 0 && busket.Length > reservedSizeOfBusket)
            {
                this.busket = new Product[busket.Length];
                for (int i = 0; i < busket.Length; ++i)
                {
                    this.busket[i] = busket[i];
                }
            }
            else
            {
                this.busket = null;
            }
        }
        public Product this[int index]
        {
            get 
            { 
                if (index > 0 && index < busket.Length)
                {
                    return busket[index];
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                if (index > 0 && index < reservedSizeOfBusket)
                {
                    busket[index] = value;
                }
                else
                {

                }
            }
        }
        public int GetSize()
        {
            return busket.Length;
        }
        public int GetAmountOfRealProducts()
        {
            int counter = 0;
            if(busket.Length != 0)
            {
                Product tmpProduct = busket[0];
                while (tmpProduct != null)
                {
                    tmpProduct = busket[++counter];
                }
                return counter;
            }
            else
            {
                return 0;
            }
        }
        public void AddProduct(Product newProduct)
        {
            Product[] newCollection = new Product[busket.Length + 1];
            for (int i = 0; i < busket.Length; ++i)
            {
                newCollection[i] = busket[i];
            }
            newCollection[busket.Length] = newProduct;
            busket = new Book[busket.Length + 1];
            for (int i = 0; i < newCollection.Length; ++i)
            {
                busket[i] = newCollection[i];
            }
        }
    }
}
