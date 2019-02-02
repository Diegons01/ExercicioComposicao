using System;
using System.Text;
using ExercicioComposicao.Entities.Enums;
using System.Collections.Generic;

namespace ExercicioComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItens.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItens.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append(Client);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in OrderItens)
            {

            }

            return sb.ToString();
        }

    }
}
