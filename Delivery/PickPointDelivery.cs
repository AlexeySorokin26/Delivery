using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class PickPointDelivery : Delivery
    {
        DateTime pickUpDeadline;
        public PickPointDelivery(Address address, Product product) : base(address, product)
        {
        }
        public override void Describe()
        {
        }
    }
}
