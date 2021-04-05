using System;

namespace Delivery
{    
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("The best book ever", 100, 1000, "Alexey Sorokin", 2021);
            Book book2 = new Book("The best book ever 2", 100, 1000, "Alexey Sorokin", 2021);
            Computer computer = new Computer("macbook air", 100000, 256, 4, false, "arm", "apple", 2021);
            Product[] products = new Product[]
            {
                new Book("The best book ever", 100, 1000, "Alexey Sorokin", 2021),
                new Computer("macbook air", 100000, 256, 4, false, "arm", "apple", 2021)
            };
            Busket busketAlexey = new Busket(products);

            Customer customerAlexey = new Customer("Alexey", 28, "+49", "111111111",
                "+49", "111111111", "russia", "moscow", "lesnay", 10, 10, 10, true, busketAlexey);

            customerAlexey.AddItemToBusket(book2);

            Courier courierAlexey = new Courier("Alexey", 28, "+49", "111111111");
            

            HomeAddress homeAddress = new HomeAddress("russia", "moscow", "tverskay", 10, 100, 26, true);
            HomeDelivery homeDelivery = new HomeDelivery(homeAddress, book);
            
            if (courierAlexey.AssignDelivery(homeDelivery))
            {
                Console.WriteLine($"Delivery {homeDelivery.Product.Name} successfully pick up by {courierAlexey.Name}");
            }
            else
            {
                Console.WriteLine($"Find another courier for your delivery {homeDelivery.Product.Name}");
            }
            ShopAddress shopAddress = new ShopAddress("russia", "moscow", "novay", 11, "mega belay", 2, false);
            
            ShopDelivery shopDelivery = new ShopDelivery(shopAddress, computer);

            courierAlexey.CourierStatus = CourierStatus.available;
            if (courierAlexey.AssignDelivery(shopDelivery))
            {
                Console.WriteLine($"Delivery {shopDelivery.Product.Name} successfully pick up by {courierAlexey.Name}");
            }
            else
            {
                Console.WriteLine($"Find another courier for your delivery {shopDelivery.Product.Name}");
            }
            
        }
    }
}
