using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery
{
    class ShopDelivery : Delivery
    {
        public ShopDelivery(ShopAddress address, Product product) : base(address, product)
        {
        }
        public override void Describe()
        {
        }
    }
}
