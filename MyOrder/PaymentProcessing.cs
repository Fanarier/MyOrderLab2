using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrder
{
    public class PaymentProcessing
    {
        public void ProcessPayment(string paymentMethod)
        {
            Console.WriteLine($"Оплата выполнена через {paymentMethod}.");
        }
    }
}
