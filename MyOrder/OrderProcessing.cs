using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrder
{
    public class OrderProcessing
    {
        public void ProcessOrder(string productName)
        {
            Console.WriteLine($"Заказ на продукт '{productName}' принят в обработку.");
        }
    }
}
