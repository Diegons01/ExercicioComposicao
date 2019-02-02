using System;
using System.Text;
using System.Globalization;
using ExercicioComposicao.Entities.Enums;
using System.Collections.Generic;

namespace ExercicioComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

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
            items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            items.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Clint: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");
            double sum = 0.0;
            foreach (OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
                sum += item.SubTotal();
            }
            sb.Append("Total Price: $");
            sb.Append(sum.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
