using System;

namespace SupermarketZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input;
            int index = 0;
            List<string> inputs = new List<string>();
            while ((input = Console.ReadLine()) != "stocked")
            {
                inputs.Add(input);
            }

           
            for (index = 0; index < inputs.Count; index++)
            {
                string[] parts = inputs[index].Split(' ');
                string name = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);

                if (products.ContainsKey(name))
                {
                    products[name].Quantity += quantity;
                    products[name].ProductPrice = price;
                }
                else
                {
                    products[name] = new Product(name,price,quantity);
                }
            }

            
            decimal grandTotal = 0;
            List<string> output = new List<string>();
            List<string> keys = new List<string>(products.Keys);

            for (index = 0; index < keys.Count; index++)
            {
                Product product = products[keys[index]];
                decimal total = product.TotalPrice;
                output.Add($"{product.ProductName} {product.ProductPrice:F2} * {product.Quantity} = {total:F2}");
                grandTotal += total;
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
            

        }
    }
}