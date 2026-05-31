using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Calculates total cost of the order (products sum + single shipping rate)
        public double CalculateTotalCost()
        {
            double total = 0;
            
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }

            // Apply flat rate shipping rules based on location
            double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
            total += shippingCost;

            return total;
        }

        // Generates the packing label details
        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- PACKING LABEL ---");
            foreach (Product product in _products)
            {
                sb.AppendLine($"Product: {product.GetName()} [ID: {product.GetProductId()}]");
            }
            return sb.ToString();
        }

        // Generates the shipping label details
        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- SHIPPING LABEL ---");
            sb.AppendLine(_customer.GetName());
            sb.AppendLine(_customer.GetAddress().GetFullAddress());
            return sb.ToString();
        }
    }
}