using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    enum CourierStatus : byte
    {
        available,
        notAvailable,
        inDelivery,
    }
    class Courier : Person
    {
        CourierStatus courierStatus = CourierStatus.available;
        Delivery delivery = null;
        public Courier(string name, int age,
            string? codeCellar, string? subscriberCellar) : 
            base(name, age, codeCellar, subscriberCellar)
        {
        }
        public CourierStatus CourierStatus
        {
            get { return courierStatus; }
            set { this.courierStatus = value; }
        }
        public bool AssignDelivery(Delivery delivery)
        {
            if(courierStatus == CourierStatus.available)
            {
                this.delivery = delivery;
                this.courierStatus = CourierStatus.inDelivery;
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
