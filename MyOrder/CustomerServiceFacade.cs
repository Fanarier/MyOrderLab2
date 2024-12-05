using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrder
{
    public class CustomerServiceFacade
    {
        private readonly OrderProcessing _orderProcessing;
        private readonly PaymentProcessing _paymentProcessing;
        private readonly DeliveryService _deliveryService;

        public CustomerServiceFacade()
        {
            _orderProcessing = new OrderProcessing();
            _paymentProcessing = new PaymentProcessing();
            _deliveryService = new DeliveryService();
        }

        public void PlaceOrder(string productName, string paymentMethod, string address)
        {
            Console.WriteLine("Служба поддержки: обрабатываем ваш запрос...");
            _orderProcessing.ProcessOrder(productName);
            _paymentProcessing.ProcessPayment(paymentMethod);
            _deliveryService.ArrangeDelivery(address);
            Console.WriteLine("Служба поддержки: ваш заказ успешно оформлен!\n");
        }
    }
}
