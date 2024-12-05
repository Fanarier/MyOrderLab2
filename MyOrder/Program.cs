using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrder
{
    class Program
    {
        static void Main()
        {
            var customerService = new CustomerServiceFacade();

            // Клиент оформляет заказ
            customerService.PlaceOrder("Ноутбук", "Кредитная карта", "ул. Ленина, д. 5");

            customerService.PlaceOrder("Смартфон", "Наличные", "ул. Пушкина, д. 10");

            Console.ReadKey();
        }
    }
}
