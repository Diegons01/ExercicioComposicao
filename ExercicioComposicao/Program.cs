using System;
using System.Globalization;
using ExercicioComposicao.Entities.Enums;
using ExercicioComposicao.Entities;


namespace ExercicioComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client date: ");
            Console.Write("Name: ");
            string clienteName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            //Cliente
            Client client = new Client(clienteName, email, date);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(status);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderStatus, client);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            
            Console.ReadLine();
        }
    }
}
