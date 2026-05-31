using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------
            // Order 1 Setup: Domestic Customer (USA)
            // ------------------------------------------------------------
            Address address1 = new Address("123 Digital Way", "Redmond", "WA", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Order order1 = new Order(customer1);

            order1.AddProduct(new Product("Ergonomic Wireless Mouse", "M908", 45.99, 1));
            order1.AddProduct(new Product("Mechanical Keyboard (Blue Switches)", "K552", 65.50, 2));
            order1.AddProduct(new Product("USB-C Desktop Hub", "H102", 29.99, 1));

            // ------------------------------------------------------------
            // Order 2 Setup: International Customer (Non-USA)
            // ------------------------------------------------------------
            Address address2 = new Address("456 Innovation Blvd", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);
            Order order2 = new Order(customer2);

            order2.AddProduct(new Product("UltraWide 34\" Monitor", "MON-34W", 349.99, 1));
            order2.AddProduct(new Product("HD Pro Webcam 1080p", "CAM-HD", 79.99, 3));

            // ------------------------------------------------------------
            // Display Outputs
            // ------------------------------------------------------------
            
            // Display Order 1
            Console.WriteLine("==================================================");
            Console.WriteLine("                    ORDER #1                      ");
            Console.WriteLine("==================================================");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price (incl. shipping): ${order1.CalculateTotalCost():F2}");
            Console.WriteLine("==================================================\n");

            // Display Order 2
            Console.WriteLine("==================================================");
            Console.WriteLine("                    ORDER #2                      ");
            Console.WriteLine("==================================================");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price (incl. shipping): ${order2.CalculateTotalCost():F2}");
            Console.WriteLine("==================================================");
        }
    }
}