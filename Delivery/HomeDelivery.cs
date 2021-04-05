using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class HomeDelivery : Delivery
    {
        public HomeDelivery(HomeAddress address, Product product) : base(address, product)
        {
        }
        public override void Describe()
        {
        }
    }
}
