using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08AndreyАndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> shopList { get; set; }
        public decimal Bill { get; set; }
        public Customer(string name)
        {
            this.Name = name;
        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            LoadTheShop(shop);
            List<Customer> customers = new List<Customer>();
            TakeOrders(shop, customers);
            printCheck(customers);
        }
        private static void LoadTheShop(Dictionary<string, decimal> shop)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, 0);
                }
                shop[product] = price;
            }
        }

        private static void TakeOrders(Dictionary<string, decimal> shop, List<Customer> customers)
        {
            string input = Console.ReadLine();
            while (input != "end of clients")
            {
                string[] orderArgs = input.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string client = orderArgs[0];
                string product = orderArgs[1];
                int quantity = int.Parse(orderArgs[2]);
                Customer currcustomer = new Customer(client);
                currcustomer.shopList = new Dictionary<string, int>();
                currcustomer.shopList.Add(product, quantity);

                if (shop.ContainsKey(product))
                {
                    decimal sum = quantity * shop[product];
                    currcustomer.Bill = sum;
                    if (!customers.Exists(x => x.Name == client))
                    {
                        customers.Add(currcustomer);
                    }
                    else
                    {
                        Customer existing = customers.First(x => x.Name == currcustomer.Name);
                        if (existing.shopList.ContainsKey(product))
                        {
                            existing.shopList[product] += quantity;
                            existing.Bill += sum;
                        }
                        else
                        {
                            existing.shopList[product] = quantity;
                            existing.Bill += sum;
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
        
        private static void printCheck(List<Customer> customers)
        {
            decimal total = 0;
            foreach (var customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.shopList)
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                Console.WriteLine($"Bill: {customer.Bill:F2}");
                total += customer.Bill;
            }
            Console.WriteLine($"Total bill: {total:F2}");
        }
    }
}
