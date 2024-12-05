using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrder
{
    public class DeliveryService
    {
        public void ArrangeDelivery(string address)
        {
            Console.WriteLine($"Доставка товара будет организована по адресу: {address}.");
        }
    }
}
