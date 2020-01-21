using System;
using enumeracoes.Entities;

namespace enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                id = 1,
                moment = DateTime.Now,
                status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // convertendo o tipo enumerado para string
            Console.WriteLine("-----------------------------------------------------");
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // convertendo uma string pro tipo enumerado
            Console.WriteLine("-----------------------------------------------------");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(orderStatus);

            // Fim
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
