using System;
using System.Collections.Generic;
using System.Text;

namespace enumeracoes.Entities
{
    class Order
    {
        public int id { get; set; }
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public override string ToString()
        {
            return $"ID da compra: {id} \nData da compra: {moment} \nStatus: {status}";
        }
    }
}
